using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Bibliotheca_Motus_Imaginibus_API.DTOs;
using Bibliotheca_Motus_Imaginibus_API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;


namespace Bibliotheca_Motus_Imaginibus_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController(

    UserManager<User> userManager,
    RoleManager<IdentityRole> roleManager,
    IConfiguration config) : ControllerBase
{

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDTO register)
    {
        var newUser = new User()
        {
            FirstName = register.FirstName,
            LastName = register.LastName,
            Email = register.Email,
            PasswordHash = register.Password,
            UserName = register.Email.Split('@')[0]
        };

        var user = await userManager.FindByEmailAsync(newUser.Email);

        if (user is not null)
        {
            return BadRequest("Ez a felhasználó már regisztrálva van.");
        }

        

        var checkAdmin = await roleManager.FindByNameAsync("Admin");

        if (checkAdmin is null)
        {
            await roleManager.CreateAsync(new IdentityRole() { Name = "Admin" });
            await userManager.AddToRoleAsync(newUser, "Admin");
            return Ok("Admin felhasználó létrehozva.");
        }

        var createUser = await userManager.CreateAsync(newUser, register.Password);

        var checkUser = await roleManager.FindByNameAsync("User");

        if (checkUser is null)
        {
            await roleManager.CreateAsync(new IdentityRole() { Name = "User" });
        }

        await userManager.AddToRoleAsync(newUser, "User");

        return Ok("Felhasználó létrehozva.");
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDTO login)
    {
        if (login is null)
        {
            return BadRequest("Üres bejelentkezési paraméterek.");
        }

        var user = await userManager.FindByNameAsync(login.UserName);

        if (user is null)
        {
            return NotFound("Nincs ilyen felhasználónév.");
        }

        bool checkUserPasswords = await userManager.CheckPasswordAsync(user, login.Password);

        if (!checkUserPasswords)
        {
            return BadRequest("Helytelen belépés.");
        }

        var userRole = await userManager.GetRolesAsync(user);

        string token = GenerateToken(user.Id, user.UserName, user.Email, userRole.First());

        var response = new
        {
            token
        };

        return Ok(response);

    }

    private string GenerateToken(string id, string name, string email, string role)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]!));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var userClaims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, id),
            new Claim(ClaimTypes.Name, name),
            new Claim(ClaimTypes.Email, email),
            new Claim(ClaimTypes.Role, role)
        };
        var token = new JwtSecurityToken(
            issuer: config["Jwt:Issuer"],
            audience: config["Jwt:Audience"],
            claims: userClaims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: credentials
        );
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}











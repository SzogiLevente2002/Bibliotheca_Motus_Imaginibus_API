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
        // Új felhasználó objektum létrehozása
        var newUser = new User()
        {
            FirstName = register.FirstName,
            LastName = register.LastName,
            Email = register.Email,

            UserName = register.Email.Split('@')[0]
        };

        // Ellenőrzés, hogy a felhasználó már létezik-e
        var user = await userManager.FindByEmailAsync(newUser.Email);

        if (user is not null)
        {
            return BadRequest("Ez a felhasználó már regisztrálva van.");
        }

        // Felhasználó létrehozása az UserManager segítségével (ez kezeli a jelszót is)
        var createUserResult = await userManager.CreateAsync(newUser, register.Password);
        if (!createUserResult.Succeeded)
        {
            return BadRequest("Felhasználó létrehozása sikertelen: " +
                string.Join(", ", createUserResult.Errors.Select(e => e.Description)));
        }

        // Alapértelmezett szerepkör ellenőrzése és létrehozása, ha szükséges
        var checkUserRole = await roleManager.FindByNameAsync("User");
        if (checkUserRole is null)
        {
            var createRoleResult = await roleManager.CreateAsync(new IdentityRole("User"));
            if (!createRoleResult.Succeeded)
            {
                return BadRequest("Szerepkör létrehozása sikertelen: " +
                    string.Join(", ", createRoleResult.Errors.Select(e => e.Description)));
            }
        }

        // Felhasználó hozzáadása a "User" szerepkörhöz
        var addToRoleResult = await userManager.AddToRoleAsync(newUser, "User");
        if (!addToRoleResult.Succeeded)
        {
            return BadRequest("Szerepkör hozzárendelése sikertelen: " +
                string.Join(", ", addToRoleResult.Errors.Select(e => e.Description)));
        }

        return Ok("Felhasználó sikeresen létrehozva és a 'User' szerepkörhöz rendelve.");
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

        string token = GenerateToken(user.Id, user.UserName, user.Email, userRole.ToList());

        var response = new
        {
            token
        };

        return Ok(response);

    }

    private string GenerateToken(string id, string name, string email, IList<string> roles)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]!));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        // A szerepkörök listáját egyetlen stringgé alakítjuk
        var rolesClaim = string.Join(",", roles);

        var userClaims = new[]
        {
        new Claim(ClaimTypes.NameIdentifier, id),
        new Claim(ClaimTypes.Name, name),
        new Claim(ClaimTypes.Email, email),
        new Claim(ClaimTypes.Role, rolesClaim)  // Az összes szerepkör hozzáadása
    };

        var token = new JwtSecurityToken(
            issuer: config["Jwt:Issuer"],           // Az alkalmazás kiadója (Issuer)
            audience: config["Jwt:Audience"],       // A token címzettje (Audience)
            claims: userClaims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }


}












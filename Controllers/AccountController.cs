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

    [HttpGet("me")]
    [Authorize] // Csak bejelentkezett felhasználók érhetik el
    public async Task<IActionResult> GetLoggedInUserData()
    {
        // Az aktuális felhasználó azonosítása a token alapján
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userId))
        {
            return Unauthorized("Nem található azonosított felhasználó.");
        }

        // Felhasználó lekérése az adatbázisból
        var user = await userManager.FindByIdAsync(userId);

        if (user == null)
        {
            return NotFound("A felhasználó nem található.");
        }

        // A felhasználó összes adatának visszaadása
        var response = new
        {
            user.Id,
            user.FirstName,
            user.LastName,
            user.Email,
            user.UserName,
            Roles = await userManager.GetRolesAsync(user) // Felhasználó szerepei
        };

        return Ok(response);
    }

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

    // Felhasználónév módosítása
    [HttpPut("update-username")]
    [Authorize] // Csak bejelentkezett felhasználók számára elérhető
    public async Task<IActionResult> UpdateUsername([FromBody] UpdateUsernameDTO updateUsernameDto)
    {
        var user = await userManager.GetUserAsync(User); // Jelenlegi bejelentkezett felhasználó

        if (user == null)
        {
            return NotFound("Felhasználó nem található.");
        }

        // Ellenőrizd, hogy az új felhasználónév már létezik-e
        var existingUser = await userManager.FindByNameAsync(updateUsernameDto.NewUsername);
        if (existingUser != null)
        {
            return BadRequest("Ez a felhasználónév már használatban van.");
        }

        // Felhasználónév módosítása
        user.UserName = updateUsernameDto.NewUsername;

        var result = await userManager.UpdateAsync(user);

        if (!result.Succeeded)
        {
            return BadRequest("Felhasználónév módosítása nem sikerült.");
        }

        return Ok("Felhasználónév sikeresen módosítva.");
    }
    // Email módosítása
    [HttpPut("update-email")]
    [Authorize] // Csak bejelentkezett felhasználók számára elérhető
    public async Task<IActionResult> UpdateEmail([FromBody] UpdateEmailDTO updateEmailDto)
    {
        var user = await userManager.GetUserAsync(User); // Jelenlegi bejelentkezett felhasználó

        if (user == null)
        {
            return NotFound("Felhasználó nem található.");
        }

        // Ellenőrizd, hogy az új email cím már létezik-e
        var existingUser = await userManager.FindByEmailAsync(updateEmailDto.NewEmail);
        if (existingUser != null)
        {
            return BadRequest("Ez az email cím már használatban van.");
        }

        // Email módosítása
        user.Email = updateEmailDto.NewEmail;
        user.UserName = updateEmailDto.NewEmail.Split('@')[0]; // A felhasználónév frissítése is

        var result = await userManager.UpdateAsync(user);

        if (!result.Succeeded)
        {
            return BadRequest("Email módosítása nem sikerült.");
        }

        return Ok("Email sikeresen módosítva.");
    }

    // Jelszó módosítása
    [HttpPut("update-password")]
    [Authorize] // Csak bejelentkezett felhasználók számára elérhető
    public async Task<IActionResult> UpdatePassword([FromBody] UpdatePasswordDTO updatePasswordDto)
    {
        var user = await userManager.GetUserAsync(User); // Jelenlegi bejelentkezett felhasználó

        if (user == null)
        {
            return NotFound("Felhasználó nem található.");
        }

        // Ellenőrizd, hogy a régi jelszó helyes-e
        var checkPasswordResult = await userManager.CheckPasswordAsync(user, updatePasswordDto.OldPassword);
        if (!checkPasswordResult)
        {
            return BadRequest("Helytelen régi jelszó.");
        }

        // Jelszó módosítása
        var result = await userManager.ChangePasswordAsync(user, updatePasswordDto.OldPassword, updatePasswordDto.NewPassword);

        if (!result.Succeeded)
        {
            return BadRequest("Jelszó módosítása nem sikerült.");
        }

        return Ok("Jelszó sikeresen módosítva.");
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












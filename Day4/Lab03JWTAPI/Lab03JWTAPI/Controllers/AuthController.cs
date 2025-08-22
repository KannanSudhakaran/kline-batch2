using Lab03JWTAPI.Data;
using Lab03JWTAPI.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.JSInterop.Infrastructure;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Lab03JWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private KlineAppDbContext _context;
        private IConfiguration _configuration;
        public AuthController(KlineAppDbContext context,IConfiguration configuration)
        { 
           _context = context;
            _configuration = configuration;
        }


        [HttpPost]
        public IActionResult Login(LoginDto dto) { 
        
          var appUser=  _context.AppUsers.FirstOrDefault(u=>u.UserName== dto.UserName);

            if (appUser == null || appUser.PasswordHash != dto.Password)
            {
                return Unauthorized();
            }

            //idenity of user
            var claims = new[]
           {
                 new Claim(ClaimTypes.Name, appUser.UserName),
                 new Claim(ClaimTypes.Role, appUser.Role)
             };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["KlineJwt:secretkey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds);

            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });


        }


    }
}

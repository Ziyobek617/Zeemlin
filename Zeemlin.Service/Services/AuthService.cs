//using Microsoft.Extensions.Configuration;
//using Microsoft.IdentityModel.Tokens;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text;
//using Zeemlin.Domain.Entities;
//using Zeemlin.Service.DTOs.User;
//using Zeemlin.Service.Exceptions;
//using Zeemlin.Service.Interfaces;

//namespace Zeemlin.Service.Services;

//public class AuthService : IAuthService
//{
//    private readonly IUserService _userService;
//    private readonly IConfiguration _configuration;

//    public AuthService(IUserService userService, IConfiguration configuration)
//    {
//        _userService = userService;
//        _configuration = configuration;
//    }


//    public async Task<LoginForResult> AuthenticateAsync(LoginDto login)
//    {
//        var user = await _userService.RetrieveByEmailAsync(login.Email);
//        if (user is null)
//            throw new ZeemlinException(400, "Email or Password is incorrect");

//        return new LoginForResult
//        {
//            Token = GenerateToken(user)
//        };

//    }

//    private string GenerateToken(Student user)
//    {
//        var tokenHandler = new JwtSecurityTokenHandler();
//        var tokenKey = Encoding.UTF8.GetBytes(_configuration["JWT:Key"]);
//        var tokenDescriptor = new SecurityTokenDescriptor
//        {
//            Subject = new ClaimsIdentity(new Claim[]
//            {
//                new Claim("Id",user.Id.ToString()),
//                new Claim(ClaimTypes.Name,user.FirstName),
//                new Claim(ClaimTypes.Email,user.Email)
//            }),
//            Audience = _configuration["JWT:Audience"],
//            Issuer = _configuration["JWT:Issuer"],
//            IssuedAt = DateTime.UtcNow,
//            Expires = DateTime.UtcNow.AddMinutes(double.Parse(_configuration["JWT:Expire"])),
//            SigningCredentials = new SigningCredentials(
//                new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
//        };

//        var token = tokenHandler.CreateToken(tokenDescriptor);
//        return tokenHandler.WriteToken(token);
//    }
//}

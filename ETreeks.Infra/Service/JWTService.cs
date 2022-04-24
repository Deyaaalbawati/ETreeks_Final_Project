using ETreeks.Core.Repository;
using ETreeks.Core.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Infra.Service
{
   public class JWTService: IJWTService
    {
        private readonly IJWTRepoistory iJWTRepoistory;
        public JWTService(IJWTRepoistory _iJWTRepoistory)
        {
            iJWTRepoistory = _iJWTRepoistory;
        }
        public string Auth(Account account) 
        {
            var result = iJWTRepoistory.Auth(account);
            if (result == null)
            {
                return null;
            }
            else
            {

                var tokenhandler = new JwtSecurityTokenHandler();

                var tokenKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]"));

                var tokendescriptor = new SecurityTokenDescriptor()
                {
                    Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Email,result.Email),
                    new Claim(ClaimTypes.Role,result.RoleName),
                    new Claim(ClaimTypes.Actor,result.Accountstatus),

                    //new Claim(ClaimTypes.Name,result.FirstName),

                    //new Claim(ClaimTypes.Name,result.FirstName) //deyaa 

                    }),
                    Expires = DateTime.UtcNow.AddYears(1),
                    SigningCredentials = new SigningCredentials(tokenKey, SecurityAlgorithms.HmacSha256)
                };
                var token = tokenhandler.CreateToken(tokendescriptor);
                return tokenhandler.WriteToken(token);
            }
        }
        public string AuthStudent(Account account)
        {
            var result = iJWTRepoistory.Auth(account);
            if (result == null)
            {
                return null;
            }
            else
            {

                var tokenhandler = new JwtSecurityTokenHandler();

                var tokenKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]"));

                var tokendescriptor = new SecurityTokenDescriptor()
                {
                    Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Email,result.Email),
                    new Claim(ClaimTypes.Role,result.RoleName),
                    //new Claim(ClaimTypes.Actor,result.Accountstatus),

                    //new Claim(ClaimTypes.Name,result.FirstName),

                    //new Claim(ClaimTypes.Name,result.FirstName) //deyaa 

                    }),
                    Expires = DateTime.UtcNow.AddYears(1),
                    SigningCredentials = new SigningCredentials(tokenKey, SecurityAlgorithms.HmacSha256)
                };
                var token = tokenhandler.CreateToken(tokendescriptor);
                return tokenhandler.WriteToken(token);
            }
        }
    }
}

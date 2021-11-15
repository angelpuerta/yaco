using authentication.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Threading.Tasks;

namespace authentication.Services
{
    public class UserService : IUserService
    {
        private AppSettings appSettings;
        private IMongoDatabase Database;
        private readonly IMongoCollection<User> users;

        private UserService(IOptions<AppSettings> appSettings, DatabaseSettings dbSettings)
        {
            var client = new MongoClient(dbSettings.ConnectionString);
            Database = client.GetDatabase(dbSettings.UserDatabase);
            users = Database.GetCollection<User>(dbSettings.UserCollectionName);
        }

        public string Authenticate(string userId, string password)
        {
            return users.Find(user => user.UserId == userId & user.Password == password)
                 .SingleAsync<User>()
                 .ContinueWith<string>(user => GenerateJwtToken(user.Result))
                 .Result;
        }


        private string GenerateJwtToken (User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = System.Text.Encoding.ASCII.GetBytes(appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.Add(appSettings.Expiration),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}

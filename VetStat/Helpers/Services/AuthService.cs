using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetStat.Data;
using VetStat.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VetStat.Helpers.Services
{

    public class AuthService
    {
        private readonly DataContext _db;
        private readonly IHttpContextAccessor _httpContext;

        public AuthService(DataContext db, IHttpContextAccessor _httpContext)
        {
            
            _db = db;
            this._httpContext = _httpContext;
        }

        public bool IsLogged()
        {
            string authToken = _httpContext.HttpContext.Request.Headers["my-auth-token"];

            AuthentificationToken? token = _db.AuthentificationToken.SingleOrDefault(x=>x.Token == authToken);

            return token != null; //If there is false, user isn`t logged
        }
    }
}

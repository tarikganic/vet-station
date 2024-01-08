using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using VetStat.Data;
using VetStat.Helpers.Services;
using VetStat.Helpers.Validators;
using VetStat.Models;

namespace VetStat.Endpoints.ProfileEndpoint
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProfileEndpointController : ControllerBase
    {

        private readonly DataContext _db;
        private AuthService _authService;
        public ProfileEndpointController(DataContext db, AuthService authService)
        {
            _db = db;
            _authService = authService;
        }


      
        [HttpGet("{token}")]
        public ActionResult<Person> GetUserInfo(string token)
        {
            if (_authService.IsLogged())
            {

            var _token = _db.AuthentificationToken.SingleOrDefault(x => x.Token == token);
            
            try
            {
                var person = _db.Person.SingleOrDefault<Person>(x => x.Id == _token.UserProfileId);

                var userProfile = new ProfileEndpointResponse(person);
                
                return Ok(userProfile);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            }

            return BadRequest("You are not logged!");
        }




       
    }
}

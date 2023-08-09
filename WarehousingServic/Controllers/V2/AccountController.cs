using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarehousingServic.Entity;

namespace WarehousingServic.Controllers.V2
{
    [Route("api/[controller]")]
    [ApiVersion("2", Deprecated = true)]
    [ApiController]
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {

        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromForm] LoginFieldRequest loginFieldRequest)
        {
            var jwtAuthorizationManager = new JWTAuthorizationManager();
            var result = jwtAuthorizationManager.Authenticate(loginFieldRequest.UserName, loginFieldRequest.Password);
            if (result == null)
                return Unauthorized();
            else
                return Ok(result);
        }
    }
}   

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Web.Controller
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route(nameof(AuthenticationController))]
    public class AuthenticationController
    {
        // private readonly UserManager userManager;

        // public AuthenticationController(UserManager userManager )
        // {
        //     this.userManager = userManager;
        // }

        [HttpPost]
        public ActionResult Login(string pass, string login)
        {

            return new OkObjectResult("f");
        }
    }
}
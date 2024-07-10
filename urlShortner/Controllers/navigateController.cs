using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UrlShortner.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},BasicAuthentication")]
[ApiController]
[Route("[controller]")]
public class NavigateController : ControllerBase
{
        [HttpGet]
    [Route("navigate/{url}")]
    public IActionResult NavigateRedirection(string url){
       // TODO: return
       return Redirect("http://google.com");
       
    }
}

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace urlShortner.Controllers;

using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using urlShortner;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},BasicAuthentication")]
[ApiController]
[Route("[controller]")]
public class shortURLsController : ControllerBase
{

    private readonly ILogger<shortURLsController> _logger;
    private string longUrl;
    
    public shortURLsController(ILogger<shortURLsController> logger)
    {
        _logger = logger;
    }

    [Authorize(Policy = "AddCustomer")]
    [HttpGet("{urlID}")]
    public ShortUrl Get([FromRoute] string urlID)
    {
// TODO: return
        return new ShortUrl()
        {
            UrlID = urlID,
            CreatedBy = "Helina Azer",
        };
    }

    [Authorize(Policy = "AddCustomer")]
    [HttpPut("{urlID}")]
    public ShortUrl Put([FromRoute] string urlID, [FromBody] ShortUrl shortUrl) {
        return new ShortUrl() { 
            UrlID = urlID,
            URL = shortUrl.URL,
            CreatedBy = "Helina Azer", 
        };
    }

    // [HttpPut("{urlID}")]
    // public ShortUrl Put([FromBody] LongUrl body) {
    //     return longUrl = body.URL;
    // }

    [Authorize(Roles = "Emperor,Deacon")]
    [HttpDelete("{urlID}")]
    public ShortUrl Delete([FromRoute] string urlID) {
        return new ShortUrl() {
            UrlID = null,
        };
    }
    
    [AllowAnonymous]
    [HttpGet("{urlID}/hits")]
    public ShortUrl Hits([FromRoute] string urlID)
    {
        //return 4;
        return new ShortUrl()
        {
            UrlID = urlID,
            //URL = shortUrl.URL, 
            Hits = 4
        };
    }

    [AllowAnonymous]
    [HttpGet]
    [Route("navigate/{url}")]
    public IActionResult NavigateRedirection(string url){
       // TODO: return
       return Redirect("http://google.com");
       
    }
}

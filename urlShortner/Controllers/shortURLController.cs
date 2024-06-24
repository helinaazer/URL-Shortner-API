using Microsoft.AspNetCore.Mvc;

namespace urlShortner.Controllers;

using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using urlShortner;

[ApiController]
[Route("[controller]")]
public class shortURLsController : ControllerBase
{
    // private static readonly string[] Summaries = new[]
    // {
    //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    // };

    private readonly ILogger<shortURLsController> _logger;
    private string longUrl;
    public shortURLsController(ILogger<shortURLsController> logger)
    {
        _logger = logger;
    }

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

    [HttpDelete("{urlID}")]
    public ShortUrl Delete([FromRoute] string urlID) {
        return new ShortUrl() {
            UrlID = null,
        };
    }
    
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
    [HttpGet]
    [Route("navigate/{url}")]
    public IActionResult NavigateRedirection(string url){
       // TODO: return
       return Redirect("http://google.com");
       
    }
}

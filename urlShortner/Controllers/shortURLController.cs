using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
//using urlShortner.Models.UrlShortenerContext;
//using urlShortner.Models;
//using urlShortner;
//using UrlShortner.Helper;
// using UrlShortner.Security;

namespace urlShortner.Controllers;

[Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme},BasicAuthentication")]
[ApiController]
[Route("[controller]")]
public class shortURLsController : ControllerBase
{

    private readonly ILogger<shortURLsController> _logger;
    //private string longUrl;

    private readonly UrlShortenerContext _context;
    
    public shortURLsController(ILogger<shortURLsController> logger, UrlShortenerContext context)
    {
        _logger = logger;
        _context = context;
    }

    // public shortURLsController(ILogger<shortURLsController> logger)
    // {
    //     _logger = logger;
    // }

    // [Authorize(Policy = "AccessCode")]
    // //shorturls/url1
    // [HttpGet("{urlID}")]
    // public ShortUrl Get([FromRoute] string urlID)
    // {
    //     return new ShortUrl()
    //     {
    //         UrlID = urlID,
    //         CreatedBy = "Helina Azer",
    //     };
    // }

    [AllowAnonymous]
    [HttpGet("{urlID}")]
    public string Get([FromRoute] string urlID){
        var url = _context.Urls.SingleOrDefault(u => u.UrlId == urlID);
        if (url == null)
        {
            return "Shortened URL not found.";
        }
        return url.ShortenedUrl;
    }

    [AllowAnonymous]
    [HttpGet("original/url/{shortUrl}")]
    public string GetOriginalUrl(string shortUrl)
    {
        var url = _context.Urls.SingleOrDefault(u => u.ShortenedUrl == shortUrl);
        if (url == null)
        {
            return "Shortened URL not found.";
        }
        return url.OriginalUrl;
    }

    [AllowAnonymous]
    [HttpPost("addUrl")]
    public string AddUrl() {
        string longUrl = "www.meta.com";
        int customerId = 2;
        string urlId = "urlTest";
        string shortUrl = "www.m.com";

        var newUrl = new Url {
        UrlId = urlId,
        OriginalUrl = longUrl,
        ShortenedUrl = shortUrl,
        UserId = customerId,
        };

        // Add the new entity to the Urls DbSet
        _context.Urls.Add(newUrl);

        // Save the changes to the database
        _context.SaveChanges();

        var url = _context.Urls.SingleOrDefault(u => u.ShortenedUrl == shortUrl);
        if (url == null) {
            return "Shortened URL not found.";
        }
        
        return url.OriginalUrl;
        
    }

    [Authorize(Policy = "CreateProduct")]
    //shorturls/url1
    [HttpPut("{urlID}")]
    public ShortUrl Put([FromRoute] string urlID, [FromBody] ShortUrl shortUrl) {
        return new ShortUrl() { 
            UrlID = urlID,
            URL = shortUrl.URL,
            CreatedBy = "Helina Azer", 
        };
    }

    [Authorize(Roles = "Cybersecurity Analyst, Data Analyst")]
    [HttpDelete("{urlID}")]
    public ShortUrl Delete([FromRoute] string urlID) {
        return new ShortUrl() {
            UrlID = null,
        };
    }
    
    [AllowAnonymous]
    //shorturls/url1/hits
    [HttpGet("{urlID}/hits")]
    public ShortUrl Hits([FromRoute] string urlID)
    {
        //return 4;
        return new ShortUrl()
        {
            UrlID = urlID,
            Hits = 4
        };
    }

    [AllowAnonymous]
    [HttpGet]
    //shorturls/navigate/url1
    [Route("navigate/{url}")]
    public IActionResult NavigateRedirection(string url){
       return Redirect("http://google.com");
       
    }
}

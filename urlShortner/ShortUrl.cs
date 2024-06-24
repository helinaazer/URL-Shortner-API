namespace urlShortner;

public class ShortUrl
{
    //representation of a long URL
    public string? URL { get; set; }

    //represent who created the link
    public string? CreatedBy { get; set; }

    //represents the number of times the short URL was used
    public int Hits { get; set; }

    //representation of a short URL
    public string? UrlID { get; internal set; }
}

// public class LongUrl {
//     public string? URL { get; set;}
// }
    
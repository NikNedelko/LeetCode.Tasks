public class Codec {
    private int position = 0;
    private Dictionary<string, string> dict = new ();

    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        var indx = position;
        position++;
        dict.Add(indx.ToString(), longUrl);
        return indx.ToString();
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        return dict[shortUrl];
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));


public class Codec {
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        var bytes = System.Text.Encoding.UTF8.GetBytes(longUrl);
        return Convert.ToBase64String(bytes);
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        var bytes = Convert.FromBase64String(shortUrl);
        return System.Text.Encoding.UTF8.GetString(bytes);
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));
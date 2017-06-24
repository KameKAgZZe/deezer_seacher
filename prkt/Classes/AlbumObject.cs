using System.Collections.Generic;

public class Datum
{
    public int id { get; set; }
    public string name { get; set; }
    public string picture { get; set; }
    public string type { get; set; }
}

public class Genres
{
    public List<Datum> data { get; set; }
}

public class Contributor
{
    public int id { get; set; }
    public string name { get; set; }
    public string link { get; set; }
    public string share { get; set; }
    public string picture { get; set; }
    public string picture_small { get; set; }
    public string picture_medium { get; set; }
    public string picture_big { get; set; }
    public string picture_xl { get; set; }
    public bool radio { get; set; }
    public string tracklist { get; set; }
    public string type { get; set; }
    public string role { get; set; }
}

public class Artist
{
    public int id { get; set; }
    public string name { get; set; }
    public string picture { get; set; }
    public string picture_small { get; set; }
    public string picture_medium { get; set; }
    public string picture_big { get; set; }
    public string picture_xl { get; set; }
    public string tracklist { get; set; }
    public string type { get; set; }
}

public class Artist2
{
    public int id { get; set; }
    public string name { get; set; }
    public string tracklist { get; set; }
    public string type { get; set; }
}

public class Artist3
{
    public int id { get; set; }
    public string name { get; set; }
    public string tracklist { get; set; }
    public string type { get; set; }
}

public class Alternative
{
    public int id { get; set; }
    public bool readable { get; set; }
    public string title { get; set; }
    public string title_short { get; set; }
    public string title_version { get; set; }
    public string link { get; set; }
    public int duration { get; set; }
    public int rank { get; set; }
    public bool explicit_lyrics { get; set; }
    public string preview { get; set; }
    public Artist3 artist { get; set; }
    public string type { get; set; }
}

public class Datum2
{
    public int id { get; set; }
    public bool readable { get; set; }
    public string title { get; set; }
    public string title_short { get; set; }
    public string title_version { get; set; }
    public string link { get; set; }
    public int duration { get; set; }
    public int rank { get; set; }
    public bool explicit_lyrics { get; set; }
    public string preview { get; set; }
    public Artist2 artist { get; set; }
    public string type { get; set; }
    public Alternative alternative { get; set; }
}

public class Tracks
{
    public List<Datum2> data { get; set; }
}

public class AlbumObject
{
    public int id { get; set; }
    public string title { get; set; }
    public string upc { get; set; }
    public string link { get; set; }
    public string share { get; set; }
    public string cover { get; set; }
    public string cover_small { get; set; }
    public string cover_medium { get; set; }
    public string cover_big { get; set; }
    public string cover_xl { get; set; }
    public int genre_id { get; set; }
    public Genres genres { get; set; }
    public string label { get; set; }
    public int nb_tracks { get; set; }
    public int duration { get; set; }
    public int fans { get; set; }
    public int rating { get; set; }
    public string release_date { get; set; }
    public string record_type { get; set; }
    public bool available { get; set; }
    public string tracklist { get; set; }
    public bool explicit_lyrics { get; set; }
    public List<Contributor> contributors { get; set; }
    public Artist artist { get; set; }
    public string type { get; set; }
    public Tracks tracks { get; set; }
}
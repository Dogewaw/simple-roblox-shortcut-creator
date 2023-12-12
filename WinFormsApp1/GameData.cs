public class Datum
{
    public long targetId { get; set; }
    public string? state { get; set; }
    public string? imageUrl { get; set; }
    public string? version { get; set; }
}

public class Root
{
    public List<Datum> data { get; set; }
}
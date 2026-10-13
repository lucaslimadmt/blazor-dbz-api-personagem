namespace BlazorDbzPersonagem.Models;

public class Personagem
{
    public int id { get; set; }
    public string? name { get; set; }
    public string? ki { get; set; }
    public string? maxKi { get; set; }
    public string? race { get; set; }
    public string? gender { get; set; }
    public string? description { get; set; }
    public string? image { get; set; }
    public string? affiliation { get; set; }
    public Planeta? originPlanet { get; set; }
    public List<Transformacao>? transformations { get; set; }
}

public class Planeta
{
    public int id { get; set; }
    public string? name { get; set; }
    public bool isDestroyed { get; set; }
    public string? description { get; set; }
    public string? image { get; set; }
}

public class Transformacao
{
    public int id { get; set; }
    public string? name { get; set; }
    public string? image { get; set; }
    public string? ki { get; set; }
}

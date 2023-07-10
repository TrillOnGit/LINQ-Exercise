namespace LINQ;

public class Game
{
    public Game(string name, string genre)
    {
        Name = name;
        Genre = genre;
    }

   

    public string Name { get; set; }
    public string Genre { get; set; }
}
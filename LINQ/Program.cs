using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Game> sortList = new ListManager().GameList;

            sortList = sortList.OrderBy(x => x.Name.Length).ToList();

            foreach (var game in sortList)
            {
                Console.WriteLine($"{game.Name}, Genre: {game.Genre}");
            }
        }
    }
}

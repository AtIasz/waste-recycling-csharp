using System;

namespace WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameMaster gm = GameMaster.Instance;
            Console.WriteLine(@"
        _________________________________
        |                               |
        |       Welcome, to the         |
        |       LEGEND OF TRASH         |
        |_______________________________|");

            Console.Write("\nCopyright to Adam Csondes. 2019.\nPlease enter your character's name: ");
            gm.CharacterName = Console.ReadLine();

            Console.WriteLine($"Welcome {gm.CharacterName}!");
        }
    }
}

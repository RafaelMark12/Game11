using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Valami_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Inventory item = new Inventory();

            Terulet valami = new ElsoTerem();
            Npc ember = new Rasszista();

            Console.WindowWidth = 120;
            Console.WindowHeight = 30;
            Animalt("Üdvözöllek a Neumann iskolájában.");
            Thread.Sleep(2000);
            Animalt("Kérlek nyomj egy Entert!");
            Console.ReadLine();
            Console.Clear();
            Animalt("Szeretne-e bejönni az iskolába? (Y/N)");
            string input = Console.ReadLine();
            if (input == "Y")
            {
                Console.Clear();
                Animalt("Indulás...");
            }
            else if (input == "N")
            {
                Console.Clear();
                Animalt("A játék hamarosan leáll...");
                Thread.Sleep(200);
            }
            else
            {
                Console.Clear();
                Animalt("ÉRVÉNYTELEN A BEMENET!");
                Thread.Sleep(200);
            }
            
























        }
        static void Animalt(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }
            Console.WriteLine();
        }
    }
}

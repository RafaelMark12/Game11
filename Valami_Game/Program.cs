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

            string ora = "Fizika";
            Animalt("Üdvözöllek a Neumann János Technikumjában.");
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
                Thread.Sleep(5000);
                Console.ReadLine();
            }
            else if (input == "N")
            {
                Console.Clear();
                Animalt("A játék hamarosan leáll...");
                Thread.Sleep(2000);
            }
            else
            {
                Console.Clear();
                Animalt("ÉRVÉNYTELEN A BEMENET!");
                Animalt("A játék hamarosan leáll...");
                Thread.Sleep(2000);
            }
            Console.Clear();
            Animalt("Beléptél az Aulába. \n\nHamarosan indul az óra, ideje bemenni az órádra.");
            Thread.Sleep(1000);
            Animalt($"\nAz első órád a {ora}. \n\nVálasztási opcióid: ");
            Animalt("Büfé");
            Animalt("Terem");
            input = Console.ReadLine();
            if (input == "Büfé")
            {

            }
            else if (input == "Terem")
            {

            }
            else
            {
                Animalt("ÉRVÉNYTELEN PARANCS");
                Thread.Sleep(1000);
                Animalt($"Választási opcióid: ");
                Animalt("Büfé");
                Animalt("Terem");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Valami_Game;
using System.Media;

namespace Valami_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Inventory item = new Inventory();
            Terulet valami = new ElsoTerem();
            Npc ember = new Rasszista();







            /*Történet kezdete*/

            string ora = "Fizika";
            Animalt("Üdvözöllek a Neumann János Technikumjában.");
            Thread.Sleep(1);
            Animalt("Kérlek nyomj egy Entert!");
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(1000);
            Animalt("Szeretne-e bejönni az iskolába? (Y/N)");
            string input = Console.ReadLine();
            if (input == "Y")
            {
                Console.Clear();
                Animalt("Indulás...");
                Thread.Sleep(2000);
                
            }
            else if (input == "N")
            {
                Console.Clear();
                Animalt("A játék hamarosan leáll...");
                Thread.Sleep(2000);
                return; //arra szolgál a return itt, hogyha a játék le akarna állítani, 
                        //ezzel a paranccsal tudjuk kiléptetni a console-ból a személyt.
                
            }
            else
            {
                Console.Clear();
                Animalt("ÉRVÉNYTELEN A BEMENET!");
                Animalt("A játék hamarosan leáll...");
                Thread.Sleep(2000);
                return;
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




        /*A szöveg animálása ezzel a függvénnyel írható ki*/
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

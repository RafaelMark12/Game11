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
            Egyeb ido = new Egyeb();
            


            /*Történet kezdete*/

            string ora = "Fizika";
            Animalt("Üdvözöllek a Neumann János Technikumjában.");
            Thread.Sleep(1);
            Animalt("Kérlek nyomj egy Entert!");
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(1000);
            string input;
            while (true)
            {
                Animalt("Szeretne-e bejönni az iskolába? (Y/N)");
                Console.Write("Válasz: ");
                input = Console.ReadLine();
                if (input == "Y")
                {
                    Console.Clear();
                    Animalt("Indulás...");
                    Thread.Sleep(2000);
                    break;

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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Animalt("ÉRVÉNYTELEN A BEMENET!");
                    Console.ResetColor();
                    Console.Clear();
                }
            }
            Console.Clear();
            Animalt("Beléptél az Aulába...");
            Animalt("Merre szeretnél menni?");
            Thread.Sleep(1000);
            while (true)
            {
                Animalt("\nVálasztási opcióid: ");
                Animalt("Büfé\tTerem");
                Console.Write("Válasz: ");
                input = Console.ReadLine();
                if (input == "Büfé")
                {
                    Animalt("Zúdulás...");
                    break;
                }
                else if (input == "Terem")
                {
                    Animalt("Irány a terem...");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Animalt("ÉRVÉNYTELEN PARANCS");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                }
            }
            Console.ReadLine();
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

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
            

            Animalt("Üdvözöllek a Neumann iskolájában.");
            Thread.Sleep(2000);
            Animalt("Kérlek nyomj egy Entert!");
            Console.ReadLine();
            Console.Clear();
            Console.ReadLine();



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

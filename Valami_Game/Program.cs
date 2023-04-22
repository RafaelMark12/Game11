using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Valami_Game; 
using System.Media; //hang-médiaeszközhöz szükséghez


namespace Valami_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*Npc-k meghívása*/
            Npc Rasszista = new Rasszista();
            Npc Agressziv = new Agressziv();
            Npc Kedves = new Kedves();
            Npc Igazgato = new Igazgato();
            Npc BabucsTanarno = new BabucsTanarno();
            Npc RendszerGazda = new RendszerGazda();
            Npc Bufes = new Bufes();
            Npc Futar = new Futar();


            /*A Termek meghívása*/
            Terulet TeremOs = new TeremOs();
            Terulet GT4 = new GT4();
            Terulet Terem205 = new Terem205();
            Terulet Terem46 = new Terem46();
            Terulet Bufe = new Bufe();

            /*Inventory osztály meghívása*/
            Inventory invent = new Inventory();
            

            /*Háttérzene lefuttatása
            Task.Run(() => BackgroundMusic());
            Thread.Sleep(5000);
            */


            /*Történet kezdete*/

            string ora = "Fizika";
            Animalt("Üdvözöllek a Neumann János Technikumjában.");
            
            Thread.Sleep(2000);
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
                    return; 

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
                    Thread.Sleep(5000);
                    Console.Clear();
                    Animalt(Bufe.Leiras());
                    Thread.Sleep(1000);
                    while (true)
                    {
                        Animalt("Választási opcióid: \nIgen\tNem");
                        Console.Write("Válasz: ");
                        input = Console.ReadLine();
                        if (input == "Igen")
                        {
                            Animalt("Elérhető ajánlatok: ");
                            Animalt("Vettél valamit....");
                            Animalt("Irány végre a Terembe menni, mindjárt óra!");                                                                                    
                            break;
                        }
                        else if (input == "Nem")
                        {
                            Animalt("Irány a terem akkor...");
                            Thread.Sleep(5000);
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Animalt("ÉRVÉNYTELEN PARANCS");
                            Console.ResetColor();
                            Console.Clear();
                            Thread.Sleep(1000);
                        }
                    }
                    break;
                }
                else if (input == "Terem")
                {
                    Animalt("Irány a terem...");
                    Thread.Sleep(5000);
                    Animalt(Terem46.Leiras());
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Animalt("ÉRVÉNYTELEN PARANCS");
                    Console.ResetColor();
                    Console.Clear();
                    Thread.Sleep(1000);
                }
            }

            Console.Clear();
            Animalt(Terem205.Leiras());

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




        /*
        static void BackgroundMusic()
        {
            SoundPlayer majom = new SoundPlayer("hatterzene.wav");
            majom.PlayLooping();
        }
        */
    }
}

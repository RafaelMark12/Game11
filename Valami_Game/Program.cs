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
            Npc Dealer = new Dealer();
            Npc Igazgato = new Igazgato();
            Npc BabucsTanarno = new BabucsTanarno();
            Npc RendszerGazda = new RendszerGazda();
            Npc JozsiTanar = new JozsiTanar();
            Npc LegjobbBarat = new LegjobbBarat();
            Npc Bufes = new Bufes();
            Npc Futar = new Futar();


            /*A Termek meghívása*/
            Terulet TeremOs = new TeremOs();
            Terulet GT4 = new GT4();
            Terulet Terem205 = new Terem205();
            Terulet Terem46 = new Terem46();
            Terulet Terem33 = new Terem33();
            Terulet Terem133 = new Terem133();
            Terulet Aula = new Aula();
            Terulet Lepcso = new Lepcso();
            Terulet Bufe = new Bufe();

            /*Inventory osztály meghívása, szótár kialakítása*/
            Inventory invent = new Inventory();

            Dictionary<string, int> taska = new Dictionary<string, int>();
            taska.Add("Laptop", invent.Laptop);
            taska.Add("Matekkönyv", invent.Matekkonyv);
            taska.Add("Toll",invent.Toll);
            taska.Add("Óra", invent.Ora);
            taska.Add("Tornacsuka", invent.Tornacsuka);
            taska.Add("Telefon", invent.Telefon);

            Dictionary<string, int> bufetar = new Dictionary<string, int>();
            bufetar.Add("Szendvics",invent.Szendvics);
            bufetar.Add("Bor", invent.Bor);
            bufetar.Add("Fank", invent.Fank);

            Dictionary<string, int> deal = new Dictionary<string, int>();
            deal.Add("Kés",invent.Kes);
            deal.Add("Amongus", invent.Amongus);
            






            /*Történet kezdete*/


            Animalt("Üdvözöllek a Neumann János Technikumjában.");
            
            Thread.Sleep(500);
            Animalt("\nAlap információk: ");
            Animalt($"Életerő: {invent.Eleted}");
            Animalt($"Pénz: {invent.Penz}");
            Thread.Sleep(100);
            Animalt("\nTáska tartalma:");
            foreach (var i in taska)
            {
                Animalt($"{i.Key}");
            }
            Thread.Sleep(2000);
            Animalt("\nA játék indításához kérlek nyomj egy Entert!");
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(4000);
            string input;
            while (true)
            {
                Animalt("Szeretne-e bejönni az iskolába? (Igen/Nem)");
                Console.Write("Válasz: ");
                input = Console.ReadLine();
                if (input == "Igen")
                {
                    Console.Clear();
                    Animalt("Indulás...");
                    Thread.Sleep(3000);
                    break;

                }
                else if (input == "Nem")
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
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            Console.Clear();
            Animalt("Beléptél az Aulába...");
            Animalt("Merre szeretnél menni?");
            Thread.Sleep(1000);
            while (true)
            {
                
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
                    BufeEsemeny();
                    break;
                }
                else if (input == "Terem")
                {
                    Animalt("Irány a terem...");
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

            Console.Clear();
            Thread.Sleep(1000);
            Animalt(Terem205.Leiras());
            Console.ReadLine();







            
            void BufeEsemeny()
            {
                while (true)
                {
                    Animalt("Igen\tNem");
                    Console.Write("Válasz: ");
                    input = Console.ReadLine();
                    if (input == "Igen")
                    {
                        Console.Clear();
                        Thread.Sleep(1000);
                        while (true)
                        {
                            Animalt("Elérhető ajánlatok: ");
                            foreach (var i in bufetar)
                            {
                                Animalt($"{i.Key} - {i.Value}");
                            }
                            Thread.Sleep(500);
                            Console.Write("Válasz: ");
                            input = Console.ReadLine();
                            if (bufetar.ContainsKey(input))
                            {
                                switch (input)
                                {
                                    case "Szendvics":
                                        Animalt("Vásárlásod folyamatban: ");
                                        invent.Eleted = invent.Eleted - invent.Szendvics;
                                        if (invent.Eleted > 0)
                                        {
                                            bufetar.Remove("Szendvics");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Animalt("Vásárlásod Sikeres");
                                            Console.ResetColor();
                                            Animalt("Megmaradt összeged: " + invent.Penz);
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Animalt("Nincs Pízzed!");
                                            Animalt("Nem tudtad megvenni.");
                                            Console.ResetColor();
                                        }
                                        break;

                                    case "Bor":
                                        Animalt("Vásárlásod folyamatban: ");
                                        invent.Eleted = invent.Eleted - invent.Bor;
                                        if (invent.Eleted > 0)
                                        {
                                            bufetar.Remove("Bor");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Animalt("Vásárlásod Sikeres");
                                            Console.ResetColor();
                                            Animalt("Megmaradt összeged: " + invent.Penz);
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Animalt("Nincs Pízzed!");
                                            Animalt("Nem tudtad megvenni.");
                                            Console.ResetColor();
                                        }
                                        break;

                                    case "Fánk":
                                        Animalt("Vásárlásod folyamatban: ");
                                        invent.Eleted = invent.Eleted - invent.Fank;
                                        if (invent.Eleted > 0)
                                        {
                                            bufetar.Remove("Fank");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Animalt("Vásárlásod Sikeres");
                                            Console.ResetColor();
                                            Animalt("Megmaradt összeged: " + invent.Penz);
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Animalt("Nincs Pízzed!");
                                            Animalt("Nem tudtad megvenni.");
                                            Console.ResetColor();
                                        }
                                        break;

                                }

                                break;
                            }
                        }
                        Thread.Sleep(1000);
                        Animalt("\nIrány végre a Terembe menni, mindjárt óra!");
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
            }
        }









        /*A szöveg animálása ezzel a függvénnyel írható ki*/
        static void Animalt(string text)
        {
            
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(80);
            }
            Console.WriteLine();
        }



        /*
        static void BackgroundMusic()
        {
            SoundPlayer majom = new SoundPlayer("hatterzene.wav");
            majom.PlayLooping();

        

            /*Háttérzene lefuttatása
            Task.Run(() => BackgroundMusic());
            Thread.Sleep(5000);
            
        }
        */
    }
}

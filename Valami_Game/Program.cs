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
            taska.Add("Toll", invent.Toll);
            taska.Add("Óra", invent.Ora);
            taska.Add("Tornacsuka", invent.Tornacsuka);
            taska.Add("Telefon", invent.Telefon);

            Dictionary<string, int> bufetar = new Dictionary<string, int>();
            bufetar.Add("Szendvics", invent.Szendvics);
            bufetar.Add("Bor", invent.Bor);
            bufetar.Add("Fank", invent.Fank);

            Dictionary<string, int> deal = new Dictionary<string, int>();
            deal.Add("Kés", invent.Kes);
            deal.Add("Amongus", invent.Amongus);







            /*Történet kezdete*/


            Animalt("Üdvözöllek a Neumann János Technikumjában.");

            EzerKesleltetes();
            Animalt("\nAlap információk: ");
            OtKesleltetes();
            Console.WriteLine($"Életerő: {invent.Eleted}");
            OtKesleltetes();
            Console.WriteLine($"Pénz: {invent.Penz}");
            OtKesleltetes();
            Animalt("\nTáska tartalma:");
            foreach (var i in taska)
            {
                Console.WriteLine($"{i.Key}");
                OtKesleltetes();
            }
            EzerKesleltetes();
            Animalt("\nA játék indításához kérlek nyomj egy Entert!");
            Console.ReadLine();
            Console.Clear();
            NegyEKesleltetes();
            string input;
            while (true)
            {
                Animalt("Szeretne-e bejönni az iskolába? (Y/N)");
                Console.Write("Válasz: ");
                input = Console.ReadLine();
                if (input == "Y" || input == "Igen")
                {
                    Console.Clear();
                    Animalt("Indulás...");
                    NegyEKesleltetes();
                    break;

                }
                else if (input == "N" || input == "Nem")
                {
                    Console.Clear();
                    Animalt("A játék hamarosan leáll...");
                    StopKesleltetes();
                    return;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Animalt("ÉRVÉNYTELEN A BEMENET!");
                    Console.ResetColor();
                    EzerKesleltetes();
                    Console.Clear();
                }
            }
            Console.Clear();
            Animalt("Beléptél az Aulába...");
            Animalt("Merre szeretnél menni?");
            EzerKesleltetes();
            while (true)
            {

                Animalt("Büfé\tTerem");
                Console.Write("Válasz: ");
                input = Console.ReadLine();
                if (input == "Büfé")
                {
                    Animalt("Zúdulás...");
                    NegyEKesleltetes();
                    Console.Clear();
                    Animalt(Bufe.Leiras());
                    EzerKesleltetes();
                    BufeEsemeny();
                    break;
                }
                else if (input == "Terem")
                {
                    Animalt("Irány a terem...");
                    NegyEKesleltetes();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Animalt("ÉRVÉNYTELEN PARANCS");
                    Console.ResetColor();
                    Console.Clear();
                    EzerKesleltetes();
                }
            }

            Console.Clear();
            EzerKesleltetes();
            Animalt(Terem205.Leiras());
            NegyEKesleltetes();
            Animalt("Visszamentél az aulába");
            ElsoEvent();
            Console.ReadLine();



            /*Az adott helyszínek, vagy más eseményei*/

            void BufeEsemeny()
            {
                while (true)
                {
                    Animalt("Y/N");
                    Console.Write("Válasz: ");
                    input = Console.ReadLine();
                    if (input == "Igen" || input == "Y")
                    {
                        Console.Clear();
                        EzerKesleltetes();
                        while (true)
                        {
                            Animalt("Elérhető ajánlatok: ");
                            foreach (var i in bufetar)
                            {
                                Animalt($"{i.Key} - {i.Value}");
                            }
                            OtKesleltetes();
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
                                    case "Fank":
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
                        EzerKesleltetes();
                        Animalt("\nIrány végre a Terembe menni, mindjárt óra!");
                        break;
                    }
                    else if (input == "Nem" || input == "N")
                    {
                        Animalt("Irány a terem akkor...");
                        NegyEKesleltetes();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Animalt("ÉRVÉNYTELEN PARANCS");
                        Console.ResetColor();
                        Console.Clear();
                        EzerKesleltetes();
                    }
                }
            }



            void ElsoEvent()
            {
                Animalt(TeremOs.Leiras());
                OtKesleltetes();
                Animalt("Az idő elmúlásával növelted az életerődet és a tudásodat" +
                    ", amely segítségével képes vagy Neumann fejében átdolgozni.");
                invent.Eleted = invent.Eleted + 200;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Animalt("Az életerőd pontszáma: "+invent.Eleted);
                Console.ResetColor();
                EzerKesleltetes();
                Animalt("Visszamész az aulába, mintha mise történt volna.");
            }

            void MasodikEvent()
            {
                Animalt("");
                OtKesleltetes();
                Animalt("Találkoztál a bunkó osztálytársaddal, aki belédkötött");
                Animalt("\nVissza szeretnél bökni? ");
                
                
                
                while (true)
                {
                    Animalt("I\tN");
                    input = Console.ReadLine();
                    if (input == "I")
                    {
                        Animalt("Megbökted, emiatt kialakult egy párbaj.");
                        break;
                    }
                    else if (input == "N")
                    {
                        Animalt("Nem bökted meg, nem foglalkoztál vele.");
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Animalt("ÉRVÉNYTELEN A BEMENET!");
                        Console.ResetColor();
                        EzerKesleltetes();
                        Console.Clear();
                    }
                }
                    
                
            }
            
            void HarmadikEvent()
            {

            }

            void NegyedikEvent()
            {

            }

            void OtodikEvent()
            {

            }

            void HatodikEvent()
            {

            }

            void HetedikEvent()
            {

            }



        }



        








        /*A szöveg animálása ezzel a függvénnyel írható ki*/
        static void Animalt(string text)
        {
            
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(1);
            }
            Console.WriteLine();
        }


        //A Késleltetések egyszerűbbé vétele
        static void OtKesleltetes()
        {
            Thread.Sleep(500);
        }

        static void EzerKesleltetes()
        {
            Thread.Sleep(1000);
        }

        static void NegyEKesleltetes()
        {
            Thread.Sleep(4000);
        }
        static void StopKesleltetes()
        {
            Thread.Sleep(2000);
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

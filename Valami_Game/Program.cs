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

            AlapInformáció();
            JátékSzabály();
            string input;
            Belépés();
            InditoEvent();
            AulaEvent();
            ElsoEvent();
            AulaEvent();
            Console.ReadLine();



            /*Az adott helyszínek, vagy más eseményei*/

            void JátékSzabály()
            {
                Animalt("\nA játékban van I/N VAGY Y/N Válaszadás, ahol csak 'I' vagy'Y'(igen) betűvel, vagy 'N'(nem) betűvel választhatsz.");
                OtKesleltetes();
                Animalt("\nA helyválasztós vagy esetleg értékválasztós, ahol kaját vagy tárgyat lehet választani,\n mindig is a tárgy előtti számot ír be, utána üss le egy Entert!");
                Animalt("\n\nPéldául: \t1 - Alma, 2 - Körte. \nEzeknél mindig csak a számot írd be!");
                OtKesleltetes();
                Animalt("\nA büfében pedig az étel vagy az  adott vásárolnivalót adja meg szó szerint, \nPéldául: 'Alma'\tVálaszában az Alma szót beírja és egy Entert leüt.");
                Animalt("\nA játék indításához kérlek nyomj egy Entert!");
                Console.ReadLine();
                Console.Clear();
                NegyEKesleltetes();
            }
            void AlapInformáció()
            {
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
            }
            void Belépés()
            {
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

                EzerKesleltetes();
                while (true)
                {

                    Animalt("Merre szeretnél menni?");
                    Console.WriteLine("1 - Büfé");
                    Console.WriteLine("2 - Terem");
                    Console.Write("Válasz: ");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        Animalt("Zúdulás...");
                        NegyEKesleltetes();
                        Console.Clear();
                        Animalt(Bufe.Leiras());
                        EzerKesleltetes();
                        BufeEsemeny();
                        break;
                    }
                    else if (input == "2")
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
            }
            
            void InditoEvent()
            {
                Console.Clear();
                Animalt(Terem205.Leiras());
                OtKesleltetes();
                Animalt("Megtudtad, hogy a következő órák váratlanul fognak lenni, így izgalmas lesz a mai napod.");
                OtKesleltetes();
                Animalt("Visszamentél az aulába.");
                NegyEKesleltetes();
            }
            void AulaEvent()
            {
                Console.Clear();
                Animalt("Most több opciód is lesz a választásra.");
                OtKesleltetes();
                
                while (true)
                {
                    Animalt("Az alábbi opciók közúl tudsz választani, hogy mit szeretnél csinálni(Válaszként csak a számot írd be!): ");
                    Console.WriteLine("1 - Menni a következő órára.");
                    OtKesleltetes();
                    Console.WriteLine("2 - Pihenni, aulában lenni.");
                    OtKesleltetes();
                    Console.WriteLine("3 - Büfébe menni.");
                    OtKesleltetes();
                    Console.WriteLine("4 - Információk");
                    OtKesleltetes();
                    Console.WriteLine("5 - Kimenni az iskolából.");
                    OtKesleltetes();
                    Console.Write("Válasz: ");
                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        Animalt("Irány a terem...");
                        NegyEKesleltetes();
                        break;
                    }
                    else if (input == "2")
                    {
                        Animalt("Itt maradtál az aulában.");
                        OtKesleltetes();
                        Animalt("Leültél egy padra, miközben beszélgettél a barátaiddal, illetve osztálytársaiddal...");
                        EzerKesleltetes();
                        for (int i = 0; i < 5; i++)
                        {
                            Animalt("Prrr...");
                            Thread.Sleep(100);
                        }
                        Animalt("Meghallottad a csengőt, emiatt gyorsan beszaladsz a terembe...");
                        EzerKesleltetes();
                        break;
                    }
                    else if (input == "3")
                    {
                        Animalt("A büfét választottad, így indulás...");
                        EzerKesleltetes();
                        BufeEsemeny();
                    }
                    else if (input == "4")
                    {
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
                        Animalt("\nHa készenállsz folytatni, akkor nyomj egy Entert!");
                        Console.ReadLine();
                        Animalt("Indulás a terembe...");
                        NegyEKesleltetes();
                        break;
                    }
                    else if (input == "5")
                    {
                        Console.Clear();
                        Animalt("Kiléptél az iskolából, talán egy késsel, de ki tudja, mégis igazolatlan lesz a mai nap...");
                        OtKesleltetes();
                        Animalt("A játék hamarosan leáll...");
                        StopKesleltetes();
                        return;
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
                Console.Clear();
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
                StopKesleltetes();

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
                Animalt("");
                OtKesleltetes();
                Animalt("Kaptál egy váratlan telefonhívást egy ismeretlentől.");
                Animalt("Felvennéd a telefont?");

                while (true)
                {
                    Animalt("I\tN");
                    input = Console.ReadLine();
                    if (input == "I")
                    {
                        Animalt("Felvetted a telefont, és meglepődve hallod, hogy egy híres kutató keresett.");
                        break;
                    }
                    else if (input == "N")
                    {
                        Animalt("Nem vetted fel a telefont, és nem tudod, hogy ki hívott.");
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Animalt("ÉRVÉNYTELEN BEMENET!");
                        Console.ResetColor();
                        EzerKesleltetes();
                        Console.Clear();
                    }
                }
            }

            void NegyedikEvent()
            {
                Console.Clear();
                Animalt(TeremOs.Leiras());
                OtKesleltetes();
                Animalt("Egy különleges varázslatot találtál az egyik könyvtárban.");
                Animalt("Megpróbálod eltanulni a varázslatot?");

                while (true)
                {
                    Animalt("I\tN");
                    input = Console.ReadLine();
                    if (input == "I")
                    {
                        Animalt("Megpróbálod eltanulni a varázslatot, de nehéz feladatnak bizonyul.");
                        break;
                    }
                    else if (input == "N")
                    {
                        Animalt("Nem próbálod meg eltanulni a varázslatot, mert úgy érzed, túl kockázatos lenne.");
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Animalt("ÉRVÉNYTELEN BEMENET!");
                        Console.ResetColor();
                        EzerKesleltetes();
                        Console.Clear();
                    }
                }
            }

            void OtodikEvent()
            {
                Animalt("");
                OtKesleltetes();
                Animalt("A suliban egy rejtélyes üzenetet találsz a táblán.");
                Animalt("Megpróbálod megfejteni az üzenetet?");

                while (true)
                {
                    Animalt("I\tN");
                    input = Console.ReadLine();
                    if (input == "I")
                    {
                        Animalt("Megpróbálod megfejteni az üzenetet, és rájössz, hogy egy titkos üzenet van benne elrejtve.");
                        break;
                    }
                    else if (input == "N")
                    {
                        Animalt("Nem foglalkozol az üzenettel, mert úgy gondolod, hogy csak valami tréfa lehet.");
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Animalt("ÉRVÉNYTELEN BEMENET!");
                        Console.ResetColor();
                        EzerKesleltetes();
                        Console.Clear();
                    }
                }
            }

            void HatodikEvent()
            {
                Animalt("");
                OtKesleltetes();
                Animalt("Egy ismeretlen küldött neked egy titkos levélben egy rejtélyes térképet.");
                Animalt("Elhatározod, hogy felkutatod a térképen jelölt kincset?");
            
                while (true)
                {
                    Animalt("I\tN");
                    input = Console.ReadLine();
                    if (input == "I")
                    {
                        Animalt("Úgy döntesz, hogy felkutatod a térképen jelölt kincset, és egy izgalmas kalandba keveredsz.");
                        break;
                    }
                    else if (input == "N")
                    {
                        Animalt("Nem foglalkozol a térképpel, mert úgy gondolod, hogy csak átverés lehet.");
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Animalt("ÉRVÉNYTELEN BEMENET!");
                        Console.ResetColor();
                        EzerKesleltetes();
                        Console.Clear();
                    }
                }
            }

            void HetedikEvent()
            {
                Animalt("");
                OtKesleltetes();
                Animalt("Egy régi barátod hív, és meghív téged egy izgalmas expedícióra.");
                Animalt("Elfogadod a meghívást?");

                while (true)
                {
                    Animalt("I\tN");
                    input = Console.ReadLine();
                    if (input == "I")
                    {
                        Animalt("Elfogadod a meghívást, és kalandos útra indultok a barátoddal.");
                        break;
                    }
                    else if (input == "N")
                    {
                        Animalt("Nem fogadod el a meghívást, mert úgy érzed, hogy most nem vagy rá készen.");
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Animalt("ÉRVÉNYTELEN BEMENET!");
                        Console.ResetColor();
                        EzerKesleltetes();
                        Console.Clear();
                    }
                }
            }

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace LBAutovaerksted
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Velkommen hos Lasse Bornholm AUTOVÆRKSTED A/S");
            Console.WriteLine("");
            Console.WriteLine("Tast venligst det nummer tilhørende det menupunkt du vil fortsætte ind til");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("[1] Opret/slet eller vis kunder");
            Console.WriteLine("[2] Opret/opdater/slet eller vis biler");
            Console.WriteLine("[3] ???");


            ConsoleKeyInfo menu = Console.ReadKey(true);
            switch (menu.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("KUNDER");
                    Console.WriteLine("");
                    Console.WriteLine("Tast venligst det nummer/bogstav tilhørende det menupunkt du vil fortsætte ind til");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("[O] Opret ny kunde");
                    Console.WriteLine("[S] Slet eksisterende kunde");
                    Console.WriteLine("");
                    ConsoleKeyInfo kunder = Console.ReadKey(true);
                    switch (kunder.Key)
                    {
                        case ConsoleKey.O:
                            Console.WriteLine("opret ny kunde");
                            Console.ReadKey();
                            break;

                        case ConsoleKey.S:

                            break;

                    }
                    Console.ReadKey();
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("BILER");

                    Console.ReadKey();
                    break;

                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine("???");

                    Console.ReadKey();
                    break;
            }
            Console.Clear();

        }
    }
}
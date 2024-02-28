using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Geef een commando: (ToonHond, ToonGekleurdeHond, ToonRennendeHond)");
                string command = Console.ReadLine();


                Console.ResetColor();

                switch (command)
                {
                    case "ToonHond":
                        ToonHond();
                        break;
                    case "ToonGekleurdeHond":
                        ToonGekleurdeHond();
                        break;
                    case "ToonRennendeHond":
                        break;
                    default:
                        Console.WriteLine("?? bark bark");
                        break;
                }
            }
        }

        static void ToonHond()
        {
            Console.WriteLine(@",
                                 ,:'/   _..._
                                // ( `""""-.._.'
                                \| /    6\___
                                |     6      4
                                |            /
                                \_       .--'
                                (_'---'`)
                                / `'---`()
                              ,'        |
              ,            .'`          |
              )\       _.-'             ;
             / |    .'`   _            /
           /` /   .'       '.        , |
          /  /   /           \   ;   | |
          |  \  |            |  .|   | |
           \  `""|           /.-' |   | |
            '-..-\       _.;.._  |   |.;-.
                  \    <`.._  )) |  .;-. ))
                  (__.  `  ))-'  \_    ))'
                      `'--""`    `""""""`
");
        }

        static void ToonGekleurdeHond()
        {
            Random random = new Random();
            int foregroundColorIndex = random.Next(6);
            int backgroundColorIndex = random.Next(4);

            ConsoleColor foregroundColor;
            ConsoleColor backgroundColor;
            Console.ResetColor();

            switch (foregroundColorIndex)
            {
                case 0:
                    foregroundColor = ConsoleColor.Green;

                    break;
                case 1:
                    foregroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    foregroundColor = ConsoleColor.Yellow;
                    break;
                case 3:
                    foregroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    foregroundColor = ConsoleColor.Cyan;
                    break;
                case 5:
                    foregroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    foregroundColor = ConsoleColor.White;
                    break;
            }

            switch (backgroundColorIndex)
            {
                case 0:
                    backgroundColor = ConsoleColor.Red;
                    break;
                case 1:
                    backgroundColor = ConsoleColor.Yellow;
                    break;
                case 2:
                    backgroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    backgroundColor = ConsoleColor.Cyan;
                    break;
                default:
                    backgroundColor = ConsoleColor.Black;
                    break;
            }

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
            ToonHond();
        }

    }

}

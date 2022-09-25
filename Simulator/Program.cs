using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static string elephante = " ░░▄███▄███▄\r\n░░█████████\r\n░░▒▀█████▀░\r\n░░▒░░▀█▀\r\n░░▒░░█░\r\n░░▒░█\r\n░░░█\r\n░░█░░░░███████\r\n░██░░░██▓▓███▓██▒\r\n██░░░█▓▓▓▓▓▓▓█▓████\r\n██░░██▓▓▓(◐)▓█▓█▓█\r\n███▓▓▓█▓▓▓▓▓█▓█▓▓▓▓█\r\n▀██▓▓█░██▓▓▓▓██▓▓▓▓▓█\r\n░▀██▀░░█▓▓▓▓▓▓▓▓▓▓▓▓▓█\r\n░░░░▒░░░█▓▓▓▓▓█▓▓▓▓▓▓█\r\n░░░░▒░░░█▓▓▓▓█▓█▓▓▓▓▓█\r\n░▒░░▒░░░█▓▓▓█▓▓▓█▓▓▓▓█\r\n░▒░░▒░░░█▓▓▓█░░░█▓▓▓█\r\n░▒░░▒░░██▓██░░░██▓▓██\r\n████████████████████████\r\n█▄─▄███─▄▄─█▄─█─▄█▄─▄▄─█\r\n██─██▀█─██─██─█─███─▄█▀█\r\n▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▀▀▄▄▄▄▄▀\r\n";


        static string[] arrOfCommands = {
            "MOV [register] [register | hexadecimalNumber] \n(desc. Swap resgiter or set value of register. hexadecimalNumber range is from 0 to FF)",
            "XCHG [register] [register] \n(desc. Swap register values)",
            "CLEAR \n(desc. clear terminal screan)",
            "EXIT  \n(desc. shutdown program)",
            "SHOW \n(desc. shows all registers` values)"
        };

        static void Main(string[] args)
        {
            //==================
            //ELEPHANTETUSPORTUS
            //==================

            Console.Clear();
            MainColors();
            Console.WriteLine(elephante);


            Terminal terminal = new Terminal();

            Dictionary<string, HexNum> Registers = new Dictionary<string, HexNum>() {
                { "AL", new HexNum("af")},
                { "AH", new HexNum("cf")},
                { "BL", new HexNum()},
                { "BH", new HexNum()},
                { "CL", new HexNum()},
                { "CH", new HexNum()},
                { "DL", new HexNum()},
                { "DH", new HexNum()}
            };

           
            terminal.working = true;

            while (terminal.working)
            {
                //==================
                //Maybe u wan't this
                //==================
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nHleb@Sweet.roll :=>  ");
                MainColors();


                string[] input = Console.ReadLine().ToUpper().Split(' ');
                try
                {

                    switch (input[0])
                    {
                        case "MOV":
                            terminal.MOV(Registers, input[1], input[2]);
                            break;
                        case "XCHG":
                            terminal.XCHG(Registers, input[1], input[2]);
                            break;
                        case "SHOW":
                            terminal.SHOW(Registers);
                            break;
                        case "CLEAR":
                            Console.Clear();
                            break;
                        case "EXIT":
                            Environment.Exit(1);                            
                            break;
                        case "HELP":
                            terminal.SHOW(arrOfCommands);
                            break;
                        default:
                            info();
                            break;
                    }
                }
                catch (Exception e){
                    info();
                }

            }

        }

        public static void DangerStart()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void MainColors()
        {   
            Console.ForegroundColor = ConsoleColor.Magenta;
        }

        public static void info() {
            DangerStart();


            Console.WriteLine("\n\nInvalid command!!!");
            Console.WriteLine("Write <[ HELP ]> if you don't know how to use this program or to check list of commands.\n");

            MainColors();
        }

        

    }
}

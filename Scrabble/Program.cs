using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int point = 0;
            string wordsused = "";//The program will save the words that the player have used so they can always check it again.
            
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------SCRABBLE----------------");
                Console.WriteLine("         1 Point = (E, A, N, R)");
                Console.WriteLine("         2 Point = (D, L, O, S, T)");
                Console.WriteLine("         3 Point = (B, I, K, F, G, M, U, V)");
                Console.WriteLine("         4 Point = (H, J, P, Y, Æ, Ø, Å)");
                Console.WriteLine("         8 Point = (C, X, Z, W, Q)\r\n\r\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Points: " + point);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\r\nWords used" + wordsused);
                Console.ForegroundColor = ConsoleColor.White;
                //At the start of the each round it will show this board with what is what.


                string playertext = Console.ReadLine();
                wordsused = wordsused + " | " + playertext;//Used words will be saved to show the player later.

                string point1 = ("EANReanr");
                for (int i = 0; i < point1.Length; i++)
                {
                    if (playertext.Contains(point1[i]))
                    {
                        point = point + 1;
                        Console.WriteLine(point1[i]+"+1");
                    }
                }

                string point2 = ("DLOSTdlost");
                for (int i = 0; i < point2.Length; i++)
                {
                    if (playertext.Contains(point2[i]))
                    {
                        point = point + 2;
                        Console.WriteLine(point2[i] + "+2");
                    }
                }

                string point3 = ("BIKFGMUBbikfgmuv");
                for (int i = 0; i < point3.Length; i++)
                {
                    if (playertext.Contains(point3[i]))
                    {
                        point = point + 3;
                        Console.WriteLine(point3[i] + "+3");
                    }
                }

                string point4 = ("HJPYÆØÅhjpyæøå");
                for (int i = 0; i < point4.Length; i++)
                {
                    if (playertext.Contains(point4[i]))
                    {
                        point = point + 4;
                        Console.WriteLine(point4[i] + "+4");
                    }
                }

                string point8 = ("CXZWQcxzwq");
                for (int i = 0; i < point8.Length; i++)
                {
                    if (playertext.Contains(point8[i]))
                    {
                        point = point + 8;
                        Console.WriteLine(point8[i] + "+8");
                    }
                }
                //When the round ends it will pause so the player can have an overview of what they typed
                Console.WriteLine("\r\nPress Any Key to Continue");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}

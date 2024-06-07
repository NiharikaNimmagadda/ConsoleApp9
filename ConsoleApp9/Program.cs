using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("                         TOTAL FLOORS : ");
            int TF = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" Now U R in  Floor  : ");
            int PF = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter the Floor u Want :");
            int SF = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (SF > PF)
            {
                for (int i = PF + 1; i < SF; ++i)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Thread.Sleep(5000);
                    Console.WriteLine("Reached  Floor " + i);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Thread.Sleep(2500);
                    Console.WriteLine(" Floor " + i + "  Departed");

                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Thread.Sleep(5000);
                Console.WriteLine("---------------------------------------------YOU ARRIVED YOUR FLOOR-----------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("Do  you want to move to another floor");
                Console.WriteLine("1) Yes");
                Console.WriteLine("2) No");
                int f = Convert.ToInt32(Console.ReadLine());
                if (f == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("                                     Enter the Floor u Want:");
                    int RF = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (RF > SF)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(2500);
                        Console.WriteLine("Departed " + SF + "Floor");
                        for (int a = SF + 1; a < RF; a++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Thread.Sleep(5000);
                            Console.WriteLine("Reached  Floor " + a);
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(2500);
                            Console.WriteLine(" Floor " + a + "  Departed");
                        }
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Thread.Sleep(5000);
                        Console.WriteLine("---------------------------------------------YOU ARRIVED YOUR FLOOR-----------------------------------------------");
                    }
                    else if (RF < SF)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(2500);
                        Console.WriteLine("Departed " + SF + "Floor");
                        for (int b = SF - 1; b > RF; b--)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Thread.Sleep(5000);
                            Console.WriteLine("Reached  Floor " + b);
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(2500);
                            Console.WriteLine(" Floor " + b + "  Departed");

                        }
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Thread.Sleep(5000);
                        Console.WriteLine("---------------------------------------------YOU ARRIVED YOUR FLOOR-----------------------------------------------");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Thread.Sleep(2500);
                    Console.WriteLine("Floor " + SF + " Departed");
                }
            }
            else if (SF == PF)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("---------------------------------------------YOU ARRIVED YOUR FLOOR-----------------------------------------------");
            }
            else
            {
                Thread.Sleep(2500);
                Console.WriteLine("Departed " + SF + " Floor");
                for (int j = PF - 1; j > SF; j--)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Thread.Sleep(5000);
                    Console.WriteLine("Reached  Floor " + j);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Thread.Sleep(2500);
                    Console.WriteLine(" Floor " + j + "  Departed");

                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Thread.Sleep(5000);
                Console.WriteLine("---------------------------------------------YOU ARRIVED YOUR FLOOR-----------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("Do  you want to move to another floor");
                Console.WriteLine("1) Yes");
                Console.WriteLine("2) No");
                int f = Convert.ToInt32(Console.ReadLine());
                if (f == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("                                     Enter the Floor u Want:");
                    int RF = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (RF > SF)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(2500);
                        Console.WriteLine("Departed " + SF + "Floor");
                        for (int a = SF + 1; a < RF; a++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Thread.Sleep(5000);
                            Console.WriteLine("Reached  Floor " + a);
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(2500);
                            Console.WriteLine(" Floor " + a + "  Departed");
                        }
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Thread.Sleep(5000);
                        Console.WriteLine("---------------------------------------------YOU ARRIVED YOUR FLOOR-----------------------------------------------");
                    }
                    else if (RF < SF)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(2500);
                        Console.WriteLine("Departed " + SF + "Floor");
                        for (int b = SF - 1; b > RF; b--)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Thread.Sleep(5000);
                            Console.WriteLine("Reached  Floor " + b);
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(2500);
                            Console.WriteLine(" Floor " + b + "  Departed");

                        }
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Thread.Sleep(5000);
                        Console.WriteLine("---------------------------------------------YOU ARRIVED YOUR FLOOR-----------------------------------------------");
                    }

                }
            }
        }
    }
}

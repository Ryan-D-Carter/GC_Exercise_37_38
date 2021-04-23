using System;
using System.Linq;

namespace GC_Exercise_37_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 37");
            double[] arr = new double[5];

            bool repeat = true;
            while (repeat)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Please enter a whole number!");

                    string input = Console.ReadLine();
                    double value;

                    if (double.TryParse(input, out value))
                    {
                        arr[i] = value;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid number, please only enter a whole number.");
                        i--;
                    }
                }
                Console.WriteLine($"{arr[0]} + {arr[1]} + {arr[2]} + {arr[3]} + {arr[4]} = {arr.Sum()}");

                //continue?
                bool conLoop = true;
                while (conLoop)
                {
                    Console.WriteLine("Continue? y/n");
                    string vCon = Console.ReadLine().ToLower();

                    switch (vCon)
                    {
                        case "y":
                            conLoop = false;
                            repeat = true;
                            break;
                        case "n":
                            Console.WriteLine("Goodbye!");
                            conLoop = false;
                            repeat = false;
                            break;
                        default:
                            Console.WriteLine("I didn't catch that");
                            conLoop = true;
                            break;
                    }
                }
            }




            Console.WriteLine("Exercise 38");
            double[] arr2 = new double[5];

            bool repeat2 = true;
            while (repeat2)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.WriteLine("Please enter a whole number!");

                    string input = Console.ReadLine();
                    double value2;

                    if (double.TryParse(input, out value2))
                    {
                        arr2[c] = value2;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid number, please only enter a whole number.");
                        c--;
                    }
                }

                double average = arr2.Sum() / 5;
                Console.WriteLine($"({arr2[0]} + {arr2[1]} + {arr2[2]} + {arr2[3]} + {arr2[4]}) / 5 = {average}");

                //continue?
                bool conLoop2 = true;
                while (conLoop2)
                {
                    Console.WriteLine("Continue? y/n");
                    string vCon2 = Console.ReadLine().ToLower();

                    switch (vCon2)
                    {
                        case "y":
                            conLoop2 = false;
                            repeat2 = true;
                            break;
                        case "n":
                            Console.WriteLine("Goodbye!");
                            conLoop2 = false;
                            repeat2 = false;
                            break;
                        default:
                            Console.WriteLine("I didn't catch that");
                            conLoop2 = true;
                            break;
                    }
                }
            }
        }
    }
}

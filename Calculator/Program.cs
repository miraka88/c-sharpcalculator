using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            bool exit = false;


            while (exit == false)
            {


                Console.WriteLine("\nEnter equation below, or type quit to exit\nWrite your equation in following formats 2 + 2 or 2+2.\n");
                var input = Console.ReadLine();
                

                if (String.IsNullOrEmpty(input))//Catch Empty Line
                {
                    Console.WriteLine("Please enter valid input");
                }
                else if (input == "quit")
                {
                    exit = true;
                }
                else
                {
                    //REGULAR EXPRESSIONS
                    // (/d+)= capture 1 or more decimal digits
                    //(\.?) = captures optional decimal point
                    // /s+ = match 1 or more whitespace characters
                    // ([-+*/]) = capture arithmetic operator
                    String pattern = @"(\d+\.?\d+)([-+*/])(\d+\.?\d+)";

                    //Remove Whitespace
                    input = input.Replace(" ", "");

                    string[] substrings = Regex.Split(input, pattern);

                    foreach (string s in substrings)
                    {
                        Console.WriteLine(s);
                    }
                    
                    //if(Double.TryParse(substrings[1], out a) || Double.TryParse(substrings[3], out b))
                    


                    a = double.Parse(substrings[1]);
                    b = double.Parse(substrings[3]);



                    switch (substrings[2])
                    {
                        case "+":
                            Console.WriteLine("\n{0}\n", a + b);
                            break;
                        case "-":
                            Console.WriteLine("\n{0}\n", a - b);
                            break;
                        case "*":
                            Console.WriteLine("\n{0}\n", a * b);
                            break;
                        case "/":
                            Console.WriteLine("\n{0}\n", a * b);
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }

            }

        }
    }
}

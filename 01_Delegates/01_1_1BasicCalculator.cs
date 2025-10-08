using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_Delegates;

public class _01_1_1_BasicCalculator
{
    public delegate double MathOperation(double a, double b);



    public static double Calculate(double x, double y, MathOperation operation)
    {
        return operation(x, y);
    }

  
    static double Pow(double x, double y) => Math.Pow(x, y);
    static double Add(double x, double y) => x + y;
    static double Sub(double x, double y) => x - y;
    static double Mul(double x, double y) => x * y;
    static double Div(double x, double y) => x / y;


    public static void Run()
    {

        while (true)
        {
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || input == "exit")
            {
                Console.WriteLine("Goodbye!!!");
                return;
            }

            var line = input.Trim().ToLower();

            var elements = Regex.Split(line, "([-*/+^ ])");
            Console.WriteLine(string.Join(",", elements));

            double? arg1 = null;
            double? arg2 = null;
            MathOperation? op = null;


            foreach (var element in elements)
            {
                if (string.IsNullOrEmpty(element.Trim()))
                    continue;
                if (double.TryParse(element, out var a))
                {
                    if (arg1 == null)
                    {
                        arg1 = a;
                    }
                    else
                    {
                        arg2 = a;
                    }
                }
                else
                {
                    switch (element)
                    {
                        case "+": op = Add; break;
                        case "^": op = Pow; break;
                        case "-": op = Sub; break;
                        case "*": op = Mul; break;
                        case "/": op = Div; break;
                        default:
                            {
                                Console.WriteLine("Invalid operator");
                                return;
                            }
                    }

                } 

                    if (arg1 != null && arg2 != null && op != null)
                {
                    var result = Calculate(arg1.Value, arg2.Value, op);
                    Console.WriteLine($"Result = {result}");
                }     
                
                
                
                
                
                
                 }

        }
    }


}
using Maths;
using System;

namespace AdvMathsConsole
{
    class Program
    {
        private static string _operand;
        private static double _num1;
        private static double _num2;
        private static double _num3;
        private static double _num4;

        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            AreArgumentsValid(args);

            var math = new AdvMath(); 
            switch (_operand)
            {
                case "area":
                    Console.WriteLine($"Area is: {math.CalcArea(_num1, _num2)}");
                    break;
                case "avg":
                    Console.WriteLine($"Average is: {math.CalcAvg(new System.Collections.Generic.List<double> { _num1, _num2})}");
                    break;
                case "numsq":
                    Console.WriteLine($"{_num1} Squared is: {math.CalcNumSq(_num1)}");
                    break;
                case "numsqrt":
                    Console.WriteLine($"Square root of {_num1} is: {math.CalcNumSqrt(_num1)}");
                    break;
                case "pt":
                    Console.WriteLine($"C = {math.CalcPT(_num1, _num2)}");
                    break;
                default:
                    Console.WriteLine($"{_operand} is not a valid operator. Please enter area, avg, numsq, numsqrt, or pt.");
                    break;
            }
            Console.ReadLine();
        }

        public static void AreArgumentsValid(string[] args)
        {
            _operand = args[1].ToLower();
            _num1 = NumParser(args[2]);

            // Some operations only need one param, so accountt for that
            if (_operand == "numsq" || _operand == "numsqrt")
            {
                if (args.Length != 3)
                {
                    Console.WriteLine("Invalid number of arguments for the selected operator.");
                    Environment.Exit(99);
                }
            }
            else
            {
                _num2 = NumParser(args[3]);
            }
            Console.WriteLine("All Arguments are valid!");
        }

        public static double NumParser(string arg)
        {
            double number;
            if (double.TryParse(arg, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine($"Unable to parse {arg}.");
                Environment.Exit(99);
            }
            return 0;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabieeNetLearning
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            try
            {
                Console.WriteLine("Calculator");
                string ask;
                do
                {
                    string typeHandler = null;
                    Console.WriteLine("Enter First Value");
                    double valueFirst = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Second Value");
                    double valueSecond = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What is your type of calculation");
                    Console.Write("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n");
                    string type = Console.ReadLine();
                    if (type == "1")
                    {
                        typeHandler = "add";
                    }else if(type == "2")
                    {
                        typeHandler = "sub";
                    }else if(type == "3")
                    {
                        typeHandler = "multi";
                    }else if (type == "4")
                    {
                        typeHandler = "Div";
                    }
                    else
                    {
                        Console.WriteLine("No function existed!");
                        break;
                    }
                    double output = program.calculation(valueFirst,valueSecond, typeHandler);
                    Console.WriteLine("Calution of {0} {1} {2} = {3}",valueFirst,typeHandler,valueSecond,output);
                    Console.WriteLine("More Calculation(n/y)?");
                    ask = Console.ReadLine();
                } while (ask.ToLower() == "y");
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        double calculation(double x, double y,string type)
        {
            double z = 0;
            try
            {
                switch(type.ToUpper())
                {
                    case "ADD":
                        z = x + y;
                        break;
                    case "SUB":
                        z = x - y;
                        break;
                    case "MULTI":
                        z = x * y;
                        break;
                    case "DIV":
                        z = x / y;
                        break;
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return z;
        }

    }
}

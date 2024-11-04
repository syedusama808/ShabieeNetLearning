using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabieeNetLearning
{
    public class Program
    {
        private string[] arr;
        Program() {
            arr = new string[5];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To My Array");
            Program program = new Program();
            program.ArrayBaseFN("Usama", 3);
            program.ArrayBaseFN("Shabiee", 2);
            program.ArrayBaseFN("Ahsam", 4);
            program.ArrayBaseFN(4);
            program.Print();
            Console.ReadKey();
        }
        public string ArrayBaseFN(string value,int index)
        {
            //Push
            arr[index] = value;
            return "Data Pushed";
        }
        public string ArrayBaseFN(int index)
        {
            //Pop
            arr[index] = null;
            return "Data Pushed";
        }
        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Data is : " + arr[i]);
            }
        }

    }
}

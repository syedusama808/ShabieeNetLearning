using ShabieeNetLearning.Controller;
using ShabieeNetLearning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabieeNetLearning
{
    internal class Program
    {
        private static Student student;
        private static StudentController studentController;

        static void Main(string[] args)
        {
            Console.WriteLine("--Student Marksheet--");
            student = new Student();
            studentController = new StudentController();
            studentController.SetStudentName(student);
            string loopcheck;
            do
            {
                studentController.setSubjectScores(student);
                Console.WriteLine("Do you want to add more subjects.(N/Y)");
                loopcheck = Console.ReadLine();
            } while (loopcheck.ToUpper().Contains("Y"));
            Console.WriteLine("--Student Marksheet--");
            Console.WriteLine("My student name is : {0}", student.StudentName);
            studentController.GetMarksheet(student);
            studentController.getStudentMetaData(student);
            Console.WriteLine("Total Percentage is {0}%",student.Percentage);
            Console.ReadKey();
        }
        
    }
}

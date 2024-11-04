using ShabieeNetLearning.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabieeNetLearning.Controller
{
    public class StudentController
    {
        public void SetStudentName(Student model)
        {
            Console.WriteLine("Please enter student name");
            model.StudentName = Console.ReadLine();
        }
        public string GetStudentName(Student model)
        {
            return model.StudentName;
        }
        public void setSubjectScores(Student model)
        {
            Console.WriteLine("Please Enter Course Name.");
            string course = Console.ReadLine();
            Console.WriteLine("Please Enter Total Marks.");
            string total = Console.ReadLine();
            Console.WriteLine("Please Enter Obtained Marks.");
            string obtain = Console.ReadLine();
            Subject subjects = new Subject();
            subjects.CoruseName = course;
            subjects.Total = Convert.ToInt32(total);
            subjects.Obtain = Convert.ToInt32(obtain);
            model.Marksheet.Add(subjects);
        }
        public void GetMarksheet(Student model)
        {
            Console.Write("#\tSubject\tTotal Score\tTotal Obtained\tPercentage(%)\n");
            int counter = 1;
            for (int i = 0; i < model.Marksheet.Count; i++)
            {
                float calPercentage = model.Marksheet[i].Obtain / model.Marksheet[i].Total;

                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t\t{4}%", counter, model.Marksheet[i].CoruseName, model.Marksheet[i].Total, model.Marksheet[i].Obtain,calPercentage);
                counter++;
            }
        }
        public float getStudentMetaData(Student model)
        {
            int totatSubjectCount = model.Marksheet.Count;
            int totalScore = 0;
            int totalObtained = 0;
            for (int i = 0; i < model.Marksheet.Count; i++)
            {
            }
            model.AvScore = totalObtained / totatSubjectCount;
            float hPer = totalObtained / totalScore;
            return  hPer* 100;
        }
    }
}

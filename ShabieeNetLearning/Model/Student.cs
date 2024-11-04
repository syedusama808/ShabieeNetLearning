using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabieeNetLearning.Model
{
    public class Student
    {
        public string StudentName { get; set; }
        public string StudentClass { get; set; }
        public List<Subject> Marksheet { get; set; } = new List<Subject>();
        public float Percentage { get; set; } = 0;
        public string Grade { get; set; } = null;
        public float AvScore { get; set; } = 0;
    }
    public class Subject
    {
        public string CoruseName { get; set; }
        public int Total { get; set; }
        public int Obtain { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_practice
{
     class Student
    {
        public string Fullname;
        public string GroupNo;
        public List<Exam> Exams = new List<Exam>();


        public double GetAvgPoint()
        {
            double sum = 0;
            foreach (var item in Exams)
            {
                sum += item.Point;
            }
            return sum / Exams.Count;
        }


    }
}

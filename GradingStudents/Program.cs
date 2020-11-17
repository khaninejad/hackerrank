using System;
using System.Collections.Generic;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> grades = new List<int> {4, 73, 67, 38, 33};

            List<int> result = gradingStudents(grades);
            Console.WriteLine(String.Join("\n", result));
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                var item = grades[i];
                if (item >= 38)
                {
                    var diff = 5 - (item % 5);
                    if (diff < 3)
                        grades[i] = item + diff;
                }
            }

            return grades;
        }
  
    }
}

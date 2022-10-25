using System;
using System.Collections.Generic;

namespace GradeBook
{
   
    class Program
    {
        static void Main(string[] args)
        {
            // var book = new Book();
            // book.AddGrade(89.1);

           var grades = new List<double>() {3.2, 3.3, 3.1, 1.1};
        //    int [] myArray = new int[5]; 
        //    int[] myValue = {2,15,36};
           grades.Add(56.1);
        //    grades.Remove(56.1);
          
           

            var results = 0.0;
            foreach(double number in grades)
            {
               results += number;
            }
            results /= grades.Count;
            System.Console.WriteLine($"The average grade is {results:N1}");
           

            Console.WriteLine(results);
           
           
        }
 
    }




}


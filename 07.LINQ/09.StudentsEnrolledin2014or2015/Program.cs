using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public Student()
    {
        this.Marks = new List<int>();
    }
    public string FacultyNumber { get; set; }

    public List<int> Marks { get; set; }


}

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();//input
        List<Student> output = new List<Student>();//makes list for the output

        while (Convert.ToString(input[0]) != "END")
        {
            output.Add(
               new Student
               {
                   FacultyNumber = input[0],
                   Marks = new List<int>
                   {
                    Convert.ToInt32(input[1]),
                    Convert.ToInt32(input[2]),
                    Convert.ToInt32(input[3]),
                    Convert.ToInt32(input[4]),
                   }

               }
            );
            input = Console.ReadLine().Split().ToArray();
        }

        Console.WriteLine();
        var studentsYears =
            output.Where(
                s =>
                    s.FacultyNumber.Substring(4, 2) == "15" ||
                    s.FacultyNumber.Substring(4, 2) == "14").ToList();

        foreach (var student in studentsYears)
        {
            foreach (var mark in student.Marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public Student()
    {
        this.Marks = new List<int>();
    }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public List<int> Marks { get; set; }
}

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();//input
        List<string> output = new List<string>();//makes list for the output
        var someStudent = new List<Student>();//makes list of students from input
        while (input[0] != "END")
        {

            someStudent.Add(
               //Advame nov student v Lista some student
               new Student
               {
                   FirstName = input[0],
                   LastName = input[1],
                   Marks = new List<int>
                   {
                       Convert.ToInt32(input[2]),
                        Convert.ToInt32(input[3]),
                         Convert.ToInt32(input[4]),
                          Convert.ToInt32(input[5])
                   }

               }
            );

            input = Console.ReadLine().Split().ToArray();
        }
        int countMarks = 0;
        foreach (var student in someStudent)
        {
            foreach (var mark in student.Marks)
            {
                if (mark<=3)
                {
                    countMarks++;
                }
            }
            if (countMarks>=2)
            {
                Console.WriteLine(student.FirstName+" "+student.LastName);
            }
            countMarks = 0;
        }


    }

}

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();//input
        List<Student> output = new List<Student>();//makes list for the output

        while (input[0] != "END")
        {
            if (Convert.ToInt32(input[2]) == 2)
            {
                var student = new Student
                {
                    FirstName = input[0],
                    LastName = input[1],
                    Group = 2
                };
                output.Add(student);
            }


            input = Console.ReadLine().Split().ToArray();
        }
        foreach (var student in output.OrderBy(s => s.FirstName))
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
    }
}
public class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Group { get; set; }
}


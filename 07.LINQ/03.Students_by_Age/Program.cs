using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();//input
        List<string> output = new List<string>();//makes list for the output
        while (input[0] != "END")
        {

            var someStudent = new List<Student>() //new list sus vseki student
            {
                new Student
                {
                    FirstName = input[0],
                    LastName = input[1],
                    Age = Convert.ToInt32(input[2])
                }
             };

            var studentsFirstAndLastName = from st in someStudent
                                           where st.Age >= 18 && st.Age <= 24
                                           select st;
            //st.FirstName.CompareTo(st.LastName) < 0
            // select st;
            foreach (var st in studentsFirstAndLastName)
            {
                output.Add(st.FirstName + " " + st.LastName + " " + st.Age);

            }
            input = Console.ReadLine().Split().ToArray();
        }

        Console.WriteLine();
        foreach (var item in output)
        {
            Console.WriteLine(item);
        }

    }

}


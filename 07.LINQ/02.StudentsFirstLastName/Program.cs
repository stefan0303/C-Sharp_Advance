using System;
using System.Collections.Generic;
using System.Linq;

public class Student 
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
}

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();//input
        List<string> output = new List<string>();//makes list for the output
        while (input[0] != "END")
        {

            var someStudent = new List<Student>() //new list for every student
            {//Advame nov student v clasa Student
                new Student
                {
                    FirstName = input[0],
                    LastName = input[1],
                }
             };

            var studentsFirstAndLastName = from st in someStudent    
                                           where st.FirstName.CompareTo(st.LastName) < 0
                                           select st;
            foreach (var st in studentsFirstAndLastName)
            {
                output.Add(st.FirstName + " " + st.LastName);
             
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


using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Mark { get; set; }
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

                   Mark = input[2] + input[3] + input[4] + input[5]
               }
            );
            input = Console.ReadLine().Split().ToArray();
        }
       
        var studentsFirstAndLastName = from st in someStudent where st.Mark.Contains("6") select st;
        foreach (var st in studentsFirstAndLastName)
        {
            output.Add(st.FirstName + " " + st.LastName);
            
        }
     
        Console.WriteLine();
        foreach (var item in output)
        {
            Console.WriteLine(item);
        }

    }

}

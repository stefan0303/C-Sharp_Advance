using System;
using System.Collections.Generic;
using System.Linq;

public class Student 
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Phone { get; set; }
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
           
               new Student
               {
                   FirstName = input[0],
                   LastName = input[1],
                   Phone = input[2]
               }
            );
            input = Console.ReadLine().Split().ToArray();
        }
      
        var studentsFirstAndLastName = from st in someStudent where st.Phone.StartsWith("+3592")||st.Phone.StartsWith("02") select st;
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

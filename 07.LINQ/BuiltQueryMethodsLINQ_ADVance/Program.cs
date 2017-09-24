using System;
using System.Collections.Generic;
using System.Linq;

public class Student //!! zaduljitelno public da go izpolzvame
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Id { get; set; }


}

class Program
{
    static void Main()
    {
        string[] input= Console.ReadLine().Split().ToArray();//input
        List<string> output = new List<string>();//makes list for the output
        while (input[0] != "END")
        {

            var someStudent = new Student//Advame nov student v clasa Student
            {
                FirstName = input[0],
                LastName = input[1],
                Id = input[2],
            };
            if (someStudent.Id=="2")
            {        
                //Add to output list students with 2
                output.Add(someStudent.FirstName + " " + someStudent.LastName);
            }
            
            input = Console.ReadLine().Split().ToArray();
        }
        var sortedFirstName = output.OrderBy(x => x).ToList();//Sortirame lista sus Linq
        foreach (var item in sortedFirstName)
        {
            Console.WriteLine(item);
        }
       
    }
    
}


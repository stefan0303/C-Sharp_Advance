using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();//input
        List<string> output = new List<string>();//makes list for the output
        while (input[0] != "END")
        {

            var someStudent = new List<Student>() //new list sus vseki student
            {//Advame nov student v clasa Student
                new Student
                {
                    FirstName = input[0],
                    LastName = input[1],
                }
             };
            //ot st(moje da e vsichko) v someStudent kadeto st e Purvo ime sravni sus st Vtoro ime da e predi nego >!!! ako e < ste oburne imenata
            var studentsFirstAndLastName = from st in someStudent
                                           where st.FirstName.CompareTo(st.LastName) < 0
                                           select st;
            foreach (var st in studentsFirstAndLastName)
            {
                output.Add(st.FirstName + " " + st.LastName);
                // Console.WriteLine(st.FirstName+" "+st.LastName);
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

public class Student
   {
       public string FirstName { get; set; }
 
       public string LastName { get; set; }
 
       public string Id { get; set; }
 
      
   }
 

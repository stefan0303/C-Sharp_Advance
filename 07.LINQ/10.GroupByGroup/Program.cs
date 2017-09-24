using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();//input
        List<Person> output = new List<Person>();//makes list for the output

        while (Convert.ToString(input[0]) != "END")
        {
            output.Add(

                new Person
                {
                    FirstName = input[0],
                    Lastname = input[1],
                    Group = Convert.ToInt32(input[2])
                });

            input = Console.ReadLine().Split().ToArray();
        }
        var printByGroup = output.GroupBy(p => p.Group).OrderBy(g => g.Key).ToList();
        int count = 0;
        string print = "";

        foreach (var person in printByGroup)
        {
            var sb = new StringBuilder();
            Console.Write(person.Key + " - ");
            foreach (var p in person)
            {
                sb.Append(p.FirstName + " " + p.Lastname + ", ");
                print += p.FirstName + " " + p.Lastname + ", ";

            }
            sb.Length -= 2;
            Console.Write(sb);
            // Console.Write(print.Substring(0,print.Length-2));
            Console.WriteLine();
            print = "";
        }
    }
}

class Person
{
    public string FirstName { get; set; }
    public string Lastname { get; set; }
    public int Group { get; set; }
}


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        SortedDictionary<string, Dictionary<string, int>> namesIPs = new SortedDictionary<string, Dictionary<string, int>>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end") { break; }
            int m = input.IndexOf('m') - 1; //find index Ip ends
            int b = input.LastIndexOf('=');//find last index of '='

            string ipAdress = input.Substring(3, m - 3);//Substring the IP
            string userName = input.Substring(b + 1, input.Length - b - 1);//Substring the user name
            int countSameIpAdresses = 1;

            if (!namesIPs.ContainsKey(userName))//if there is no key user name Add it
            {

                namesIPs.Add(userName, new Dictionary<string, int>());
                namesIPs[userName].Add(ipAdress, countSameIpAdresses);
            }

            else if (!namesIPs[userName].ContainsKey(ipAdress))//if there is Key with not the same Key(ipAdress)
            {
                namesIPs[userName].Add(ipAdress, 1);

            }
            else if (namesIPs[userName].ContainsKey(ipAdress))//if there is Key with same Key(ipAdress)
            {
                int lastKeyValue = namesIPs[userName][ipAdress];
                namesIPs[userName][ipAdress] = lastKeyValue + 1;
            }
        }
        foreach (var item in namesIPs)//Print
        {
            Console.WriteLine(item.Key + ": ");
            Console.WriteLine("{0}.", string.Join(", ", item.Value.Select(kv => kv.Key + " => " + kv.Value)));

        }
    }
}


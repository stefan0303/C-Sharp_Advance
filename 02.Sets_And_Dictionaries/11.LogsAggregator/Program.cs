using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        SortedDictionary<string, SortedDictionary<string, int>> userIpDuration = new SortedDictionary<string, SortedDictionary<string, int>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string userName = input[1];
            string ipAdress = input[0];
            int duration = Convert.ToInt32(input[2]);
            int sumOfdurations;

            if (!userIpDuration.ContainsKey(userName))
            {
                userIpDuration.Add(userName, new SortedDictionary<string, int>());
                userIpDuration[userName].Add(ipAdress, duration);
            }
            else
            {
                if (userIpDuration[userName].ContainsKey(ipAdress))
                {
                    sumOfdurations = userIpDuration[userName][ipAdress];//last duration
                    sumOfdurations = sumOfdurations + duration;         //sum two durations
                    userIpDuration[userName][ipAdress] = sumOfdurations;//add the new sum duration
                   
                }
                else
                {
                    userIpDuration[userName].Add(ipAdress, duration);
                }
            }
        }
        int sumOfvalues = 0;
        string ipsForPrint = "";

        foreach (var user in userIpDuration)//for every user In dictionary
        {

            foreach (var ip in user.Value)//for every ip value
            {
                sumOfvalues = sumOfvalues + ip.Value; //sum all values of ips

                ipsForPrint = ipsForPrint + ip.Key + ", ";
            }
            ipsForPrint = ipsForPrint.Remove(ipsForPrint.Length - 2);//remove last char

            Console.WriteLine(user.Key + ": " + sumOfvalues + " [" + ipsForPrint + "]");
            ipsForPrint = "";
            sumOfvalues = 0;
        }
    }
}


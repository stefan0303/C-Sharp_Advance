using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        int startIndex;
        int endIndex;
        while (command[0] != "end")
        {
            switch (command[0])
            {
                case "reverse":
                    startIndex = Convert.ToInt32(command[2]);
                    endIndex = Convert.ToInt32(command[4]);
                    if (startIndex + endIndex >= nums.Count || startIndex < 0 || endIndex < 0)//is out of range
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }
                    List<string> getFromList = nums.GetRange(startIndex, endIndex).ToList();
                    getFromList.Reverse();
                    int count = 0;

                    for (int i = startIndex; i < endIndex + startIndex; i++)
                    {
                        nums[i] = getFromList[count];
                        count++;
                    }
                    break;
                case "sort":
                    startIndex = Convert.ToInt32(command[2]);
                    endIndex = Convert.ToInt32(command[4]);
                    if (startIndex + endIndex - 1 >= nums.Count || startIndex < 0 || endIndex < 0 || startIndex >= nums.Count)//is out of range
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }
                    count = 0;//?
                    List<string> sortfromList = nums.GetRange(startIndex, endIndex).ToList();
                    sortfromList.Sort(); //sort the new list
                    for (int i = startIndex; i < endIndex + startIndex; i++)
                    {
                        nums[i] = sortfromList[count];
                        count++;
                    }
                    break;
                case "rollLeft":
                    startIndex = Convert.ToInt32(command[1]);
                    if (startIndex < 0)//out of range
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }
                    int countListLeft = nums.Count;
                    int realRollLeft = startIndex % countListLeft;

                    for (int i = 0; i < realRollLeft; i++)
                    {

                        nums.Add(nums[0]);
                        nums.RemoveAt(0);
                    }

                    break;
                case "rollRight":
                    startIndex = Convert.ToInt32(command[1]);
                    if (startIndex < 0)//out of range
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }
                    int countList = nums.Count;
                    int realRoll = startIndex % countList;

                    for (int i = 0; i < realRoll; i++)
                    {
                        nums.Insert(0, nums[countList - 1]);
                        nums.RemoveAt(countList);
                    }
                    break;
            }
            command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        }

        Console.Write("[");

        for (int i = 0; i < nums.Count; i++)
        {
            if (i < nums.Count - 1)
            {
                Console.Write(nums[i] + ", ");
            }
            else
            {
                Console.Write(nums[i]);
            }
        }
        Console.Write("]");
        Console.WriteLine();
    }
}


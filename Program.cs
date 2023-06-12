using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

public class Fibonacci
{
    public static List<int> list; 

    static void Main(string[] args)
    {
       //calling the method that validates the input and proceeds further if the input is valid.
        FibCounter();

        //printing the list of the fibonacci sequence to the console and the last element as well as a goodbye message.
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("The number you are looking for is: " + list[list.Count-1]);
        Console.WriteLine("Press any key to close this window! Have a good one! =)");
        //added this line so if anyone has the option for console window closure unchecked can still see the results.
        Console.ReadLine();
    }

    public static int FibCounter()
    {
        Console.WriteLine("Please give me a number..");
        string input = Console.ReadLine();
        int fibNum = 0;

        if (int.TryParse(input, out fibNum))
        {
            //with a valid input we call the real method that makes the calculations for us with the input.
            FibMethod(fibNum);
        }
        else
        {
            //if the input is invalid (not a number) recursively call the method until a proper input is given.
            FibCounter();
        }
        return fibNum;
    }
    public static List<int> FibMethod(int fibNum)
    {
        //basic fibonacci code, declaring an integer list, checking if the desired number is 0 or less as the original fibonacci sequence is designed for positive integers.
        list = new List<int>();
        if (fibNum <= 0)
        {
            list.Add(0);
            return list;
        }
        //if the desired number is 1 or above the list is populated with the sum of the 2 previous elements of the list, creating a proper sequence.
        if (fibNum >= 1)
        {
            list.Add(1);
            list.Add(1);
        }
        for (int i = 2; i < fibNum; i++)
        {
            list.Add(list[i - 1] + list[i - 2]);
        }
        return list;
    }

}



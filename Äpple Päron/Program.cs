using System;

class Program
{
    static void Main(string[]args)
    {
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');

        int a = int.Parse(inputs[0]);
        int p = int.Parse(inputs[1]);



        if (a*7 < p*13) 
        {
            Console.WriteLine("petra");
        }

        else if (p*13 < a*7)
        {
            Console.WriteLine("axel");
        }

        else
        {
            Console.WriteLine("lika");
        }
    }
}
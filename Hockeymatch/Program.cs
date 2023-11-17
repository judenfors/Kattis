using System;

class Program
{
    static void Main(string[]args)
    {
        string input1 = Console.ReadLine();
        string[] inputs = input1.Split(' ');

        int saves1 = int.Parse(inputs[0]);
        int goals1 = int.Parse(inputs[1]);
        int skott1 = int.Parse(inputs[2]);

        string input2 = Console.ReadLine();
        string[] splitInput = input2.Split(' ');

        int saves2 = int.Parse(splitInput[0]);
        int goals2 = int.Parse(splitInput[1]);
        int skott2 = int.Parse(splitInput[2]);

        saves1 = skott2 - goals2;
        saves2 = skott1 - goals1;

        goals1 = skott1 - saves2;
        goals2 = skott2 - saves1;

        skott1 = saves2 + goals1;
        skott2 = saves1 + goals2;

        Console.WriteLine($"{saves1}:{goals1}:{skott1}");
        Console.WriteLine($"{saves2}:{goals2}:{skott2}");
    }
}
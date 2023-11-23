using System;

class Program
{
    static void Main(string[]args)
    {
        string input1 = Console.ReadLine();
        string[] inputs = input1.Split(' ');

        int saves1 = int.Parse(inputs[0]); // 1
        int goals1 = int.Parse(inputs[1]); // -1
        int skott1 = int.Parse(inputs[2]); // 3

        string input2 = Console.ReadLine();
        string[] splitInput = input2.Split(' ');

        int saves2 = int.Parse(splitInput[0]); // 2
        int goals2 = int.Parse(splitInput[1]); // 4
        int skott2 = int.Parse(splitInput[2]); // -1

        int newSaves1, newSkott1, newGoals1;
        int newSaves2, newSkott2, newGoals2;
        

        if (saves1 == -1)
        {
            newSaves1 = skott2 - goals2;
            newGoals1 = goals1;
            newSkott1 = skott1;
        }
        else if (goals1 == -1)
        {
            newSaves1 = saves1;
            newGoals1 = skott1 - saves2;
            newSkott1 = skott1;
        }
        else if (skott1 == -1)
        {
            newSaves1 = saves1;
            newGoals1 = goals1;
            newSkott1 = saves2 + goals1;
        }
        else
        {
            newSaves1 = saves1;
            newGoals1 = goals1;
            newSkott1 = skott1;
        }

        if (saves2 == -1)
        {
            newSaves2 = skott1 - goals1;
            newGoals2 = goals2;
            newSkott2 = skott2;
        }
        else if (goals2 == -1)
        {
            newSaves2 = saves2;
            newGoals2 = skott2 - saves1;
            newSkott2 = skott2;
        }
        else if (skott2 == -1)
        {
            newSaves2 = saves2;
            newGoals2 = goals2;
            newSkott2 = saves1 + goals2;
        }
        else
        {
            newSaves2 = saves2;
            newGoals2 = goals2;
            newSkott2 = skott2;
        }
        
        Console.WriteLine($"{newSaves1} {newGoals1} {newSkott1}");
        Console.WriteLine($"{newSaves2} {newGoals2} {newSkott2}");
    }
}
using System;

class Program
{
    static void Main()
    {
        // Getting user input
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter your gender (Male/Female): ");
        string gender = Console.ReadLine();

        Console.Write("Please enter your height in centimeters: ");
        int height = Convert.ToInt32(Console.ReadLine());

        // Determining height status
        string heightStatus;
        if (height > 165)
        {
            heightStatus = "tall";
        }
        else
        {
            heightStatus = "short";
        }

        // Outputting the result
        string title = gender.ToLower() == "male" ? "Mr." : "Ms.";
        Console.WriteLine($"{title} {name}, your height is {height} cm, so you are considered {heightStatus}.");
    }
}
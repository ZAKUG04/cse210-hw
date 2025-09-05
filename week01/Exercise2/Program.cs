using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string grade_value = Console.ReadLine();
        int percent = int.Parse(grade_value);

        string letter = "";
        string sign = "";


        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else if (percent < 60)
        {
            letter = "F";
        }

        int digit = percent % 10;
        if (digit >= 7) 
        {
            sign = "+";
        }
        else if (digit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter == "A")
        {
            if (sign == "+")
            {
                sign = "";
            }
        }
        if (percent == 100)
        {
            sign = "";
        }
        if (letter == "F")
            {
                sign = "";
            }
        Console.WriteLine($"you grade is {letter}{sign}");
        if (percent >= 70)
        {
            Console.WriteLine("Guess what?; You pass!");
        }
        else
        {
            Console.WriteLine("It's all good, bro. You'll do better next time.");
        }
    }
}
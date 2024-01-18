using System;
using static System.Console;


//Write a C# console program named HOT1-1 that asks your name and prints the following message: 

//Hello, yourName! (where yourName is your full name).



namespace HOT_01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Please Enter Your Name:");
            string name = ReadLine();
                    
            if (name != "")
            {
                Write($"Hello, {name}!");
                ReadLine();
            }
        }
    }
}

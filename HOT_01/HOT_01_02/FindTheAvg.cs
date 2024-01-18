using System;
using System.Xml.Linq;
using static System.Console;

//Write a C# console program named HOT1-2
//that asks for any three decimal numbers
//and prints the average value of those numbers.
//Credit for the correct result will not be given if the
//average isn’t correct for any 3 given numbers.

namespace HOT_01_02
{
    internal class FindTheAvg
    {
        //Declare and initilize global variables
        static decimal avg = 0;
        static decimal num1 = 0;
        static decimal num2 = 0;
        static decimal num3 = 0;
        static void Main(string[] args)
        {
        
            Write("Please Enter Your First Number:\t\t");
            num1 = decimal.Parse(ReadLine());

            Write("Please Enter Your Second Number:\t");
            num2 = decimal.Parse(ReadLine());

            Write("Please Enter Your Third Number:\t\t");
            num3 = decimal.Parse(ReadLine());

            findTheAvg();
        }

        static private void findTheAvg()
        {
            avg = ((num1 + num2 + num3) / 3);

            Write($"The Average of Your Numbers is: {avg}");
            ReadLine();
        }
    }
}

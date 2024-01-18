using System;
using System.Diagnostics;
using System.Security.Cryptography;
using static System.Console;

namespace HOT_01_03
{

    //Write a C# console program named HOT1-3 that prompts the user for a name, street address, city, state, zip code,
    //and quantity of t-shirts ordered at $14.99 each.  In an attractive format (similar to the one below),
    //display all the input data as well as the following:

    //Total Price: defined as number ordered times price each. Use a constant.
    //Sales tax: defined as 8% of the total price.Use a constant.
    //Amount due: defined as amount due before tax, plus tax

    internal class ShirtOrdering
    {

        //Declare and initilize program constants
        const decimal shirtPrice = 14.99m;
        const decimal salesTax = 0.08m;
        static decimal taxTotal = 0m;
        static decimal amountDue = 0m;
        static decimal firstTotal = 0m;
        static decimal shirtAmt = 0m;
        static string name1 = ""; 
        static string address = "";
        static string city = "";
        static string state = "";
        static string zip = "";
        
        static void Main(string[] args)
        {
            Write("\t\tFull Name:\t\t");
            name1 = ReadLine();

            Write("\t\tStreet Address:\t\t");
            address = ReadLine();

            Write("\t\tCity\t\t\t");
            city = ReadLine();

            Write("\t\tState\t\t\t");
            state = ReadLine();

            Write("\t\tZip Code:\t\t");
            zip = ReadLine();

            Write("\n\t\tHow many shirts would you like to order?  ");
            shirtAmt = decimal.Parse(ReadLine());

            
            calculateTotal();
        }

        static void calculateTotal()
        {
            firstTotal = (shirtAmt * shirtPrice);
            taxTotal = (firstTotal * salesTax);
            amountDue = (firstTotal + taxTotal);

            printInfo();
        }

        static void printInfo()
        {
            Write("\n\n\t\tReciept For:\n");
            Write($"\t\t{name1}\n");
            Write($"\t\t{address}\n");
            Write($"\t\t{city}, {state} {zip}\n");

            Write($"\n\t\t{shirtAmt} Shirts Ordered @ $14.99 each\n\n");

            Write($"\t\tTotal:\t ${firstTotal:0.##}\n");
            Write($"\t\tTax:\t ${taxTotal:0.##}\n");
            Write("\t\t-------------------------\n");
            Write($"\t\tDue:\t ${amountDue:0.##}");
            ReadLine();
        }
    }
}

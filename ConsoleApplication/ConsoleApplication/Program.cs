using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program 
    {
        static void Main(string[] args)
        {
            //.2
            string name = "Upen Rijal";
            string location = "Rexburg, ID";

            //.3

            Console.WriteLine($"My name is { name}");
            Console.WriteLine($"I am from {location}");

            //.4
            var currentDate = DateTime.Now;
            Console.WriteLine($"Today is {currentDate.ToString("d")}");

            //.5
            var christmasDay = new DateTime(currentDate.Year, 12, 25);
            var daysUntillChristmas = currentDate - christmasDay;
            Console.WriteLine("Days until Christmass " + daysUntillChristmas.ToString("dd"));

            //.6

            double width, height, woodLength, glassArea;   string widthString, heightString;
            Console.WriteLine("Please enter the width ");
            widthString = Console.ReadLine();   width = double.Parse(widthString);
            Console.WriteLine("Please enter the width ");
            heightString = Console.ReadLine();   height = double.Parse(heightString); 
            woodLength = 2 * ( width + height ) * 3.25 ; 
            glassArea = 2 * ( width * height ) ; 
            Console.WriteLine ( "The length of the wood is " +     woodLength + " feet" ) ;   Console.WriteLine( "The area of the glass is " +     glassArea + " square metres" ) ;  





            //.7
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();

        }
    }
}

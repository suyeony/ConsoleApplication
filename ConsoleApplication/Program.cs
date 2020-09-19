using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.
            string name;
            Console.Write("Please enter your full name: ");
            name = Console.ReadLine();

            string location;
            Console.Write("Please enter your location: ");
            location = Console.ReadLine();

             // 3.
            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"You are from {location}");

            // 4.
            var currentDate = DateTime.Now;
            Console.WriteLine("The current date is " + currentDate.ToShortDateString());

            // 5.
            DateTime christmas = new DateTime(2020, 12, 25);
            Console.WriteLine((christmas - DateTime.Now).Days + " days");


            // 6.
            double width, height, woodLength, glassArea; 
            string widthString, heightString;

            Console.Write("Please enter width: (in meters) ");
            widthString = Console.ReadLine(); 
            width = double.Parse(widthString);

            Console.Write("Please enter height: (in meters) ");
            heightString = Console.ReadLine(); 
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet"); 
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");


            // 7.

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

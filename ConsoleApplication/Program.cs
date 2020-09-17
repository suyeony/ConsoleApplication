using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = "Suyeon Yang";
            String location = "Rexburg, Idaho";
            Console.WriteLine("My name is " + name + ". I am from " + location);

            Console.WriteLine(DateTime.Now.ToString("d"));

            DateTime christmas = new DateTime(2020, 12, 25);
            Console.WriteLine((christmas - DateTime.Now).Days + " days");
        }
    }
}

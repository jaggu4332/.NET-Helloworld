using System;
namespace CurrentDateandTime
{
    class Program
    {
        static void Main(string[] args)
        {
           DateTime aDate = DateTime.Now;
           Console.WriteLine(aDate.ToString("dddd, MMMM ")); 
           Console.ReadKey();
        }
    }
}
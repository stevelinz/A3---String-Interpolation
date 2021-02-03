using System;

/*A3 - String Interpolation
Display the following using string interpolation:

From today’s date

1.January 22, 2019
2.2019.01.22
3.Day 22 of January, 2019
4.Year: 2019, Month: 01, Day: 22
5.            Tuesday (10 spaces)
6.     11:01 PM             Tuesday (10 spaces between)
7.h:11, m:01, s:27
8.2019.01.22.11.01.27

 If you have PI (3.1415)
1. Output as currency
2. Output as right-aligned (10 spaces), number with 3 decimal places
*/


namespace C__Class
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("\nFrom today's date\n");
            DateTime today = DateTime.Now;
            Console.WriteLine($"1. {today:MMMM} {today:dd}, {today:yyyy}");
            Console.WriteLine($"2. {today:yyyy}.{today:MM}.{today:dd}");
            Console.WriteLine($"3. Day {today:dd} of {today:MMMM}, {today:yyyy}");
            Console.WriteLine($"4. Year:{today:yyyy},Month:{today:MM},Day:{today:dd}");

            Console.WriteLine(String.Format("{0,-10}  {1,-10}", "5.", $"{today:dddd}"));

            Console.WriteLine(String.Format("{0,-10}  {1,-10}  {2,10}", "6.", $"{today:hh}:{today:mm} {today:tt}", $"{today:dddd}"));

            Console.WriteLine($"7. h:{today:hh},m:{today:mm},s:{today:ss}");
            Console.WriteLine($"8. {today:yyyy}.{today:MM}.{today:dd}.{today:hh}.{today:mm}.{today:ss}");

            System.Console.WriteLine("\nIf you have PI\n");
            double pi = Math.PI;
            var piCurrency = String.Format("{0:C}", pi);
            Console.WriteLine("1. " + piCurrency);

            var piTrunc = String.Format("{0:0.###}", pi);
        
            Console.WriteLine(String.Format("{0,-10}  {1,-10}", "2.", piTrunc+ "\n"));

        }
    }
}

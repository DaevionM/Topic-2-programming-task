namespace Topic_2_programming_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("21 * 8 = " + (21 * 8));
            Console.WriteLine("money earned is " + (21 * 8).ToString("C"));
            Console.WriteLine("Task 2");
            Console.WriteLine("6 / 12 = " + (6.0 / 12));
            Console.WriteLine("1 egg cost " + (6.0 / 12).ToString("C"));
            Console.WriteLine("Task 3");
            Console.WriteLine("79.99 * 1.13 = " + (79.99 * 1.13));
            Console.WriteLine("The price after tax on 79.99 is " + (79.99 * 1.13).ToString("C"));
            Console.WriteLine("Challenge");
            Console.WriteLine("(5 * 12 + 6) * 2.54 = " + ((5 * 12 + 6) * 2.54));
            Console.WriteLine("There are " + (5*12+6) * 2.54 + "centimeters in 5'6\""); 
        }
    }
}

namespace assignment_3._1._2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            
            if (year % 4 == 0)
            {
                
                if (year % 100 == 0)
                {
                    
                    if (year % 400 == 0)
                    {
                        Console.WriteLine(year + " is a leap year.");
                    }
                    else
                    {
                        Console.WriteLine(year + " is not a leap year.");
                    }
                }
                else
                {
                    
                    Console.WriteLine(year + " is a leap year.");
                }
            }
            else
            {
                
                Console.WriteLine(year + " is not a leap year.");
            }
        }
    }
}
    

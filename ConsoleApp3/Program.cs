using System;
class HelloWorld
{
    static void Main()
    {

        while (true)
        {
            try
            {
                Console.Write("Enter Your Grade in ISM 4300: "); 
                int num = int.Parse(Console.ReadLine());

                if (num >= 1 && num < 60)
                {
                    Console.WriteLine("\nYour letter grade is F");
                }

                else if (num >= 60 && num < 70)
                {
                    Console.WriteLine("\nYour letter grade is D");
                }

                else if (num >= 70 && num < 80)
                {
                    Console.WriteLine("\nYour letter grade is C");
                }

                else if (num >= 80 && num < 90)
                {
                    Console.WriteLine("\nYour letter grade is B");
                }

                else if (num >= 90 && num <= 100)
                {
                    Console.WriteLine("\nYour letter grade is A");
                }

                else
                {
                    Console.WriteLine("\nYour Marks are not valid");
                }

            }

            catch (FormatException ex)
            {
                Console.WriteLine("Not a valid Number. Please try again.");
            }

            Console.WriteLine("");
        }


    }
}
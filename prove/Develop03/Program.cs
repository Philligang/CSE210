using System;

namespace DailyScripture
{
    class Program
    {
        
        static void Main()
        {
            Scripture scripture = new Scripture("D&C ", 10, 5, "Pray always, that you may come off conqueror; yea, that you may conquer Satan, and that you may escape the hands of the servants of Satan that do uphold his work.");
            Console.Clear();
            scripture.Display(); 
            Console.WriteLine("\nPress enter to keep hiding words, or type 'quit' close the program.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("\nCongratulations, you've finished the scripture.");
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress enter to keep hiding words, or type 'quit' close the program.");
            }
        }
    }
}
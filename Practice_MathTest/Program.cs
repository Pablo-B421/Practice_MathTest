using System;

namespace Practice_MathTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine("How many questions would you like to answer?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < userInput; i++)
            {
                Random numGen = new Random(); //creating an instance of the Random Class
                int x = numGen.Next(1, 11);
                int y = numGen.Next(1, 11);

                Console.Write($"{i + 1})What is {x} multiplbied by {y}?:  ");
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == x * y)
                {
                    int responseIndex = numGen.Next(1, 4);

                    switch (responseIndex)
                    {
                        case 1:
                            Console.WriteLine($"Wow {userName}. you are so smart!");
                            Console.WriteLine();
                            break;

                        case 2:
                            Console.WriteLine($"Geeze {userName}, you must be a scientist, you are correct!");
                            Console.WriteLine();
                            break;

                        case 3:
                            Console.WriteLine($"Incredible job {userName}, that is correct!");
                            Console.WriteLine();
                            break;
                    }

                }
                else
                {
                    int responseIndexTwo = numGen.Next(1, 4);

                    switch (responseIndexTwo)
                    {
                        case 1:
                            Console.WriteLine("You are wrong!");
                            Console.WriteLine();
                            break;

                        case 2:
                            Console.WriteLine("Are you even trying?");
                            Console.WriteLine();
                            break;

                        case 3:
                            Console.WriteLine("Come on! You are better than this");
                            Console.WriteLine();
                            break;
                    }

                }
            }

            Console.WriteLine("The Exam is Now Over");
        }
    }
}

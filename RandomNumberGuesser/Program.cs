using System;

namespace RandomNumberGuesser 
{
    class Program 
    {
        static void Main(string[] args)
        {
         bool rightAnswer = true;
         bool rightplayAgain = false;
         
            while (rightplayAgain == false)
            {
                bool wrongplayAgain = true;
                Random rnd = new Random();
                int systemNumber = rnd.Next(1, 101);
                rightAnswer = true;
                Console.WriteLine("This is a random number guessing game. The result will be different each time");
                while (rightAnswer == true)
                {
                    
                    while (wrongplayAgain == true)
                    {
                        Console.WriteLine("Please enter in a number.");
                        int userGuess = int.Parse(Console.ReadLine());
                        if (userGuess < systemNumber || userGuess > systemNumber)
                        {
                            Console.WriteLine("Your guess is incorrect");
                            rightAnswer = true;
                            wrongplayAgain = true;
                            Console.WriteLine("Please guess again!");

                        }
                        else
                        {
                            Console.WriteLine("Good job! You got it right! Yippee!");
                            rightAnswer =false;
                            //wrongplayAgain = true;
                        }
                        Console.WriteLine("Would you like to play again? Please enter in Y for yes or N for no");
                        string userAnswer = Console.ReadLine().ToUpper();
                        if (userAnswer == "Y")
                        {
                            rightplayAgain = false;
                            wrongplayAgain=false;
                            rightAnswer = false;
                        }
                        if (userAnswer == "N")
                        {
                            rightplayAgain = true;
                            wrongplayAgain = false;
                            rightAnswer= false;
                            
                        }
                    }

                }
            }

        }

    }
   




}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace
namespace NumberGuesser
{
    //class
    class Program
    {
        // Entry point method
        static void Main(string[] args)
        {
            // get app information
            GetAppInfo();

            GreetUser();

            while (true)
            {
                // initialize a guess number var
                // int correctNumber = 7;

                // create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 20);

                // init guess
                int guess = 0;

                // ask user for number
                Console.WriteLine("Guess a number between 1 and 20");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.DarkMagenta, "Please enter an actual number");

                        //keep going 
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // print message to play again
                        PrintColorMessage(ConsoleColor.DarkYellow, "Wrong number, please try again");

                    }
                }

                // print success message
                PrintColorMessage(ConsoleColor.Green, "Correct!!! You guessed it!!!");

                // ask to play again
                Console.WriteLine("Play again ? [Y/N]");

                // get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            // set app name
            string appName = "Number Guesser";
            string appVersion = "1.5.5";
            string appAuthor = "Gemini";

            // change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("{0} : Version {1} by : {2}", appName, appVersion, appAuthor);

            // reset text color
            Console.ResetColor();
        }

        // print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // change text color
            Console.ForegroundColor = color;

            // write message to play again
            Console.WriteLine(message);

            // reset text color
            Console.ResetColor();
        }

        // greet user
        static void GreetUser()
        {
            // ask users name 
            Console.WriteLine("What is your name?");

            // get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", inputName);
        }
    }
}

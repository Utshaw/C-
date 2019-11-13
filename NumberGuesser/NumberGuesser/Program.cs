using System;

namespace NumberGuesser
{
    class Program
    {
        // entry point
        static void Main(string[] args)
        {
             
            GetAppInfo(); // Run GetAppInfo function to get info


            GreetUser(); // greet user
            

           

            while (true)
            {

                // Create a new random object
                Random random = new Random();
                // Generate random number between 1 & 10
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // make sure it's a number

                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");

                        // keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                        
                    }


                }

                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct");
                
                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine();
                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
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
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Farhan Utshaw";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write app info
            Console.WriteLine("{0}: Version {1} By {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask user's name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name? ");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}

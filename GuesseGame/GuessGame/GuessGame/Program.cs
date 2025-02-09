using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {

            appInfo();//Getting app info


            while (true) {

                getUserInfo();//Greeting the user

                //Creating random number object
                Random random = new Random();

                //Number that user has to guess
                int correctNumber = random.Next(1, 10);

                //Initial guess number
                int guess = 0;

                //Asking user for number
                Console.WriteLine("Enter a guess number between 1 to 10.");

                //While guess is not correct
                while (correctNumber != guess)
                {

                    //Get user input
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {

                        //Wrong input type
                        colorMessage(ConsoleColor.Red, "Your input is not a number. Please enter a number");

                        continue;

                    }

                    //Converting into int and putting in guess
                    guess = Int32.Parse(input);

                    //Match the guess with correct number
                    if (guess != correctNumber)
                    {

                        //Wrong number
                        colorMessage(ConsoleColor.Red, "Wrong number. please try again.");

                    }

                }

                //Correct number
                colorMessage(ConsoleColor.Magenta, "You have won!!!");

                //Asking user if that person wants to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get user's answer
                string answer = Console.ReadLine().ToUpper();

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

        //App information function
        static void appInfo()
        {
            //App details
            string appName = " Guess That Number!!";
            string appVersion = "1.0.0";
            string creator = "Tanvir";

            Console.ForegroundColor = ConsoleColor.Blue;

            //Printing app details
            Console.WriteLine("Name:{0} Version:{1} Creator:{2}", appName, appVersion, creator);

            Console.ResetColor();
        }

        //User information function
        static void getUserInfo()
        {

            //Asking for name
            Console.WriteLine("Enter your name.");

            //Putting the name into a variable
            string name = Console.ReadLine();

            //Writing that user's name
            Console.WriteLine("Welcome {0}. let's play a game", name);

        }

        //Console color function
        static void colorMessage(ConsoleColor color, string message)
        {


            Console.ForegroundColor = color;

            //Correct guess message
            Console.WriteLine(message);

            Console.ResetColor();

        }

    }

}


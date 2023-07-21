Console.WriteLine("Welcome to Guessing Game!");

var secretNumber = new Random().Next(1,100);
int numOfGuess = 0;
int guessLimit = 3;

Console.WriteLine(@"Please choose a difficulty Level: 
                    1. Easy
                    2. Medium
                    3. Hard
                    4. Cheater");

int difficulty = Convert.ToInt32(Console.ReadLine());

if (difficulty == 1)
{
    guessLimit = 7;
}
else if (difficulty == 2)
{
    guessLimit = 5;
}
else if (difficulty == 3)
{
    guessLimit = 3;
}
else if (difficulty == 4)
{
    guessLimit = 101;
}

Welcome();
void Welcome()
{
    if (difficulty != 4)
    {
        Console.WriteLine($"You have {guessLimit + 1 - numOfGuess} guesses remaining, Please guess a Number");
    }
    else
    {
        Console.WriteLine("You're a cheater, you have unlimited guesses remaining, Please guess a Number");
    }

    var userGuess = Convert.ToInt32(Console.ReadLine());

    // Console.WriteLine($"You guessed: {userGuess}");


    if (difficulty != 4)
    {
        while (numOfGuess != guessLimit)
        {
            if (userGuess > secretNumber)
            {
                numOfGuess++;
                // Console.WriteLine($"You have {guessLimit - numOfGuess} guesses remaining");
                Console.WriteLine("Sorry, your guess was too high, please guess again");
                userGuess = Convert.ToInt32(Console.ReadLine());

            }
            if (userGuess < secretNumber)
            {
                numOfGuess++;
                // Console.WriteLine($"You have {guessLimit - numOfGuess} guesses remaining");
                Console.WriteLine("Sorry, your guess was too low, please guess again");
                userGuess = Convert.ToInt32(Console.ReadLine());

            }
            if (userGuess == secretNumber)
            {
                Console.WriteLine($"Your guess of {userGuess} was correct and matches the secret number of {secretNumber}!");
                break;
            }
            if (numOfGuess == guessLimit)
            {
                Console.WriteLine($"You are out of guesses! The secret number was {secretNumber}!");
            }
            // Console.Clear();
            Console.WriteLine($"You have {guessLimit - numOfGuess} guesses remaining");
        }
    }
    else
    {
        while (numOfGuess != guessLimit)
        {
            if (userGuess > secretNumber)
            {
                numOfGuess++;
                Console.WriteLine("Sorry, your guess was too high, please guess again");
                userGuess = Convert.ToInt32(Console.ReadLine());

            }
            if (userGuess < secretNumber)
            {
                numOfGuess++;
                Console.WriteLine("Sorry, your guess was too low, please guess again");
                userGuess = Convert.ToInt32(Console.ReadLine());

            }
            if (userGuess == secretNumber)
            {
                Console.WriteLine($"Your guess of {userGuess} was correct and matches the secret number of {secretNumber}!");
                break;
            }

            Console.WriteLine($"You chose Cheater difficulty, you can keep guessing and guessing!");
        }
    }

}


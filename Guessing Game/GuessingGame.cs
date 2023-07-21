Console.WriteLine("Welcome to Guessing Game!");

var secretNumber = new Random().Next(1,100);
int numOfGuess = 0;
int guessLimit = 3;

Welcome();
void Welcome()
{
    Console.WriteLine($"You have {guessLimit +1 - numOfGuess} guesses remaining, Please guess a Number");

    var userGuess = Convert.ToInt32(Console.ReadLine());

    // Console.WriteLine($"You guessed: {userGuess}");



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
        if (numOfGuess  == guessLimit)
        {
            Console.WriteLine($"You are out of guesses! The secret number was {secretNumber}!");
        }
        // Console.Clear();
        Console.WriteLine($"You have {guessLimit - numOfGuess} guesses remaining");
    }

}


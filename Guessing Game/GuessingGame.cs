Console.WriteLine("Welcome to Guessing Game!");

var secretNumber = 42;

Welcome();
void Welcome()
{
    Console.WriteLine("Please guess a Number");

    var userGuess = Convert.ToInt32(Console.ReadLine());

    // Console.WriteLine($"You guessed: {userGuess}");

    if (userGuess != secretNumber)
    {
        Console.WriteLine("Sorry, that is not the secret number");
    }
    else
    {
        Console.WriteLine($"Your guess of {userGuess} was correct and matches the secret number of {secretNumber}!");
    }
}

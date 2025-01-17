Random rnd = new Random();
int randomNumber = rnd.Next(1, 100); // returns random integers >= 1 and &lt; 101
Console.WriteLine("Lets play a game!");
Console.WriteLine("I will think about a random number and you will have to guess it!");
Console.WriteLine("If you guess it right, you win!");
Console.WriteLine("If you don't, I will give you a hint!");
Console.WriteLine("The number is between 1 and 100");
int guess = 0;
while (guess != randomNumber)
{
    Console.Write("Enter your guess: ");
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess < randomNumber)
    {
        Console.WriteLine("The number is higher!");
    }
    else if (guess > randomNumber)
    {
        Console.WriteLine("The number is lower!");
    }
}
Console.WriteLine("Congratulations! You guessed it right. You win!");

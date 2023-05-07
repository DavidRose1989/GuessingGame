class Program
{

    static void Mian(string[] args)
    {

        string secretWord = "Basketball";
        string guess = "";
        int guessCount = 0;
        int guessLimit = 5;
        bool outOfGuesses = false;


        while (guess != secretWord && !outOfGuesses)
        {
            if (guessCount < guessLimit)
            {
                Console.Write("Enter Guess: ");
                guess = Console.ReadLine();
                guessCount++;
            }
            else
            {
                outOfGuesses = true;
            }
            
            
        }
        if (outOfGuesses)
        {
            Console.Write("You Lose!");
        }
        else
        {
            Console.Write("You Win!");
        }
        


    }

}

    
namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 12;

            Console.WriteLine($"Guess my favorite number!");

            string input = Console.ReadLine();

            int userGuess = int.Parse(input);



                if (userGuess == favNumber)
                {
                    Console.WriteLine($"You Guessed It!");
                }

                else if (userGuess > favNumber)
                {
                    Console.WriteLine($"Too High!");
                }

                else
                {
                    Console.WriteLine($"Too Low!");
                }
           
          

        }
    }
}

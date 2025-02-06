//Emilynn Molesky
// 2/5/2025

namespace TheProtype
{
    public class Program
    {
        static void Main(string[] args)
        {
            int pilotNumber;
            do
            {
                Console.Write("Enter a number between 0 and 100:");
                pilotNumber = Convert.ToInt32(Console.ReadLine());
            }
            while (pilotNumber < 0 || pilotNumber > 100);
            Console.Clear();

            while(true)
            {
                Console.WriteLine("Guess a number between 0 and 100:");
                int hunterGuess = Convert.ToInt32(Console.ReadLine());

                if (hunterGuess > pilotNumber) Console.WriteLine($"{hunterGuess}is too high.");
                else if (hunterGuess < pilotNumber) Console.WriteLine($"{hunterGuess} is too low");
                else break;
            }
            Console.WriteLine("Youve guessed the number!!");
        }
    }
}
//Emilynn Molesky
//2/5/2025

namespace Replicator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = new int[5];

            Console.WriteLine("Enter 5 Numbers:");
            for (int i = 0; i < originalArray.Length; i++)
            {
                Console.WriteLine($"Number {i + 1}:");
                originalArray[i] = int.Parse(Console.ReadLine());
            }

            int[] copyArray = new int[5];

            for (int i = 0; i < originalArray.Length; i++)
            {
                copyArray[i] = originalArray[i];
            }

            Console.WriteLine("Original Array:" + string.Join(", ", originalArray));
            Console.WriteLine("Copy Array:" + string.Join(", ", copyArray));

        }
    }
}

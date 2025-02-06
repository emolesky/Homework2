//Emilynn Molesky 
//1/5/2025


using System.ComponentModel.Design;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
           

           

            Console.WriteLine("The follwing items are available:");
            Console.WriteLine("1- Rope");
            Console.WriteLine("2- Torches");
            Console.WriteLine("3- Climbing Equipment");
            Console.WriteLine("4- Clean Water");
            Console.WriteLine("5- Machete");
            Console.WriteLine("6- Canoe");
            Console.WriteLine("7- Food Supplies");
            Console.WriteLine("What number do you want to see the cost of?");
            

            int itemNumber = Convert.ToInt32(Console.ReadLine());

            string item = itemNumber switch
            {
                1 => "Rope",
                2 => "Torches",
                3 => "Climbing Eqiupment",
                4 => "Clean Water",
                5 => "Machete",
                6 => "Canoe",
                7 => "Food Supplies"
            };

            int price = item switch
            {
                "Rope" => 10,
                "Torches" => 15,
                "Climbing Equipment" => 25,
                "Clean Water" => 1,
                "Machete" => 20,
                "Canoe" => 2,
                "Food Supplies" => 1

            };

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            if (name == "Chloe") price /= 2;
            Console.WriteLine($"{item} costs {price} gold.");
            
            
     


        }
    }
}

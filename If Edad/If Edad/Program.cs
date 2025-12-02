using System; 

namespace Program
{
    class Edad
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age");

            int edad = int.Parse(Console.ReadLine());

            if (edad < 12)
            {
                Console.WriteLine("You are a kid");
            }
            else if (edad < 17)
            {
                Console.WriteLine("You are a teenager");
            }

            else { Console.WriteLine("You are an adult"); }

            
        }
    }
}
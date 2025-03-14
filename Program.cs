using System.Diagnostics.CodeAnalysis;

namespace mothods_brown_jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter whole number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter anouther whole number");
            int y = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine(Multiply(x,y));

            Console.WriteLine("What u name is?");
            string name = Console.ReadLine();

            WelcomeUser(name);
            goodbye();
        }
        static int Multiply(int num1, int num2)
        { 
        return num1 * num2; 
        }
        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username}!");
        }
        static void goodbye()
        {
            Console.WriteLine("have a good one");
        }

    }  
}

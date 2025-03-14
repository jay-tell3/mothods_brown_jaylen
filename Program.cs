using System.Diagnostics.CodeAnalysis;

namespace mothods_brown_jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {   // asks user for number
            Console.WriteLine("enter whole number");
            //sets number to x int
            int x = Convert.ToInt32(Console.ReadLine());
            // asks for another number
            Console.WriteLine("enter anouther whole number");
            // sets number to y int
            int y = Convert.ToInt32(Console.ReadLine());
           // calls the multiply method with the x y int set as num1 and 2 and then writes it to console
            Console.WriteLine(Multiply(x,y));
            //ask for a name
            Console.WriteLine("What u name is?");
            //sets answer to sting named name
            string name = Console.ReadLine();
            // calls welcomeuser with the name varablie
            WelcomeUser(name);
            // calls goodbye to say good bye
            goodbye();
        }
        // makes the multply method and has to changeable varables whitch are multpyed
        static int Multiply(int num1, int num2)
        { 
        return num1 * num2; 
        }
        // makes a method called welcome user that says hello when called
        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username}! nice to see you");
        }
        // makes a method called goodbye that says bye when called
        static void goodbye()
        {
            Console.WriteLine("have a good one");
        }

    }  
}

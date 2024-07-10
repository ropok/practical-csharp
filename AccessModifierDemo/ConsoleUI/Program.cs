using DemoLibrary;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccessDemo demo = new AccessDemo();

            BadClass badClass = new BadClass();

            badClass.Age = 150;
            badClass._age = 150;

            demo.PublicDemo();

        }

        private static void SayHello()
        {
            Console.WriteLine("Hello user");
        }
    }
}

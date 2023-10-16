namespace Module9
{
    internal class Program
    {
        //task 9.4.2

        public delegate Car Handler();

        public static Car CarHandler()
        {
            return null;
        }

        public static Lexus LexusHandler()
        {
            return null;
        }

        static void Main(string[] args)
        {
            Handler carHandler = CarHandler;

            Handler lexusHandler = LexusHandler;


            Console.Read();
        }
    }

    class Car { }

    class Lexus : Car { }
}
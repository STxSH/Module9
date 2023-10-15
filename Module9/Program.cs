namespace Module9
{
    internal class Program
    {
        //task 9.3.15

        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate = () => new Random().Next(0, 100);
            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
namespace Module9
{
    internal class Program
    {
        //task 9.3.2
        static void Main(string[] args)
        {
            DiffDelegate diffDelegate = Diff;

            Console.WriteLine(diffDelegate.Invoke(5, 3));

        }

        public delegate int DiffDelegate(int a, int b);
        static int Diff(int a, int b)
        {
            return a - b;
        }
    }
}
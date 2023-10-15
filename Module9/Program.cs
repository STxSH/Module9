namespace Module9
{
    internal class Program
    {
        //task 9.3.4

        public delegate void MultiDelegate(int a, int b);
        static void Main(string[] args)
        {
            MultiDelegate mDelegate = Diff;
            mDelegate += Summ;

            mDelegate(5, 3);

        }

        static void Diff(int a, int b)
        {
            Console.WriteLine(a - b); 
        }

        static void Summ(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
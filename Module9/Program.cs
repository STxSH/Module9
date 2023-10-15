namespace Module9
{
    internal class Program
    {
        //task 9.3.12

        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = delegate (string _message)
            {
                Console.WriteLine(_message);
            };

            showMessageDelegate.Invoke("Hello World!");
            Console.Read();
        }
    }
}
namespace Module9
{
    internal class Program
    {
        //task 9.3.14

        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = (string _message) => Console.WriteLine(_message);
            

            showMessageDelegate.Invoke("Hello World!");
            Console.Read();
        }
    }
}
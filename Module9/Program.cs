namespace Module9
{
    internal class Program
    {
        //task 9.2.2
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Блок try");

                throw new ArgumentOutOfRangeException();
            }

            catch (Exception ex) when (ex is ArgumentOutOfRangeException)
            {
                Console.WriteLine("Аргумент не соответствует допустимому диапазону значений");
            }

            finally 
            {
                Console.WriteLine("Блок finally");
            }
        }
    }
}
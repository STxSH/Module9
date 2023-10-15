namespace Module9
{
    internal class Program
    {
        //task 9.2.3
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Блок try");

                throw new RankException("Исключение типа RankException");
            }

            catch (Exception ex) when (ex is RankException)
            {
                Console.WriteLine(ex.GetType().ToString());
            }

            finally 
            {
                Console.WriteLine("Блок finally");
            }
        }
    }
}
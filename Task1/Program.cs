using System.Reflection.Metadata;

namespace Task1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Exception[] exceptions = new Exception[]
            {
                new CustomException("Error"),
                new DivideByZeroException("Divide by zero exception"),
                new IndexOutOfRangeException("Index Out Of Range Exception"),
                new InvalidOperationException("Invalid Operation Exception"),
                new DirectoryNotFoundException("Directory Not Found Exception")
            };

            foreach (var ex in exceptions)
            {
                try
                {
                    Console.WriteLine("Блок try");
                    throw ex;
                }
                catch (CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }
                catch (DivideByZeroException de)
                {
                    Console.WriteLine( de.Message);
                }
                catch (IndexOutOfRangeException ie)
                {
                    Console.WriteLine(ie.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
                catch (DirectoryNotFoundException dne)
                {
                    Console.WriteLine(dne.Message);
                }
                finally
                {
                    Console.WriteLine("Блок finally");
                }
            }

        }
    }
}
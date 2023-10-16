namespace Module9
{
    internal class Program
    {
        //task 9.4.3

        public delegate void info(Child ch);


        static void Main(string[] args)
        {
            info chInfo = GetParentInfo;

            chInfo.Invoke(new Child());


            Console.Read();
        }

        public static void GetParentInfo(Parent p)
        {
            Console.WriteLine(p);
        }
    }       

    class Parent { }

    class Child : Parent { }
}
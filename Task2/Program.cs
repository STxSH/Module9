using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Task2
{
    internal class Program
    {             
        static void Main(string[] args)
        {
            PersonList listPerson = new PersonList();
            listPerson.Notify += (message) => Console.WriteLine(message);

            listPerson.AddPerson (new Person("Иванов"));
            listPerson.AddPerson(new Person("Смирнов"));
            listPerson.AddPerson(new Person("Кузнецов"));
            listPerson.AddPerson(new Person("Попов"));
            listPerson.AddPerson(new Person("Васильев"));

            Console.WriteLine("\nЛист до сортировки:");
            listPerson.PrintPersons();
            UserInput.InputMethod(listPerson);

            listPerson.PrintPersons();

            Console.ReadKey();
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static Task2.PersonList;

namespace Task2
{
    class PersonList
    {
        public delegate void PersonListHandler(string s);
        public event PersonListHandler? Notify;

        private List<Person> persons = new List<Person>();

        public void AddPerson(Person person)
        {
            persons.Add(person);
            Notify?.Invoke($"Добавлен person: {person.Name}");
        }

        public void RemovePerson(Person person)
        {
            persons.Remove(person);
            Notify?.Invoke($"Удален person: {person.Name}");
        }

        public void PrintPersons()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine($"Name: {person.Name}");
            }
        }

        public void SortPersons()
        {
            persons.Sort((personOne, personTwo) => personOne.Name.CompareTo(personTwo.Name));
            Notify?.Invoke($"Выполнена сортировка в порядке А-Я");
        }

        public void ReverseSortPersons()
        {
            persons.Sort((personOne, personTwo) => personOne.Name.CompareTo(personTwo.Name));
            persons.Reverse();
            Notify?.Invoke($"Выполнена сортировка в порядке Я-А");
        }


    }
}

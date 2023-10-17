using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task2
{
    class UserInput
    {
        public static void InputMethod (PersonList list)
        {
            Console.WriteLine("Введите число 1 (сортировка А-Я), число 2 (сортировка Я-А):");
            int UserInput = 0;

            do
            {
                try
                {
                    UserInput = int.Parse(Console.ReadLine());

                    if (UserInput != 1 && UserInput != 2)
                    {
                        throw new CustomException("Требуется ввести число 1, либо число 2");
                    }
                }
                catch(CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                finally
                {
                    switch (UserInput)
                    {
                        case 1:
                            list.SortPersons();
                            break;
                        case 2:
                            list.ReverseSortPersons();
                            break;
                    }
                }
            }
            while (UserInput != 1 && UserInput != 2);
        }
    }
}

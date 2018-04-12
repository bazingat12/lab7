using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Book = new Book(1, "Пушкин", "Руслан и Людмила", "Поэма");
            Exemplar exemplar = new Exemplar(1, Book, DateTime.Now, "Exmo");
            Position position = new Position(1, "Библиотекарь");
            Reader reader = new Reader(1, "Семенов", "Игорь", "Евгеньевич", "муж.", 79835, "Киров", "Лепсе", "43");
            Employee employee = new Employee(1, position, "Петрова", "Людмила", "Сергеевна", 345678892, 4, "Киров", "Попова", "6");
            Delivery delivery = new Delivery(1, DateTime.Now, employee, reader, exemplar);
            DateTime start = new DateTime(2018, 05, 6);
            DateTime end = new DateTime(2019, 12, 31);
            List<DateDelivery> ListDelivery = new List<DateDelivery>();
            ListDelivery.Add(new DateDelivery(1, DateTime.Now, employee, reader, exemplar, start, end));
            foreach (DateDelivery date in ListDelivery)
            {
                date.Info();
                if (date is IbooksReader)
                {
                    (date as IbooksReader).Count("3");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

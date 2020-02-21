using Classwork;
using System;

namespace test
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] ListOfAutors = new string[] { "Автор 1", "Автор 2" };
            Students student = new Students("Илья", "Сварщик", 4);

            Employee employee = new Employee("Илья", "Строитель", 10);
            Console.WriteLine(employee.ToString());

            Banknote banknote = new Banknote("1831 193738373", 5000, "Пять тысяч");
            Console.WriteLine(banknote.ToString());

            Book book = new Book("Учебник по алгебре", ListOfAutors, 700);
            Console.WriteLine(book.ToString());

            Workshop workshop = new Workshop(" ВКДП 32", 7);
            Console.WriteLine(workshop.ToString());

            Offset offset = new Offset("ВЕ Добрынин", "ИИ Ильин", DateTime.Now , -2);
            Console.WriteLine(offset.ToString());

            Address address = new Address(404102, "Москва", "Кукушкина", 5, 12);
            Console.WriteLine(address.ToString());

            Product product = new Product("Молоко", 20, 40.50, DateTime.Now);
            Console.WriteLine(product.ToString());

            StudyGroup studyGroup = new StudyGroup("ИСП", 30, 2018, "Программирование");
            Console.WriteLine(studyGroup.ToString());

            ComputerGame computerGame = new ComputerGame("Dota 3", "Pudge Company", 2047, "Казуальные");
            Console.WriteLine(computerGame.ToString());

            Students students = new Students("Илья", "Сварщик", 7);
            Console.WriteLine(students.ToString());

        }
    }

}

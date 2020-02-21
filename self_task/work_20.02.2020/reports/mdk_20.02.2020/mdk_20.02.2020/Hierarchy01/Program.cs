using System;
using System.Collections.Generic;

namespace mdk_20._02._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(2, "РАТ - 12", 11, "Артем");
            Student student2 = new Student(5, "ИКС - 6", 12, "Степан");


            List<string> dicipline = new List<string> {"Математика", "Русский язык"};
            Teacher teacher1 = new Teacher(dicipline,"Алексей",40);

            List<string> dicipline2 = new List<string> { "Лит-ра", "Физ-ра" };
            Teacher teacher2 = new Teacher(dicipline2,"Артем", 80);

            Person[] people = new Person[4] { student1, student2, teacher1, teacher2 };
            foreach (var item in people)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    class Book
    {
        public string Title { get; set; }
        public string[] ListOfAutors { get; set; }
        public int Price { get; set; }

        public Book(string title, string[] listOfAutors, int price) 
        {
            Title = title;
            ListOfAutors = listOfAutors;
            Price = price;
        }
        public override string ToString()
        {
            string resultString = $"Книга: \n" +
                                  $"Название: {Title}, Авторы: ";
            foreach (var item in ListOfAutors)
            {
                resultString += item + " ";
            }

            resultString += $"Цена: {Price} \n"; 
            return resultString;
        }
    }
}

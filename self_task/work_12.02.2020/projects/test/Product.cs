using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Product(string name, int quantity, double price, DateTime expirationDate) 
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            ExpirationDate = expirationDate;
        }

        public override string ToString()
        {
            string resultString = $"Продукт: \n" +
                                  $"Название: {Name}, Кол-во: {Quantity}, Цена: {Price}, Cрок годности: {ExpirationDate} \n";
            return resultString;
        }

    }
}

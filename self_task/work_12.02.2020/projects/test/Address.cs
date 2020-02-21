using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    class Address
    {
        public int Postcode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }

        public Address(int postcode, string city, string street, int house, int apartment) 
        {
            Postcode = postcode;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }

        public override string ToString()
        {
            string resultString =   $"Адрес: \n" +
                                    $"Почтовый индекс: {Postcode}, Город: {City}, Улица: {Street}, Дом: {House}, Квартира: {Apartment} \n";
            return resultString;
        }
    }
}

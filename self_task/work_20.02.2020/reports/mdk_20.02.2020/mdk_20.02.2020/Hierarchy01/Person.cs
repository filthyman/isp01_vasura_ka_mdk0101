using System;
using System.Collections.Generic;
using System.Text;

namespace mdk_20._02._2020
{
    class Person
    {
        private int age;
        private string name;

        public Person(int age, string name) 
        {
            this.age = age;
            this.name = name;
        }

        public void SetName(string name) 
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public override string ToString()
        {
            string resString = $" имя - {name} и возраст - {age}";
            return resString;
        }

        public void Print() 
        {
            Console.WriteLine(ToString());
        }
    }
}

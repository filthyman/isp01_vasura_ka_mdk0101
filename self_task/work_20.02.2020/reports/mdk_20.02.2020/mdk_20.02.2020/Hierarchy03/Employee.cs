using System;
using System.Collections.Generic;
using System.Text;

namespace mdk_20._02._2020.Hierarchy03
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
       
        public override string ToString()
        {
            string resString = $", имеет ID - {ID} и имя - {Name} ";
            return resString;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace mdk_20._02._2020.Hierarchy03
{
    class Contract_Employee : Employee
    {
        public float PayPerHour { get; set; }
        public string ContactPeriud { get; set; }
        public Contract_Employee(float PayPerHour, string ContactPeriud, string Name, int ID)
            :base(ID, Name)
        {
            this.PayPerHour = PayPerHour;
            this.ContactPeriud = ContactPeriud;

        }
        public override string ToString()
        {
            string resString = $"Контрактный рабочий имеет оплата труда за час в размере - {PayPerHour} и контрактный периуд равен - {ContactPeriud} " + base.ToString();
            return resString;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace mdk_20._02._2020.Hierarchy03
{
    class Regular_Employer : Employee
    {
        public float salary { get; set; }
        public int bonus { get; set; }

        public Regular_Employer(float salary, int bonus, int id, string name)
            :base(id,name)
        {
            this.salary = salary;
            this.bonus = bonus;

        }
        public override string ToString()
        {
            string resString = $"Обычный рабочий имеет оплата труда в размере - {salary} и бонус - {bonus} "+ base.ToString();
            return resString;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace mdk_20._02._2020_secondTask_
{
    class Worker : User
    {
        private double salary;

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public double GetSalary()
        {
            return salary;
        }

    }
}

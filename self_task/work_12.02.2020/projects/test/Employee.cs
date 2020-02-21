using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Employee
    {
        public string Name { get; set; }
        public string Job{ get; set; }
        public int WorkExpiriance { get; set; }


        public Employee(string name, string job, int cours)
        {
            Name = name;
            Job = job;
            WorkExpiriance = cours;
        }

        public override string ToString()
        {
            string resultString = $"Рабочий: \n" +
                                  $"Имя: {Name}, Специальность: {Job}, Рабочий опыт: {WorkExpiriance} \n";
            return resultString;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Students
    {
        public string Name { get; }
        public string Job { get; }
        public int Cours { get; }

        public Students(string name, string jop, int cours) 
        {
            Name = name;
            Job = jop;
            Cours = cours;
        }

        public override string ToString()
        {
            string resultString = $"Студент: \n" +
                                  $"Имя: {Name}, Специальность: {Job}, Курс: {Cours} \n";
            return resultString;
        }
    }
}

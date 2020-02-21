using System;
using System.Collections.Generic;
using System.Text;

namespace mdk_20._02._2020
{
    class Teacher : Person
    {
        private List<string> dicipline;

        
        public Teacher(List<string> dicipline, string name, int age)
            :base(age, name)
        {
            this.dicipline = dicipline;
                    
        }

        public void AddDicipline(string nameOfAddedDiscipline) 
        {
            dicipline.Add(nameOfAddedDiscipline);            
        }

        public void RemoveDicipline(int indexOfRemoveDicipline) 
        {
            dicipline.RemoveAt(indexOfRemoveDicipline);
        }

        public override string ToString()
        {
            string resString = $"Преподаватель";
            resString += base.ToString() + ", предметы: ";
            
            foreach (var item in dicipline)
                resString += $" {item}";
            
            return resString;
        }

        public void PrintInfo() 
        {
            Console.WriteLine(ToString());
        }

    }
}

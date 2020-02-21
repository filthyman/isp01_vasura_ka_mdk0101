using System;
using System.Collections.Generic;
using System.Text;

namespace mdk_20._02._2020
{
    class Student : Person
    {
        private int course;
        private string groupe;

        public Student(int course, string groupe, int age, string name)
            :base(age, name)
        {
            this.course = course;
            this.groupe = groupe;
        
        }

        public void SetCourse(int course)
        {
            this.course = course;

        }

        public void SetGroupe(string groupe)
        {
            this.groupe = groupe;
        }

        public void nextCourse() 
        {
            course++;   
        }

        public override string ToString()
        {
            string resString = $"Студент имеет курс - {course} и группу - {groupe}," + base.ToString();
            return resString;
        }

        public void PrintInfo() 
        {
            Console.WriteLine(ToString());
        }



    }
}

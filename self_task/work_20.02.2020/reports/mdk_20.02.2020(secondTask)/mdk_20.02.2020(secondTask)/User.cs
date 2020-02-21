using System;
using System.Collections.Generic;
using System.Text;

namespace mdk_20._02._2020_secondTask_
{
    class User
    {
        protected string name;
        protected int age;

        public void SetName(string name) 
        {
            this.name = name;
        }

        public string GetName() 
        {
            return name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }
    }
}

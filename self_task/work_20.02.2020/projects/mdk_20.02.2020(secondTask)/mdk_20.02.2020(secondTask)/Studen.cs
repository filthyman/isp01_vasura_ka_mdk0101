using System;
using System.Collections.Generic;
using System.Text;

namespace mdk_20._02._2020_secondTask_
{
    class Studen : User
    {
        private double scholarship;
        private int course;

        public void SetCourse(int course)
        {
            this.course = course;
        }

        public int GetCourse()
        {
            return course;
        }

        public void SetScholarship(double scholarship)
        {
            this.scholarship = scholarship;
        }

        public double GetScholarship()
        {
            return scholarship;
        }


    }
}

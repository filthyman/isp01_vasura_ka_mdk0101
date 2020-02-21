using System;
using System.Collections.Generic;
using System.Text;

namespace mdk_20._02._2020_secondTask_
{
    class Driver : Worker
    {
        private int driverExpiriance;

        private char drivingCategory;

        public void SetDriverExpiriance(int driverExpiriance)
        {
            this.driverExpiriance = driverExpiriance;
        }

        public string GetDriverExpiriance()
        {
            return name;
        }

        public void SetDrivingCategory(char drivingCategory)
        {
            if (drivingCategory != 'A'|| drivingCategory != 'B' || drivingCategory != 'C'  )
                throw new IndexOutOfRangeException();

            this.drivingCategory = drivingCategory;
        }

        public char GetDrivingCategory()
        {
            return drivingCategory;
        }

    }
}

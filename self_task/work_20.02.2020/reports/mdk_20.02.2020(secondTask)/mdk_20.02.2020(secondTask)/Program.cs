using System;

namespace mdk_20._02._2020_secondTask_
{
    class Program
    {
        static void Main()
        {
            Worker worker = new Worker();
            worker.SetName("Иван");
            worker.SetAge(25);
            worker.SetSalary(1000);
            
            Worker worker2 = new Worker();
            worker2.SetName("Вася");
            worker2.SetAge(26);
            worker2.SetSalary(2000);

            double sumSalary = worker.GetSalary() + worker2.GetSalary();

        }
    }
}

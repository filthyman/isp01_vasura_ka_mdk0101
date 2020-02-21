using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    class Offset
    {
        public string FioOfExaminer{ get; set; }
        public string FioOfExaminee{ get; set; }
        public DateTime Date { get; set; }

        public int Grade { get; set; }

        public Offset(string fioOfExaminer, string fioOfExaminee, DateTime date, int grade)
        {
            FioOfExaminer = fioOfExaminer;
            FioOfExaminee = fioOfExaminee;
            Date = date;
            Grade = grade;

        }
        public override string ToString()
        {
            string resultString = $"Зачет: \n" +
                                    $"ФИО экзаменатора: {FioOfExaminer}, ФИО экзаменуймого: {FioOfExaminee}, Дата экзамена: {Date}, Оценка: {Grade} \n";
            return resultString;
        }
    }
}

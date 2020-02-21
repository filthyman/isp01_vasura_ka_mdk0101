using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    class StudyGroup
    {
        public string Chipher { get; set; }
        public int NumberOfStudents { get; set; }
        public int YeatrOfFormation { get; set; }
        public string Specialty { get; set; }

        public StudyGroup(string chipher, int numberOfStudents, int yeatrOfFormation, string specialty)
        {
            Chipher = chipher;
            NumberOfStudents = numberOfStudents;
            YeatrOfFormation = yeatrOfFormation;
            Specialty = specialty;
        }

        public override string ToString()
        {
            string resultString = $"Компютерная игра: \n" +
                                  $"Шифр: {Chipher}, Количество студентов: {NumberOfStudents}, Год формирования: {YeatrOfFormation}, Cпециальность: {Specialty} \n";
            return resultString;
        }
    }
}

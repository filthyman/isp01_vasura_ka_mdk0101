using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    class Workshop
    {
        public string StringCipher { get; set; }
        public int NumberOfWorkers { get; set; }

        public Workshop(string stringChiper, int numberOfWorkers) 
        {
            StringCipher = stringChiper;
            NumberOfWorkers = numberOfWorkers;
        }

        public override string ToString()
        {
            string resultString = $"Цех: \n" +
                                  $"Шифр в строчном представлении: {StringCipher}, Количество работников: {NumberOfWorkers} \n";
            return resultString;
        }

    }
}

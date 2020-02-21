using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Banknote
    {
        public string SeriesAndNumber{ get; set; }
        public double FaceVlaue { get; set; }
        public string FaceVlaueInSamplesInWords { get; set; }

        public Banknote(string seriesAndNumber, double faceVlaue, string faceVlaueInSamplesInWords)
        {
            SeriesAndNumber = seriesAndNumber;
            FaceVlaue = faceVlaue;
            FaceVlaueInSamplesInWords = faceVlaueInSamplesInWords;
        }
        public override string ToString()
        {
            string resultString = $"Банкнота: \n" +
                                  $"Серия и номер: {SeriesAndNumber}, Номинал: {FaceVlaue}, Номинал прописью: {FaceVlaueInSamplesInWords} \n";
            return resultString;
        }
    }
}

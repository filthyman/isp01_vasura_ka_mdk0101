using System;
using Vector;

namespace Classwork_2
{
    class Program

    {
        
        static void Main()
        {
            Vector3D firstVector3D = new Vector3D(1, 10, 10);
            Vector3D secondVector3D = new Vector3D(4, 3, 10);

            double resultOfVectorLength = firstVector3D.Length();
            double resultOfScalarProductWithOther = firstVector3D.scalarProductWithOther(secondVector3D);
            Vector3D resultOfvectorMultiplicationWithAnotherVector = firstVector3D.vectorMultiplicationWithAnotherVector(secondVector3D);


            //Console.WriteLine(firstVector3D.ToString());

            Console.WriteLine($"Длинна вектора: {resultOfVectorLength}");
            Console.WriteLine($"Скалярное произведение 2х векторов: {resultOfScalarProductWithOther}");
            Console.WriteLine($"Векторное произведение  с другим вектором: {resultOfvectorMultiplicationWithAnotherVector}");
            
            
            
            
        }
    }
}

using System;
using System.Data;

namespace MethodCall
{
    class Program
    {
        static void Main(string[] args)
        {
            const float MATH_GRADE = 80.0f;
            const float BIOLOGY_GRADE = 80.0f;
            const float PROG_GRADE = 96.2f;
            const string STUDENT_NAME = "G.Treele";
            //const float = MATH_GRADE + BIOLOGY_GRADE + PROG_GRADE);
            // call calculateAverage() to calculate the average grade.
            float average = CalculateAverage(MATH_GRADE,BIOLOGY_GRADE,PROG_GRADE);
            //result average = MATH_GRADE + BIOLOGY_GRADE + PROG_GRADE / 3 );
            ShowAverage(STUDENT_NAME,average);
            Console.ReadLine();

        }

        static float CalculateAverage(float mathGrade, float biologyGrade, float progGrade)
            {
            result average = (mathGrade + biologyGrade + progGrade) /3;
        }
        static void ShowAverage(string name, float average)
            {
            Console.WriteLine(name+ "average: "+ average);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using LINQExercise3;
namespace LINQExercise3
{
    class Exercise3
    {
        static void Main(string[] args)
        {
            IEnumerable<int> ListOfRandomNumbers = new List<int>{ 1, 2, 3, 4, 5 };
            IEnumerable<int> ListOfNumbersAfterTransformation = ListOfRandomNumbers.Transform(IncrementInt);

            foreach(var number in ListOfNumbersAfterTransformation)
            {
                Console.WriteLine(number);
            }
        }

        private static int IncrementInt(int IntNumber)
        {
            return IntNumber + 1;
        }



    }
}

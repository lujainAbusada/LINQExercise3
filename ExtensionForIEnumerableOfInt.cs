using System;
using System.Collections.Generic;
using System.Text;

namespace LINQExercise3
{
    public static class  ExtensionForIEnumerableOfInt
    {
        public delegate int TransformationFunction(int num);
        public static IEnumerable<int> Transform(this IEnumerable<int> num, TransformationFunction func)
    {

        foreach (var value in num)
        {
            yield return func(value);
        }

    }
}
}


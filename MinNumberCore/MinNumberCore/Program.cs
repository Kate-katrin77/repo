using System;
using System.Collections.Generic;

namespace MinNumberCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            var integerSet = new List<int> { 5, 90, 44, 3, -1, 555, 602, 8 };
            var result = GetLowestValue(integerSet);
            Console.WriteLine("The lowest number is: " + result);

            List<int> integerSet1 = null;
            var result1 = GetLowestValue(integerSet1);
            if (result1 == null)
            {
                Console.WriteLine("The list is null or doesn't contain any elements");
            }

            var integerSet2 = new List<int>();
            var result2 = GetLowestValue(integerSet2);
            if (result2 == null)
            {
                Console.WriteLine("The list is null or doesn't contain any elements");
            }
            Console.ReadLine();
        }

        public static int? GetLowestValue(List<int> inputValues)
        {
            if (inputValues == null || inputValues.Count == 0)
            {
                return null;
            }

            var minValue = inputValues[0];

            for (var i = 0; i < inputValues.Count; i++)
            {
                var number = inputValues[i];

                if (number < minValue)
                {
                    minValue = number;
                }
            }
            return minValue;
        }
    }
}

using System;
using System.Collections.Generic;

namespace MinNumberCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            var integerSet = new List<int> { };
            var result = GetLowestValue(integerSet);
            Console.WriteLine("The lowest number is: " + result);

            Console.ReadLine();
        }

        public static int GetLowestValue(List<int> inputValues)
        {
            if (inputValues == null)
            {
                throw new NullReferenceException("Input values are null");
            }

            if (inputValues.Count == 0)
            {
                throw new Exception("List doesn't contain any elements");
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

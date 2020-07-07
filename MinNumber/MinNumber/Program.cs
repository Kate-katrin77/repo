using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            var integerSet = new List<int> { 5, 90, 44, 3, 555, 602, 8 };
            var result = GetLowestValue(integerSet);
            Console.WriteLine("The lowest number is: " + result);
            Console.ReadLine();
        }

        public static int GetLowestValue(List<int> inputValues)
        {
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

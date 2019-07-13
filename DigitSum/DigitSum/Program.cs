using System;
using System.Globalization;
using System.Linq;


namespace DigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string userInput;
            int[] intArray;
            int maxValue = 0;
            int maxValuePosition = 0;

            Console.WriteLine("Provide number of integers that you want to check:");
            userInput = Console.ReadLine();
            N = ToInt32(userInput);
            intArray = new int[N];

            Console.WriteLine("Please provide N numbers, accordingly to the input above. Put spaces in between.");
            userInput = Console.ReadLine();
            intArray = StringConvertToArr(userInput);

            foreach (int i in intArray)
            {
                int currentValue = i;

                if (currentValue > maxValue)
                {
                    maxValue = currentValue;
                    maxValuePosition = Array.IndexOf(intArray, i);
                }
            }
            Console.WriteLine(maxValuePosition);
            Console.ReadKey();
        }

        // Method which turns string into an int32 variable.
        private static int ToInt32(string value)
        {
            if (value == null)
                return 0;
            return Int32.Parse(value, CultureInfo.CurrentCulture);
        }

        // Method which turns string into an array.
        private static int[] StringConvertToArr(string s)
        {
            string[] StringArray = s.Split(' ');
            int[] asIntegers = StringArray.Select(token => int.Parse(token)).ToArray();
            return asIntegers;
        }
    }
}
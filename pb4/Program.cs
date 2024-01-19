using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');

            float maxValue = float.Parse(nums[0]) - 1, minValue = float.Parse(nums[0]) + 1;
            int maxValueCount = 1, minValueCount = 1;

            for (int i = 0; i < nums.Length; i += 1)
            {
                if (float.Parse(nums[i]) > maxValue) { maxValue = float.Parse(nums[i]); maxValueCount = 1; }
                else if (float.Parse(nums[i]) == maxValue) maxValueCount += 1;
                if (float.Parse(nums[i]) < minValue) { minValue = float.Parse(nums[i]); minValueCount = 1; }
                else if (float.Parse(nums[i]) == minValue) minValueCount += 1;
            }

            Console.WriteLine("Valoarea maxima este " + maxValue + " si apare de " + maxValueCount + " ori, iar valoarea minima " + minValue + " aparand de " + minValueCount + " ori");
        }
    }
}

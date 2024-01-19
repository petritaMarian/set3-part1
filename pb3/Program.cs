using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');

            float maxValue = float.Parse(nums[0]), minValue = float.Parse(nums[0]);

            for (int i = 0; i < nums.Length; i += 1) 
            { 
                if (float.Parse(nums[i]) > maxValue) maxValue = float.Parse(nums[i]);
                if (float.Parse(nums[i]) < minValue) minValue = float.Parse(nums[i]);
            }

            Console.WriteLine("Valoarea maxima este " + maxValue + ", iar valoarea minima " +  minValue);
        }
    }
}

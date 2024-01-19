using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            float sum = 0;

            for (int i = 0; i < nums.Length; i += 1)
                sum += float.Parse(nums[i]);

            Console.WriteLine("Suma: " + sum);
        }
    }
}

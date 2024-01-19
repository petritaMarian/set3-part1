using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayInput = Console.ReadLine();
            string[] nums = arrayInput.Split(' ');
            string aux;

            for (int i = 0; i < nums.Length / 2; i++)
            {
                aux = nums[i];
                nums[i] = nums[nums.Length - i - 1];
                nums[nums.Length - i - 1] = aux;
            }

            for (int i = 0; i < nums.Length; i += 1)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}

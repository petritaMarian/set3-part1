using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayInput = Console.ReadLine();
            string[] nums = arrayInput.Split(' ');

            int k = int.Parse(Console.ReadLine());

            for (int i = k; i < nums.Length - 1; i++)
                nums[i] = nums[i + 1];

            nums[nums.Length - 1] = " " + "\n"; 

            for (int i = 0; i < nums.Length; i += 1)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}

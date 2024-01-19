using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayInput = Console.ReadLine();
            string[] nums = arrayInput.Split(' ');
            string[] newNum = new string[nums.Length + 1];

            string[] elemPosInput = Console.ReadLine().Split(' ');
            string e = elemPosInput[0];
            int k = int.Parse(elemPosInput[1]);

            for (int i = 0; i < k; i += 1)
                newNum[i] = nums[i];

            newNum[k] = e;

            for (int i = k + 1; i < newNum.Length; i += 1)
                newNum[i] = nums[i - 1];

            for (int i = 0; i < newNum.Length; i += 1) 
            {
                Console.Write(newNum[i] + " ");
            }
        }
    }
}

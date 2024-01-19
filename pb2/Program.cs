using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace pb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            float k = float.Parse(Console.ReadLine());

            int poz = -1;

            for (int i = 0; i < nums.Length; i += 1)
                if (float.Parse(nums[i]) == k) { poz = i; break; }

            if (poz != -1) Console.WriteLine("Prima pozitie in vector a lui " + k + " este " + poz);
            else Console.WriteLine(poz);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class ParameterDemo
    {
        // Method 1: Increase using ref
        public void Increase(ref int number)
        {
            number += 10;
        }

        // Method 2: GetFullName using out
        public void GetFullName(out string fullname)
        {
            fullname = "Samir Bhandari";  // Replace with your actual name
        }

        // Method 3: SumAll using params
        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}

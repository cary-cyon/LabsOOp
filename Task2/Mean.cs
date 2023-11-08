using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Mean : IArrayChange
    {
        public void ChangeArray(int[] arr)
        {
            int sum = 0; 
            for(int i = 0; i < arr.Length; i++)
            {
                sum+= arr[i];
            }
            arr[0] = sum / arr.Length;
        }
    }
}

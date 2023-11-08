using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Min : IArrayChange
    {
        public void ChangeArray(int[] arr)
        {
            int min  = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < min)
                    min = arr[i];
            }
            arr[arr.Length - 1] = min;
        }
    }
}

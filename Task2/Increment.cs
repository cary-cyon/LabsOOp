using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Increment : IArrayChange
    {
        public void ChangeArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]++;
            }
        }
    }
}

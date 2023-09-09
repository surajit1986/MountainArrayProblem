using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountainSequence
{
    internal class MountainSeq
    {
        public bool IfMountainSeq(int[] arr)
        {
            int i = 1;

            while((i<arr.Length) && (arr[i-1] < arr[i]))
            {
                i++;
            }

            if((i ==1) || (i ==arr.Length)) { return false; }

            while((i < arr.Length) && (arr[i-1] > arr[i]))
            {
                i++;
            }

            if(i == arr.Length) {  return true; }
            return false;
        }
    }
}

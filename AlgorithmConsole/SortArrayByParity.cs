using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmConsole
{

    public class SortArrayByParity
    {
        /// <summary>
        /// Given an array A of non-negative integers, return an array consisting
        /// of all the even elements of A, followed by all the oll elements of A
        /// e.g. 
        /// Input [3, 1, 2, 4]
        /// Output [ 2, 4, 3 , 1]
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[] SortArray(int[] A)
        {
            if(A.Length == 0)
            {
                return new int[] { };
            }

            int i = 0;
            int j = A.Length - 1;

            while(i < j )
            {
                if (A[i] % 2 != 0)
                {
                    if (A[j] % 2 == 0)
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                        i++;
                    }

                    j--;
                }
                else
                {
                    i++;
                }
            }

        }
    }
}

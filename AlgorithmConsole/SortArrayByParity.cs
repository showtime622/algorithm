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
		
		  public static int[] SortArrayByParityII(int[] A)
        {
            if(A.Length == 0)
            {
                return A;
            }

            int i = 0;
            int j = A.Length - 1;
            int tempj = j;

            while(i < j)
            {
               if(A[i] % 2 == 0 && i % 2 != 0)
               {
                    if(A[j] %2 != 0 && j % 2 == 0)
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                        i++;
                        j = A.Length - 1;
                    }
                    else
                    {
                        j--;
                    }
                }
               else if(A[i] % 2 != 0 && i % 2 == 0)
               {
                    if (A[j] % 2 == 0 && j % 2 != 0)
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                        i++;
                        j = A.Length - 1;
                    }
                    else
                    {
                        j--;
                    }
                }
               else
               {
                    i++;
               }
            }

            return A;
        }
        /// <summary>
        /// very smart sol from others
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[] SortArrayByParityIINew(int[] A)
        {
            int e = 0;
            int o = 1;

            while(o < A.Length && e < A.Length)
            {
                if(A[e] % 2 != 0)
                {
                    int temp = A[e];
                    A[e] = A[o];
                    A[o] = temp;
                    o += 2;
                }
                else
                {
                    e += 2;
                }
            }

            return A;
        }
    
    }
}

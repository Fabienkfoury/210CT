using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Sorted_Array = { 2, 3, 5, 7, 9, 13  };
            Console.WriteLine(Binary_Search(10,14, Sorted_Array));
            //Binary_Search(5,Sorted_Array);
            Console.ReadLine();
        }

        static bool Binary_Search(int n, int [] Sorted_Array)
        {
            int Last_Index=Sorted_Array.Length;
            int First_Index=0;

            int i = First_Index +( (Last_Index - First_Index) /2 );

            while(Last_Index>First_Index)
            {
                if(Sorted_Array[i] == n)
                {      
                    return true;
                }
                else if  (Sorted_Array[i]<n)
                {
                    First_Index = i;
                    i = First_Index + (Last_Index-First_Index) / 2;
                }
                else if (Sorted_Array[i]> n)
                {
                    Last_Index = i;
                    i = First_Index + ( Last_Index- First_Index) / 2;
                }   
            }
            return false;
        }

        static bool Binary_Search(int low, int high, int[] Sorted_Array)  
        {
            int Last_Index = Sorted_Array.Length;
            int First_Index = 0;
            int i = First_Index + ((Last_Index - First_Index) / 2);

            while ((Last_Index > First_Index) && (low < high))
            {
                if ((Sorted_Array[i] == low) || (Sorted_Array[i] == high))
                {
                    return true;
                }
                if ((Sorted_Array[i] > low) || (Sorted_Array[i] < high))
                {
                    return true;
                }
                else if (Sorted_Array[i] < low)
                {
                    First_Index = i + 1;
                    i = First_Index + (Last_Index - First_Index) / 2;
                }
                else if (Sorted_Array[i] > high)
                {
                    Last_Index = i - 1;
                    i = First_Index + (Last_Index - First_Index) / 2;
                }
            }
            return false;
        }
    }
}

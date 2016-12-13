using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 6, 5, 7, 8, 2 , 5, 6, 8 };
            Sub_Sequence(tab);
            
            Console.ReadLine();
        }

        static void Sub_Sequence(int[] tab)
        {
            int start = 0;
            int longestlength = 0;
            int longestlengthstart = 0;

            for (int i = 1; i < tab.Length; i++)
            {
                int length = i - start; 
                if (tab[i] < tab[i - 1])                    
                {
                    Console.WriteLine(start + " to " + i);
                    if (length > longestlength)
                    {
                        longestlength = length;
                        longestlengthstart = start;
                    }
                    start = i;
                }
            
                // whith out this if statement : 
                // at the end of the array, at the value 8 :  start = 4 , i = 7
                // length = 7-4 = 3 BUT it is suppose to equal 4 because we have 4 consecutive ascending number
                // that is why, when i test the end of the array, I do length +1 because an array starts at 0
                if (i == tab.Length-1)                          // When we are at the end
                {
                    if (tab[i] > tab[i - 1] && (length + 1 > longestlength) )           // if last element is superior to the previous element
                    {                                                                   // and the sub sequence is the longest
                        longestlength = length + 1;                                     // +1 because at the end of the loop i = 7 and then lenght has not his right value
                        longestlengthstart = start;

                    }
                    
                }
                
            }

            for (int i = longestlengthstart; i < longestlength + longestlengthstart; i++)
            {
                Console.Write(tab[i] + " ");
            }

        }

    }
}

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
            int[] tab = { 6, 5, 9, 7, 2 , 4, 5, 7 };
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
                if (tab[i] < tab[i - 1])                    // Si le nombre d'apés est inférieur au nombre d'avant alors on rentre dans la boucle 
                {
                    Console.WriteLine(start + " to " + i);

                                 // i est implémté à chaque fois alors que start à chaque fois qu'on rentre dans la boucle 


                    if (length > longestlength)
                    {
                        longestlength = length;
                        longestlengthstart = start;
                    }
                    start = i;
                }
                if (length > longestlength)
                {
                    longestlength = length;
                    longestlengthstart = start;
                }
                
            }
            Console.WriteLine("Affichage");
            Console.WriteLine(longestlength);
            Console.WriteLine(longestlengthstart);

            for (int i = longestlengthstart; i <= longestlength + longestlengthstart; i++)
            {
                Console.Write(tab[i] + " ");
            }

        }

    }
}

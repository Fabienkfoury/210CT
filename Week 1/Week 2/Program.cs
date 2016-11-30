using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //ShuffleArray();
           //Trailling0();
            //Fact2();
            //Alien();
            int DimI = 3;
            int DimJ = 3;
 
            int[,] Matrix = new int[DimI, DimJ];
            int[,] Matrix2 = new int[DimI, DimJ];

           // SparseMatrix(Matrix,Matrix2,DimI,DimJ);
            Console.ReadLine();
        }

        static void Task1()
        {
            int[] tab = { 5, 3, 8, 6, 1, 9, 2, 7 };
            Console.WriteLine("Here is an array");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i]);
            }

            Random Rand = new Random();
            int Shuffle = Rand.Next(0, tab.Length);

            int[] newtab = new int[tab.Length];

            for (int i = 0; i < tab.Length; i++)
            {
                Shuffle = Rand.Next(0, tab.Length);
                while (tab[Shuffle] != -1)
                {
                    newtab[i] = tab[Shuffle];
                    tab[Shuffle] = -1;
                }
                if (tab[Shuffle] == -1)
                {
                    int j = 0;
                    while (j < 10)
                    {
                        Shuffle = Rand.Next(0, tab.Length);
                        if (tab[Shuffle] != -1)
                        {
                            newtab[i] = tab[Shuffle];
                            tab[Shuffle] = -1;
                        }
                        j++;
                    }
                }
            }
            Console.WriteLine();

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(newtab[i]);
            }
        }

        static void ShuffleArray()
        {
            int[] tab = { 5, 3, 8, 6, 1, 9, 2, 7 };
            Console.WriteLine("Here is an array");

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i]);
            }

            Random Rand = new Random();
            int Shuffle = Rand.Next(0, tab.Length);

            for (int i = 0; i < tab.Length; i++)
            {
                int tmp = tab[i];
                tab[i] = tab[Shuffle];
                tab[Shuffle] = tmp;
            }

            Console.WriteLine();
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i]);
            }

        } 

        static int Fact(int number) 
        {
            if(number==0 )
            {
                return 1;
            }
            else
            {
                return (Fact(number-1) * (number ));
            }

        }

        static void Fact2() 
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            if (number == 0 )
            {
                result = 1;
            }
            else
            {
                for (int i =number; i>1; i--)
                {

                    result = result * i;
                }
            }
            Console.Write(result);
        }

        static void Trailling0() 
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fact(number));

            int result=Fact(number);
            int output=0;

            while(result %5 ==0)
            {
                result=result/5;
                output+=1;
            }
            Console.Write("Output :" + output);
        }

        static void Alien()
        {
            int MAX_DAY = 30; // Number of days

            Console.WriteLine("Enter a value of X ( Number of egg laid by the Alien :");
            int NumberOfEggLaid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value of Y(Number of days needed to the egg to hatch :");
            int DaysToHatch = Convert.ToInt32(Console.ReadLine());

            int[] Jour = new int[MAX_DAY]; // Tableau représentant les 30 jours dans lequel on rentre le nombre d'alien qu'il y a chaque jour

            for (int i = 0; i < DaysToHatch; i++)
            {
                Jour[i] = 1;
            }

            for(int i=DaysToHatch;i< MAX_DAY;i++)
            {
                Jour[i] = Jour[i - 1] + NumberOfEggLaid * Jour[i - DaysToHatch];
            }

            for(int i=1;i<= MAX_DAY;i++)
            {
                Console.Write("Jour "+i +":");
                Console.WriteLine(Jour[i-1]);
            }
        }
        
        static void SparseMatrix(int [,] Matrix,int [,] Matrix2,int DimI,int DimJ)
        { 
            Random rand = new Random();
            
            int Rand1 = rand.Next(0, DimJ);
            int Rand2 = rand.Next(1, 9);

            // Implémentation of the first matrice
            for (int i = 0; i < DimI; i++)  
            {
                for(int j = 0; j < DimJ; j++)
                {
                    Matrix[i, Rand1] = Rand2;
                }
                 Rand1 = rand.Next(0, DimJ);
                 Rand2 = rand.Next(1, 9);
            }

            //Implémentation of the second Matrix
            
            for(int i=0;i<DimI;i++)
            {
                for(int j=0;j<DimJ;j++)
                {
                    Matrix2[i, Rand1] = Rand2;
                }
                Rand1 = rand.Next(0, DimJ);
                Rand2 = rand.Next(1, 9);
            }

            Console.WriteLine("Matrix 1: ");
            for(int i=0; i<DimI;i++) // Output Matrix 1
            {
                for(int j=0;j<DimJ;j++)
                {
                    Console.Write(Matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("--------------------");

            Console.WriteLine("Matrix 2: ");
            for (int i = 0; i < DimI; i++) // Output Matrix 2
            {
                for (int j = 0; j < DimJ; j++)
                {
                    Console.Write(Matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Now, do you want to add(0), substract(1) or multiply(2) your matrixes ?");
            int Choice = Convert.ToInt32(Console.ReadLine());

            switch(Choice)
            {
                case 0 :
                    {
                        break;
                    }
                case 1 :
                    {
                        break;
                    }
                case 2 :
                    {
                        break;
                    }
                default:
                        {
                            break;
                        }
            }
            


        }
        
    }
    
}

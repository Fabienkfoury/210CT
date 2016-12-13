using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Real
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.Write(Perfect_Square(26));

            int a = 2;
            int[,] B = { {1,2 },{1,2} };            
            int[,] C = { {1,1 },{1,2} };

            //Matrix_Operations(B, C);
            Affichage(Matrix_Operations(B, C));

            // RESULT = {{-1,-1},
                //       {-1,-3} };

            Console.ReadLine();
        }


                                        ////////// PSEUDOCODE \\\\\\\\\\\

        /* 1 : Write the pseudocode for a function which returns the highest perfect square which is less or equal to
           its parameter (a positive integer). Implement this in the programming language of your choice*/
        /*
         *  PERFECT SQUARE(parametre)
         *     
             * Racine <- square root of parametre:
             * i <- 1:
             * 
             * while (Racine %1 != 0)     
             *      Racine <- root of parametre-i;
             *      i<-i+1;
             * 
             * Write Racine;
         */

        static double Perfect_Square(double parametre)
        {

            double Racine = Math.Sqrt(parametre);   // 1

            int i = 1;                              // 1
            while (Racine % 1 != 0)                 // N
            {

                Racine = Math.Sqrt(parametre - i);  // N
                i++;                                // N
            }
            return Racine;                          //1
        }                                           // --> 3N+3  --> O(N)


        /*2. Look back at last week’s tasks. Describe the run-time bounds of these algorithms using the BigO
            notation.*/

        static void Shuffle()
        {
            int[] tab = { 5, 3, 8, 6, 1, 9, 2, 7 };     //1    
            Console.WriteLine("Here is an array");      //1

            for (int i = 0; i < tab.Length; i++)        // N
            {
                Console.Write(tab[i]);                  // N
            }

            Random Rand = new Random();                 //1
            int Shuffle = Rand.Next(0, tab.Length);     //1

            for (int i = 0; i < tab.Length; i++)        //N
            {
                int tmp = tab[i];                       //N
                tab[i] = tab[Shuffle];                  //N
                tab[Shuffle] = tmp;                     //N
            }

            Console.WriteLine(); //1
            for (int i = 0; i < tab.Length; i++)        //N
            {
                Console.Write(tab[i]);                  //N
            }

        } // Random Shuffle : --> 8N +4 --> O(n)

        static int Fact(int number) // Factoriel in recursif
        {
            if (number == 0)         //1
            {
                return 1; //1
            }
            else //1
            {
                return (Fact(number - 1) * (number)); //1
            }
        } //--> +4
        static void Task2() //On regarde si le nombre modulo 5 est égale à 0, si oui on rajoute +1 à l'output et on continue en divisant par 5 le nombre initial
        {
            Console.WriteLine("Enter a number");                 //1
            int number = Convert.ToInt32(Console.ReadLine());       //1
            Console.WriteLine(Fact(number));                        //1

            int result = Fact(number);                              //1
            int output = 0;                                         //1

            while (result % 5 == 0)                                 //n
            {
                result = result / 5;                            //n
                output += 1;                                    //n
            }
            Console.Write("Output :" + output);                 //1
        } //3n+6
        // --> 3n+10 --> O(n)

        //3. Write the pseudocode corresponding to functions for addition, 
        //subtraction and multiplication of two matrices, and then compute A = B*C-2*(B+C), 
        //where B and C are two matrices of order N. What is the run-time?


        /* 
         * MATRIX_ADDITION(A,B)
         *  A<- [N,N];
         *  B<- [N,N]:
         *  C<- [N,N];
         *  
         *  for i<-0 to Lenght[A]
         *      for j<-0 to Lenght[B]
         *          C[i,j]<- A[i,j] + B[i,j];     
         * return C;
         *  
         * MATRIX_SUBSTRACTION(A,B)
         *  A<- [N,N];
         *  B<- [N,N]:
         *  C<- [N,N];
         *  
         *  for i<-0 to Lenght[A]
         *      for j<-0 to Lenght[B]
         *          C[i,j]<- A[i,j] - B[i,j];
         *          
         * return C;
         * 
         * MATRIX_MULTIPLICATION(A,B)
         *  A<- [N,N];
         *  B<- [N,N]:
         *  C<- [N,N];
         *  
         *  for i<-0 to Lenght[A]
         *      for j<-0 to Lenght[B]
         *          for l<0 to Lenght[A]
         *              C[j,i]<- C[j,i] +A[j,k] *B[k,i];
         * 
         * Return C;
         * 
         * MATRIX_MULTIPLICATION_INTEGER(Integer,A)
         *  A<=[N,N];
         *  B<-[N,N]; 
         *  
         *  for i<-0 to Lenght[A]
         *      for j<-0 to Lenght [B]
         *          B[i,j]=Integer*A[i,j];
         * 
         * return B;
         * 
         * MATRIX_OPERATION(B,C)
         * 
         
         * B<-[N,N];
         * C<-[N,N];
         * 
         * D<=[N,N];
         * E<=[N,N];
         * 
         * D<-MATRIX_MULTIPLICATION(B,C); B*C
         * E<= MATRICE_ADDITION(B,C) );  B+C
         * F<-MATRICE_MULTIPLICATION_INTEGER(2,E); 2*(B+C)
         * 
         * A<= MATRICE_ADDITION(D,F); B*C +2*(B+C)
         * Return A;
         */

        static int [,] Matrix_Addition(int [,]A,int [,]B)
        {
            int lenght=A.GetLength(0);
            int[,] C = new int[lenght, lenght];

            for(int i=0;i<lenght;i++)
                for(int j=0;j<lenght;j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            return C;
        }

        static int[,] Matrix_Substraction(int[,] A, int[,] B)
        {
            int lenght = A.GetLength(0);
            int[,] C = new int[lenght, lenght];

            for (int i = 0; i < lenght; i++)
                for (int j = 0; j < lenght; j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
            return C;
        }

        static int [,] Matrix_Multiplication(int [,]A,int [,]B)
        {
            int lenght = A.GetLength(0);
            int[,] C = new int[lenght, lenght];

            for (int i = 0; i < lenght; i++)
                for (int j = 0; j < lenght; j++)
                    for (int k = 0; k < lenght;k++)
                    {
                        C[i, j] = C[i,j]+ A[i, k] * B[k, j];
                    }
            return C;
        }

        static int [,] Matrix_Multiplication_Integer(int a, int[,]A)
        {
            int lenght = A.GetLength(0);
            int[,] B = new int[lenght, lenght];

            for (int i = 0; i < lenght; i++)
                for (int j = 0; j < lenght; j++)
                {
                    B[i, j] = a*A[i, j];
                }
            return B;
        }

        static int [,] Matrix_Operations(int [,]B,int [,]C)
        {
            int lenght = B.GetLength(0);
            int[,] D = new int[lenght, lenght];

            int[,] E = new int[lenght, lenght];
            int[,] F = new int[lenght, lenght];
            int[,] G = new int[lenght, lenght];

            D = Matrix_Multiplication(B, C); // B*C
            E = Matrix_Addition(B, C);
            F = Matrix_Multiplication_Integer(2, E); // 2*(B+C)
            G = Matrix_Substraction(D,F);

            return G;
        }

        static void Affichage(int [,]Result)
        {

            for (int i = 0; i < Result.GetLength(0); i++)
            {
                for (int j = 0; j < Result.GetLength(1); j++)
                {
                    Console.Write(Result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
    }
}

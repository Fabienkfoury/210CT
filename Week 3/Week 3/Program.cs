using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse("je suis fou .");
            //Console.Write(Prime(10));
            string word="beautiful";
            string [] input=new string[word.Length-1];
            int i=0;
            int j = 0;

            Voyel(word, input, i,j);
            Console.ReadLine();
        }

        /*6. Write the pseudocode and code for a function that reverses the words in a sentence. 
         * Input: "This is awesome" Output: "awesome is This". 
         * Give the Big O notation.
         */

        /* REVERSE(chaine)
            *  wordsArray <- [lenght(chaine)];
            *  j<-0;
            *  WordCompteur<-0
            *  SentenceEnd <- False;
         *  
            *   While(SentenceEnd equal false)
            *        While(chaine[j] not a space AND chaine[j] not a dot)
            *           word[WordCompteur] = word[WordCompteur] + chaine[j];
         *           if (chaine[j] equal to a space)
         *              j<-j+1;
         *           WordCompteur++;
         *           if (chaine[j] equal to a dot)
         *              SentenceEnd<- True;
         *              
         *      for (i<-0 to lenght(wordsArray) )
         *          tempo <- wordsArray[i];
         *          wordsArray[i] <- wordsArray[lenght(wordsArray)-i];
         *          wordsArray[lenght(wordsArray)-i] <- tempo;
         
            */
        static void Reverse(string sentence)
        {
            string[]chaine =new string [sentence.Length];                               // (1)
            int j = 0;                                                                  // (1)
            bool SentenceEnd = false;                                                   // (1)
            int WordCompteur = 0;                                                       // (1)

                while (!SentenceEnd)                                                    // (N)
                {
                    while ( (sentence[j] != ' ') && (sentence[j] != '.' ) )             // (NN)
                    {
                        chaine[WordCompteur] = chaine[WordCompteur] + sentence[j];      // (NN)
                        j++;                                                            // (NN)
                        
                    }   
                    WordCompteur++;                                                     // (N)
                    if(sentence[j]==' ')                                                // (N)
                    {
                        j = j + 1;                                                      // (N)
                        
                    }

                    if (sentence[j] == '.')                                             // (N)
                    {
                        SentenceEnd = true;                                             // (N)
                    }
                }
                     
            Console.WriteLine("There are " + WordCompteur +" words");                   // (1)

            for (int i = 1; i < WordCompteur;i++ )                                      // (N)
            {
                string tmp = chaine[i-1];                                               // (N)
                chaine[i - 1] = chaine[WordCompteur - i];                               // (N)
                chaine[WordCompteur - i] = tmp;                                         // (N)
            }

            for (int i = 0; i < WordCompteur; i++)                                      // (N)
            {
                Console.Write(chaine[i] + " ");                                         // (N)
            }
        }   

        static bool Prime(int n,int i)
        {
            if (n == i)                 
                return true;           
            else if (n % i == 0)        
                return false;           
            
            return Prime(n, i + 1);    
        }   
        static bool Prime(int n)
        {
             return Prime(n, 2);         
        }
         
        static bool Voyel(string Word,string []input,int i,int j)
        {
            if(i==Word.Length)
            {
                return true;
            }
            if(Word[i]=='a' || Word[i]=='e' || Word[i]=='i' || Word[i]=='o' || Word[i]=='u' || Word[i]=='y')
            {
                i = i + 1;
            }
            else
            {
               input[j]=input[j] + Word[i];
               Console.Write(input[j]);
                i++;
               j++;
              
            }
            return Voyel(Word, input, i,j);
        }
           
    }
}

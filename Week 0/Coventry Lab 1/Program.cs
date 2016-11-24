using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coventry_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Console.WriteLine(Task3());
            //Task4();
            //Task4Bis();
            //Task5();
            Task6();
            Console.ReadKey();
        }

        static void Task1()
        {
            Console.Write("A:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("B:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("C:");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("D:");
            int d = Convert.ToInt32(Console.ReadLine());

            int result1= a/b;
            int result2=c/d;
            Console.Clear();

            if (result1 > result2) 
            {
                Console.WriteLine(result1);
            }
            else
            {
                Console.WriteLine(result2);
            }
            
        }

        static void Task2()
        {

        }

        static float Task3()
        {
            Console.WriteLine("Enter a value :");
            float x = float.Parse(Console.ReadLine());
            //int x =Convert.ToInt32(Console.ReadLine());

            float result;


            if (x < -2)
            {
                result = ((x * x) + (4*x) + 4);
                return result;
            }

            if (x > -2)
            {
                result = (x * x + 5 * x);
                return result;
            }
            else
                return 0;

        }

        static void Task4()
        {
            Console.WriteLine("Write a word");
            string input = Console.ReadLine();

            Console.WriteLine("Beginning position");
            int position = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Length of the substring");
            int L = Convert.ToInt32(Console.ReadLine());

            char [] tab = new char [input.Length];

            for (int i = 0; i < input.Length;i++ )
            {
                tab[i] = input[i];
            }

                for (int i = position; i < position + L; i++)
                {
                    tab[i]=' ';
                }

            for(int i=0; i< input.Length;i++)
            {
                Console.Write(tab[i]);
            }

        } // En créant un tableau que l'on remplit avec les caractère du mot puis on met des espaces à la place des mots à suprimer

        static void Task4Bis()
        {
            Console.WriteLine("Write a word");
            string input = Console.ReadLine();
            int position;

            do
            {
                Console.WriteLine("Beginning position :");
                position = Convert.ToInt32(Console.ReadLine());

            }
            while (position < 0);
            

                Console.WriteLine("Length of the substring");
                int L = Convert.ToInt32(Console.ReadLine());

                for(int i=0; i< position;i++)
                {
                    Console.Write(input[i]);
                }

                for(int i=position + L; i< input.Length;i++)
                {
                    Console.Write(input[i]);
                }
            
        

        } // Sans créer de tableau, en affichant en deux parties, les caractères du mot

        static void Task5()
        {
           
            Console.WriteLine("Enter a year :");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a month :");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a day :");
            int day = Convert.ToInt32(Console.ReadLine());

            int totalday = ((month-1) * 30) + day;

            int totaldayyear = 365;

            if(year%4==0 || !(year%100==0))
            {
                totaldayyear = 366;
                Console.WriteLine("Leap year ! ");
            }

            for(int i=1; i<month;i++)
            {
                if(i==2)
                    {
                        totalday=totalday-1;
                    }
                if(i%2  == 1)     
                {
                    totalday = totalday + 1;
                }
            }
             

            Console.WriteLine("Passed " + totalday);
            Console.Write("Left :" + (totaldayyear-totalday));
            
        }

        static void Task6()
        {

            int[] tab = new int[5];

            for(int i=0; i<tab.Length;i++)
            {
                Console.WriteLine("Enter numbers "+ i +" :");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = tab[tab.Length-1];

            int max = tab[0];

            for (int i = 1; i < tab.Length;i++ )
            {
                if(max<tab[i])
                {
                    max = tab[i];
                }
            }

            for(int i=tab.Length-1;i>=0;i--)
            {
                if(min>tab[i])
                {
                    min = tab[i];
                }
            }

            Console.WriteLine("Max:"+max);
            Console.WriteLine("Min :" + min);
            

        }
    }
}

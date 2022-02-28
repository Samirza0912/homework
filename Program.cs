using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int qaliq = a % 3;
           
            if (qaliq == 0)
            {
                Console.WriteLine("yes");
            } 
            else
            {
                Console.WriteLine("no");
            }






            int b = 18;
            int qal = b % 3;
            int qal1 = b % 2; 
            if (qal == 0 && qal1 == 0)
            {
                Console.WriteLine("3-e bolunur, cutdur");
            }
            else if (qal == 0 && qal1 != 0)
            {
                Console.WriteLine("3-e bolunur, tekdir");
            }
            else
            {
                Console.WriteLine("3-e bolunmur");
            }







            int c = 155;
            int d = 29;
            int sum = c + d;
            if (sum >= 10 && sum < 100)
            {
                Console.WriteLine("sum is 2-reqemli");
            }
            else if (sum >= 100 && sum < 1000)
            {
                Console.WriteLine("sum is 3-reqemli");
            }
            else
            {
                Console.WriteLine("nezere alinmayib");
            }






            int e = 2587;
            
            if (e >= 1 && e < 10)
            {
                Console.WriteLine("1-reqemli");
            }
            else if (e >= 10 && e < 100)
            {
                Console.WriteLine("2-reqemli");
            }
            else if (e >= 100 && e < 1000)
            {
                Console.WriteLine("3-reqemli");
            }
            else if (e >= 1000 && e < 10000)
            {
                Console.WriteLine("4-reqemli");
            }
            else if (e >= 10000 && e < 100000)
            {
                Console.WriteLine("5-reqemli");
            }
            else
            {
                Console.WriteLine("invalid");
            }







            int f = 45;
            int g = 23;
            int bolunme = f % g;
            if (bolunme == 0)
            {
                Console.WriteLine("bolunur");
            }
            else
            {
                Console.WriteLine("bolunmur");
            }


        }
    }
}

using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int a = 0;
            int i = 0;
            int o = 0;
            int e = 0;
            for (int r = 0; r < str.Length; r++)
            {
                if (str[r] == 'a')
                {
                    a = a + 1;
                }
                if (str[r] == 'i')
                {
                    i = i + 1;
                }
                if (str[r] == 'o')
                {
                    o = o + 1;
                }
                if (str[r] == 'e')
                {
                    e = e + 1;
                }
            }
            Console.WriteLine("count of a=" + a);
            Console.WriteLine("count of i=" + i);
            Console.WriteLine("count of o=" + o);
            Console.WriteLine("count of e=" + e);
            //task 2
            Console.WriteLine("task2:");
            Console.WriteLine(" Enter the number of mounth:");
            string str1 = Console.ReadLine();
            int numb = Convert.ToInt32(str1);
            Console.WriteLine(" Enter the number of year:");
            string str2 = Console.ReadLine();
            int y = Convert.ToInt32(str2);
            if ((y % 4 == 0) && (numb == 2))
            {
                Console.WriteLine("29");
            }
            if ((numb == 2) && (y % 4 != 0))
            {
                Console.WriteLine("28");
            }
            if (((numb % 2) == 1) && (numb < 8)) {
                Console.WriteLine("31");
            }
            if (((numb % 2) == 0) && (numb < 8) && (numb != 2))
            {
                Console.WriteLine("30");
            }
            if ((numb >= 8) && ((numb % 2) == 1))
            {
                Console.WriteLine("30");
            }
            if ((numb >= 8) && ((numb % 2) == 0))
            {
                Console.WriteLine("31");
            }
            //task 3
            int[] mass = new int[10];
            int summ = 0;
            int mult = 0;
            bool ispos;
            Console.WriteLine("input 10 integer numbers");
            for (int f = 0; f < mass.Length; f++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }
            foreach (int iter in mass)
            {
                if (iter < 0)
                {
                    ispos = false;


                    if (ispos)
                    {
                        for (int f = 0; f <= 4; f++)
                        {
                            summ += mass[i];
                        }

                    }
                }

            
             
            else
            {
                for (int f = 5; f < mass.Length; f++)
                {
                    mult *= mass[i];
                }
                Console.WriteLine("product of last 5 elements =" + mult);
            }
            Console.WriteLine("summ of first five elements =" + summ);
        }
    }
}


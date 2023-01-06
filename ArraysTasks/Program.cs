using System.Globalization;

namespace ArraysTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int[] mass = new int[n];

            //for (int i = 0; i < mass.Length; i++)
            //{
            //    Console.Write($"mass[{i}]=");
            //    mass[i] = int.Parse(Console.ReadLine());
            //}


            #region Sade 10

            //int max = 0;

            ////4 4 3
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    if (mass[max] <= mass[i])
            //        max = i;
            //}

            //Console.WriteLine($"1. max index={max}");

            #endregion

            #region Orta 1

            ////2 4 8 16 32 64  q=2 

            //double q = (double)mass[1] / mass[0];
            //double q1;
            ////bool hendesiSilsiledir = true;
            //int k = 1;
            //int count = 0;

            //for (int i = 1; i < mass.Length - 1; i++)
            //{
            //    q1 = (double)mass[i + 1] / mass[i];

            //    if (q != q1)
            //    {
            //        Console.WriteLine("Hendesi silsile deyil!");
            //        k = 0;
            //        //hendesiSilsiledir = false;
            //        break;
            //    }
            //    else
            //    {
            //        count++;
            //    }
            //}

            //if (count == mass.Length - 2)
            //    Console.WriteLine("hendesi silsiledir");

            //    //if (hendesiSilsiledir)
            //    //    Console.WriteLine("hendesi silsiledir");

            //    //if (k == 789)
            //    //    Console.WriteLine("hendesi silsiledir");

            #endregion

            #region xx

            //int x=int.Parse(Console.ReadLine());
            //int count = 0;
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    if (mass[i]==x)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            #endregion

            #region Ededi orta
            //double edediOrta = (double)mass.Sum() / mass.Length;
            //double max = edediOrta - mass[0];
            //int min = mass[0];
            //for (int i = 1; i < mass.Length; i++)
            //{
            //    //if (max < edediOrta - mass[i])
            //    //    max = edediOrta - mass[i];

            //    if (min > mass[i])
            //        min = mass[i];
            //}

            //Console.WriteLine(edediOrta - min);
            #endregion

            #region Axrinci musbet

            //int axrinciMusbetIndeks;

            ////for (int i = 0; i < mass.Length; i++)
            ////{
            ////    if (mass[i] > 0)
            ////        axrinciMusbetIndeks = i;
            ////}

            //for (int i = mass.Length-1; i >=0; i--)
            //{
            //    if (mass[i] > 0)
            //    {
            //        axrinciMusbetIndeks = i;
            //        break;
            //    }
            //}

            #endregion

            #region Simmetrik ededler

            //int reverseNumber;
            //int tmp,r,digitCount;
            ////123
            ////321 3*10^2 + 2*10^1 + 1*10^0
            ////52
            ////25 2*10^1+5*10^0
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    tmp = mass[i];
            //    digitCount = (int)Math.Log10(tmp);
            //    reverseNumber = 0;

            //    while (tmp != 0)
            //    {
            //        r = tmp % 10;
            //        tmp /= 10;

            //        reverseNumber += r * (int)Math.Pow(10, digitCount--);
            //    }

            //    if (mass[i] == reverseNumber)
            //        Console.WriteLine(mass[i]);
            //}

            #endregion
            //1(0) 2(1) 3(2) 5(3)
            //
            //12(0,0) 45(0,1)
            //36(1,0) 85(1,1) 

            //int[,] mass = 
            //{ 
            //    { 1, 2 },
            //    { 45, 678 } 
            //};

            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] mass = new int[m, n];
            //mass[0, 0] = 1;
            //mass[1, 0] = 2;
            //mass[1, 2] = 45;
            //int[,,] xyz = new int[2, 2, 2];

            //mass[1, 1] = 100;
            //Console.WriteLine(mass[1, 1]);

            int sum = 0;

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write($"mass[{i},{j}]=");
                    mass[i, j] = int.Parse(Console.ReadLine());

                    if (i == j)
                        sum += mass[i, j];
                }
            }

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write($"{mass[i, j], -8}");
                }

                Console.WriteLine();
            }

            Console.WriteLine(sum);
        }
    }
}
using System;

namespace Task_Methods
{
    class Methods
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 25 };

            //Task_1
            Dividing3Or7(21);

            //Task_2
            Console.WriteLine(SumOfEvenNumbers(2, 4));

            //Task_3
            Console.WriteLine(CountOddNumbers(3, 5));

            //Task_4
            Console.WriteLine(FindOddNumbersSum(3, 5));

            //Task_5
            Console.WriteLine(FindOddNumbersSumInArray(arr));

            //Task_6
            Console.WriteLine(CountEvenNumbersInArray(arr));

            //Task_7
            PrimeOrComplex(6);

            //Task_8
            TheNumberIsPowerOf2(16, 2);

            //Task_9
            Console.WriteLine(FindResOfNumbersBetween1And20(arr));

            //Task_10
            Console.WriteLine(FindSquareOfResOfEvenNumbers(arr));

        }

        //Task_1
        public static void Dividing3Or7(int n)
        {
            if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine("n can divide 3 and 7 at the same time");
            }
            else
            {
                Console.WriteLine("n isn't dividing 3 or 7 or each of them");
            }
        }

        //Task_2
        public static int SumOfEvenNumbers(int n, int m)
        {
            int sum = 0;
            if (n % 2 == 0 && m % 2 == 0)
            {
                sum = n + m;
            }
            return sum;
        }

        //Task_3
        public static int CountOddNumbers(int n, int m)
        {
            int cnt = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 2 != 0)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        //Task_4
        public static int FindOddNumbersSum(int n, int m)
        {
            int sum = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        //Task_5
        public static int FindOddNumbersSumInArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        //Task_6
        public static int CountEvenNumbersInArray(int[] arr)
        {
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        //Task_7
        public static void PrimeOrComplex(int n)
        {
            int cnt = 0;
            if (n > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt > 2)
                {
                    Console.WriteLine("n is complex number");
                }
                else
                {
                    Console.WriteLine("n is prime number");
                }
            }
            else
            {
                Console.WriteLine("Please, write correct number");
            }
        }

        //Task_8
        public static void TheNumberIsPowerOf2(int n, int i)
        {
            if (n < 1)
            {
                Console.WriteLine("Please, add correct number");
            }
            else
            {
                while (i < n)
                {
                    i *= 2;

                }
                if (i == n)
                {
                    Console.WriteLine("Yes, n is the power of 2!");
                }
                else
                {
                    Console.WriteLine("No, n isn't the power of 2!");
                }
            }

        }

        //Task_9
        public static int FindResOfNumbersBetween1And20(int[] arr)
        {
            int res = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 1 && arr[i] <= 20)
                {
                    res *= arr[i];
                }
            }
            return res;
        }

        //Task_10
        public static int FindSquareOfResOfEvenNumbers(int[] arr)
        {
            int res = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            res = sum * sum;
            return res;
        }
    }
}


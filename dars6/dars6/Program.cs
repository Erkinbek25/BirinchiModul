namespace dars6
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // ------------------ Homework ---------------

            // 1.6.1.1
            //float res1 = Add(3.5f, 6.4f);  
            //float res2 = Add(3.5f, 6.4f, 7.5f);  
            //string res3 = Add("Salom" , "Erkin"); 
            //Console.WriteLine(res1);      
            //Console.WriteLine(res2);      
            //Console.WriteLine(res3);      

            // 1.6.1.2

            //Repeat(5, 3);
            //Repeat(5);

            // 1.6.1.3
            //Console.WriteLine(calculate(7,8,1));

            // 1.6.1.4

            //Console.WriteLine(GetAmountDigit("SAdg12%jg3ds"));
            //Console.WriteLine(GetAmountDigit(3212));

            // 1.6.1.5

            //Console.WriteLine(FindMax(1, 5 , 7));
            //Console.WriteLine(FindMax(1, 5 , 7, 8) );
            //Console.WriteLine(FindMax(1, 5 , 7, 8, 99));

            // 1.6.1.6

            //Console.WriteLine(Multiplication(4));
            //Console.WriteLine(Multiplication(2,5));
            //Console.WriteLine(Multiplication(2,3,1));

            // 1.6.1.7

            //Console.WriteLine(CountNumRoom(123));

            // 1.6.1.8

            //Console.WriteLine(SummAB(2,4));
            //Console.WriteLine(SummAB1(2,4));

            // 1.6.1.9

            //Console.WriteLine(SummCubNums(5));
            //Console.WriteLine(SummCubNums1(5));

            // 1.6.1.10

            //int max = Max(-500, -90);
            //Console.WriteLine(max);

            // 1.6.1.11

            //Console.WriteLine(Abc(-9));

            // 1.6.1.12

            //Console.WriteLine(IsUpper('A'));

            // 1.6.1.13

            //Console.WriteLine(ToUpper('h'));

            // 1.6.1.14

            // Console.WriteLine(IsDigit('7'));

            // 1.6.1.16

            //Console.WriteLine(ToLower('H'));

            // 1.6.1.15
            //Console.WriteLine(IsLower('f'));

            // 1.6.1.17

            // Console.WriteLine(Pow(3,3));
        }
        static int Pow ( int a, int b)
        {
            int res = 1;
            for (var i = 0; i < b; i++)
            {
                res *= a;
            }
            return res;
        }
        static bool IsLower(char ch)
        {

            return 'a' <= ch && ch <= 'z';
        }
        static char ToLower(char ch)
        {
            if ( ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
            }
            return ch;
        }
        static bool IsDigit(char ch)
        {

            return '0' <= ch && ch <= '9';
        }

        static char ToUpper( char ch)
        {
            if (ch >= 'a' && ch <= 'z')
            {
                ch = (char)(ch - 32);
            }
            return ch;

        }
        static bool IsUpper(char ch)
        {
            
            return 'A' <= ch && ch <= 'Z';
        }
        static int Abc(int a)
        {
            return a < 0 ? -1 * a : a;
        }

        static int Max(int a, int b)
        {
            int max = int.MinValue;
            if (a > b)
            {
                max = a;
            }
            else max = b;
            return max;
        }
        static int SummCubNums1(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            return a * a * a + SummCubNums1(a - 1);
        }
        static int SummCubNums(int a)
        {
            var summ = 0;
            for (var i = 1; i <= a; i++)
            {
                summ += i * i * i;
            }
            return summ;
        }
        static int SummAB1(int a, int b)
        {   /// 12345
            if (a == b - 1)
            {
                return 0;
            }
            return a + 1 + SummAB(a + 1, b);
        }
        static int SummAB(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            return a + SummAB(a + 1, b);
        }
        static int CountNumRoom(int a)
        {
            if (-9 <= a && a <= 9)
            {
                return 1;
            }
            return 1 + CountNumRoom(a / 10);
        }
        static int Multiplication(int n)
        {
            int summ = 1;
            for (var i = 1; i <= n; i++)
            {
                summ *= i;
            }
            return summ;
        }
        static int Multiplication(int n, int m)
        {
            int summ = 1;
            for (var i = n; i <= m; i++)
            {
                summ *= i;
            }
            return summ;
        }
        static int Multiplication(int n, int m, int x)
        {
            int summ = n * m * x;

            return summ;
        }


        static int FindMax(int a, int b, int c)
        {
            int max = Math.Max(a, Math.Max(b, c));
            return max;
        }
        static int FindMax(int a, int b, int c, int d, int e)
        {
            int max = Math.Max(Math.Max(b, c), FindMax(a, d, e));
            return max;
        }
        static int FindMax(int a, int b, int d, int c)
        {
            int max = Math.Max(Math.Max(a, d), Math.Max(b, c));
            return max;
        }
        static int GetAmountDigit(string str)
        {
            var count = 0;
            for (var i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    count++;
                }
            }
            return count;
        }
        static int GetAmountDigit(int number)
        {
            string num = number.ToString();
            return num.Length;
        }

        static void Repeat(int a, int b)
        {
            for (int i = 0; i < b; i++)
            {
                Console.Write(" " + a);
            }
            Console.WriteLine();
        }
        static void Repeat(int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write(" " + a);
            }

        }








        static int multiplication(int num1, int num2, int num3)
        {

            return num1 * num2 * num3;
        }
        static int multiplication(int num1, int num2)
        {
            int summ = 1;
            for (int i = num1; i <= num2; i++)
            {
                summ *= i;
            }
            return summ;
        }


        static int multiplication(int num1)
        {
            int summ = 1;
            for (int i = 1; i <= num1; i++)
            {
                summ *= i;
            }
            return summ;
        }


        static int calculate(int num1, int num2)
        {

            return num1 + num2;
        }
        static int calculate(int num1, int num2, int num3)
        {

            return num1 * num2 * num3;
        }

        static float Add(float num1, float num2)
        {
            float res = num1 + num2;

            return res;
        }

        static float Add(float num1, float num2, float num3)
        {
            float res = num1 + num2 + num3;
            return res;
        }

        static string Add(string str1, string str2)
        {
            string res = str1 + str2;

            return res;
        }
    }
}

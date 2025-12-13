namespace dars6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float res = Add(3.5f, 6.4f); // 1 
            //Console.WriteLine(res);      

            //Console.WriteLine(calculate(7,8,1)); // 2

            //Console.WriteLine(multiplication(2,3,4)); // 3


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
            for ( int i = 1; i <= num1; i++)
            {
                summ *= i;
            }
            return summ;
        }


        static int calculate ( int num1 , int num2)
        {

            return num1 + num2;
        }
        static int calculate ( int num1 , int num2, int num3)
        {

            return num1 * num2 * num3;
        }

        static float Add( float num1, float num2)
        {
            float res = num1 + num2;

            return res;
        }

        static float Add( float num1, float num2, float num3)
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

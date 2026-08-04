namespace Dars4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1.4.0.1

            //Console.WriteLine(joinstring("Salom", "Erkin"));

            // 1.4.0.2

            //Console.WriteLine(changeXtoY("xxyyzz"));

            // 1.4.0.3

            //Console.WriteLine(CountLetter("asdfko"));

            // 1.4.0.6
            //Console.WriteLine(CheckTubNum(14));


            // C belgisi va S1, S2 satrlari berilgan.
            // S1 satriga shu satrda uchragan har bir C belgisidan oldin S2 satrini qo'shuvchi programma tuzilsin.


            //Console.WriteLine(GetString(" Erckinc" , "Bek"));

            Console.WriteLine(masala8("oqqoraoq", "qora", "yashil"));
        }

        static string masala8(string str1, string str2, string str3)
        {
            int Str2 = str2.Length;
            for (int i = 0; i <= str1.Length - Str2; i++)
            {
                if (str1.Substring(i, Str2) == str2)
                {
                    str1 = str1.Replace(str2, str3);
                    break;
                }
                // else { Console.WriteLine(" Birinchi satr ichida ikkinchi satr ishtirok etmagan"); break; }
            }

            return str1;

        }

        static string GetString ( string str, string str2)
        {
            string res = string.Empty;

            for ( var i =0; i < str.Length; i++)
            {
                if (str[i] == 'c')
                {
                    res += str2;
                    res += 'c';
                }
                else { res += str[i]; }
            }

            return res;
        }
        static bool CheckTubNum(int n)
        {
            int count = 0;
            bool res = false;
            for (int i = 1; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    count++;
                }

            }
            if (count == 1)
            {
                res = true;
            }
            return res;
        }

        static int CountLetter(string str)
        {
            int count = 0;
            for (var i = 0; i < str.Length; i++)
            {
                if ('a' < str[i] && 'z' > str[i])
                {
                    count++;
                }

            }
            return count;
        }

        static string changeXtoY(string str)
        {
            string res = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == 'y' || str[i] == 'Y')
                {
                    res += 'z';
                }
                else if (str[i] == 'x' || str[i] == 'X')
                {
                    res += 'y';
                }
                else { res += str[i]; }
            }
            return res;
        }
        static string joinstring(string s1, string s2)
        {
            string res = s1 + s2;
            return res;
        }




















    }





}

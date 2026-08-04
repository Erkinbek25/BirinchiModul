namespace ModulOneExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 masala 

            //List<int> Nums = new List<int>() { 1,5,4,6,8,7,4,2,8};
            //Console.WriteLine(CountEvenNums(Nums));

            // 2 masala
            //List<string> str = new List<string>() { "asgffs", "sdfgfg", "sdfcv" };
            //Console.WriteLine(LengthString(str));

            // 3 masala
            //string str = "BekJon";
            //Console.WriteLine(GetThreeChar(str));

            // 4 masala
            //string str = "Erkinbek Hasanov";
            //Console.WriteLine(StartPdp(str));

            // 5 masala

            //string str = "SalomG13!!!";
            //Console.WriteLine(FindG13(str));


            // 6 masala
            List<int> Numbers = new List<int>() { 4, 5, 6, 9, 7 };
            Console.WriteLine(SummFirstSecond(Numbers));
        }

        static int SummFirstSecond(List<int> nums)
        {
            int summ = nums[0] + nums[1];
            return summ;

        }
        static bool FindG13(string str)
        {
            bool res = false;
            for (var i = 0; i < str.Length - 3; i++)
            {
                if (str.Substring(i, 3) == "G13")
                {
                    res = true;
                }
            }
            return res;
        }

        static bool StartPdp(string str)
        {
            bool res = false;
            if (str.Substring(0, 8) == "Erkinbek")
            {
                res = true;
            }

            return res;
        }
        static string GetThreeChar(string str)
        {
            string res = string.Empty;
            res = str.Substring(0, 3);
            return res;
        }

        static bool LengthString(List<string> str)
        {
            bool res = true;
            foreach (var text in str)
            {
                if (text.Length < 5)
                {
                    res = false;
                }
            }


            return res;
        }
        static int CountEvenNums(List<int> nums)
        {
            int count = 0;
            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }
        static List<int> FillListWithConsoleValues(List<int> nums, int len)
        {
            for (var i = 0; i < len; i++)
            {
                Console.Write($" {i} : ");
                nums.Add(int.Parse(Console.ReadLine()));
            }
            return nums;
        }


        static void DisplayList(List<string> nums)
        {
            foreach (var num in nums)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }


    }
}

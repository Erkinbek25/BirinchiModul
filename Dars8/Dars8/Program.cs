namespace Dars8
{
    internal class Program
    {
        /// CRUD => Create Read Update Dekete
        static List<string> Ids = new List<string>();
        static void Main(string[] args)
        {
            var newId = string.Empty;
            var oldId = string.Empty;

            while (true)
            {
                Console.WriteLine("1. Add id");
                Console.WriteLine("2. Delete id");
                Console.WriteLine("3. Display id");
                Console.WriteLine("4. Update id");
                Console.WriteLine("5. Quit ");
                Console.WriteLine(" Kriting : ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write(" Id ni kriting : ");
                    newId = Console.ReadLine();
                    var res = ValidateId(newId);
                    var exists = Ids.Contains(newId);

                    if (res == true && exists == false)
                    {
                        Ids.Add(newId);
                        Console.WriteLine("Id muvaffaqiyatli  qo'shildi. ");
                    }
                    else
                    {
                        Console.WriteLine("Id noto'g'ri formatda");
                    }

                }

                else if (choice == 2)
                {
                    Console.Write("Id ni kriting: ");
                    newId = Console.ReadLine();
                    var exists = Ids.Contains(newId);
                    if (exists == true)
                    {
                        DeleteId(newId);
                        Console.WriteLine("Id muvaffaqiyatli o'chirildi.");
                    }
                    else
                    {
                        Console.WriteLine("Bunday id mavjud emas.");
                    }


                }

                else if (choice == 3)
                {
                    DisplayIds();
                }

                else if ( choice == 4)
                {
                    Console.Write("Eski id ni kriting : ");
                    oldId = Console.ReadLine();
                    Console.WriteLine("Yangi id ni kriting : ");
                    newId = Console.ReadLine();
                    var validateRes = ValidateId(newId);
                    var exists = Ids.Contains(oldId);


                    if (validateRes == true && exists == true)
                    {
                        UpdateId(oldId, newId);
                        Console.WriteLine("Id muvaffaqiyatli yangilandi.");

                    }
                    else
                    {
                        Console.WriteLine(" Id yangilashda xatolik yuz berdi. ");
                    }



                }
                else
                {
                    Console.WriteLine("Davay");
                    break;
                }

                    Console.ReadKey();
                Console.Clear();

            }
        }

        static void DeleteId(string id)
        {
            Ids.Remove(id);
        }

        static void Add(string id)
        {
            Ids.Add(id);

        }

        static void DisplayIds()
        {
            foreach (var id in Ids)
            {
                Console.WriteLine(id);
            }
            Console.WriteLine();
        }

        static void UpdateId(string oldId, string newId)
        {
            var index = Ids.IndexOf(oldId); // AE1234565
            if (index != -1)
            {
                Ids[index] = newId;

            }

        }

        static bool ValidateId(string id)
        {
            if (id.Length != 9)
            {
                return false;
            }

            if (!char.IsUpper(id[0]) || !char.IsUpper(id[1]))
            {
                return false;
            }

            for (int i = 2; i < id.Length; i++)
            {
                if (!char.IsDigit(id[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

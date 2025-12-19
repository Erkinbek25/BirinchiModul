namespace Dars10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ----------- People -----------------

            // 1. Dasturchi
            Person person1 = new Person()
            {
                FullName = "Ali Valiyev",
                Age = 28,
                Gender = "Erkak",
                PhoneNumber = "+998901234567",
                Email = "ali.valiyev@gmail.com",
                Address = "Toshkent, Yunusobod tumani",
                Occupation = "Senior Dasturchi",
                Education = "Oliy (TATU)",
                BirthDate = new DateTime(1996, 5, 15),
                Nationality = "O'zbek"
            };

            // 2. O'qituvchi
            Person person2 = new Person()
            {
                FullName = "Zarina Xolmirzayeva",
                Age = 35,
                Gender = "Ayol",
                PhoneNumber = "+998902345678",
                Email = "zarina.x@mail.ru",
                Address = "Samarqand, Registon ko'chasi",
                Occupation = "Matematika o'qituvchisi",
                Education = "Oliy (SamDU)",
                BirthDate = new DateTime(1989, 8, 22),
                Nationality = "O'zbek"
            };

            // 3. Talaba
            Person person3 = new Person()
            {
                FullName = "Javohir Ismoilov",
                Age = 20,
                Gender = "Erkak",
                PhoneNumber = "+998903456789",
                Email = "javohir.i@student.uz",
                Address = "Buxoro, B. Naqshband ko'chasi",
                Occupation = "Talaba",
                Education = "Oliy talaba (BuxDU)",
                BirthDate = new DateTime(2004, 1, 10),
                Nationality = "O'zbek"
            };

            // 4. Biznesmen
            Person person4 = new Person()
            {
                FullName = "John Smith",
                Age = 42,
                Gender = "Erkak",
                PhoneNumber = "+11234567890",
                Email = "john.smith@company.com",
                Address = "New York, 5th Avenue",
                Occupation = "CEO - TechCorp",
                Education = "MBA Harvard University",
                BirthDate = new DateTime(1982, 11, 30),
                Nationality = "American"
            };

            // 5. Shifokor
            Person person5 = new Person()
            {
                FullName = "Madina Karimova",
                Age = 32,
                Gender = "Ayol",
                PhoneNumber = "+998904567890",
                Email = "dr.madina@hospital.uz",
                Address = "Andijon, Bobur shox ko'chasi",
                Occupation = "Kardioloq shifokor",
                Education = "Oliy (Andijon tibbiyot instituti)",
                BirthDate = new DateTime(1992, 3, 8),
                Nationality = "O'zbek"
            };

            // Listga joylash
            List<Person> people = new List<Person> { person1, person2, person3, person4, person5 };

            // Ekranga chiqarish
            Console.WriteLine("5 ta odam ma'lumotlari:\n");

            int counter = 1;
            foreach (Person person in people)
            {
                Console.WriteLine($"=== Odam {counter} ===");
                Console.WriteLine($"To'liq ism: {person.FullName}");
                Console.WriteLine($"Yoshi: {person.Age}");
                Console.WriteLine($"Jinsi: {person.Gender}");
                Console.WriteLine($"Telefon: {person.PhoneNumber}");
                Console.WriteLine($"Email: {person.Email}");
                Console.WriteLine($"Manzil: {person.Address}");
                Console.WriteLine($"Kasbi: {person.Occupation}");
                Console.WriteLine($"Ma'lumoti: {person.Education}");
                Console.WriteLine($"Tug'ilgan sana: {person.BirthDate:dd.MM.yyyy}");
                Console.WriteLine($"Millati: {person.Nationality}");
                Console.WriteLine();
                counter++;
            }
        


        // ----------- TV Series -----------------

        TvSeries serie6 = new TvSeries();
            serie6.Title = "Prison Break";
            serie6.ReleasedDate = "August 29, 2005";
            serie6.Language = "English";
            serie6.Genres = new string[] { "Crime drama", " Action thriller" };
            serie6.Duration = 42-44;
            serie6.Country = "US";
            serie6.CreatedBy = "Paul Scheuring";
            serie6.Rating = 8.3;
            serie6.Seasons = 5;
            serie6.Episodes = 90;


            TvSeries serie5 = new TvSeries();
            serie5.Title = "How I Met Your Mother";
            serie5.ReleasedDate = "September 19, 2005";
            serie5.Language = "English";
            serie5.Genres = new string[] { "Sitcom", "Romantic comedy", " Comedy drama" };
            serie5.Duration = 22;
            serie5.Country = "US";
            serie5.CreatedBy = "Pamela Fryman, Rob Greenberg";
            serie5.Rating = 8.3;
            serie5.Seasons = 9;
            serie5.Episodes = 208;

            TvSeries serie4 = new TvSeries();
            serie4.Title = "The Office";
            serie4.ReleasedDate = "March 24, 2005";
            serie4.Language = "English";
            serie4.Genres = new string[] { "Sitcom", "Workplace comedy", "Cringe comedy", "Mockumentary" };
            serie4.Duration = 20-42;
            serie4.Country = "US";
            serie4.CreatedBy = "Greg Daniels";
            serie4.Rating = 9.0;
            serie4.Seasons = 9;
            serie4.Episodes = 201;

            TvSeries serie3 = new TvSeries();
            serie3.Title = "Friends";
            serie3.ReleasedDate = "September 22, 1994";
            serie3.Language = "English";
            serie3.Genres = new string[] { "Sitcom" };
            serie3.Duration = 20-22;
            serie3.Country = "US";
            serie3.CreatedBy = "David Crane";
            serie3.Rating = 9.7;
            serie3.Seasons = 10;
            serie3.Episodes = 235;
            


            TvSeries serie2 = new TvSeries();
            serie2.Title = "Breaking Bad";
            serie2.ReleasedDate = "January 20, 2008";
            serie2.Language = "English";
            serie2.Genres = new string[] { "Drama", "Crime", " Thriller", "Black Comedy", "Neo-Western" };
            serie2.Duration = 43 - 58;
            serie2.Country = "US";
            serie2.CreatedBy = "Vince Gilligan";
            serie2.Rating = 9.5;
            serie2.Seasons = 5;
            serie2.Episodes = 62;
            serie2.Budget = 3; // million per episode 


            TvSeries serie1 = new TvSeries();
            serie1.Title = "Game of Thrones";
            serie1.ReleasedDate = "April 17, 2011";
            serie1.Language = "English";
            serie1.Genres = new string[] { "Action", "Adventure", "Fantasy", "Serial drama", "Tragedy" };
            serie1.Duration = 50 - 82;
            serie1.Country = "US";
            serie1.CreatedBy = "David Benioff";
            serie1.Rating = 9.2;
            serie1.Seasons = 8;
            serie1.Episodes = 74;



            // ------------ Movies -------------------

            Movies movie6 = new Movies()
            {
                Title = "Pirates of the Caribbean: The Curse of the Black Pearl",
                ReleasedDate = "June 28, 2003  ",
                Country = "US",
                Language = "English",
                Genres = new string[]{ "Action", "Adventure" },
                Duration = 143,
                Director = "Gore Verbinski",
                Rating = 8.1,
                Budget = 140,
                BoxOffice = 654.3,

            };
            Movies movie5 = new Movies()
            {
                Title = "The Lord of the Rings: The Fellowship of the Ring",
                ReleasedDate = "10 December 2001  ",
                Country = "US",
                Language = "English",
                Genres = new string[]{ "Fantasy", "Adventure" },
                Duration = 178,
                Director = "Peter Jackson",
                Rating = 8.9,
                Budget = 93,
                BoxOffice = 887.8,

            };
            Movies movie4 = new Movies()
            {
                Title = "The Godfather",
                ReleasedDate = "March 14, 1972 ",
                Country = "US",
                Language = "English",
                Genres = new string[]{ "Crime" },
                Duration = 175,
                Director = "Francis Ford Coppola",
                Rating = 9.2,
                Budget = 7,
                BoxOffice = 291,

            };
            Movies movie3 = new Movies()
            {
                Title = "The Matrix",
                ReleasedDate = "March 24, 1999 ",
                Country = "US",
                Language = "English",
                Genres = new string[]{ "Action", "Sci-fi" },
                Duration = 136,
                Director = "The Wachowskis",
                Rating = 8.7,
                Budget = 63,
                BoxOffice = 467.8,

            };
            Movies movie2 = new Movies()
            {
                Title = "Fight Club",
                ReleasedDate = "September 10, 1999",
                Country = "US",
                Language = "English",
                Genres = new string[]{ "Action", "Crime" },
                Duration = 139,
                Director = "David Fincher",
                Rating = 8.8,
                Budget = 65,
                BoxOffice = 101,

            };
            Movies movie1 = new Movies()
            {
                Title = "Interstellar",
                ReleasedDate = "October 26, 2014",
                Country = "US",
                Language = "English",
                Genres = new string[]{"Dramma", "Sci-fi/Adventure" },
                Duration = 169,
                Director = "Christopher Nolan",
                Rating = 8.7,
                Budget = 165,
                BoxOffice = 771,

            };




            // ---------- Countries -------------------


            Countries France = new Countries()
            {
              Capital = "Paris",
              President = "Emmonuel Macron",
              Population = " 68.52 million",
              Language = "French",
              GDP = "3.162 trillion USD",
              Government = "Unitary state, Semi-presidential system",
              DialingCode = "+33",
              Nationality = "French",
              Religion = "Christianity",
              Currency = "EURO",
              Area = "632,702.3 km2",

            };

            Countries Germany = new Countries()
            {
              Capital = "Berlin",
              President = "Frank-Walter Steinmeier",
              Population = " 83.51 million",
              Language = "German",
              GDP = "4.66 trillion USD",
              Government = "Federal parliamentary republic",
              DialingCode = "+49",
              Nationality = "German",
              Religion = "Christianity",
              Currency = "EURO",
              Area = "357,022 km2",

            };
            Countries Uzbekistan = new Countries()
            {
              Capital = "Toshkent",
              President = "Shavkat Mirziyoyev",
              Population = " 36.36 million",
              Language = "Uzbek",
              GDP = "115 billion USD",
              Government = "Presidential system ",
              DialingCode = "+998",
              Nationality = "Uzbek",
              Religion = "Islam",
              Currency = "UZS or SUM",
              Area = "448,978 km2",

            };
            Countries Canada = new Countries()
            {
              Capital = "Ottawa",
              President = " Charles III",
              Population = " 41.29 million",
              Language = "English",
              GDP = "2.241 trillion USD",
              Government = "Monarch ",
              DialingCode = "+1",
              Currency = "Canadian dollar ($) (CAD)",
              Area = "9,984,670 km2",

            };
            Countries Japan = new Countries()
            {
              Capital = "Tokyo",
              President = "Shavkat Mirziyoyev",
              Population = " 124 million",
              Language = "Japanese",
              GDP = "6.758 trillion USD",
              Government = "Unitary parliamentary constitutional monarchy ",
              DialingCode = "+81",
              Currency = "Japanese yen (¥)",
              Area = "377,976 km²",

            };

            Countries UAE = new Countries()
            {
                Capital = "Abu Dhabi",
                President = "Mohammed bin Zayed Al Nahyan",
                Population = " 10.88 million",
                Language = "Arabic",
                GDP = "905.23 billion USD",
                Government = "Emirate, Monarchy, Absolute monarchy ·",
                DialingCode = "+971",
                Nationality = "South Asian",
                Religion = "Islam",
                Currency = "UAE dirham (AED)",
                Area = "83,600 km2",

            };
            Countries Turkiye = new Countries()
            {
                Capital = "Ankara",
                President = "Recep Tayyip Erdoğan",
                Population = " 85.52 million",
                Language = "Turkish",
                GDP = "3.77 trillion USD",
                Government = "Republic, Unitary state, Representative democracy, Presidential system, Parliamentary republic",
                DialingCode = "+90",
                Nationality = "Turkish",
                Religion = "Islam",
                Currency = "Turkish lira",
                Area = "783,562 km2",

            };

            Countries Brazil = new Countries();
            Brazil.Capital = "Brasília";
            Brazil.Language = "Portuguese";
            Brazil.President = "Luiz Inácio Lula da Silva";
            Brazil.Population = "212 million";
            Brazil.GDP = "2.179 trillion USD";
            Brazil.DialingCode = "+55";
            Brazil.Area = "8,515,767 km2";
            Brazil.Government = "Federal presidential republic";

            // ------------------------- Anima Lion -----------------------------------

            Animal lion = new Animal()
            {
                Name = "Arslon",
                ScientificName = "Panthera leo",
                Species = "Yirik mushuklar",
                Breed = "Afrika arsloni",
                Weight = 190.5,
                Height = 120,
                Length = 250,
                Color = "Sariq-jigarrang",
                DistinctiveFeatures = new string[] { "Yelka qismida yung", "Erkagida yoli" },
                Habitat = "Savanna",
                Countries = new string[] { "Kenya", "Tanzaniya", "Janubiy Afrika" },
                ClimateZone = "Tropik",
                DietType = "Yirtqich",
                Foods = new string[] { "Zebra", "Antilopa", "Bizon" },
                DailyFoodIntake = 7.5,
                ReproductionType = "Tirik tug'ish",
                GestationPeriod = 110,
                AverageLitterSize = 3,
                Lifespan = 15,
                Age = 5,
                BirthDate = new DateTime(2019, 3, 15),
                Behaviors = new string[] { "Guruh bo'lib yashash", "Kunduzi faol" },
                IsNocturnal = false,
                IsDomestic = false,
                ConservationStatus = "Zaif (Vulnerable)",
                PopulationCount = 20000,
                Threats = new string[] { "Yashash joyining yo'qolishi", "Brakonyerlik" }
            };







            //Appliance Blendr1 = new Appliance()
            //{


            //    Color = "Black",
            //    Brand = "LG",
            //    Price = 200,
            //    MadeOf = "Plastic",
            //    MadeIn = "China",
            //    ProdusedDate = 2025,

            //};
            //Appliance Blendr = new Appliance();

            //Blendr.Color = "Black";
            //Blendr.Brand = "LG";
            //Blendr.Price = 200;
            //Blendr.MadeOf = "Plastic"; 
            //Blendr.MadeIn = "China";
            //Blendr.ProdusedDate = 2025;





        }

        /// -------------- LeetCode Example --------------------
        public string[] UncommonFromSentences(string s1, string s2)
        {
            List<string> words = new List<string>();
            words.AddRange(s1.Split(' '));
            words.AddRange(s2.Split(' '));

            List<string> result = new List<string>();

            foreach (var word in words)
            {
                var counter = words.Count(x => x == word);

                if (counter == 1)
                {
                    result.Add(word);
                }

            }

            return result.ToArray();


        }
    }
}

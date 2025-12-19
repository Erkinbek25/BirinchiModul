namespace Dars10;


internal class Animal
{
    // 1. Asosiy ma'lumotlar
    public string Name { get; set; }
    public string ScientificName { get; set; } // Ilmiy nomi
    public string Species { get; set; } // Turi
    public string Breed { get; set; } // Zoti

    // 2. Jismoniy xususiyatlar
    public double Weight { get; set; } // kg
    public double Height { get; set; } // sm
    public double Length { get; set; } // sm
    public string Color { get; set; }
    public string[] DistinctiveFeatures { get; set; } // O'ziga xos belgilar

    // 3. Yashash joyi
    public string Habitat { get; set; } // Yashash muhiti
    public string[] Countries { get; set; } // Tarqalgan mamlakatlar
    public string ClimateZone { get; set; } // Iqlim zoni

    // 4. Oziqlanish
    public string DietType { get; set; } // O'txo'r, Yirtqich, Hammaxo'r
    public string[] Foods { get; set; }
    public double DailyFoodIntake { get; set; } // kg

    // 5. Ko'payish
    public string ReproductionType { get; set; } // Tuxum qo'yish, Tirik tug'ish
    public int GestationPeriod { get; set; } // Homiladorlik davri (kun)
    public int AverageLitterSize { get; set; } // Bir vaqtda tug'iladigan bolalar

    // 6. Hayot davri
    public int Lifespan { get; set; } // Yil
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }

    // 7. Xatti-harakatlar
    public string[] Behaviors { get; set; }
    public bool IsNocturnal { get; set; } // Tunga hayvonmi
    public bool IsDomestic { get; set; } // Uy hayvonimi

    // 8. Muhofaza holati
    public string ConservationStatus { get; set; } // Yo'qolib ketish xavfi
    public int PopulationCount { get; set; }
    public string[] Threats { get; set; } // Xavflar
}
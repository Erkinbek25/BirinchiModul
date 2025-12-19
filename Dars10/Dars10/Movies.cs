namespace Dars10;

internal class Movies
{   
    // 1 Asosiy ma'lumotlar
    public string Title { get; set; }
    public string ReleasedDate { get; set; }
    public string Country { get; set; }
    public string Language { get; set; }

    // 2 Janr va kategoriya
    public string[] Genres { get; set; }
    public int Duration { get; set; } // minutlarda

    // 3 Yaratuvchilar

    public string Director { get; set; }

    // 4 Baholash

    public double Rating { get; set; }

    // 5 Moliyaviy 

    public double Budget { get; set; } // Budgeti mln USD
    public double BoxOffice { get; set; }  // Daromadi mln USD

    
}


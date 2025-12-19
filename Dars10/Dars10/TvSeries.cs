using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dars10
{
    internal class TvSeries
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

        public string CreatedBy { get; set; }

        // 4 Baholash

        public double Rating { get; set; }
        public int Seasons { get; set; }
        public int Episodes { get; set; }
        public double Budget { get; set; } // Budgeti mln USD

    }
}

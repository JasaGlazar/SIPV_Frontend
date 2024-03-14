using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPV_Frontend
{
    public class StatisticsClass
    {

        public string uporabnik { get; set; }

        public string refuelDay { get; set; }

        public int liters { get; set; }


        public StatisticsClass()
        {

        }

        public StatisticsClass(string uporabnik, string refuelDay, int liters)
        {
            this.uporabnik = uporabnik;
            this.refuelDay = refuelDay;
            this.liters = liters;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task1
{


    public class Film
    {
    }

    public class Movie : Film
    {
        public double Timekeeping = 0;
        public int NumberAwards = 0;
        
    }

    public class Series : Film
    {
        public int NumberSeasons = 0;
        public int BonesNumber = 0;
    }

    public class Telecast : Film
    {
        public double Duration = 0;
        public double AirTime = 0;
    }
}
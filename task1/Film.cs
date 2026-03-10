using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task1
{


    public class Film
    {
        public virtual String GetInfo()
        {
            return "Я Кино";
        }
    }

    public class Movie : Film
    {
        public double Timekeeping = 0;
        public int NumberAwards = 0;

        
        public override String GetInfo()
        {
            var str = "Я Фильм";
            str += String.Format("\nХронометраж{0}\nКол.Наград{1}", this.Timekeeping, this.NumberAwards);
            return str;
        }
    }

    public class Series : Film
    {
        public int NumberSeasons = 0;
        public int BonesNumber = 0;
        
        public override String GetInfo()
        {
            var str = "Я Cериал";
            str += String.Format("\nКол.Серий{0}\nКол.Сезонов{1}", this.BonesNumber, this.NumberSeasons);
            return str;
        }
    }

    public class Telecast : Film
    {
        public double Duration = 0;
        public double AirTime = 0;
        
        public override String GetInfo()
        {
            var str = "Я ТВ передача";
            str += String.Format("\nПродолжительность{0}\nЭфирное время{1}", this.Duration, this.AirTime);
            return str;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task1
{


    public class Film
    {
        public double Rating = 0;
        public virtual String GetInfo()
        {
           
            var str = String.Format("\nРейтинг {0}", this.Rating);
            return str;
        }
    }

    public class Movie : Film
    {
        public double Timekeeping = 0;
        public int NumberAwards = 0;

        
        public override String GetInfo()
        {
            var str = "Я Фильм";
            str += base.GetInfo();
            str += String.Format("\nХронометраж {0}\nКол.Наград {1}", this.Timekeeping, this.NumberAwards);
            return str;
        }

        public static Movie Generate()
        {
            var rnd = new Random();
            return new Movie
            {
                Rating = rnd.Next() % 101,
                Timekeeping = rnd.Next() % 101,
                NumberAwards = rnd.Next() % 101
            };
        }
    }

    public class Series : Film
    {
        public int NumberSeasons = 0;
        public int BonesNumber = 0;
        
        public override String GetInfo()
        {
            var str = "Я Cериал";
            str += base.GetInfo();
            str += String.Format("\nКол.Серий {0}\nКол.Сезонов {1}", this.BonesNumber, this.NumberSeasons);
            return str;
        }

        public static Series Generate()
        {
            var rnd = new Random();
            return new Series
            {
                Rating = rnd.Next() % 101,
                NumberSeasons = rnd.Next() % 101,
                BonesNumber = rnd.Next() % 101
            };
        }
    }

    public class Telecast : Film
    {
        public double Duration = 0;
        public double AirTime = 0;
        
        public override String GetInfo()
        {
            var str = "Я ТВ передача";
            str += base.GetInfo();
            str += String.Format("\nПродолжительность {0}\nЭфирное время {1}", this.Duration, this.AirTime);
            return str;
        }

        public static Telecast Generate()
        {
            var rnd = new Random();
            return new Telecast
            {
                Rating = rnd.Next() % 101,
                Duration = rnd.Next() % 101,
                AirTime = rnd.Next() % 101
            };
        }
    }
}
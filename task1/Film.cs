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
        public static Random rnd = new Random();
        public virtual String GetInfo()
        {
            var str = $"Рейтинг {this.Rating}\n";
            return str;
        }
    }

    public class Movie : Film
    {
        public double Timekeeping = 0;
        public int NumberAwards = 0;

        
        public override String GetInfo()
        {
            var str = "Я Фильм\n";
            str += base.GetInfo();
            str += $"Хронометраж {this.Timekeeping}\nКол.Наград {this.NumberAwards}";
            return str;
        }

        public static Movie Generate()
        {
            
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
            var str = "Я Cериал\n";
            str += base.GetInfo();
            str += $"Кол.Серий {this.BonesNumber}\nКол.Сезонов {this.NumberSeasons}";
            return str;
        }

        public static Series Generate()
        {
            
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
            var str = "Я ТВ передача\n";
            str += base.GetInfo();
            str += $"Продолжительность {this.Duration}\nЭфирное время {this.AirTime}";
            return str;
        }

        public static Telecast Generate()
        {
            
            return new Telecast
            {
                Rating = rnd.Next() % 101,
                Duration = rnd.Next() % 101,
                AirTime = rnd.Next() % 101
            };
        }
    }
}
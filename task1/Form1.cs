

namespace task1
{
    public partial class Form1 : Form
    {

        List<Film> filmList = new List<Film>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.filmList.Clear();
            var rnd = new Random();

            for (var i = 0; i < 5; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.filmList.Add(Movie.Generate());
                        break;
                    case 1:
                        this.filmList.Add(Series.Generate());
                        break;
                    case 2:
                        this.filmList.Add(Telecast.Generate());
                        break;

                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {

            int movieCount = 0;
            int seriesCount = 0;
            int telecastCount = 0;
            string line = "";
            this.filmList.Reverse();

            foreach (var film in this.filmList)
            {


                if (film is Movie)
                {
                    movieCount += 1;
                    line += film.GetInfo();
                    line += "\n\n";
                }
                else if (film is Series)
                {
                    seriesCount += 1;
                    line += film.GetInfo();
                    line += "\n\n";
                }
                else if (film is Telecast)
                {
                    telecastCount += 1;
                    line += film.GetInfo();
                    line += "\n\n";
                }
            }

            this.filmList.Reverse();


            txtInfo.Text = "Фильм\t\tСериал\t\tПередача";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t\t{1}\t\t{2}", movieCount, seriesCount, telecastCount);
            txtLine.Text = line;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.filmList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }


            var film = this.filmList[0];

            this.filmList.RemoveAt(0);

            txtOut.Text = film.GetInfo();

            ShowInfo();
        }

    }
}

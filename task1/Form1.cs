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

            for (var i = 0; i < 10; ++i)
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

            
            foreach (var film in this.filmList)
            {
                
                
                if (film is Movie) 
                {
                    movieCount += 1;
                }
                else if (film is Series)
                {
                    seriesCount += 1;
                }
                else if (film is Telecast)
                {
                    telecastCount += 1;
                }
            }

            
            txtInfo.Text = "Фильм\tСриал\tПрдач";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", movieCount, seriesCount, telecastCount);
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

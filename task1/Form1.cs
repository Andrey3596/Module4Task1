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
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0: // если 0, то мандарин
                        this.filmList.Add(Movie.Generate());
                        break;
                    case 1: // если 1 то виноград
                      
                        this.filmList.Add(Series.Generate());
                        break;
                    case 2: // если 2 то арбуз
                        this.filmList.Add(Telecast.Generate());
                        break;
                        // появление других чисел маловероятно
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int movieCount = 0;
            int seriesCount = 0;
            int telecastCount = 0;

            // пройдемся по всему списку
            foreach (var film in this.filmList)
            {
                // помните, что в списки у нас лежат фрукты,
                // то есть объекты типа Fruit
                // поэтому чтобы проверить какой именно фрукт
                // мы в данный момент обозреваем, мы используем ключевое слово is
                if (film is Movie) // читается почти как чистый инглиш, "если fruit есть Мандарин"
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

            // а ну и вывести все это надо на форму
            txtInfo.Text = "Фильм\tСриал\tПрдач"; // буквы экнмлю, чтобы влезло на форму
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

            // взяли первый фрукт
            var film = this.filmList[0];
            // тут вам не реальность, взятие это на самом деле создание указателя на область в памяти
            // где хранится экземпляр класса, так что если хочешь удалить, делай это сам
            this.filmList.RemoveAt(0);

            txtOut.Text = film.GetInfo();

            // обновим информацию о количестве товара на форме
            ShowInfo();
        }
    }
}

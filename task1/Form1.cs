namespace task1
{
    public partial class Form1 : Form
    {

        List<Film> filmList = new List<Film>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.filmList.Clear();
            for (var i = 0; i < 10; ++i)
            {
                // классно да, список типа Fruit, а кладем Mandarin
                // вот она: "сила наследования"
                this.filmList.Add(new Movie());
            }
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
            txtInfo.Text = "фильмы\tсериалы\tтв"; // буквы экнмлю, чтобы влезло на форму
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", mandarinsCount, grapesCount, watermellonsCount);
        }

    }
}

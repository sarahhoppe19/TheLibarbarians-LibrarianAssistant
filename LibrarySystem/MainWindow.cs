namespace LibrarySystem
{
    public partial class MainWindow : Form
    {
        private Inventory LibraryDatabase = new();
        // Basically Main
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ResultBox1.Text = SearchBox.Text;
        }
        // Add Book Menu Button Fuctionality
        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hide all boxes
            ChangeSearchStuffVisibility(false);
        }
        private void SaveBookButton_Click(object sender, EventArgs e)
        {
            ChangeSearchStuffVisibility(true);
        }
        // Shows/Hides Search Stuff (when true)
        private void ChangeSearchStuffVisibility(bool visible)
        {
            ResultBox1.Visible = visible;
            ResultBox2.Visible = visible;
            ResultBox3.Visible = visible;
            ResultBox4.Visible = visible;
            SearchBox.Visible = visible;
            BookDescBox.Visible = visible;
            CoverImageBox.Visible = visible;
            PrevButton.Visible = visible;
            NextButton.Visible = visible;
            PageTextBox.Visible = visible;
            SaveBookButton.Visible = !visible;
            TitleBox.Visible = !visible;
            TitleEntryBox.Visible = !visible;
            ISBNBox.Visible = !visible;
            ISBNEntryBox.Visible = !visible;
            AuthorBox.Visible = !visible;
            AuthorEntryBox.Visible = !visible;
            PublisherBox.Visible = !visible;
            PublisherEntryBox.Visible = !visible;
            GenreBox.Visible = !visible;
            GenreEntryBox.Visible = !visible;
            PriceBox.Visible = !visible;
            PriceEntryBox.Visible = !visible;
            DescriptionBox.Visible = !visible;
            DescEntryBox.Visible = !visible;
            AddPhotoButton.Visible = !visible;
        }

    }
}
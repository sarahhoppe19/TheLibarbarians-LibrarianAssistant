using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace LibrarySystem
{
    public partial class MainWindow : Form
    {
        // Main Window Members
        private Inventory LibraryDatabase = new();
        private Image? tempPhoto;
        private List<int>? BookSearchResults; // Stores search results (can be null)
        int CurSelection; // Tracks current search result selection
        int CurPage; // Tracks current page
        public MainWindow()
        {
            InitializeComponent();
        }
        // Search button
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchPhrase = SearchBox.Text;
            if (int.TryParse(searchPhrase, out int resultInt)) BookSearchResults = LibraryDatabase.BookSearch(resultInt);
            else BookSearchResults = LibraryDatabase.BookSearch(searchPhrase);
            DisplaySearchResults();
        }
        private void DisplaySearchResults()
        {
            if (BookSearchResults == null || BookSearchResults.Count == 0)
            {
                ResultBox1.Text = string.Empty;
                ResultBox2.Text = string.Empty;
                ResultBox3.Text = string.Empty;
                ResultBox4.Text = string.Empty;
                return;
            }
            // Set search selection to default
            CurSelection = 1;
            ResultBox1.BackColor = Color.White;
            ResultBox2.BackColor = SystemColors.Window;
            ResultBox3.BackColor = SystemColors.Window;
            ResultBox4.BackColor = SystemColors.Window;
            PageTextBox.Text = "1/" + ((int)(BookSearchResults.Count / 4) + 1).ToString();
            string result;
            Book curBook;
            for (int i = 0; i < BookSearchResults.Count && i < 4; i++)
            {
                curBook = LibraryDatabase.GetBook(BookSearchResults[i]);
                result = "ISBN: " + curBook.ISBN.ToString() + "\r\nTitle: " + curBook.Title + "\r\nAuthor: " + curBook.Author +
                    "\tPublisher: " + curBook.Publisher + "\r\nGenre(s): " + curBook.Genre + "\r\nStock: " + curBook.Stock.ToString() + "\tPrice: " + curBook.Price.ToString();
                SetResultBox(i + 1, result);
            }
            DisplayCurrentBook(LibraryDatabase.GetBook(BookSearchResults[0]));
        }
        private void DisplayCurrentBook(Book curBook)
        {
            CoverImageBox.Image = curBook.CoverPhoto;
            BookDescBox.Text = curBook.Description;
        }
        // Sets target result box with text
        private void SetResultBox(int resultBox, string text)
        {
            switch (resultBox)
            {
                case 1:
                    ResultBox1.Text = text; break;
                case 2:
                    ResultBox2.Text = text; break;
                case 3:
                    ResultBox3.Text = text; break;
                case 4:
                    ResultBox4.Text = text; break;
            }
        }
        // Add-Book Menu Button Fuctionality
        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hide all boxes
            ChangeSearchVisibility(false);
        }
        private void SaveBookButton_Click(object sender, EventArgs e)
        {
            uint isbn;
            if (!(uint.TryParse(ISBNEntryBox.Text, out isbn) ||
                (double.TryParse(PriceEntryBox.Text, out double _))))
            { ChangeSearchVisibility(true); return; } // Invalid Entry Case

            if (double.TryParse(PriceEntryBox.Text, out double price))
                LibraryDatabase.CreateBook((int)isbn,
                    TitleEntryBox.Text, DescEntryBox.Text, AuthorEntryBox.Text,
                    PublisherEntryBox.Text, GenreEntryBox.Text, 0, price);
            else LibraryDatabase.CreateBook((int)isbn,
                    TitleEntryBox.Text, DescEntryBox.Text, AuthorEntryBox.Text,
                    PublisherEntryBox.Text, GenreEntryBox.Text, 0, 0);
            if (CoverImageBox.Visible) LibraryDatabase.GetBook((int)isbn).CoverPhoto = CoverImageBox.Image;

            CoverImageBox.Image = null;
            ChangeSearchVisibility(true);
        }
        /// <summary>
        /// Shows/Hides Search UI Elements (when true)
        /// </summary>
        /// <param name="visibility"></param>
        private void ChangeSearchVisibility(bool visibility)
        {
            // Search UI Elements
            ResultBox1.Visible = visibility;
            ResultBox2.Visible = visibility;
            ResultBox3.Visible = visibility;
            ResultBox4.Visible = visibility;
            SearchBox.Visible = visibility;
            BookDescBox.Visible = visibility;
            CoverImageBox.Visible = visibility;
            PrevButton.Visible = visibility;
            NextButton.Visible = visibility;
            PageTextBox.Visible = visibility;
            SearchButton.Visible = visibility;
            Upbutton.Visible = visibility;
            DownButton.Visible = visibility;
            // Book Creation UI Elements
            SaveBookButton.Visible = !visibility;
            TitleBox.Visible = !visibility;
            TitleEntryBox.Visible = !visibility;
            ISBNBox.Visible = !visibility;
            ISBNEntryBox.Visible = !visibility;
            AuthorBox.Visible = !visibility;
            AuthorEntryBox.Visible = !visibility;
            PublisherBox.Visible = !visibility;
            PublisherEntryBox.Visible = !visibility;
            GenreBox.Visible = !visibility;
            GenreEntryBox.Visible = !visibility;
            PriceBox.Visible = !visibility;
            PriceEntryBox.Visible = !visibility;
            DescriptionBox.Visible = !visibility;
            DescEntryBox.Visible = !visibility;
            AddPhotoButton.Visible = !visibility;
        }

        private void AddPhotoButton_Click(object sender, EventArgs e)
        {
            CoverImageBox.Visible = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tempPhoto = new Bitmap(openFileDialog1.FileName);
                tempPhoto = ResizeImage(tempPhoto, 300, 450);
                CoverImageBox.Image = tempPhoto;
            }
        }
        // Crops target image to book aspect ratio
        private static Image CropImage(Image img)
        {
            int width = img.Width;
            int height = img.Height;
            int dif = Math.Abs(width - height);
            bool isHor = false;
            if (width > height)
                isHor = true;
            Rectangle cropArea;
            if (isHor) cropArea = new Rectangle(dif / 2, 0, height, height);
            else cropArea = new Rectangle(0, dif / 2, width, width);

            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }

        // Resizes image while maintaining good quality
        // Found at: https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp
        private static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void Upbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
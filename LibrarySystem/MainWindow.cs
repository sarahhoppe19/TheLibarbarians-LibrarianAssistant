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
        int? CurUser;
        int CurSelection; // Tracks current search result selection
        int CurPage; // Tracks current page
        public MainWindow()
        {
            InitializeComponent();
            TestInventory.RunAllTests();
        }
        // Search button
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchPhrase = SearchBox.Text;
            if (int.TryParse(searchPhrase, out int resultInt)) BookSearchResults = LibraryDatabase.BookSearch(resultInt);
            else BookSearchResults = LibraryDatabase.BookSearch(searchPhrase);
            CurPage = 1;
            DisplaySearchResults();
        }
        private void DisplaySearchResults()
        {
            // Reset all Text Boxes
            ResultBox1.Text = string.Empty;
            ResultBox2.Text = string.Empty;
            ResultBox3.Text = string.Empty;
            ResultBox4.Text = string.Empty;
            if (BookSearchResults == null || BookSearchResults.Count == 0)
            {
                return;
            }
            // Set search selection to default
            CurSelection = 1;
            ResultBox1.BackColor = Color.White;
            ResultBox2.BackColor = Color.LightGray;
            ResultBox3.BackColor = Color.LightGray;
            ResultBox4.BackColor = Color.LightGray;
            if (BookSearchResults.Count % 4 != 0) PageTextBox.Text = CurPage.ToString() + "/" + ((int)((BookSearchResults.Count + (4 - BookSearchResults.Count % 4)) / 4)).ToString();
            else PageTextBox.Text = CurPage.ToString() + "/" + (BookSearchResults.Count / 4).ToString();
            string result;
            Book curBook;
            // Loop through up to 4 search results and displays them
            for (int i = ((CurPage-1)*4); i < BookSearchResults.Count && i < 4*CurPage; i++)
            {
                curBook = LibraryDatabase.GetBook(BookSearchResults[i]);
                SetResultBox((i%4) + 1, curBook);
            }
            DisplayCurrentBookDesc(LibraryDatabase.GetBook(BookSearchResults[0+4*(CurPage-1)]));
        }

        private void DisplayCurrentBookDesc(Book curBook)
        {
            CoverImageBox.Image = curBook.CoverPhoto;
            BookDescBox.Text = curBook.Description;
        }
        // Sets target result box with book info
        private void SetResultBox(int resultBox, Book curBook)
        {
            if (curBook == null) { CoverImageBox.Image = null; DescriptionBox.Text = String.Empty; return; }
            string text = "ISBN: " + curBook.ISBN.ToString() + "\r\nTitle: " + curBook.Title + "\r\nAuthor: " + curBook.Author +
                    "\tPublisher: " + curBook.Publisher + "\r\nGenre(s): " + curBook.Genre + "\r\nStock: " + curBook.Stock.ToString() + "\tPrice: " + curBook.Price.ToString();
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
            ChangeUserEntryVisibility(false);
            ChangeBookCreateVisibility(true);
        }
        private void SaveBookButton_Click(object sender, EventArgs e)
        {
            uint isbn;
            if (!(uint.TryParse(ISBNEntryBox.Text, out isbn) ||
                (double.TryParse(PriceEntryBox.Text, out double _))))
            { ChangeSearchVisibility(true); ChangeBookCreateVisibility(false); ChangeUserEntryVisibility(false); return; } // Invalid Entry Case

            if (double.TryParse(PriceEntryBox.Text, out double price))
                LibraryDatabase.CreateBook((int)isbn,
                    TitleEntryBox.Text, DescEntryBox.Text, AuthorEntryBox.Text,
                    PublisherEntryBox.Text, GenreEntryBox.Text, 0, price);
            else LibraryDatabase.CreateBook((int)isbn,
                    TitleEntryBox.Text, DescEntryBox.Text, AuthorEntryBox.Text,
                    PublisherEntryBox.Text, GenreEntryBox.Text, 0, 0);
            if (CoverImageBox.Visible) LibraryDatabase.GetBook((int)isbn).CoverPhoto = CoverImageBox.Image;
            // Reset Page
            CoverImageBox.Image = null;
            TitleEntryBox.Text = String.Empty;
            ISBNEntryBox.Text = String.Empty;
            AuthorEntryBox.Text = String.Empty;
            PublisherEntryBox.Text = String.Empty;
            GenreEntryBox.Text = String.Empty;
            PriceEntryBox.Text = String.Empty;
            DescEntryBox.Text = String.Empty;
            ChangeSearchVisibility(true);
            ChangeBookCreateVisibility(false);
            ChangeUserEntryVisibility(false);
        }
        /// <summary>
        /// Shows/Hides Search UI Elements
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
        }
        /// <summary>
        /// Shows/Hides Book Creating UI Elements
        /// </summary>
        /// <param name="visibility"></param>
        private void ChangeBookCreateVisibility(bool visibility)
        {
            // Book Creation UI Elements
            SaveBookButton.Visible = visibility;
            TitleBox.Visible = visibility;
            TitleEntryBox.Visible = visibility;
            ISBNBox.Visible = visibility;
            ISBNEntryBox.Visible = visibility;
            AuthorBox.Visible = visibility;
            AuthorEntryBox.Visible = visibility;
            PublisherBox.Visible = visibility;
            PublisherEntryBox.Visible = visibility;
            GenreBox.Visible = visibility;
            GenreEntryBox.Visible = visibility;
            PriceBox.Visible = visibility;
            PriceEntryBox.Visible = visibility;
            DescriptionBox.Visible = visibility;
            DescEntryBox.Visible = visibility;
            AddPhotoButton.Visible = visibility;
        }
        /// <summary>
        /// Shows/Hides User Entry UI Elements
        /// </summary>
        /// <param name="visibility"></param>
        private void ChangeUserEntryVisibility(bool visibility)
        {
            UsernameBox.Visible = visibility;
            UsernameEntryBox.Visible = visibility;
            PasswordBox.Visible = visibility;
            PasswordEntryBox.Visible = visibility;
            LoginButton.Visible = visibility;
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
            if (CurSelection < 2) return;
            CurSelection -= 1;
            switch (CurSelection)
            {
                case 1:
                    ResultBox1.BackColor = Color.White;
                    ResultBox2.BackColor = Color.LightGray;
                    break;
                case 2:
                    ResultBox2.BackColor = Color.White;
                    ResultBox3.BackColor = Color.LightGray;
                    break;
                case 3:
                    ResultBox3.BackColor = Color.White;
                    ResultBox4.BackColor = Color.LightGray;
                    break;
            }
            Book temp;
            if (CurSelection - 1 + (CurPage - 1) * 4 < BookSearchResults.Count)
            {
                temp = LibraryDatabase.GetBook(BookSearchResults[CurSelection - 1 + (CurPage - 1) * 4]);
                CoverImageBox.Image = temp.CoverPhoto;
                BookDescBox.Text = temp.Description;
            }
            else
            {
                CoverImageBox.Image = null;
                BookDescBox.Text = String.Empty;
            }
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if (CurSelection > 3) return;
            CurSelection += 1;
            switch (CurSelection)
            {
                case 2:
                    ResultBox2.BackColor = Color.White;
                    ResultBox1.BackColor = Color.LightGray;
                    break;
                case 3:
                    ResultBox3.BackColor = Color.White;
                    ResultBox2.BackColor = Color.LightGray;
                    break;
                case 4:
                    ResultBox4.BackColor = Color.White;
                    ResultBox3.BackColor = Color.LightGray;
                    break;
            }
            Book temp;
            if (CurSelection - 1 + (CurPage - 1) * 4 < BookSearchResults.Count)
            {
                temp = LibraryDatabase.GetBook(BookSearchResults[CurSelection - 1 + (CurPage - 1) * 4]);
                CoverImageBox.Image = temp.CoverPhoto;
                BookDescBox.Text = temp.Description;
            }
            else
            {
                CoverImageBox.Image = null;
                BookDescBox.Text = String.Empty;
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUserEntryVisibility(true);
            ChangeBookCreateVisibility(false);
            ChangeSearchVisibility(false);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {


            // End of Login Sequence
            UsernameEntryBox.Text = String.Empty;
            PasswordEntryBox.Text = String.Empty;
            ChangeUserEntryVisibility(false);
            ChangeBookCreateVisibility(false);
            ChangeSearchVisibility(true);
            userToolStripMenuItem.Text = "Welcome, Loser";
            userToolStripMenuItem.Visible = true;
            loginToolStripMenuItem.Visible = false;
        }


        // David's section:
        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (CurPage > 1)
            {
                CurPage--;
                DisplaySearchResults();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (BookSearchResults.Count > (CurPage * 4))
            {
                CurPage++;
                DisplaySearchResults();
            }
        }
    }
}
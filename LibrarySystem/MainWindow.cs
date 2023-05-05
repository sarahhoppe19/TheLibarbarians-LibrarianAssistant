using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace LibrarySystem
{
    public partial class MainWindow : Form
    {
        // Main Window Members
        private Inventory LibraryDatabase = new();
        private Image? tempPhoto;
        private List<int>? BookSearchResults; // Stores search results (can be null)
        int CurUser;
        int CurSelection; // Tracks current search result selection
        int CurPage; // Tracks current page
        public MainWindow()
        {
            CurPage = 1;
            using (StreamReader sr = new StreamReader("../../../bookdatabase.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split('|');
                    LibraryDatabase.CreateBook(int.Parse(line[0]), line[1], line[2], line[3], line[4], line[5], int.Parse(line[6]), Convert.ToDouble(line[7]));
                    string coverFile = "../../../covers/" + line[0] + ".bmp";
                    if (File.Exists(coverFile))
                    {
                        using(FileStream fs = new FileStream(coverFile, FileMode.Open))
                        {
                            LibraryDatabase.GetBook(int.Parse(line[0])).CoverPhoto = Image.FromStream(fs);
                            fs.Close();
                        }
          
                        
                    }
                }
            }
            InitializeComponent();
            TestInventory.RunAllTests();
            // Add Default User Logins
            LibraryDatabase.CreateUser(0, "Dev", "dev", true);
            LibraryDatabase.CreateUser(1, "Admin", "admin", true);
            LibraryDatabase.CreateUser(2, "User", "user", false);
            // Default to User Login
            ChangeBookCreateVisibility(false);
            ChangeSearchVisibility(false);
            ChangeUserEntryVisibility(true);
           
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
            for (int i = ((CurPage - 1) * 4); i < BookSearchResults.Count && i < 4 * CurPage; i++)
            {
                curBook = LibraryDatabase.GetBook(BookSearchResults[i]);
                SetResultBox((i % 4) + 1, curBook);
            }
            DisplayCurrentBookCoverDesc(LibraryDatabase.GetBook(BookSearchResults[0 + 4 * (CurPage - 1)]));
        }

        private void DisplayCurrentBookCoverDesc(Book curBook)
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
            int stock;
            double price;
            bool returnDialog = false;
            // Invalid ISBN Entry Case
            if (!(uint.TryParse(ISBNEntryBox.Text, out isbn)))
            {
                var result = MessageBox.Show("Invalid ISBN. Return to form?",
                    "ISBN Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) returnDialog = true;
            }
            if (returnDialog) return;
            if (!int.TryParse(StockEntryBox.Text, out stock)) stock = 0;
            if (!double.TryParse(PriceEntryBox.Text, out price)) price = 0;
            if (!LibraryDatabase.CreateBook((int)isbn,
                    TitleEntryBox.Text, DescEntryBox.Text, AuthorEntryBox.Text,
                    PublisherEntryBox.Text, GenreEntryBox.Text, stock, price))
                LibraryDatabase.EditBook((int)isbn,
                    TitleEntryBox.Text, DescEntryBox.Text, AuthorEntryBox.Text,
                    PublisherEntryBox.Text, GenreEntryBox.Text, stock, price);
            if (CoverImageBox.Visible) LibraryDatabase.GetBook((int)isbn).CoverPhoto = CoverImageBox.Image;
            // Reset Page
            CoverImageBox.Image = null;
            TitleEntryBox.Text = string.Empty;
            ISBNEntryBox.Text = string.Empty;
            AuthorEntryBox.Text = string.Empty;
            PublisherEntryBox.Text = string.Empty;
            GenreEntryBox.Text = string.Empty;
            PriceEntryBox.Text = string.Empty;
            DescEntryBox.Text = string.Empty;
            StockEntryBox.Text = string.Empty;
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
            StockBox.Visible = visibility;
            StockEntryBox.Visible = visibility;
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
                BookDescBox.Text = string.Empty;
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
            if (!LibraryDatabase.ValidateUser(UsernameEntryBox.Text, PasswordEntryBox.Text))
            {
                MessageBox.Show("Invalid Login");
                return;
            }

            // End of Login Sequence
            ChangeUserEntryVisibility(false);
            ChangeBookCreateVisibility(false);
            ChangeSearchVisibility(true);
            userToolStripMenuItem.Text = "Welcome, " + UsernameEntryBox.Text;
            CurUser = LibraryDatabase.GetUserID(UsernameEntryBox.Text, PasswordEntryBox.Text);
            if (CurUser == -1) throw new Exception("Get User Failed");
            if (LibraryDatabase.isAdmin(CurUser))
            {
                inventoryToolStripMenuItem.Visible = true;
                createUserToolStripMenuItem.Visible = true;
            }
            else
            {
                inventoryToolStripMenuItem.Visible = false;
            }
            userToolStripMenuItem.Visible = true;
            loginToolStripMenuItem.Visible = false;
            UsernameEntryBox.Text = string.Empty;
            PasswordEntryBox.Text = string.Empty;
            string searchPhrase = SearchBox.Text;
            if (int.TryParse(searchPhrase, out int resultInt)) BookSearchResults = LibraryDatabase.BookSearch(resultInt);
            else BookSearchResults = LibraryDatabase.BookSearch(searchPhrase);
            CurPage = 1;
            DisplaySearchResults();
        }

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
            if (BookSearchResults != null && BookSearchResults.Count > (CurPage * 4))
            {
                CurPage++;
                DisplaySearchResults();
            }
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookSearchResults == null || !(CurSelection - 1 + (CurPage - 1) * 4 < BookSearchResults.Count)) { return; }
            Book book = LibraryDatabase.GetBook(BookSearchResults[(CurSelection-1) + 4 * (CurPage - 1)]);
            TitleEntryBox.Text = book.Title;
            ISBNEntryBox.Text = book.ISBN.ToString();
            AuthorEntryBox.Text = book.Author;
            PublisherEntryBox.Text = book.Publisher;
            GenreEntryBox.Text = book.Genre;
            PriceEntryBox.Text = book.Price.ToString();
            DescEntryBox.Text = book.Description;
            StockEntryBox.Text = book.Stock.ToString();
            CoverImageBox.Image = book.CoverPhoto;
            DisplayCurrentBookCoverDesc(book);
            ChangeBookCreateVisibility(true);
            ChangeSearchVisibility(false);
            ChangeUserEntryVisibility(false);
        }

        // David do:)
        private void MainWindow_Closing(object sender, FormClosingEventArgs e)
        {
            SaveToFile();
        }
        private void SaveToFile()
        {
            using (StreamWriter writer = new StreamWriter("../../../bookdatabase.txt"))
            {
                List<int> allIsbns = LibraryDatabase.BookSearch("");
                foreach (int isbn in allIsbns)
                {
                    Book curBook = LibraryDatabase.GetBook(isbn);
                    writer.WriteLine(isbn + "|" + curBook.Title + "|" + curBook.Description + "|" + curBook.Author + "|" + curBook.Publisher + "|" + curBook.Genre + "|" + curBook.Stock + "|" + curBook.Price);
                    if(curBook.CoverPhoto != null)
                    {
                        if(!File.Exists("../../../covers/" + isbn + ".bmp")) curBook.CoverPhoto.Save("../../../covers/" + isbn + ".bmp");
                    }
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeBookCreateVisibility(false);
            ChangeSearchVisibility(false);
            ChangeUserEntryVisibility(true);
            createUserToolStripMenuItem.Visible = false;
            userToolStripMenuItem.Visible = false;
            loginToolStripMenuItem.Visible = true;
        }
    }
}
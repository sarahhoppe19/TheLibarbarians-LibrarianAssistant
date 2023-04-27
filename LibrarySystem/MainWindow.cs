using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace LibrarySystem
{
    public partial class MainWindow : Form
    {
        // Main Window Members
        private Inventory LibraryDatabase = new();
        private Image? tempPhoto;
        int CurSelection;

        // Basically Main
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ResultBox1.Text = SearchBox.Text;
            if (LibraryDatabase.GetBook(123) != null)
            {
                ResultBox2.Text = "Title: " + LibraryDatabase.GetBook(123).Title + "\r\nISBN: " + LibraryDatabase.GetBook(123).ISBN;
                CoverImageBox.Image = LibraryDatabase.GetBook(123).CoverPhoto;
            }
        }
        // Add Book Menu Button Fuctionality
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
        // Shows/Hides Search Stuff (when true)
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
        // Crops target image to square
        private static Image CropImage(Image img)
        {
            int width = img.Width;
            int height = img.Height;
            int dif = Math.Abs(width - height);
            bool isHor = false;
            if (width > height)
                isHor = true;
            Rectangle cropArea;
            if (isHor)
                cropArea = new Rectangle(dif / 2, 0, height, height);
            else
                cropArea = new Rectangle(0, dif / 2, width, width);

            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }

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
    }
}
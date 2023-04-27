namespace LibrarySystem
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            addBookToolStripMenuItem = new ToolStripMenuItem();
            editBookToolStripMenuItem = new ToolStripMenuItem();
            NextButton = new Button();
            SearchBox = new TextBox();
            PrevButton = new Button();
            PageTextBox = new TextBox();
            CoverImageBox = new PictureBox();
            BookDescBox = new TextBox();
            ResultBox1 = new TextBox();
            ResultBox2 = new TextBox();
            ResultBox3 = new TextBox();
            ResultBox4 = new TextBox();
            SaveBookButton = new Button();
            TitleBox = new TextBox();
            TitleEntryBox = new TextBox();
            ISBNBox = new TextBox();
            ISBNEntryBox = new TextBox();
            AuthorBox = new TextBox();
            AuthorEntryBox = new TextBox();
            PublisherBox = new TextBox();
            PublisherEntryBox = new TextBox();
            GenreBox = new TextBox();
            GenreEntryBox = new TextBox();
            PriceBox = new TextBox();
            PriceEntryBox = new TextBox();
            DescriptionBox = new TextBox();
            DescEntryBox = new TextBox();
            AddPhotoButton = new Button();
            SearchButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            Upbutton = new Button();
            DownButton = new Button();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CoverImageBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, inventoryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(69, 24);
            loginToolStripMenuItem.Text = "Login...";
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addBookToolStripMenuItem, editBookToolStripMenuItem });
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(84, 24);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // addBookToolStripMenuItem
            // 
            addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            addBookToolStripMenuItem.Size = new Size(158, 26);
            addBookToolStripMenuItem.Text = "Add Book";
            addBookToolStripMenuItem.Click += addBookToolStripMenuItem_Click;
            // 
            // editBookToolStripMenuItem
            // 
            editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            editBookToolStripMenuItem.Size = new Size(158, 26);
            editBookToolStripMenuItem.Text = "Edit Book";
            // 
            // NextButton
            // 
            NextButton.Location = new Point(697, 592);
            NextButton.Margin = new Padding(2, 2, 2, 2);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(87, 27);
            NextButton.TabIndex = 1;
            NextButton.Text = "Next>>";
            NextButton.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(481, 29);
            SearchBox.Margin = new Padding(2, 2, 2, 2);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(351, 27);
            SearchBox.TabIndex = 2;
            // 
            // PrevButton
            // 
            PrevButton.Location = new Point(545, 592);
            PrevButton.Margin = new Padding(2, 2, 2, 2);
            PrevButton.Name = "PrevButton";
            PrevButton.Size = new Size(87, 27);
            PrevButton.TabIndex = 3;
            PrevButton.Text = "<<Prev";
            PrevButton.UseVisualStyleBackColor = true;
            // 
            // PageTextBox
            // 
            PageTextBox.Location = new Point(636, 593);
            PageTextBox.Margin = new Padding(2, 2, 2, 2);
            PageTextBox.MaxLength = 10;
            PageTextBox.Name = "PageTextBox";
            PageTextBox.Size = new Size(59, 27);
            PageTextBox.TabIndex = 4;
            PageTextBox.Text = "1/1";
            PageTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CoverImageBox
            // 
            CoverImageBox.Location = new Point(956, 56);
            CoverImageBox.Margin = new Padding(2, 2, 2, 2);
            CoverImageBox.Name = "CoverImageBox";
            CoverImageBox.Size = new Size(200, 300);
            CoverImageBox.TabIndex = 5;
            CoverImageBox.TabStop = false;
            // 
            // BookDescBox
            // 
            BookDescBox.Enabled = false;
            BookDescBox.Location = new Point(869, 360);
            BookDescBox.Margin = new Padding(2, 2, 2, 2);
            BookDescBox.Multiline = true;
            BookDescBox.Name = "BookDescBox";
            BookDescBox.Size = new Size(365, 207);
            BookDescBox.TabIndex = 6;
            // 
            // ResultBox1
            // 
            ResultBox1.Enabled = false;
            ResultBox1.Location = new Point(69, 80);
            ResultBox1.Margin = new Padding(2, 2, 2, 2);
            ResultBox1.Multiline = true;
            ResultBox1.Name = "ResultBox1";
            ResultBox1.Size = new Size(625, 101);
            ResultBox1.TabIndex = 7;
            // 
            // ResultBox2
            // 
            ResultBox2.Enabled = false;
            ResultBox2.Location = new Point(69, 199);
            ResultBox2.Margin = new Padding(2, 2, 2, 2);
            ResultBox2.Multiline = true;
            ResultBox2.Name = "ResultBox2";
            ResultBox2.Size = new Size(625, 101);
            ResultBox2.TabIndex = 8;
            // 
            // ResultBox3
            // 
            ResultBox3.Enabled = false;
            ResultBox3.Location = new Point(69, 317);
            ResultBox3.Margin = new Padding(2, 2, 2, 2);
            ResultBox3.Multiline = true;
            ResultBox3.Name = "ResultBox3";
            ResultBox3.Size = new Size(625, 101);
            ResultBox3.TabIndex = 9;
            // 
            // ResultBox4
            // 
            ResultBox4.Enabled = false;
            ResultBox4.Location = new Point(69, 435);
            ResultBox4.Margin = new Padding(2, 2, 2, 2);
            ResultBox4.Multiline = true;
            ResultBox4.Name = "ResultBox4";
            ResultBox4.Size = new Size(625, 101);
            ResultBox4.TabIndex = 10;
            // 
            // SaveBookButton
            // 
            SaveBookButton.Location = new Point(625, 561);
            SaveBookButton.Margin = new Padding(2, 2, 2, 2);
            SaveBookButton.Name = "SaveBookButton";
            SaveBookButton.Size = new Size(87, 27);
            SaveBookButton.TabIndex = 11;
            SaveBookButton.Text = "Save Book";
            SaveBookButton.UseVisualStyleBackColor = true;
            SaveBookButton.Visible = false;
            SaveBookButton.Click += SaveBookButton_Click;
            // 
            // TitleBox
            // 
            TitleBox.Enabled = false;
            TitleBox.Location = new Point(69, 80);
            TitleBox.Margin = new Padding(2, 2, 2, 2);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(118, 27);
            TitleBox.TabIndex = 12;
            TitleBox.Text = "Title";
            TitleBox.Visible = false;
            // 
            // TitleEntryBox
            // 
            TitleEntryBox.Location = new Point(69, 107);
            TitleEntryBox.Margin = new Padding(2, 2, 2, 2);
            TitleEntryBox.Name = "TitleEntryBox";
            TitleEntryBox.Size = new Size(406, 27);
            TitleEntryBox.TabIndex = 13;
            TitleEntryBox.Visible = false;
            // 
            // ISBNBox
            // 
            ISBNBox.Enabled = false;
            ISBNBox.Location = new Point(69, 135);
            ISBNBox.Margin = new Padding(2, 2, 2, 2);
            ISBNBox.Name = "ISBNBox";
            ISBNBox.Size = new Size(118, 27);
            ISBNBox.TabIndex = 14;
            ISBNBox.Text = "ISBN";
            ISBNBox.Visible = false;
            // 
            // ISBNEntryBox
            // 
            ISBNEntryBox.Location = new Point(69, 162);
            ISBNEntryBox.Margin = new Padding(2, 2, 2, 2);
            ISBNEntryBox.Name = "ISBNEntryBox";
            ISBNEntryBox.Size = new Size(406, 27);
            ISBNEntryBox.TabIndex = 15;
            ISBNEntryBox.Visible = false;
            // 
            // AuthorBox
            // 
            AuthorBox.Enabled = false;
            AuthorBox.Location = new Point(69, 189);
            AuthorBox.Margin = new Padding(2, 2, 2, 2);
            AuthorBox.Name = "AuthorBox";
            AuthorBox.Size = new Size(118, 27);
            AuthorBox.TabIndex = 16;
            AuthorBox.Text = "Author";
            AuthorBox.Visible = false;
            // 
            // AuthorEntryBox
            // 
            AuthorEntryBox.Location = new Point(69, 217);
            AuthorEntryBox.Margin = new Padding(2, 2, 2, 2);
            AuthorEntryBox.Name = "AuthorEntryBox";
            AuthorEntryBox.Size = new Size(406, 27);
            AuthorEntryBox.TabIndex = 17;
            AuthorEntryBox.Visible = false;
            // 
            // PublisherBox
            // 
            PublisherBox.Enabled = false;
            PublisherBox.Location = new Point(69, 244);
            PublisherBox.Margin = new Padding(2, 2, 2, 2);
            PublisherBox.Name = "PublisherBox";
            PublisherBox.Size = new Size(118, 27);
            PublisherBox.TabIndex = 18;
            PublisherBox.Text = "Publisher";
            PublisherBox.Visible = false;
            // 
            // PublisherEntryBox
            // 
            PublisherEntryBox.Location = new Point(69, 271);
            PublisherEntryBox.Margin = new Padding(2, 2, 2, 2);
            PublisherEntryBox.Name = "PublisherEntryBox";
            PublisherEntryBox.Size = new Size(406, 27);
            PublisherEntryBox.TabIndex = 19;
            PublisherEntryBox.Visible = false;
            // 
            // GenreBox
            // 
            GenreBox.Enabled = false;
            GenreBox.Location = new Point(69, 299);
            GenreBox.Margin = new Padding(2, 2, 2, 2);
            GenreBox.Name = "GenreBox";
            GenreBox.Size = new Size(118, 27);
            GenreBox.TabIndex = 20;
            GenreBox.Text = "Genre(s)";
            GenreBox.Visible = false;
            // 
            // GenreEntryBox
            // 
            GenreEntryBox.Location = new Point(69, 326);
            GenreEntryBox.Margin = new Padding(2, 2, 2, 2);
            GenreEntryBox.Name = "GenreEntryBox";
            GenreEntryBox.Size = new Size(406, 27);
            GenreEntryBox.TabIndex = 21;
            GenreEntryBox.Visible = false;
            // 
            // PriceBox
            // 
            PriceBox.Enabled = false;
            PriceBox.Location = new Point(69, 353);
            PriceBox.Margin = new Padding(2, 2, 2, 2);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(118, 27);
            PriceBox.TabIndex = 22;
            PriceBox.Text = "Price";
            PriceBox.Visible = false;
            // 
            // PriceEntryBox
            // 
            PriceEntryBox.Location = new Point(69, 381);
            PriceEntryBox.Margin = new Padding(2, 2, 2, 2);
            PriceEntryBox.Name = "PriceEntryBox";
            PriceEntryBox.Size = new Size(406, 27);
            PriceEntryBox.TabIndex = 23;
            PriceEntryBox.Visible = false;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Enabled = false;
            DescriptionBox.Location = new Point(69, 408);
            DescriptionBox.Margin = new Padding(2, 2, 2, 2);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(118, 27);
            DescriptionBox.TabIndex = 24;
            DescriptionBox.Text = "Description";
            DescriptionBox.Visible = false;
            // 
            // DescEntryBox
            // 
            DescEntryBox.Location = new Point(69, 435);
            DescEntryBox.Margin = new Padding(2, 2, 2, 2);
            DescEntryBox.Multiline = true;
            DescEntryBox.Name = "DescEntryBox";
            DescEntryBox.Size = new Size(406, 101);
            DescEntryBox.TabIndex = 25;
            DescEntryBox.Visible = false;
            // 
            // AddPhotoButton
            // 
            AddPhotoButton.Location = new Point(69, 539);
            AddPhotoButton.Margin = new Padding(2, 2, 2, 2);
            AddPhotoButton.Name = "AddPhotoButton";
            AddPhotoButton.Size = new Size(165, 27);
            AddPhotoButton.TabIndex = 26;
            AddPhotoButton.Text = "Add Cover Photo";
            AddPhotoButton.UseVisualStyleBackColor = true;
            AddPhotoButton.Visible = false;
            AddPhotoButton.Click += AddPhotoButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(405, 27);
            SearchButton.Margin = new Padding(2, 2, 2, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(71, 27);
            SearchButton.TabIndex = 27;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Upbutton
            // 
            Upbutton.Location = new Point(725, 272);
            Upbutton.Margin = new Padding(2, 2, 2, 2);
            Upbutton.Name = "Upbutton";
            Upbutton.Size = new Size(36, 27);
            Upbutton.TabIndex = 28;
            Upbutton.Text = "/\\";
            Upbutton.UseVisualStyleBackColor = true;
            // 
            // DownButton
            // 
            DownButton.Location = new Point(725, 317);
            DownButton.Margin = new Padding(2, 2, 2, 2);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(36, 27);
            DownButton.TabIndex = 29;
            DownButton.Text = "\\/";
            DownButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 677);
            Controls.Add(DownButton);
            Controls.Add(Upbutton);
            Controls.Add(SearchButton);
            Controls.Add(AddPhotoButton);
            Controls.Add(DescEntryBox);
            Controls.Add(DescriptionBox);
            Controls.Add(PriceEntryBox);
            Controls.Add(PriceBox);
            Controls.Add(GenreEntryBox);
            Controls.Add(GenreBox);
            Controls.Add(PublisherEntryBox);
            Controls.Add(PublisherBox);
            Controls.Add(AuthorEntryBox);
            Controls.Add(AuthorBox);
            Controls.Add(ISBNEntryBox);
            Controls.Add(ISBNBox);
            Controls.Add(TitleEntryBox);
            Controls.Add(TitleBox);
            Controls.Add(SaveBookButton);
            Controls.Add(ResultBox4);
            Controls.Add(ResultBox3);
            Controls.Add(ResultBox2);
            Controls.Add(ResultBox1);
            Controls.Add(BookDescBox);
            Controls.Add(CoverImageBox);
            Controls.Add(PageTextBox);
            Controls.Add(PrevButton);
            Controls.Add(SearchBox);
            Controls.Add(NextButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainWindow";
            Text = "Library Management System";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CoverImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private Button NextButton;
        private TextBox SearchBox;
        private Button PrevButton;
        private TextBox PageTextBox;
        private PictureBox CoverImageBox;
        private TextBox BookDescBox;
        private TextBox ResultBox1;
        private TextBox ResultBox2;
        private TextBox ResultBox3;
        private TextBox ResultBox4;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private Button SaveBookButton;
        private TextBox TitleBox;
        private TextBox TitleEntryBox;
        private TextBox ISBNBox;
        private TextBox ISBNEntryBox;
        private TextBox AuthorBox;
        private TextBox AuthorEntryBox;
        private TextBox PublisherBox;
        private TextBox PublisherEntryBox;
        private TextBox GenreBox;
        private TextBox GenreEntryBox;
        private TextBox PriceBox;
        private TextBox PriceEntryBox;
        private TextBox DescriptionBox;
        private TextBox DescEntryBox;
        private Button AddPhotoButton;
        private Button SearchButton;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem editBookToolStripMenuItem;
        private Button Upbutton;
        private Button DownButton;
        private SaveFileDialog saveFileDialog1;
    }
}
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
            userToolStripMenuItem = new ToolStripMenuItem();
            createUserToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
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
            UsernameEntryBox = new TextBox();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            PasswordEntryBox = new TextBox();
            LoginButton = new Button();
            StockBox = new TextBox();
            StockEntryBox = new TextBox();
            IDBox = new TextBox();
            IDEntryBox = new TextBox();
            IDGenerateButton = new Button();
            CheckAdminBox = new CheckBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CoverImageBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, userToolStripMenuItem, inventoryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 4, 0, 4);
            menuStrip1.Size = new Size(1896, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(82, 34);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createUserToolStripMenuItem, logoutToolStripMenuItem });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(72, 34);
            userToolStripMenuItem.Text = "User";
            userToolStripMenuItem.Visible = false;
            // 
            // createUserToolStripMenuItem
            // 
            createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            createUserToolStripMenuItem.Size = new Size(238, 40);
            createUserToolStripMenuItem.Text = "Create User";
            createUserToolStripMenuItem.Visible = false;
            createUserToolStripMenuItem.Click += createUserToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(238, 40);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addBookToolStripMenuItem, editBookToolStripMenuItem });
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(118, 34);
            inventoryToolStripMenuItem.Text = "Inventory";
            inventoryToolStripMenuItem.Visible = false;
            // 
            // addBookToolStripMenuItem
            // 
            addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            addBookToolStripMenuItem.Size = new Size(221, 40);
            addBookToolStripMenuItem.Text = "Add Book";
            addBookToolStripMenuItem.Click += addBookToolStripMenuItem_Click;
            // 
            // editBookToolStripMenuItem
            // 
            editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            editBookToolStripMenuItem.Size = new Size(221, 40);
            editBookToolStripMenuItem.Text = "Edit Book";
            editBookToolStripMenuItem.Click += editBookToolStripMenuItem_Click;
            // 
            // NextButton
            // 
            NextButton.Location = new Point(1046, 888);
            NextButton.Margin = new Padding(3, 4, 3, 4);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(130, 40);
            NextButton.TabIndex = 1;
            NextButton.Text = "Next>>";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(722, 44);
            SearchBox.Margin = new Padding(3, 4, 3, 4);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(523, 35);
            SearchBox.TabIndex = 2;
            SearchBox.KeyPress += SearchEnterKeyPress;
            // 
            // PrevButton
            // 
            PrevButton.Location = new Point(818, 888);
            PrevButton.Margin = new Padding(3, 4, 3, 4);
            PrevButton.Name = "PrevButton";
            PrevButton.Size = new Size(130, 40);
            PrevButton.TabIndex = 3;
            PrevButton.Text = "<<Prev";
            PrevButton.UseVisualStyleBackColor = true;
            PrevButton.Click += PrevButton_Click;
            // 
            // PageTextBox
            // 
            PageTextBox.Location = new Point(953, 890);
            PageTextBox.Margin = new Padding(3, 4, 3, 4);
            PageTextBox.MaxLength = 10;
            PageTextBox.Name = "PageTextBox";
            PageTextBox.Size = new Size(86, 35);
            PageTextBox.TabIndex = 4;
            PageTextBox.Text = "1/1";
            PageTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CoverImageBox
            // 
            CoverImageBox.Location = new Point(1433, 84);
            CoverImageBox.Margin = new Padding(3, 4, 3, 4);
            CoverImageBox.Name = "CoverImageBox";
            CoverImageBox.Size = new Size(300, 450);
            CoverImageBox.TabIndex = 5;
            CoverImageBox.TabStop = false;
            // 
            // BookDescBox
            // 
            BookDescBox.Enabled = false;
            BookDescBox.Location = new Point(1305, 540);
            BookDescBox.Margin = new Padding(3, 4, 3, 4);
            BookDescBox.Multiline = true;
            BookDescBox.Name = "BookDescBox";
            BookDescBox.Size = new Size(546, 308);
            BookDescBox.TabIndex = 6;
            // 
            // ResultBox1
            // 
            ResultBox1.Enabled = false;
            ResultBox1.Location = new Point(105, 120);
            ResultBox1.Margin = new Padding(3, 4, 3, 4);
            ResultBox1.Multiline = true;
            ResultBox1.Name = "ResultBox1";
            ResultBox1.Size = new Size(937, 150);
            ResultBox1.TabIndex = 7;
            // 
            // ResultBox2
            // 
            ResultBox2.Enabled = false;
            ResultBox2.Location = new Point(105, 298);
            ResultBox2.Margin = new Padding(3, 4, 3, 4);
            ResultBox2.Multiline = true;
            ResultBox2.Name = "ResultBox2";
            ResultBox2.Size = new Size(937, 150);
            ResultBox2.TabIndex = 8;
            // 
            // ResultBox3
            // 
            ResultBox3.Enabled = false;
            ResultBox3.Location = new Point(105, 476);
            ResultBox3.Margin = new Padding(3, 4, 3, 4);
            ResultBox3.Multiline = true;
            ResultBox3.Name = "ResultBox3";
            ResultBox3.Size = new Size(937, 150);
            ResultBox3.TabIndex = 9;
            // 
            // ResultBox4
            // 
            ResultBox4.Enabled = false;
            ResultBox4.Location = new Point(105, 652);
            ResultBox4.Margin = new Padding(3, 4, 3, 4);
            ResultBox4.Multiline = true;
            ResultBox4.Name = "ResultBox4";
            ResultBox4.Size = new Size(937, 150);
            ResultBox4.TabIndex = 10;
            // 
            // SaveBookButton
            // 
            SaveBookButton.Location = new Point(938, 842);
            SaveBookButton.Margin = new Padding(3, 4, 3, 4);
            SaveBookButton.Name = "SaveBookButton";
            SaveBookButton.Size = new Size(130, 40);
            SaveBookButton.TabIndex = 11;
            SaveBookButton.Text = "Save Book";
            SaveBookButton.UseVisualStyleBackColor = true;
            SaveBookButton.Visible = false;
            SaveBookButton.Click += SaveBookButton_Click;
            // 
            // TitleBox
            // 
            TitleBox.Enabled = false;
            TitleBox.Location = new Point(105, 120);
            TitleBox.Margin = new Padding(3, 4, 3, 4);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(175, 35);
            TitleBox.TabIndex = 12;
            TitleBox.Text = "Title";
            TitleBox.Visible = false;
            // 
            // TitleEntryBox
            // 
            TitleEntryBox.Location = new Point(105, 160);
            TitleEntryBox.Margin = new Padding(3, 4, 3, 4);
            TitleEntryBox.Name = "TitleEntryBox";
            TitleEntryBox.Size = new Size(607, 35);
            TitleEntryBox.TabIndex = 13;
            TitleEntryBox.Visible = false;
            // 
            // ISBNBox
            // 
            ISBNBox.Enabled = false;
            ISBNBox.Location = new Point(105, 202);
            ISBNBox.Margin = new Padding(3, 4, 3, 4);
            ISBNBox.Name = "ISBNBox";
            ISBNBox.Size = new Size(175, 35);
            ISBNBox.TabIndex = 14;
            ISBNBox.Text = "ISBN";
            ISBNBox.Visible = false;
            // 
            // ISBNEntryBox
            // 
            ISBNEntryBox.Location = new Point(105, 244);
            ISBNEntryBox.Margin = new Padding(3, 4, 3, 4);
            ISBNEntryBox.Name = "ISBNEntryBox";
            ISBNEntryBox.Size = new Size(607, 35);
            ISBNEntryBox.TabIndex = 15;
            ISBNEntryBox.Visible = false;
            // 
            // AuthorBox
            // 
            AuthorBox.Enabled = false;
            AuthorBox.Location = new Point(105, 284);
            AuthorBox.Margin = new Padding(3, 4, 3, 4);
            AuthorBox.Name = "AuthorBox";
            AuthorBox.Size = new Size(175, 35);
            AuthorBox.TabIndex = 16;
            AuthorBox.Text = "Author";
            AuthorBox.Visible = false;
            // 
            // AuthorEntryBox
            // 
            AuthorEntryBox.Location = new Point(105, 326);
            AuthorEntryBox.Margin = new Padding(3, 4, 3, 4);
            AuthorEntryBox.Name = "AuthorEntryBox";
            AuthorEntryBox.Size = new Size(607, 35);
            AuthorEntryBox.TabIndex = 17;
            AuthorEntryBox.Visible = false;
            // 
            // PublisherBox
            // 
            PublisherBox.Enabled = false;
            PublisherBox.Location = new Point(105, 366);
            PublisherBox.Margin = new Padding(3, 4, 3, 4);
            PublisherBox.Name = "PublisherBox";
            PublisherBox.Size = new Size(175, 35);
            PublisherBox.TabIndex = 18;
            PublisherBox.Text = "Publisher";
            PublisherBox.Visible = false;
            // 
            // PublisherEntryBox
            // 
            PublisherEntryBox.Location = new Point(105, 406);
            PublisherEntryBox.Margin = new Padding(3, 4, 3, 4);
            PublisherEntryBox.Name = "PublisherEntryBox";
            PublisherEntryBox.Size = new Size(607, 35);
            PublisherEntryBox.TabIndex = 19;
            PublisherEntryBox.Visible = false;
            // 
            // GenreBox
            // 
            GenreBox.Enabled = false;
            GenreBox.Location = new Point(105, 448);
            GenreBox.Margin = new Padding(3, 4, 3, 4);
            GenreBox.Name = "GenreBox";
            GenreBox.Size = new Size(175, 35);
            GenreBox.TabIndex = 20;
            GenreBox.Text = "Genre(s)";
            GenreBox.Visible = false;
            // 
            // GenreEntryBox
            // 
            GenreEntryBox.Location = new Point(105, 488);
            GenreEntryBox.Margin = new Padding(3, 4, 3, 4);
            GenreEntryBox.Name = "GenreEntryBox";
            GenreEntryBox.Size = new Size(607, 35);
            GenreEntryBox.TabIndex = 21;
            GenreEntryBox.Visible = false;
            // 
            // PriceBox
            // 
            PriceBox.Enabled = false;
            PriceBox.Location = new Point(105, 530);
            PriceBox.Margin = new Padding(3, 4, 3, 4);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(175, 35);
            PriceBox.TabIndex = 22;
            PriceBox.Text = "Price";
            PriceBox.Visible = false;
            // 
            // PriceEntryBox
            // 
            PriceEntryBox.Location = new Point(105, 572);
            PriceEntryBox.Margin = new Padding(3, 4, 3, 4);
            PriceEntryBox.Name = "PriceEntryBox";
            PriceEntryBox.Size = new Size(607, 35);
            PriceEntryBox.TabIndex = 23;
            PriceEntryBox.Visible = false;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Enabled = false;
            DescriptionBox.Location = new Point(105, 612);
            DescriptionBox.Margin = new Padding(3, 4, 3, 4);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(175, 35);
            DescriptionBox.TabIndex = 24;
            DescriptionBox.Text = "Description";
            DescriptionBox.Visible = false;
            // 
            // DescEntryBox
            // 
            DescEntryBox.Location = new Point(105, 652);
            DescEntryBox.Margin = new Padding(3, 4, 3, 4);
            DescEntryBox.Multiline = true;
            DescEntryBox.Name = "DescEntryBox";
            DescEntryBox.Size = new Size(607, 150);
            DescEntryBox.TabIndex = 25;
            DescEntryBox.Visible = false;
            // 
            // AddPhotoButton
            // 
            AddPhotoButton.Location = new Point(105, 808);
            AddPhotoButton.Margin = new Padding(3, 4, 3, 4);
            AddPhotoButton.Name = "AddPhotoButton";
            AddPhotoButton.Size = new Size(249, 40);
            AddPhotoButton.TabIndex = 26;
            AddPhotoButton.Text = "Add Cover Photo";
            AddPhotoButton.UseVisualStyleBackColor = true;
            AddPhotoButton.Visible = false;
            AddPhotoButton.Click += AddPhotoButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(609, 40);
            SearchButton.Margin = new Padding(3, 4, 3, 4);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(106, 40);
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
            Upbutton.Location = new Point(1089, 408);
            Upbutton.Margin = new Padding(3, 4, 3, 4);
            Upbutton.Name = "Upbutton";
            Upbutton.Size = new Size(53, 40);
            Upbutton.TabIndex = 28;
            Upbutton.Text = "/\\";
            Upbutton.UseVisualStyleBackColor = true;
            Upbutton.Click += Upbutton_Click;
            // 
            // DownButton
            // 
            DownButton.Location = new Point(1089, 476);
            DownButton.Margin = new Padding(3, 4, 3, 4);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(53, 40);
            DownButton.TabIndex = 29;
            DownButton.Text = "\\/";
            DownButton.UseVisualStyleBackColor = true;
            DownButton.Click += DownButton_Click;
            // 
            // UsernameEntryBox
            // 
            UsernameEntryBox.Location = new Point(801, 412);
            UsernameEntryBox.Margin = new Padding(3, 4, 3, 4);
            UsernameEntryBox.Name = "UsernameEntryBox";
            UsernameEntryBox.Size = new Size(282, 35);
            UsernameEntryBox.TabIndex = 30;
            UsernameEntryBox.Visible = false;
            UsernameEntryBox.KeyPress += LoginEnterKeyPress;
            // 
            // UsernameBox
            // 
            UsernameBox.Enabled = false;
            UsernameBox.Location = new Point(801, 372);
            UsernameBox.Margin = new Padding(3, 4, 3, 4);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(175, 35);
            UsernameBox.TabIndex = 31;
            UsernameBox.Text = "Enter Username";
            UsernameBox.Visible = false;
            // 
            // PasswordBox
            // 
            PasswordBox.Enabled = false;
            PasswordBox.Location = new Point(801, 454);
            PasswordBox.Margin = new Padding(3, 4, 3, 4);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(175, 35);
            PasswordBox.TabIndex = 32;
            PasswordBox.Text = "Enter Password";
            PasswordBox.Visible = false;
            // 
            // PasswordEntryBox
            // 
            PasswordEntryBox.Location = new Point(801, 496);
            PasswordEntryBox.Margin = new Padding(3, 4, 3, 4);
            PasswordEntryBox.Name = "PasswordEntryBox";
            PasswordEntryBox.Size = new Size(282, 35);
            PasswordEntryBox.TabIndex = 33;
            PasswordEntryBox.Visible = false;
            PasswordEntryBox.KeyPress += LoginEnterKeyPress;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(801, 586);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(130, 40);
            LoginButton.TabIndex = 34;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Visible = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // StockBox
            // 
            StockBox.Enabled = false;
            StockBox.Location = new Point(358, 810);
            StockBox.Margin = new Padding(3, 4, 3, 4);
            StockBox.Name = "StockBox";
            StockBox.Size = new Size(66, 35);
            StockBox.TabIndex = 35;
            StockBox.Text = "Stock:";
            StockBox.Visible = false;
            // 
            // StockEntryBox
            // 
            StockEntryBox.Location = new Point(429, 810);
            StockEntryBox.Margin = new Padding(3, 4, 3, 4);
            StockEntryBox.Name = "StockEntryBox";
            StockEntryBox.Size = new Size(175, 35);
            StockEntryBox.TabIndex = 36;
            StockEntryBox.Visible = false;
            // 
            // IDBox
            // 
            IDBox.Enabled = false;
            IDBox.Location = new Point(801, 289);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(104, 35);
            IDBox.TabIndex = 37;
            IDBox.Text = "Enter ID";
            IDBox.Visible = false;
            // 
            // IDEntryBox
            // 
            IDEntryBox.Location = new Point(801, 330);
            IDEntryBox.Name = "IDEntryBox";
            IDEntryBox.Size = new Size(282, 35);
            IDEntryBox.TabIndex = 38;
            IDEntryBox.Visible = false;
            // 
            // IDGenerateButton
            // 
            IDGenerateButton.Location = new Point(924, 289);
            IDGenerateButton.Name = "IDGenerateButton";
            IDGenerateButton.Size = new Size(118, 35);
            IDGenerateButton.TabIndex = 39;
            IDGenerateButton.Text = "Generate ID";
            IDGenerateButton.UseVisualStyleBackColor = true;
            IDGenerateButton.Visible = false;
            IDGenerateButton.Click += IDGenerateButton_Click;
            // 
            // CheckAdminBox
            // 
            CheckAdminBox.AutoSize = true;
            CheckAdminBox.Location = new Point(801, 545);
            CheckAdminBox.Name = "CheckAdminBox";
            CheckAdminBox.Size = new Size(100, 34);
            CheckAdminBox.TabIndex = 40;
            CheckAdminBox.Text = "Admin";
            CheckAdminBox.UseVisualStyleBackColor = true;
            CheckAdminBox.Visible = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1896, 1016);
            Controls.Add(CheckAdminBox);
            Controls.Add(IDGenerateButton);
            Controls.Add(IDEntryBox);
            Controls.Add(IDBox);
            Controls.Add(StockEntryBox);
            Controls.Add(StockBox);
            Controls.Add(LoginButton);
            Controls.Add(PasswordEntryBox);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(UsernameEntryBox);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainWindow";
            Text = "Library Management System";
            FormClosing += MainWindow_Closing;
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
        private TextBox UsernameEntryBox;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private TextBox PasswordEntryBox;
        private Button LoginButton;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem createUserToolStripMenuItem;
        private TextBox StockBox;
        private TextBox StockEntryBox;
        private TextBox IDBox;
        private TextBox IDEntryBox;
        private Button IDGenerateButton;
        private CheckBox CheckAdminBox;
    }
}
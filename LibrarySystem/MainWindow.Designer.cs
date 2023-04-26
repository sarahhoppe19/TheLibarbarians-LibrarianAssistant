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
            NextButton = new Button();
            SearchBox = new TextBox();
            loginToolStripMenuItem = new ToolStripMenuItem();
            PrevButton = new Button();
            PageText = new TextBox();
            CoverImageBox = new PictureBox();
            BookDescBox = new TextBox();
            ResultBox1 = new TextBox();
            ResultBox2 = new TextBox();
            ResultBox3 = new TextBox();
            ResultBox4 = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CoverImageBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1896, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // NextButton
            // 
            NextButton.Location = new Point(1046, 888);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(131, 40);
            NextButton.TabIndex = 1;
            NextButton.Text = "Next>>";
            NextButton.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(721, 43);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(524, 35);
            SearchBox.TabIndex = 2;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(97, 34);
            loginToolStripMenuItem.Text = "Login...";
            // 
            // PrevButton
            // 
            PrevButton.Location = new Point(817, 888);
            PrevButton.Name = "PrevButton";
            PrevButton.Size = new Size(131, 40);
            PrevButton.TabIndex = 3;
            PrevButton.Text = "<<Prev";
            PrevButton.UseVisualStyleBackColor = true;
            // 
            // PageText
            // 
            PageText.Location = new Point(954, 890);
            PageText.Name = "PageText";
            PageText.Size = new Size(86, 35);
            PageText.TabIndex = 4;
            // 
            // CoverImageBox
            // 
            CoverImageBox.Location = new Point(1355, 43);
            CoverImageBox.Name = "CoverImageBox";
            CoverImageBox.Size = new Size(450, 500);
            CoverImageBox.TabIndex = 5;
            CoverImageBox.TabStop = false;
            // 
            // BookDescBox
            // 
            BookDescBox.Location = new Point(1355, 549);
            BookDescBox.Multiline = true;
            BookDescBox.Name = "BookDescBox";
            BookDescBox.Size = new Size(450, 219);
            BookDescBox.TabIndex = 6;
            // 
            // ResultBox1
            // 
            ResultBox1.Location = new Point(104, 120);
            ResultBox1.Multiline = true;
            ResultBox1.Name = "ResultBox1";
            ResultBox1.Size = new Size(936, 150);
            ResultBox1.TabIndex = 7;
            // 
            // ResultBox2
            // 
            ResultBox2.Location = new Point(104, 298);
            ResultBox2.Multiline = true;
            ResultBox2.Name = "ResultBox2";
            ResultBox2.Size = new Size(936, 150);
            ResultBox2.TabIndex = 8;
            // 
            // ResultBox3
            // 
            ResultBox3.Location = new Point(104, 475);
            ResultBox3.Multiline = true;
            ResultBox3.Name = "ResultBox3";
            ResultBox3.Size = new Size(936, 150);
            ResultBox3.TabIndex = 9;
            // 
            // ResultBox4
            // 
            ResultBox4.Location = new Point(104, 652);
            ResultBox4.Multiline = true;
            ResultBox4.Name = "ResultBox4";
            ResultBox4.Size = new Size(936, 150);
            ResultBox4.TabIndex = 10;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1896, 1016);
            Controls.Add(ResultBox4);
            Controls.Add(ResultBox3);
            Controls.Add(ResultBox2);
            Controls.Add(ResultBox1);
            Controls.Add(BookDescBox);
            Controls.Add(CoverImageBox);
            Controls.Add(PageText);
            Controls.Add(PrevButton);
            Controls.Add(SearchBox);
            Controls.Add(NextButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private TextBox PageText;
        private PictureBox CoverImageBox;
        private TextBox BookDescBox;
        private TextBox ResultBox1;
        private TextBox ResultBox2;
        private TextBox ResultBox3;
        private TextBox ResultBox4;
    }
}
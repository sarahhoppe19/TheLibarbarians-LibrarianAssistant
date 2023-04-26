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

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
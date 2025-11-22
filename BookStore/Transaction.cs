namespace BookStore
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
            deals.DataSource = Header.Select();
        }
    }
}
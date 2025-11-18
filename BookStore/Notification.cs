namespace BookStore
{
    public partial class Notification : Form
    {
        public Notification(string text)
        {
            InitializeComponent();
            stackTrace.Text = text;
        }
    }
}
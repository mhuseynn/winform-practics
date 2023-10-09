namespace label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void change_label_position()
        {
            Random random = new Random();
            int maxX = this.ClientSize.Width - label1.Width;
            int maxY = this.ClientSize.Height - label1.Height;

            int newX = random.Next(maxX);
            int newY = random.Next(maxY);

            label1.Location = new Point(newX, newY);
        }
        private void dasd(object sender, EventArgs e)
        {
           change_label_position();
        }
    }
}
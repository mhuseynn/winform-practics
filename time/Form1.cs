namespace WinFormPractics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_baku_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = time.Properties.Resources.bakuu;
            city.Text = "Current time in Baku, Azerbaijan ‎(UTC+4)‎";
            time_clock.Text = DateTime.Now.ToString();
        }

        private void london_button_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = time.Properties.Resources.london;
            city.Text = "Current time in London, United Kingdom ‎(UTC+1)‎";
            DateTime utcNow = DateTime.UtcNow;
            TimeSpan utcOffset = TimeSpan.FromHours(1);
            DateTime cetTime = utcNow + utcOffset;
            time_clock.Text = cetTime.ToString("yyyy-MM-dd HH:mm:ss");

        }


    }
}
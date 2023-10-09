namespace draw_rectangle
{
    public partial class Form1 : Form
    {

        bool isdraw;
        Point start;
        Point end;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
            isdraw = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawRectangle(Pens.Blue, Math.Min(start.X,end.X), Math.Min(start.Y, end.Y), Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y));
            isdraw = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isdraw)
            {
                end = e.Location;
                pictureBox1.Refresh();
            }
        }


    }
}
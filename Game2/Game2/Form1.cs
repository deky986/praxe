namespace Game2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int m = 7;
            int n = 4;

            int squareSizeX = pictureBox1.Width / m;
            int squareSizeY = pictureBox1.Height / n;

            Graphics canva = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(0, 0, 0));

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    canva.DrawEllipse(pen, i * squareSizeX, j * squareSizeY, squareSizeX, squareSizeY);
                }
            }


        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int positionX = e.X / squareSizeX;
            int positionY = e.Y / squareSizeY;
        }
    }
}
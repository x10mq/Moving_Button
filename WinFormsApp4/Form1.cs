namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int newX = random.Next(0, this.ClientSize.Width - button1.Width);
            int newY = random.Next(0, this.ClientSize.Height - button1.Height);
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            this.BackColor = randomColor;
            button1.Location = new Point(newX, newY);
        }
    }
}
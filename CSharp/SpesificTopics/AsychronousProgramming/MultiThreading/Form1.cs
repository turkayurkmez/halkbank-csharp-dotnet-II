namespace MultiThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        Thread thread = null;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(counter));
            thread.Start();

            thread.Join();
            MessageBox.Show("Bitti");
        }

        void counter()
        {
            for (int i = 0; i <= 20000; i++)
            {
                labelCounter.Text = i.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tıklandı");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

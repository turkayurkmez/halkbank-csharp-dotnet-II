namespace MultiTasking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {

            await Task.Run(() =>
             {
                 for (int i = 0; i <= 20000; i++)
                 {
                     labelCounter.Text = i.ToString();
                     progressBar1.Value = i / 200;

                 }
             });

            MessageBox.Show("İşlem tamamlandı");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tıklandı");
        }
    }
}

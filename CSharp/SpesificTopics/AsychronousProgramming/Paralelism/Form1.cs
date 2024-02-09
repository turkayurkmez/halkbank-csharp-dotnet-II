namespace Paralelism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void buttonParallel1_Click(object sender, EventArgs e)
        {
            var numbers = Enumerable.Range(0, 10000).ToList();

            var multiplyByFive = numbers.AsParallel().Where(x => x % 5 == 0).OrderBy(x => x);

            Parallel.ForEach(multiplyByFive, n => listBoxNumbers.Items.Add(n.ToString()));


        }
    }
}

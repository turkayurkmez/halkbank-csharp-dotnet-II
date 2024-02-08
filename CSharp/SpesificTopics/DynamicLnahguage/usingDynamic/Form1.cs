namespace usingDynamic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormBag.Isim = "Türkay";
            form2.FormBag.IstenenDosyalar = new List<string>() { "A", "B", "C" };
            form2.FormBag.Color = Color.Pink;


            form2.AlternativeFormBag.NewMessage = "Bu mesaj, Expando object ile geldi!";


            form2.Show();
        }
    }
}

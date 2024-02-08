using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace usingDynamic
{
    public partial class Form2 : Form, IFormBagContainer
    {
        public Form2()
        {
            FormBag = new FormBag();
            AlternativeFormBag = new ExpandoObject();


            InitializeComponent();
        }

        public dynamic FormBag { get; set; }
        public dynamic AlternativeFormBag { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            //form2.FormBag.Isim = "Türkay";
            //form2.FormBag.IstenenDosyalar = new List<string>() { "A", "B", "C" };
            label1.Text = FormBag.Isim;
            foreach (var item in FormBag.IstenenDosyalar)
            {
                listBox1.Items.Add(item);
            }

            label2.Text = AlternativeFormBag.NewMessage;

            BackColor = FormBag.Color;
        }
    }
}

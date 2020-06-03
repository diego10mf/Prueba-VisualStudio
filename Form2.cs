using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class Form2 : Form

    {
        private List<Coche> Coches = new List<Coche>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Coches.Add(new Coche() { Nombre = "Corsa", Marca = "Opel" });

            listBox1.Items.Add("Mesa");
            listBox1.Items.Add("Silla");

            listBox1.DataSource = Coches;
            //listBox1.DisplayMember = "Nombre";

            for (int i=0; i < 10; i++)
            {
                progressBar1.PerformStep();
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

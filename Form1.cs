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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAcerptar_MouseEnter(object sender, EventArgs e)
        {
            btnAcerptar.BackColor = Color.Blue;
        }

        private void BtnAcerptar_MouseLeave(object sender, EventArgs e)
        {
            btnAcerptar.BackColor = Color.White;
        }

        private void BtnAcerptar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hola");
            lblEtiqueta.Text = "Estamo bien";

        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hola", "Saludo");
        }

        private void Nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.A)
            {
                lblEtiqueta.Text = "Adios";
                e.SuppressKeyPress = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbcaja.Checked = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("‪‪C:|Users|Diego|Desktop|th.jpg");
        }

        private void Btnnext_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}

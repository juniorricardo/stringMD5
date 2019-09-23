using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMD5hash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtContenido.Text))
            {
                txtHash.Text = Program.ToMD5Hash(txtContenido.Text);
            }
            else
                MessageBox.Show("Ingrese una cadena de texto.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtContenido.Clear();
            txtHash.Clear();
            Clipboard.Clear();
            txtContenido.Focus();
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtContenido.Text))
            {
                txtHash.SelectAll();
                txtHash.Copy();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtContenido.Focus();
        }

    }
}

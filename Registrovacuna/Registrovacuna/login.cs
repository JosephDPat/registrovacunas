using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registrovacuna
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
//Diseño del formulario
        private void textBox1_Click(object sender, EventArgs e)
        {
            txtcurplog.Clear();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            altas frm = new altas();
            frm.Show();
        }
        private void txtcontrasena_Click(object sender, EventArgs e)
        {
            txtemaillog.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Fin diseño del formulario
        private void btnacceder_Click(object sender, EventArgs e)
        {
            string correolog = txtcurplog.Text.ToString().ToUpper();
            string curplog = txtemaillog.Text.ToString().ToUpper();
            //Revisar validacion de curp y correo
            if (Evitarduplicados.Existe(curplog) != false && Evitarduplicados.Correo(correolog) !=false)
            {
                MessageBox.Show("Bienvenido al sistema");
            }
            else
            {
                MessageBox.Show("CURP o correo email invalido.\nIntente nuevamente.");
            }
        }
    }
}

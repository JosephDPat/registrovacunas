using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        //Fin diseño del formulario
        private void btnacceder_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-PAT\\SQLEXPRESS; database=dbvacunas; integrated security=true"); // creamos la conexion  

            //Seleccionamos todos los datos de la tabla y los comparamos con los del usuario
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Usuarios WHERE Curp LIKE '" + txtcurplog.Text + "' AND Email LIKE '" + txtemaillog.Text + "'", con);
            DataTable dt = new DataTable(); //Creamos una tabla con los datos obtenidos de la BD 
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")//Comparamos ambos datos
            {
                //Si los datos son correctos y estan registrados, se abre el menu principal
                this.Hide();
                new frmmenu().Show();
            }
            else
            {
                MessageBox.Show("CURP o Email invalido.");
            }
        }
    }
}

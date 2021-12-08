using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Registrovacuna
{
    public partial class altas : Form
    {
        public altas()
        {
            InitializeComponent();
        }
        //Diseño del formulario-----------------------------------------------------

        private void txtnombre_Click(object sender, EventArgs e)
        {
            txtnombre.BackColor = Color.FromArgb(255, 255, 255);
            txtnombre.Clear();
        }

        private void txtappaterno_Click(object sender, EventArgs e)
        {
            txtappaterno.Clear();
            txtapmaterno.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void txtapmaterno_Click(object sender, EventArgs e)
        {
            txtapmaterno.Clear();
            txtapmaterno.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechanacimiento = dtpfecha.Value;

            txtfechanac.Text = fechanacimiento.ToString().Substring(0, 10);
            txtfechanac.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void txtcorreo_Click(object sender, EventArgs e)
        {
            txtcorreo.Clear();
        }

        private void txttelefono_Click(object sender, EventArgs e)
        {
            txttelefono.Clear();
        }
        private void txtlugarnac_Click(object sender, EventArgs e)
        {
            txtlugarnac.Clear();
            txtlugarnac.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm = new login();
            frm.Show();
        }
        //Fin del diseño del formulario---------------------------------------------
        private void altas_Load(object sender, EventArgs e)
        {

        }
        //Metodo para ubicar la segunda consonante de la palabra para los ultimos tres caracteres
        public string consonantes(string palabra)
        {
            int contador = 0;
            string letra="";
            char[] consonantes = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm','n','p','q','r','s','t','v','w','x','y','z' };

            var conson = palabra.ToLower();

            foreach (var cons in conson)
            {
                if (palabra.Contains(cons))
                {
                    if (contador == 1)
                    {
                        letra = cons.ToString();
                    }
                    contador++;
                }
            }
            return letra;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //Validacion de campos vacios en el formulario y los señalamos
            if (txtnombre.Text.Length == 0 || txtnombre.Text.ToString() == "Nombre(s)")
            {
                this.txtnombre.BackColor = Color.FromArgb(253, 69, 29);
            }
            else { this.txtnombre.BackColor = Color.FromArgb(255, 255, 255); }

            if (txtappaterno.Text.Length == 0 || txtappaterno.Text.ToString() == "Primer apellido")
            {
                this.txtappaterno.BackColor = Color.FromArgb(253, 69, 29);
            }
            else { this.txtappaterno.BackColor = Color.FromArgb(255, 255, 255); }

            if (txtapmaterno.Text.Length == 0 || txtapmaterno.Text.ToString() == "Segundo apellido")
            {
                this.txtapmaterno.BackColor = Color.FromArgb(253, 69, 29);
            }
            else { this.txtapmaterno.BackColor = Color.FromArgb(255, 255, 255); }

            if (txtfechanac.Text.Length == 0 || txtfechanac.Text.ToString() == "Fecha de nacimiento")
            {
                this.txtfechanac.BackColor = Color.FromArgb(253, 69, 29);
            }
            else { this.txtfechanac.BackColor = Color.FromArgb(255, 255, 255); }

            if (txtlugarnac.Text.Length == 0 || txtlugarnac.Text.ToString() == "Lugar de nacimiento")
            {
                this.txtlugarnac.BackColor = Color.FromArgb(253, 69, 29);
            }
            else { this.txtlugarnac.BackColor = Color.FromArgb(255, 255, 255); }

            if (cmbsexo.SelectedItem == null)
            {
                this.cmbsexo.BackColor = Color.FromArgb(253, 69, 29);
            }
            //Fin de validacion de campos vacios

            //Recolectamos los datos del usuario para validar la curp, usamos un try&catch para cuando la longitud pueda causar un error al capturar campos vacios
            try
            {
                string curp;
                string fec = txtfechanac.Text.ToString();
                string lugar = txtlugarnac.Text.ToString();

                curp = txtappaterno.Text.ToString().ToUpper().Substring(0, 2) + txtapmaterno.Text.ToString().ToUpper().Substring(0, 1) + txtnombre.Text.ToString().ToUpper().Substring(0, 1) + fec.Substring(8, 2) + fec.Substring(3, 2) + fec.Substring(0, 2) + cmbsexo.SelectedItem.ToString().Substring(0, 1) + txtlugarnac.Text.ToString().Substring(0, 1) + lugar.Substring(lugar.Length - 1, 1) + consonantes(txtappaterno.Text.ToString()) + consonantes(txtapmaterno.Text.ToString()) + consonantes(txtnombre.Text.ToString());

                curp = curp.ToUpper();

                lblcurp.Text = curp.ToUpper();
            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("Existen campos vacios");
            }            
            //Fin de recolecta de datos

            //Convertimos el dato de fecha a un formato valido para pasarlo a la BD
            DateTime fecha = Convert.ToDateTime(dtpfecha.Value.Date.ToString("dd-MM-yyyy"));
            //Fin de conversion del formato

            string crp = lblcurp.Text.ToString().ToUpper();
            //Validamos que el campo Email sea correcto
            if (validarcorreo.IsValidEmail(txtcorreo.Text) != false)
            {
                //Validamos que no exista una curp igual en la BD
                if (Evitarduplicados.Existe(lblcurp.Text.ToString().ToUpper())==false)
                {
                    //El numero de telefono no es obligatorio, si no se coloca el dato, se pasa cadena vacia para guardar en la BD
                    if (txttelefono.Text == "Numero de telefono")
                    {
                        txttelefono.Text = "";
                    }
                    //Se realiza la llamada al metodo para crear un usuario, si el resultado es 1, significa que sí se creo el usuario correctamente
                    if (registrousuarios.CrearUsuario(txtnombre.Text, txtappaterno.Text, txtapmaterno.Text, fecha, txtlugarnac.Text, cmbsexo.SelectedItem.ToString(), txtcorreo.Text, txttelefono.Text, lblcurp.Text) > 0)
                    {
                        MessageBox.Show("Usuario registrado exitosamente.\nPara acceder, usa tu CURP y tu E-mail.");

                        this.Hide();
                        login frm = new login();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error al crear la cuenta. Contacte al administrador");
                    }//Fin de creacion de usuario
                }
                else
                {
                    MessageBox.Show("Ya se encuentra registrado la CURP");
                    this.Hide();
                    login frm = new login();
                    frm.Show();
                }//Fin validacion de campo telefono
            }
            else
            {
                MessageBox.Show("Ingrese un correo valido");
            }//Fin de validacion del campo Email
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Registrovacuna
{
    class registrousuarios
    {
        public static int CrearUsuario(string pnombre, string ppaterno, string pmaterno, DateTime pnacimiento, string plugar, string psexo, string pemail, string pcelular, string pcurp)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-PAT\\SQLEXPRESS; database=dbvacunas; integrated security=true");
            int resultado = 0;
            conexion.Open();
            SqlCommand comando = new SqlCommand(string.Format("Insert into Usuarios(Nombre, Appaterno, Apmaterno, Nacimiento,Lugarnac, Sexo, Email, Celular, Curp) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", pnombre, ppaterno, pmaterno, pnacimiento, plugar, psexo, pemail, pcelular, pcurp), conexion);
            resultado = comando.ExecuteNonQuery();
            conexion.Close();
            return resultado;
        }
    }
}

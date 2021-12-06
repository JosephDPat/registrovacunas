using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Registrovacuna
{
    class Evitarduplicados
    {
        public static bool Existe(string id)
        {
            //Conexion a la base de datos
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-PAT\\SQLEXPRESS; database=dbvacunas; integrated security=true"))
            {
                //Consulta a la base de datos para comparar los datos de la curp
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Curp LIKE @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                //El campo Id es variable, así que aquí lo cambiamos con cada consulta
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();

                /*int count = Convert.ToInt32(cmd.ExecuteScalar());*/
                int count = (int)(cmd.ExecuteScalar());
                //Si el resultado es igual a cero, no existe la curp
                if (count == 0)
                    return false;
                else
                    return true;
                conn.Close();
            }
        }
    }
}

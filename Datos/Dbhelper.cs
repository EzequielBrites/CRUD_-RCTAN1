using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_RCTAN1.Dominio;


namespace CRUD_RCTAN1.Datos
{
    class Dbhelper
    {
        private SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
        private SqlCommand comando = new SqlCommand();

        private void ConfigurarComando_SP(string SPNombre)
        {
            comando.Connection = conexion;
            comando.CommandText = SPNombre;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
        }
        public DataTable Consultar_SP(string SPNombre)
        {
            DataTable t = new DataTable();

            conexion.Open();
            ConfigurarComando_SP(SPNombre);
            t.Load(comando.ExecuteReader());

            conexion.Close();

            return t;
        }
        public DataTable Consultar_Ciudades(string SPName, int id_provincia)
        {
            DataTable tabla = new DataTable();


            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = SPName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_provincia", id_provincia+1);
                tabla.Load(cmd.ExecuteReader());

            }
            catch (Exception e)
            {

            }
            finally
            {
                conexion.Close();
            }
            return tabla;
        }
        public DataTable Consultar_grados(string SPName, int id_tipo_grado)
        {
            DataTable tabla = new DataTable();


            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = SPName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tipos_grados", id_tipo_grado+1);
                tabla.Load(cmd.ExecuteReader());

            }
            catch (Exception e)
            {

            }
            finally
            {
                conexion.Close();
            }
            return tabla;
        }
        public int VerificarUsuario(string usuario, string pass)
        {
            
            
            try
            {
                conexion.Open();
                ConfigurarComando_SP("sp_verificar_usuario");
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseña", pass);

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conexion.Close();
            }

            return -1;
        }
        public int actualizarBD(string sp, List<Parametro> lparametros)
        {
            int filasAfectadas = 0;
            conexion.Open();
            comando.CommandText = sp;
            foreach (Parametro p in lparametros)
            {
                comando.Parameters.AddWithValue(p.pNombre, p.pValor);
            }
            filasAfectadas = comando.ExecuteNonQuery();
            conexion.Close();
            return filasAfectadas;
        }


    }
}

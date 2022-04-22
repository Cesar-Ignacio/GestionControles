using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace GestionControl.Dao
{
    internal class conexionDAO
    {
        private String rutaConexion = "Data Source=LAPTOP-VDD24BSI\\SQLEXPRESS;Initial Catalog=Control;Integrated Security=True";
        private SqlConnection conexion;

        public SqlConnection establecerConexion()
        {
            this.conexion= new SqlConnection(rutaConexion);
            this.conexion.Open();
            return this.conexion;
        }

        public void cerraConexion()
        {
            conexion.Close();
        }
        

        public bool obtencionDeDatos()
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Marca";
                cmd.Connection = establecerConexion();
                cmd.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch
            {
                return false;   
            }
        }
        public bool obtencionDeUnDato(SqlCommand oComando, ref String valorRetorno)
        {
            try
            {

                SqlCommand cmd = oComando;
                cmd.Connection = establecerConexion();
                valorRetorno=Convert.ToString(cmd.ExecuteScalar());
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool obtencionDeUnDato(String consulta, ref String valorRetorno)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = consulta;
                cmd.Connection = establecerConexion();
                valorRetorno = Convert.ToString(cmd.ExecuteScalar());
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool obtencionDeDatos(String consulta,ref DataSet ds)
        {

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = consulta;
                cmd.Connection = establecerConexion();
                SqlDataAdapter adapter = new SqlDataAdapter(consulta,conexion);
                adapter.Fill(ds,"Tabla");
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool obtencionDeDatos(String consulta,ref SqlDataReader oDr)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = consulta;
                cmd.Connection = establecerConexion();
                oDr=cmd.ExecuteReader();
                
                return true;
            }
            catch
            {
                return false;
            }
        }
        //ejecucion mediante un procedimiento almacenado
        public bool ejecucionDeComandos(SqlCommand oComando,string nombreSP)
        {
            try
            {

                SqlCommand cmd = oComando;
                cmd.Connection = establecerConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;
                cmd.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //ejecucion mediante una consulta
        public bool ejecucionDeComandos(String consulta)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = consulta;
                cmd.Connection = establecerConexion();
                cmd.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ejecucionDeComandos(String consulta,ref int filasA)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = consulta;
                cmd.Connection = establecerConexion();
                filasA=cmd.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}

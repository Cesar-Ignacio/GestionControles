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


    }
}

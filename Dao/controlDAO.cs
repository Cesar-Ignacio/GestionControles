using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionControl.Negocio;
using System.Data;
using System.Data.SqlClient;

namespace GestionControl.Dao
{
    internal class controlDAO
    {
        conexionDAO oConexionDAO;

        SqlCommand oComando;

        String consulta;

        public controlDAO()
        {
            oConexionDAO = new conexionDAO();
            oComando= new SqlCommand();
        }

        public bool insertarControl(ControlNEG oControlNEG)
        {

            cargaDeParametros(oControlNEG);
                        
            return oConexionDAO.ejecucionDeComandos(oComando, "sp_InsertControl");
           
        }

        public void cargaDeParametros(ControlNEG oControlNEG)
        {
            SqlParameter sqlParameter = new SqlParameter();

            sqlParameter = oComando.Parameters.Add("@codControl", SqlDbType.Char);
            sqlParameter.Value = oControlNEG.codControl;
            sqlParameter = oComando.Parameters.Add("@cantidad", SqlDbType.Int);
            sqlParameter.Value = oControlNEG.cantidad;
            sqlParameter = oComando.Parameters.Add("@imagen", SqlDbType.Image);
            sqlParameter.Value = oControlNEG.imagenControl;

        }


        public DataTable obtenerControles()
        {
            consulta = "select codControl,cantidad, imagen from Control";
            DataSet ds = new DataSet();
            oConexionDAO.obtencionDeDatos(consulta, ref ds);
            return ds.Tables["Tabla"];
        }

        public bool actualizarControl(ControlNEG oControlNEG)
        {
            // consulta = "UPDATE Control set cantidad="+oControlNEG.cantidad+", imagen="+oControlNEG.imagenControl+" where codControl='"+oControlNEG.codControl+"'";
            // consulta = "UPDATE Control set cantidad="+oControlNEG.cantidad+", imagen="+oControlNEG.imagenControl.ToArray()+" where codControl='"+oControlNEG.codControl+"'";
            cargaDeParametros(oControlNEG);
            return oConexionDAO.ejecucionDeComandos(oComando, "spActualizarControl");   
        }

        public bool eliminarControl(ControlNEG oControlNEG)
        {
            consulta = "delete from Control where codControl='"+oControlNEG.codControl+"'";
            
            return oConexionDAO.ejecucionDeComandos(consulta);
        }
        public bool actualizarControlStock(ControlNEG oControlNEG)
        {
            consulta = "UPDATE Control set cantidad= cantidad - " +oControlNEG.cantidad+" where codControl='"+oControlNEG.codControl+"'";
            return oConexionDAO.ejecucionDeComandos(consulta);

        }
       


    }
}

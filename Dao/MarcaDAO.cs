using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using GestionControl.Negocio;
namespace GestionControl.Dao
{
    internal class MarcaDAO
    {

        conexionDAO oConexionDAO;
        SqlCommand cmd;
        String consulta;
        SqlDataReader oDtR;
        DataSet dts;
        public MarcaDAO()
        {
            oConexionDAO = new conexionDAO();
            cmd = new SqlCommand();
            dts=new DataSet();

        }

        public string  obtenerCodMarca(MarcaNEG marcaNeg)
        {
            String codMarca = "";
            cmd.CommandText = "select codMarca from Marca where nombreMarca = @nombreMarca";
            cmd.Parameters.Add("@nombreMarca", SqlDbType.Char).Value=marcaNeg.nombreMarca;          
            oConexionDAO.obtencionDeUnDato(cmd, ref codMarca);
            return codMarca;
        }
        public string obtenerCodMarca1(MarcaNEG marcaNeg)
        {
            String codMarca = "";
            String consulta= "select codMarca from Marca where nombreMarca = '"+marcaNeg.nombreMarca+"'";
            
            oConexionDAO.obtencionDeUnDato(consulta, ref codMarca);
            return codMarca;
        }
        public SqlDataReader obtencionDeMarcas()
        {
            consulta = "select nombreMarca from Marca";

            oConexionDAO.obtencionDeDatos(consulta, ref oDtR);

            return oDtR;
        }

        public DataTable controlesDeMarca(MarcaNEG oMarcaNEGO)
        {
           consulta = "select Control.codControl, cantidad, nombreMarca, imagen from Control_X_Marca inner join Marca on Marca.codMarca = Control_X_Marca.codMarca inner join Control on Control.codControl = Control_X_Marca.codControl where Marca.nombreMarca = '"+oMarcaNEGO.nombreMarca+"'";
           dts = new DataSet();
       
           oConexionDAO.obtencionDeDatos(consulta,ref dts);

            return dts.Tables["Tabla"];
        }

        public void cerrarConexion()
        {
            oConexionDAO.cerraConexion();
        }
    }
}

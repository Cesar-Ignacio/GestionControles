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
        public MarcaDAO()
        {
            oConexionDAO = new conexionDAO();
            cmd = new SqlCommand();
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

    }
}

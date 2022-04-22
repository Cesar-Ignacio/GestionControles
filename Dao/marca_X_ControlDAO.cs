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
    internal class marca_X_ControlDAO
    {

        SqlCommand cmd;
        conexionDAO oConexionDAO;
        String consulta;
        public marca_X_ControlDAO()
        {
            cmd = new SqlCommand();
            oConexionDAO = new conexionDAO();
        }

        public bool guaradarControlMarca(MarcaControlNEG oMarcaContrlNEG)
        {
            cargaParametros(oMarcaContrlNEG);

            return oConexionDAO.ejecucionDeComandos(cmd, "sp_InsertaMarcaControl");
        }

        

        public void cargaParametros(MarcaControlNEG oMarcaControlNEG)
        {
            SqlParameter sp = new SqlParameter();

            sp = cmd.Parameters.Add("@codControl", SqlDbType.Char);
            sp.Value = oMarcaControlNEG.codControl;
            sp = cmd.Parameters.Add("@codMarca", SqlDbType.Char);
            sp.Value = oMarcaControlNEG.codMarca;

        }

        public bool guaradarControlMarca1(MarcaControlNEG oMarcaContrlNEG)
        {
            consulta = "INSERT INTO Control_X_Marca (codControl,codMarca) SELECT '" + oMarcaContrlNEG.codControl + "','" + oMarcaContrlNEG.codMarca + "'";
            return oConexionDAO.ejecucionDeComandos(consulta);
        }

        public bool actualizarDatos(MarcaControlNEG oMarcaControlNEG)
        {
           
   
            cargaParametros2(oMarcaControlNEG);

            return oConexionDAO.ejecucionDeComandos(cmd,"sp_EliminarMarcaControl");
            //int fiAF=0;
            //consulta= "delete from Control_X_Marca where codControl='"+cod+"'";
            //oConexionDAO.ejecucionDeComandos(consulta,ref fiAF);
            //return fiAF;
        }
        public void cargaParametros2(MarcaControlNEG oMarcaControlNEG)
        {
            SqlParameter sp = new SqlParameter();

            sp = cmd.Parameters.Add("@codControl", SqlDbType.Char);
            sp.Value = oMarcaControlNEG.codControl;

        }


    }
}

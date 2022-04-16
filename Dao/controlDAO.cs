using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionControl.Dao
{
    internal class controlDAO
    {
        conexionDAO oConexionDAO;

        public controlDAO()
        {
            oConexionDAO = new conexionDAO();
        }

        public bool obtencion()
        {
           return oConexionDAO.obtencionDeDatos();
        }


    }
}

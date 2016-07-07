using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Datos_IA
{
    public class conexion
    {
        #region singleton
        private static readonly conexion _instancia = new conexion();
        //private Conexion(){}
        public static conexion Instancia
        {
            get { return conexion._instancia; }
        }
        #endregion

        public SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString =
                "Data Source=.;Initial Catalog=BDTesis;Integrated Security=True";
            return cn;
        }
    }
}

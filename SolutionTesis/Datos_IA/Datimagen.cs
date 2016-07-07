using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidad_IA;
namespace Datos_IA
{
   public  class Datimagen
    {
        public SqlDataAdapter dta = null;
        public DataSet dts = null;
        public SqlCommand cmd = null;
        //public SqlConnection cnn = null;
        public Entidad_IA.imagen objimagen;
        public void ingresar_imagen(imagen objimagen)
        {
            conexion cnn = new conexion();
            cnn.conectar();
            dta.SelectCommand = new SqlCommand("sp_ingresarimagen");
            dta.SelectCommand.CommandType = CommandType.StoredProcedure;
            dta.SelectCommand.Parameters.Add(new SqlParameter("@Id_Imagen", objimagen.Id_Imagen));
            dta.SelectCommand.Parameters.Add(new SqlParameter("@Ruta", objimagen.Ruta));
            dta.SelectCommand.Parameters.Add(new SqlParameter("@Nombre", objimagen.Nombre));
            dta.Fill(dts, "denuncia");

        }

    }
}

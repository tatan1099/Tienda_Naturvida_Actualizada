using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private SqlConnection conexion = new SqlConnection("Data Source=SQL5110.site4now.net;Initial Catalog=db_a98492_naturvida2;User Id=db_a98492_naturvida2_admin;Password=jonathan12");
      //  "Data Source=SQL5110.site4now.net;Initial Catalog=db_a98492_naturvida2;User Id=db_a98492_naturvida2_admin;Password=YOUR_DB_PASSWORD
       // private SqlConnection conexion = new SqlConnection("Server=BUCDFPCSEFSD038;Database=NaturVida; Integrated Security=true");
        //private SqlConnection conexion = new SqlConnection("Data Source=SQL5110.site4now.net;Initial Catalog=db_a98492_naturvida2;User Id=db_a98492_naturvida2_admin;Password=jonathan12");

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)

                conexion.Open();

            return conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Closed)

                conexion.Close();

            return conexion;
        }
    }
}

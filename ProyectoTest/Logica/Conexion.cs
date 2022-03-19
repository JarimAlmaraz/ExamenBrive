using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace ProyectoTest.Logica
{
    public class Conexion
    {
        public static string Get()
        {
            string conexion = ConfigurationManager.ConnectionStrings["DB_CARRITO"].ConnectionString;
            return conexion;
        }


        //public static string CN = "Data Source=.;Initial Catalog=DB_CARRITO;Integrated Security=True";
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaDatos_PolizayComision
{
    public class Conexion
    {
        private OdbcConnection OdbcConnection;

        public OdbcConnection Conectar()
        {
            OdbcConnection = new OdbcConnection("Dsn=HSC");

            try
            {
                //                MessageBox.Show("Succesful");
                OdbcConnection.Open();
            }
            catch
            {

                MessageBox.Show("Error en la conexion");

            }
            return OdbcConnection;

        }
    }
}


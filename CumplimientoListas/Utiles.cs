using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumplimientoListas
{
    class Utiles
    {
        //Conexión para Ambiente de Producción:
        public static string conProduccion(string Usuario, string Password, string Host, string Puerto, string SID)
        {
            return String.Format("User Id={0};Password={1};Data Source=(DESCRIPTION=" + "(ADDRESS=(PROTOCOL=TCP)(HOST={2})(PORT={3}))" +
                                 "(CONNECT_DATA=(SID={4})));", Usuario, Password, Host, Puerto, SID);
        }
        //Conexión para Ambiente de Desarrollo:
        public static string conDesarrollo(string Usuario, string Password, string Host, string Puerto, string SID)
        {
            return String.Format("User Id={0};Password={1};Data Source=(DESCRIPTION=" + "(ADDRESS=(PROTOCOL=TCP)(HOST={2})(PORT={3}))" +
                                 "(CONNECT_DATA=(SID={4})));", Usuario, Password, Host, Puerto, SID);
        }

        //Conexión para Oracle Express Edition:
        public static string conOracleXE(string Usuario, string Password, string Host, string Puerto, string SID)
        {
            return String.Format("User Id={0};Password={1};Data Source=(DESCRIPTION=" + "(ADDRESS=(PROTOCOL=TCP)(HOST={2})(PORT={3}))" +
                                 "(CONNECT_DATA=(SID={4})));", Usuario, Password, Host, Puerto, SID);
        }



    }
}

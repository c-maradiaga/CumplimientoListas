using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace CumplimientoListas
{
    class Listas
    {
        private String _Identidad = ""; 
        private String _Nombre = ""; 
        private String _Clncco; 
        private String _Clobsr; 
        private DateTime _Fecha_Registro; 
        private Int16 _Clmmco;
        private String _Clpers; 
        private String _FechaSTR = "";

        public String AgregarTemporal(String Identidad, String Nombre , String Clncco , String Clobsr,
                                    DateTime Fecha_Registro, Int16 Clmmco , String Clpers, String FechaSTR, String Mensaje)
        {
            Mensaje = "OK";
           using(OracleConnection objConn = new OracleConnection(Utiles.conOracleXE("coacehl","123456","127.0.0.1","1521","XE")))
           {
             try
               {
                   OracleCommand objComando = new OracleCommand();
                   objComando.Connection = objConn;
                   objComando.CommandText = "COACEHL.LST_REQ_PEPS_TMP";
                   objComando.CommandType = System.Data.CommandType.StoredProcedure;
                   objComando.Parameters.Add("pCLIDEN", OracleDbType.Varchar2, 20, "CLIDEN").Value = Identidad.Trim();
                   objComando.Parameters.Add("pCLNOMB", OracleDbType.Varchar2, 70, "CLNOMB").Value = Nombre.Trim();
                   objComando.Parameters.Add("pCLNNCO", OracleDbType.Char, 1, "CLNNCO").Value = Clncco.Trim();
                   objComando.Parameters.Add("pOBSR", OracleDbType.Varchar2, 200, "CLOBSR").Value = Clobsr.Trim();
                   objComando.Parameters.Add("pFECHAINGRESOOBSR", OracleDbType.Date, 10, "FECHA_INGRESO").Value = Fecha_Registro;
                   objComando.Parameters.Add("pCLMMCO", OracleDbType.Int16, 3, "CLMMCO").Value = Clmmco;
                   objComando.Parameters.Add("pCLPERS", OracleDbType.Char, 1, "CLPERS").Value = Clpers.Trim();
                   objComando.Parameters.Add("pERROR", OracleDbType.Varchar2, 200).Direction = System.Data.ParameterDirection.Output;

                   objConn.Open();
                   objComando.ExecuteNonQuery();

                   Mensaje = objComando.Parameters["pERROR"].Value.ToString();
               }
               catch (Exception ex)
               {
                   Mensaje = "Hubo un Error al Insertar el Registro " + Identidad.Trim() + " " + Nombre.Trim() + ex.Message.Trim();
                   throw;
               }
               finally
               {

               }
               return Mensaje;
           }
        }
    }
}

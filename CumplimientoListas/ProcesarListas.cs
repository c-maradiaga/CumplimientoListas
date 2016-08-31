using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Oracle.DataAccess.Client;
using System.Data.OleDb;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;


namespace CumplimientoListas
{
    public partial class ProcesarListas : Form
    {
        public ProcesarListas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProcesarListas_Load(object sender, EventArgs e)
        {

        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.InitialDirectory = @"C:\";
            dialogo.Title = "Archivo de Excel";
            dialogo.CheckFileExists = true;
            dialogo.CheckPathExists = true;
            dialogo.DefaultExt = "xlsx";
            dialogo.Filter = "Excel 97 (*.xls)|*.xls|Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                txtLibro.Text = dialogo.FileName;
            }
        }

        //Cargar Datos:
        private void btnCargarGridHoja_Click(object sender, EventArgs e)
        {
            if (txtLibro.Text.Trim() == "")
            {
                MessageBox.Show("Falta Ingresar el Nombre del Archivo de Excel.", "Archivo de Excel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLibro.Focus();
                return;
            }
            if (txtHoja.Text.Trim() == "")
            {
                MessageBox.Show("Falta Ingresar el Nombre de la Hoja donde están los Datos.", "Nombre de la Hoja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtHoja.Focus();
                return;
            }

            //{"No se pudo encontrar el archivo ISAM instalable."} =Hoja1!B4
            //txtLibro.Text = @"V:\Varios\Listas OFAC\PEPS-Subir\Listas PEPS - Periodo 2010 al 2018--YA.xls";       txtHoja.Text = "Hoja1";

            //string constr = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + txtLibro.Text + "; Extended Properties =\"Excel 8.0; HDR=Yes;\";";
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + txtLibro.Text + "; Extended Properties=\"Excel 8.0; HDR=Yes;\";";

            try
            {
                using (OleDbConnection con = new OleDbConnection(constr))
                {
                    con.Open();
                    using (OleDbDataAdapter sda = new OleDbDataAdapter("SELECT * FROM [" + txtHoja.Text + "$]", con))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }
                    lblTotalRegistros.Text = dataGridView1.RowCount.ToString();
                    con.Close();
                }
            }
            catch (OleDbException ex)
            {
                if (ex.Errors[0].NativeError == -328602519)
                {
                    MessageBox.Show("Archivo con Formato Incorrecto....");
                }
                else
                {
                    MessageBox.Show(ex.Errors[0].NativeError.ToString());
                    MessageBox.Show(ex.Errors[0].Message.ToString());
                    MessageBox.Show(ex.Errors[0].Source.ToString());
                    MessageBox.Show(ex.Errors[0].SQLState.ToString());
                }
            }

            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //Procesa los registros - Los deja en la tabla Temporal COACEHL.LST_REQ_PEPS
            string ConnectionString = Utiles.conOracleXE("coacehl", "123456", "127.0.0.1", "1521", "XE");
            //string ConnectionString = Utiles.conProduccion("coacehl", "123456", "192.168.101.4", "1521", "COAPROD1");
            //string ConnectionString = Utiles.conDesarrollo("coacehl", "123456", "192.168.101.99999999994", "1521", "COADES");

            int columnas = dataGridView1.ColumnCount; int filas = dataGridView1.RowCount;
            DataGridViewCell celda; String Mensaje = "";
            String Identidad = ""; String Nombre = ""; String Clncco; String Clobsr; DateTime Fecha_Registro; Int16 Clmmco;
            String Clpers; String FechaSTR = "";
           

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                //AgregarRegistro()
                FechaSTR = DateTime.Parse(fila.Cells[0].Value.ToString()).ToShortDateString(); Fecha_Registro = DateTime.Parse(FechaSTR.ToString());
                Clobsr =  fila.Cells[1].Value.ToString();
                Nombre = fila.Cells[2].Value.ToString();
                Identidad = fila.Cells[3].Value.ToString() ;
                Clpers =  fila.Cells[4].Value.ToString();
                Clncco = fila.Cells[5].Value.ToString(); // Tipo ID
                Clmmco = Int16.Parse(fila.Cells[6].Value.ToString()); // Tipo de Lista.

                //MessageBox.Show(Fecha_Registro + " " + Clobsr + " " + Nombre + " " + Identidad + " " + Clpers + " " + Clncco + " " + Clmmco.ToString());
                Listas listas1 = new Listas();

                if (listas1.AgregarTemporal(Identidad, Nombre, Clncco, Clobsr, Fecha_Registro, Clmmco, Clpers, FechaSTR, Mensaje) != "OK")
                {
                    MessageBox.Show(Mensaje);
                }
                
            }

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            //Sube  a Byte (CLCOADAT.CLNOAC) los registros que están en la tabla Temporal:

        }

        /* private void button1_Click(object sender, EventArgs e)
        {
            //BOTON DE PRUEBA DE CONEXIÓN:
            //Procesa los registros - Los deja en la tabla Temporal COACEHL.LST_REQ_PEPS
            string ConnectionString = Utiles.conOracleXE("coacehl", "123456", "127.0.0.1", "1521", "XE");
            //string ConnectionString = Utiles.conProduccion("coacehl", "123456", "192.168.101.4", "1521", "COAPROD1");
            //string ConnectionString = Utiles.conDesarrollo("coacehl", "123456", "192.168.101.99999999994", "1521", "COADES");

            string sql = "SELECT * FROM COACEHL.CLNOAC";

            using (OracleConnection conn = new OracleConnection(ConnectionString)) // connect to oracle
            {
                conn.Open(); // open the oracle connection
                using (OracleCommand comm = new OracleCommand(sql, conn)) // create the oracle sql command
                {
                    using (OracleDataReader rdr = comm.ExecuteReader()) // execute the oracle sql and start reading it
                    {
                        while (rdr.Read()) // loop through each row from oracle
                        {
                            //Console.WriteLine( rdr[0] );             // You can do this
                            //Console.WriteLine( rdr.GetString(0));  // or this
                            MessageBox.Show(rdr["CLNOMB"].ToString()); // or this
                        }
                        rdr.Close(); // close the oracle reader
                    }
                }
                conn.Close(); // close the oracle connection
            }
        } */
    }
}
 
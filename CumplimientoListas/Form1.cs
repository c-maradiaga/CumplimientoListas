using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Data.OleDb;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;



namespace CumplimientoListas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotalRegistros.Text = "    0"; txtHoja.Text = ""; txtLibro.Text = "";
            cmbListas.SelectedIndex = 0;
            

        }

        public string OracleConnection(string host, string port, string ServiceName, string User, string Password)
        {
            return String.Format("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})" +
                                 "(PORT={1}))(CONNECT_DATA=(SERVICE_NAME={2})));User Id={3};Password={4};",
                                host, port, ServiceName, User, Password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = OracleConnection("192.168.101.4", "1521", "COAPROD", "coacehl", "123456");
            
            string sql = "SELECT * FROM BYTE_CLIENTES WHERE CLCASO > 20000";


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
                                    Console.WriteLine( rdr["CLNOMB"] ); // or this
                                }
                                rdr.Close(); // close the oracle reader
                        }
                }
                conn.Close(); // close the oracle connection
                conn.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //{"No se pudo encontrar el archivo ISAM instalable."} =Hoja1!B4
            txtLibro.Text = @"V:\Varios\Listas OFAC\PEPS-Subir\Listas PEPS - Periodo 2010 al 2018--YA.xls";       txtHoja.Text = "Hoja1";
            //txtLibro.Text = @"V:\Varios\Listas OFAC\Listas.xls"; txtHoja.Text = "Hoja1";
            string constr = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + txtLibro.Text + "; Extended Properties =\"Excel 8.0; HDR=Yes;\";";
            OleDbConnection con = new OleDbConnection(constr);
            OleDbDataAdapter sda = new OleDbDataAdapter("SELECT * FROM [" + txtHoja.Text + "$]",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtLibro.Text = @"V:\Varios\Listas OFAC\PEPS-Subir\LISTA PEPS - CNBS--YA";
                // @"V:\Varios\Listas OFAC\PEPS-Subir\Listas PEPS - Periodo 2010 al 2018--YA.xls";   
            txtHoja.Text = "Hoja1";
            var excelApp = new Excel.Application();
            excelApp.Visible = true;

            Excel.Workbooks books = excelApp.Workbooks;
            Excel.Workbook hoja = books.Open(txtLibro.Text);

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblTotalRegistros.Text = "   0";
            if (txtLibro.Text.Trim() == "")
            {
                MessageBox.Show("Falta Ingresar el Nombre del Archivo de Excel.", "Archivo de Excel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLibro.Focus();
                return;
            }
            if (txtHoja.Text.Trim() == "")
            {
                MessageBox.Show("Falta Ingresar el Nombre de la Hoja donde están los Datos.", "Nombre de la Hoja", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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

        private void btnDialogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.InitialDirectory = @"C:\";
            dialogo.Title = "Archivo de Excel";
            dialogo.CheckFileExists = true;
            dialogo.CheckPathExists = true;
            dialogo.DefaultExt = "xlsx";
            dialogo.Filter = "Excel 97 (*.xls)|*.xls|Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if(dialogo.ShowDialog() == DialogResult.OK)
            {
                txtLibro.Text = dialogo.FileName;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int columnas = dataGridView1.ColumnCount; int filas = dataGridView1.RowCount;
            DataGridViewCell celda; string zelda;

            foreach(DataGridViewRow fila in dataGridView1.Rows)
            {
                celda = fila.Cells[0];
                zelda = celda.Value.ToString();
                MessageBox.Show(zelda);
            }
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            string strConexion = OracleConnection("192.168.101.4", "1521", "COAPROD", "coacehl", "123456");
            string strsql = "SELECT * FROM BYTE_CLIENTES WHERE CLCASO = 21865";

            using(OracleConnection conn = new OracleConnection(strConexion))
            {
                conn.Open();
                using(OracleDataAdapter da = new OracleDataAdapter(strsql, conn))
                {
                    OracleCommandBuilder cmdbuilder = new OracleCommandBuilder(da);

                    DataTable tabla = new DataTable();
                    tabla.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    da.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }

                conn.Close(); conn.Dispose();
            }
            
            
        }

        private void cmbListas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHoja.Text = cmbListas.GetItemText(cmbListas.SelectedItem).ToString();
            txtLibro.Text = cmbListas.SelectedIndex.ToString();
        }

        private void btnSubirLista_Click(object sender, EventArgs e)
        {

            int columnas = dataGridView1.ColumnCount; int filas = dataGridView1.RowCount;
            DataGridViewCell celda; string zelda;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                //AgregarRegistro()
                celda = fila.Cells[0];
                zelda = celda.Value.ToString();
                MessageBox.Show(zelda);
            }

        }


        private void AgregarRegistro(string Identidad, string Nombre, string TipoLista, string Observaciones, string Fecha)
        {
            string strConexion = OracleConnection("192.168.101.4", "1521", "COAPROD", "coacehl", "123456");

            try
            {
                using (OracleConnection conn = new OracleConnection(strConexion))
                {
                    //Crear comando para identificar el stored procedure:
                    using (OracleCommand cmd = new OracleCommand("COACEHL.CLIENTES2.LSTPEPS_ADD", conn))
                    {
                        //Indicando al cmd que lo que va a ejecutar es un store procedure (o función) :
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Pasarle los parámetros :
                        cmd.Parameters.Add("@pCLIDEN", OracleDbType.Varchar2, ParameterDirection.Input).Value = Identidad.Trim();
                        cmd.Parameters.Add("@pCLNOMB", OracleDbType.Varchar2, ParameterDirection.Input).Value = Nombre.Trim();
                        cmd.Parameters.Add("@pTIPOLISTA", OracleDbType.Varchar2, ParameterDirection.Input).Value = TipoLista.Trim();
                        cmd.Parameters.Add("@pOBSERVACION", OracleDbType.Varchar2, ParameterDirection.Input).Value = Observaciones.Trim();
                        cmd.Parameters.Add("@pFECHAINGRESO", OracleDbType.Varchar2, ParameterDirection.Input).Value = Fecha.Trim();
                        cmd.Parameters.Add("@pSQLMSG", OracleDbType.Varchar2, ParameterDirection.Output);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        txtLibro.Text = cmd.Parameters["pSQLMSG"].Value.ToString();

                    }
                    conn.Close(); conn.Dispose();
                }

            }
            catch (Exception ex)
            {
                txtHoja.Text = ex.Message.ToString();
            }
            



        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            // AgregarRegistro();
        }
    }

    

}

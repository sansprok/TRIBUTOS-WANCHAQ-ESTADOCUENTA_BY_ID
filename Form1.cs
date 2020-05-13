using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadoCuentaByID
{
    public partial class Form1 : Form
    {
        string pFAIDCIUDADANO;
        string pFADIRECCION;
        int pFATIPO;
        AUXWANCHAQDataContext BD = new AUXWANCHAQDataContext();
        SIRecuperaDataContext SIRecupera = new SIRecuperaDataContext();
        SqlConnection sqlcon = new SqlConnection(@"Data Source=USUARIO-4HQE76I\SSQLMDWPMSER06;Initial Catalog=AUXWANCHAQ;User ID=sa;Password=wanchaqsql-2013");
        public Form1(string codigo, string direccion, int tipo)
        //public Form1()
        {
            /*string[] passid = Environment.GetCommandLineArgs();
            pFAIDCIUDADANO = passid.GetValue(1).ToString();
            pFADIRECCION = "";
            pFATIPO = 1;*/
            InitializeComponent();
            pFADIRECCION = direccion;
            pFAIDCIUDADANO = codigo;
            pFATIPO = tipo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*try
            {
               
                DateTime fechamodifDeuda = (from F in SIRecupera.Deuda where F.IdCiudadano == pFAIDCIUDADANO && SqlMethods.Like(F.IdConcepto, "%IP%") && F.Saldo > 0 select F.FechaModificación).Max().Value;
                DateTime fechamodifPagoFacturado = (from F in SIRecupera.PagoFacturado where F.IdCiudadano == pFAIDCIUDADANO && SqlMethods.Like(F.IdConcepto, "%IP%") select F.FechaModificación).Max().Value;
                           
                if (fechamodifDeuda.Date == DateTime.Today.Date)
                {
                    BD.PA_ESTADOCUENTA_GENERACION_MASIVA_ACTUALIZAR__BYID(pFAIDCIUDADANO);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("SE PRODUJO UN ERROR, ACTUALICE LA DEUDA Y VUELVA A INTENTARLO");
            }*/
            BD.PA_ESTADOCUENTA_GENERACION_MASIVA_ACTUALIZAR__BYID(pFAIDCIUDADANO);
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("PA_ESTADOCUENTA", sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@FAIDCIUDADANO", pFAIDCIUDADANO);
            sqlda.SelectCommand.Parameters.AddWithValue("@FADIRECCION", pFADIRECCION);
            sqlda.SelectCommand.Parameters.AddWithValue("@FATIPO", pFATIPO);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            sqlcon.Close();
            EstadoCuentaByID.Prueba reporteMasivo = new Prueba();
            
            reporteMasivo.Database.Tables["PA_ESTADOCUENTA"].SetDataSource(dtbl);
            //crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = reporteMasivo;

        }
    }
}

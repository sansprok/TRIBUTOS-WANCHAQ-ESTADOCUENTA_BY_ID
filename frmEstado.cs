using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadoCuentaByID
{
    public partial class frmEstado : Form
    {
        string pFAIDCIUDADANO;
        string pFADIRECCION;
        int pFATIPO;
        AUXWANCHAQDataContext BD = new AUXWANCHAQDataContext();
        SIRecuperaDataContext SIRecupera = new SIRecuperaDataContext();
        //public frmEstado(string FAIDCIUDADANO)
        public frmEstado()
        {
            /*  string[] passid = Environment.GetCommandLineArgs();
              pFAIDCIUDADANO = passid.GetValue(1).ToString();*/
            pFAIDCIUDADANO = "00005511z";
            InitializeComponent();
            //pFAIDCIUDADANO = FAIDCIUDADANO;
            pFADIRECCION = "";
            pFATIPO = 1;
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ShowZoomControl = true;
        }

        private void FrmEstado_Load(object sender, EventArgs e)
        {
            /*try
            {
                if ((from F in SIRecupera.Deuda where F.IdCiudadano == pFAIDCIUDADANO && SqlMethods.Like(F.IdConcepto, "%IP%") && F.Saldo > 0 select F).Count()>0)
                {
                    DateTime fechamodifDeuda = (from F in SIRecupera.Deuda where F.IdCiudadano == pFAIDCIUDADANO && SqlMethods.Like(F.IdConcepto, "%IP%") && F.Saldo > 0 select F.FechaModificación).Max().Value;
                    DateTime fechamodifPagoFacturado = (from F in SIRecupera.PagoFacturado where F.IdCiudadano == pFAIDCIUDADANO && SqlMethods.Like(F.IdConcepto, "%IP%") select F.FechaModificación).Max().Value;

                    if (fechamodifDeuda.Date == DateTime.Today.Date)
                    {
                        BD.PA_ESTADOCUENTA_GENERACION_MASIVA_ACTUALIZAR__BYID(pFAIDCIUDADANO);
                    }
                }

               
            }
            catch (Exception)
            {
                MessageBox.Show("SE PRODUJO UN ERROR, ACTUALICE LA DEUDA Y VUELVA A INTENTARLO");
            }*/
            BD.PA_ESTADOCUENTA_GENERACION_MASIVA_ACTUALIZAR__BYID(pFAIDCIUDADANO);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            // TODO: esta línea de código carga datos en la tabla 'DS_VALORES.PA_ESTADOCUENTA' Puede moverla o quitarla según sea necesario.
            this.PA_ESTADOCUENTATableAdapter.Fill(this.DS_VALORES.PA_ESTADOCUENTA, pFAIDCIUDADANO,pFADIRECCION,pFATIPO);

            this.reportViewer1.RefreshReport();
            
        }
    }
}

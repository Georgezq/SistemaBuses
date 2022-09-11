using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmEditRecorridos : Form
    {
        public frmEditRecorridos()
        {
            InitializeComponent();
        }

        RecorridosE rle = new RecorridosE();
        RecorridosLineaLN rlln = new RecorridosLineaLN();

        public void SetDatos(RecorridosE rle)
        {
            txt_idRecorrido.Text = rle.IdRecorridoLinea.ToString();
            rtb_descripcion.Text = rle.Descripcion;
            txt_destino.Text = rle.Destino;
            txt_origen.Text = rle.Origen;
            if (rle.Estado == true) { cb_estado.Text = "Activo"; }
            if (rle.Estado == false) { cb_estado.Text = "No activo"; }
        }

        public RecorridosE CrearObjeto()
        {
            string descripcion = rtb_descripcion.Text;
            string origen = txt_origen.Text;
            string destino = txt_destino.Text;
            bool estado = false;
            if (cb_estado.Text == "Activo") { estado = true; }
            else estado = false;
            RecorridosE ob = new RecorridosE(descripcion,origen, destino, estado);
            return ob;
        }

        public RecorridosE ActualizarObjeto()
        {
            int idReco = int.Parse(txt_idRecorrido.Text);
            string descripcion = rtb_descripcion.Text;
            string origen = txt_origen.Text;
            string destino = txt_destino.Text;
            bool estado = false;
            if (cb_estado.Text == "Activo") { estado = true; }
            else estado = false;
            RecorridosE ob = new RecorridosE(idReco,descripcion, origen, destino ,estado);
            return ob;
        }

        private bool Validar()
        {
            bool vali = true;
            if (txt_destino.Text.Trim().Length == 0 || txt_origen.Text.Trim().Length == 0 || rtb_descripcion.Text.Trim().Length == 0 || cb_estado.Text.Trim().Length == 0)
            {
                vali = false;
            }
            return vali;
        }

        private void frmEditRecorridos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ingrese correctamente los datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

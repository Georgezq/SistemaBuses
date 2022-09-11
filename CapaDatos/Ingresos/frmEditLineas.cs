using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmEditLineas : Form
    {
        public frmEditLineas()
        {
            InitializeComponent();
        }

        LineasE lie = new LineasE();
        LineasLN liln = new LineasLN();

        public void SetDatos(LineasE lie)
        {
            txt_idLinea.Text = lie.IdLinea.ToString();
            txt_numLinea.Text = lie.NumLinea.ToString();
            if (lie.Estado == true) { cb_estado.Text = "Activo"; }
            if (lie.Estado == false) { cb_estado.Text = "No activo"; }
            txt_idUnidad.Text = lie.IdUnidad.ToString();    
        }

        public LineasE CrearObjetos()
        {
            int numLinea = int.Parse(txt_numLinea.Text);
            int idUnidad = int.Parse(txt_idUnidad.Text);
            bool estado = false;
            if (cb_estado.Text == "Activo") { estado = true; }
            else estado = false;
            LineasE ob = new LineasE(idUnidad,numLinea, estado);
            return ob;
        }

        public LineasE ActualizarObjeto()
        {
            int idL = int.Parse(txt_idLinea.Text);
            int numLinea = int.Parse(txt_numLinea.Text);
            int idUnidad = int.Parse(txt_idUnidad.Text);
            bool estado = false;
            if (cb_estado.Text == "Activo") { estado = true; }
            else estado = false;
            LineasE ob = new LineasE(idL,idUnidad,numLinea, estado);
            return ob;
        }

        private void frmEditLineas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Hola mundo coom estan yo valiendo verga :c");
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

        private bool Validar()
        {
            bool vali = true;
            if (txt_numLinea.Text.Trim().Length == 0 || cb_estado.Text.Trim().Length == 0)
            {
                vali = false;
            }
            return vali;
        }

        private void bt_recorrido_Click(object sender, EventArgs e)
        {
            try
            {
                frmIngresoUnidad frmT = new frmIngresoUnidad();
                frmT.ShowDialog();
                if (frmT.DialogResult == DialogResult.OK)
                {
                    txt_idUnidad.Text = frmT.une.IdUnidad.ToString();
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
    }
}

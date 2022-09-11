using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmEditTurno : Form
    {
        public frmEditTurno()
        {
            InitializeComponent();
        }

        public void SetDatos(TurnoE tue)
        {
            txt_idT.Text = tue.IdTurno.ToString();
            txt_tipo.Text = tue.Tipo;
            txt_descripcion.Text = tue.Descripcion;
            dtp_horaI.Text = tue.Hora_Inicio;
            dtp_horaT.Text = tue.Hora_Terminacion;
        }

        public TurnoE CrearObjeto()
        {
            string tipo = txt_tipo.Text;
            string descripcion = txt_descripcion.Text;
            string horaI = dtp_horaI.Value.ToString();
            string horaT = dtp_horaT.Value.ToString();
            TurnoE ob = new TurnoE(tipo, descripcion, horaI, horaT);
            return ob;
        }

        public TurnoE ActualizarObjeto()
        {
            int idT = int.Parse(txt_idT.Text);
            string tipo = txt_tipo.Text;
            string descripcion = txt_descripcion.Text;
            string horaI = dtp_horaI.Value.ToString();
            string horaT = dtp_horaT.Value.ToString();
            TurnoE ob = new TurnoE(idT,tipo, descripcion, horaI, horaT);
            return ob;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (txt_tipo.Text.Trim().Length == 0 || txt_descripcion.Text.Trim().Length == 0)
            {
                vali = false;
            }
            return vali;
        }
    }
}

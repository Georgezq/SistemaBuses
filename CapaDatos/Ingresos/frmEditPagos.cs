using System;
using System.Security.Policy;
using System.Windows.Forms;
using CapaEntidades.Clases_Personalizadas;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmEditPagos : Form
    {
        private UsuarioRolE user;

        public frmEditPagos(UsuarioRolE us = null)
        {
            user = us;
            InitializeComponent();     
        }

        PagosLN paln = new PagosLN();
        ChoferLN chln = new ChoferLN();

        public void MostrarComboChoferes()
        {
            cb_idChofer.DataSource = chln.ListarChofer("");
            cb_idChofer.SelectedIndex = 0;
            cb_idChofer.DisplayMember = "Nombre";
            cb_idChofer.ValueMember = "IdChofer";
        }

        public void SetDatos(PagosE pae) 
        {
            txt_idPa.Text = pae.IdPago.ToString();
            txt_descripcion.Text = pae.Descripcion;
            txt_valor.Text = pae.Valor.ToString();
            dtp_fecha.Value = pae.Fecha;
            if (pae.Estado == true) { cb_estado.Text = "Activo"; }
            if (pae.Estado == false) { cb_estado.Text = "No activo"; }
        }


        public PagosE CrearObjeto()
        {
            int idChofer = (int)cb_idChofer.SelectedValue;
            string descripcion = txt_descripcion.Text;
            decimal valor = decimal.Parse(txt_valor.Text);
            int iduser = int.Parse(txt_idusuario.Text);
            bool estado = false;
            if (cb_estado.Text == "Activo") { estado = true; }
            else estado = false;

            DateTime fecha = dtp_fecha.Value;

            PagosE ob = new PagosE(valor, descripcion, iduser, idChofer, estado, fecha);
            return ob;
        }

        public PagosE ActualizarObjeto()
        {
            int idPago = int.Parse(txt_idPa.Text);
            int idChofer = (int)cb_idChofer.SelectedValue;
            string descripcion = txt_descripcion.Text;
            decimal valor = decimal.Parse(txt_valor.Text);
            int iduser = int.Parse(txt_idusuario.Text);
            bool estado = false;
            if (cb_estado.Text == "Activo") { estado = true; }
            else estado = false;

            DateTime fecha = dtp_fecha.Value;

            PagosE ob = new PagosE(idPago, valor, descripcion, iduser, idChofer, estado, fecha);
            return ob;
        }

        private void frmEditPagos_Load(object sender, EventArgs e)
        {
            MostrarComboChoferes();
            textBox1.Text = user.Usuario.ToString();
            txt_idusuario.Text = user.IdUsuario.ToString();
        }

        private bool Validar()
        {
            bool vali = true;
            if (txt_descripcion.Text.Trim().Length == 0 || txt_descripcion.Text.Trim().Length == 0 || txt_valor.Text.Trim().Length == 0 || cb_estado.Text.Trim().Length == 0)
            {
                vali = false;
            }
            return vali;
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

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txt_valor.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ",")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}

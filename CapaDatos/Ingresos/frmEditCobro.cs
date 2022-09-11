using CapaEntidades.Ingresos;
using System;
using System.Windows.Forms;
using CapaNegocio.Ingresos;
using CapaEntidades.Clases_Personalizadas;

namespace CapaPresentacion.Ingresos
{
    public partial class frmEditCobro : Form
    {
        private UsuarioRolE use;

        public frmEditCobro(UsuarioRolE us = null)
        {
            use = us;
            InitializeComponent();
        }

        AfiliadosLN afln = new AfiliadosLN();

        public void MostrarCombo()
        {
            cb_afiliado.DataSource = afln.ListarAfiliado("");
            cb_afiliado.SelectedIndex = 0;
            cb_afiliado.DisplayMember = "Nombre";
            cb_afiliado.ValueMember = "IdAfiliado";
        }

        private void frmEditCobro_Load(object sender, EventArgs e)
        {         
            MostrarCombo();
            txt_idUser.Text = use.IdUsuario.ToString();
        }

        public void SetDatos(viewUsuarioAfiliadoCobro coe)
        {
            txt_idCobro.Text = coe.IdCobro.ToString();
            txt_descripcion.Text = coe.Descripcion;
            txt_Total.Text = coe.Total.ToString();
            txt_idUser.Text = coe.IdUsuario.ToString();
            if (coe.Estado == true) { cb_estado.Text = "Activo"; }
            if (coe.Estado == false) { cb_estado.Text = "No activo"; }

        }
        
         public CobroE CrearObjeto()
        {
            int idUser = int.Parse(txt_idUser.Text);
            int idAfiliado = (int)cb_afiliado.SelectedValue;
            decimal total = decimal.Parse(txt_Total.Text);
            string descripcion = txt_descripcion.Text;
            bool estado = false;
            if (cb_estado.Text == "Activo") { estado = true; }
            else estado = false;
            DateTime fecha = dateTimePicker1.Value.Date;
            CobroE ob = new CobroE(idUser, idAfiliado, total, descripcion, estado, fecha);
            return ob;
        }

        public viewUsuarioAfiliadoCobro ActualizarObjeto()
        {
            int idCobro = int.Parse(txt_idCobro.Text);
            int idUser = int.Parse(txt_idUser.Text);
            int idAfiliado = (int)cb_afiliado.SelectedValue;
            string nombreA = cb_afiliado.Text;
            decimal total = decimal.Parse(txt_Total.Text);
            string descripcion = txt_descripcion.Text;
            bool estado = false;
            if (cb_estado.Text == "Activo") { estado = true; }
            else estado = false;
            DateTime fecha = dateTimePicker1.Value.Date;
            viewUsuarioAfiliadoCobro ob = new viewUsuarioAfiliadoCobro(idCobro, idUser, idAfiliado, total, descripcion, estado, fecha);
            return ob;
        }

        private bool Validar()
        {
            bool vali = true;
            if (/*txt_idUser.Text.Trim().Length == 0 || */txt_Total.Text.Trim().Length == 0 || txt_descripcion.Text.Trim().Length == 0 || cb_afiliado.Text.Trim().Length == 0 || cb_estado.Text.Trim().Length == 0)
            {
                vali = false;
            }
            return vali;
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

        private void txt_Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if(txt_Total.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
                {
                    e.Handled = true;
                }
                else
                {
                    if(Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ",")
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

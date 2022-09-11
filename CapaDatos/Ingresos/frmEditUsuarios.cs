using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Ingresos
{
    public partial class frmEditUsuarios : Form
    {
        public frmEditUsuarios()
        {
            InitializeComponent();
        }

        RolLN roln = new RolLN();

        public void Combo()
        {
            cb_Rol.DataSource = roln.ListarRol();
            cb_Rol.SelectedIndex = 0;
            cb_Rol.DisplayMember = "Tipo";
            cb_Rol.ValueMember = "IdRol";
        }

        public void SetDatos(UsuarioE use)
        {
            txt_idU.Text = use.IdUsuario.ToString();
            txt_correo.Text = use.Correo;
            txt_name.Text = use.Nombre;
            txt_pass.Text = use.Contraseña;
            txt_user.Text = use.Usuario;
            if (use.Estado == true) { cb_estado.Text = "Activo"; }
            if (use.Estado == false) { cb_estado.Text = "No activo"; }
            cb_Rol.DisplayMember = use.IdRol.ToString();
            if (use.Sexo.Equals('F')) { rb_F.Checked = true; }
            if (use.Sexo.Equals('M')) { rb_M.Checked = true; }
            txt_apellido.Text = use.Apellido;
            txt_Edad.Text = use.Edad.ToString();

        }

        public UsuarioE CrearObjeto()
        {
            int idRol = (int)cb_Rol.SelectedValue;
            string user = txt_user.Text;
            string nombre = txt_name.Text;
            string apellido = txt_apellido.Text;
            int edad = int.Parse(txt_Edad.Text);
            char sex;
            if (rb_M.Checked == true) { sex = 'M'; }
            else sex = 'F';
            string contra = txt_pass.Text;
            string correo = txt_correo.Text;
            bool estado = false;
            if(cb_estado.Text == "Activo") { estado = true; }
            if(cb_estado.Text == "No activo") { estado = false; } 

            UsuarioE ob = new UsuarioE(idRol, user, nombre, contra, apellido, edad, correo, sex,estado);
            return ob;
        }

        public UsuarioE ActualizarObjeto()
        {
            int id = int.Parse(txt_idU.Text);
            int idRol = (int)cb_Rol.SelectedValue;
            string user = txt_user.Text;
            string nombre = txt_name.Text;
            string apellido = txt_apellido.Text;
            int edad = int.Parse(txt_Edad.Text);
            char sex;
            if (rb_M.Checked == true) { sex = 'M'; }
            else sex = 'F';
            string contra = txt_pass.Text;
            string correo = txt_correo.Text;
            bool estado = false;
            if (cb_estado.Text == "Activo") { estado = true; }
            if (cb_estado.Text == "No activo") { estado = false; }

            UsuarioE ob = new UsuarioE(id,idRol, user, nombre, contra, apellido, edad, correo, sex, estado);
            return ob;
        }

        private void frmEditUsuarios_Load(object sender, EventArgs e)
        {
            Combo();
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
            if (txt_name.Text.Trim().Length == 0 || txt_pass.Text.Trim().Length == 0 || txt_user.Text.Trim().Length == 0 || cb_Rol.Text.Trim().Length == 0 || cb_estado.Text.Trim().Length == 0)
            {
                vali = false;
            }
            return vali;
        }
    }
}

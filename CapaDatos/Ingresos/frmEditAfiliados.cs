using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmEditAfiliados : Form
    {
        public frmEditAfiliados()
        {
            InitializeComponent();
        }

        AfiliadoE afe = new AfiliadoE();
        AfiliadosLN afln = new AfiliadosLN();

        public AfiliadoE CrearObjeto()
        {
            string nom = txt_name.Text;
            string direccion = txt_direccion.Text;
            string celular = txt_celu.Text;
            string cedula = txt_cedula.Text;
            bool estado = false;
            int edad = int.Parse(txt_Edad.Text);
            string estadoCivil = cb_EstadoCivil.Text;
            string correo = txt_Correo.Text;
            if(cb_estado.Text == "Activo") { estado = true; }
            if(cb_estado.Text == "No activo") { estado = false; }
            char sex;
            if (rb_M.Checked == true) { sex = 'M'; }
            else sex = 'F';

            AfiliadoE ob = new AfiliadoE(nom, direccion, celular, cedula, sex, correo, edad, estadoCivil,estado);
            return ob;
        }

        public void SetDatos(AfiliadoE use)
        {
            txt_idA.Text = use.IdAfiliado.ToString();
            txt_direccion.Text = use.Direccion;
            txt_name.Text = use.Nombre;
            txt_celu.Text = use.Celular;
            txt_cedula.Text = use.Cedula;
            if (use.Sexo.Equals('F')) { rb_F.Checked = true; }
            if (use.Sexo.Equals('M')) { rb_M.Checked = true; }
            txt_Correo.Text = use.Correo;
            txt_Edad.Text = use.Edad.ToString();
            cb_EstadoCivil.Text = use.EstadoCivil;

            if (use.Estado == true) { cb_estado.Text = "Activo"; }
            if (use.Estado == false) { cb_estado.Text = "No activo"; }
        }

        public AfiliadoE ActualizarObjeto()
        {
            int id = int.Parse(txt_idA.Text);
            string nom = txt_name.Text;
            string direccion = txt_direccion.Text;
            string celular = txt_celu.Text;
            string cedula = txt_cedula.Text;
            bool estado = false;
            int edad = int.Parse(txt_Edad.Text);
            string estadoCivil = cb_EstadoCivil.Text;
            string correo = txt_Correo.Text;
            if (cb_estado.Text == "Activo") { estado = true; }
            if (cb_estado.Text == "No activo") { estado = false; }
            char sex;
            if (rb_M.Checked == true) { sex = 'M'; }
            else sex = 'F';

            AfiliadoE ob = new AfiliadoE(id,nom, direccion, celular, cedula, sex, correo, edad, estadoCivil, estado);
            return ob;
        }

        private void frmEditAfiliados_Load(object sender, EventArgs e)
        {

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
            if (txt_name.Text.Trim().Length == 0 || txt_cedula.Text.Trim().Length == 0 || txt_celu.Text.Trim().Length == 0 || txt_direccion.Text.Trim().Length == 0 || cb_estado.Text.Trim().Length == 0)
            {
                vali = false;
            }
            return vali;
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Restricciones re = new Restricciones();
            re.Letras(e);
        }

        private void txt_celu_KeyPress(object sender, KeyPressEventArgs e)
        {
            Restricciones re = new Restricciones();
            re.Numeros(e);
        }

        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Restricciones re = new Restricciones();
            re.Numeros(e);
        }
    }
}

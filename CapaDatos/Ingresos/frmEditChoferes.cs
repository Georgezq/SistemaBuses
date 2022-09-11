using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmEditChoferes : Form
    {
        public frmEditChoferes()
        {
            InitializeComponent();
        }

        ChoferE che = new ChoferE();
        ChoferLN chln = new ChoferLN();

        public ChoferE CrearObjetos()
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_Apellido.Text;
            char sex;
            if (rb_M.Checked == true) { sex = 'M'; }
            else sex = 'F';
            string tipoLicencia = txt_tipoLicencia.Text;
            int edad = int.Parse(txt_edad.Text);
            bool estado = false;
            if (cb_estado.Text == "Activo") { estado = true; }
            else estado = false;

            ChoferE ob = new ChoferE(nombre, apellido, sex, tipoLicencia, edad, estado);
            return ob;
        }

        public void SetDatos(ChoferE cho)
        {
            txt_idC.Text = cho.IdChofer.ToString();
            txt_nombre.Text = cho.Nombre.ToString();
            txt_Apellido.Text = cho.Apellido;
            txt_tipoLicencia.Text = cho.TipoLicencia;
            txt_edad.Text = cho.Edad.ToString();
            if(cho.Estado == true) { cb_estado.Text = "Activo"; }
            if(cho.Estado == false) { cb_estado.Text = "No activo"; }
            if(cho.Sexo.Equals('F')) { rb_F.Checked = true; }
            if(cho.Sexo.Equals('M')) { rb_M.Checked = true; }
        }

        public ChoferE ActualizarObjeto()
        {
            int idC = int.Parse(txt_idC.Text);
            string nombre = txt_nombre.Text;
            string apellido = txt_Apellido.Text;
            char sex;
            if (rb_M.Checked == true) { sex = 'M'; }
            else sex = 'F';
            string tipoLicencia = txt_tipoLicencia.Text;
            int edad = int.Parse(txt_edad.Text);
            bool estado = false;
            if (cb_estado.Text == "Activo") { estado = true; }
            else estado = false;

            ChoferE ob = new ChoferE(idC,nombre, apellido, sex, tipoLicencia, edad, estado);
            return ob;
        }

        private bool Validar()
        {
            bool vali = true;
            if (txt_nombre.Text.Trim().Length == 0 || txt_Apellido.Text.Trim().Length == 0 || txt_tipoLicencia.Text.Trim().Length == 0 || txt_edad.Text.Trim().Length == 0 || cb_estado.Text.Trim().Length == 0)
            {
                vali = false;
            }
            return vali;
        }

        private void frmEditChoferes_Load(object sender, EventArgs e)
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

        private void txt_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Restricciones re = new Restricciones();
            re.Numeros(e);
        }
    }
}

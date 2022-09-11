using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmEditUnidad : Form
    {
        public frmEditUnidad()
        {
            InitializeComponent();
        }

        UnidadE une = new UnidadE();
        UnidadLN unln = new UnidadLN();
        ChoferLN chln = new ChoferLN();
        LineasLN linl = new LineasLN();

        public void CargarComboChofer()
        {
            cb_chofer.DataSource = chln.ListarChofer("");
            cb_chofer.SelectedIndex = 0;
            cb_chofer.DisplayMember = "Nombre";
            cb_chofer.ValueMember = "IdChofer";
        }

        public void SetDatos(UnidadE uni)
        {
            txt_idUni.Text = uni.IdUnidad.ToString();
            cb_chofer.ValueMember = uni.IdChofer.ToString();
            txt_placa.Text = uni.Placa;
            txt_modelo.Text = uni.Modelo;
            txt_marca.Text = uni.Marca;
            dtp_fecha.Value = uni.FechaFabricacion;
            txt_capacidad.Text = uni.Capacidad.ToString();
            if (uni.Estado == true) { cb_estado.Text = "Activo"; }
            if (uni.Estado == false) { cb_estado.Text = "No activo"; }
        }

        public UnidadE CrearObjeto()
        {
            int idChofer = (int)cb_chofer.SelectedValue;
            string placa = txt_placa.Text;
            string modelo = txt_modelo.Text;
            string marca = txt_marca.Text;
            int idrecorrido = int.Parse(txt_idRecorrido.Text);
            DateTime fecha = dtp_fecha.Value.Date;
            int capacidad = int.Parse(txt_capacidad.Text);
            bool estado = false;
            if (cb_estado.Text == "Activo") { estado = true; }
            else estado = false;

            UnidadE ob = new UnidadE(idChofer, idrecorrido, placa,modelo, marca,  fecha, capacidad, estado);
            return ob;
        }

        public UnidadE ActualizarObjeto()
        {
            int idUnidad = int.Parse(txt_idUni.Text);
            int idChofer = (int)cb_chofer.SelectedValue;
            string placa = txt_placa.Text;
            string modelo = txt_modelo.Text;
            string marca = txt_marca.Text;
            int idrecorrido = int.Parse(txt_idRecorrido.Text);

            DateTime fecha = dtp_fecha.Value.Date;
            int capacidad = int.Parse(txt_capacidad.Text);
            bool estado = false;
            if (cb_estado.Text == "Activo") { estado = true; }
            else estado = false;

            UnidadE ob = new UnidadE(idUnidad,idChofer, placa,modelo, marca, fecha , capacidad, estado);
            return ob;
        }

        private bool Validar()
        {
            bool vali = true;
            if (txt_placa.Text.Trim().Length == 0 || txt_modelo.Text.Trim().Length == 0 || txt_marca.Text.Trim().Length == 0 || txt_capacidad.Text.Trim().Length == 0 || cb_estado.Text.Trim().Length == 0 || txt_idRecorrido.Text.Trim().Length == 0)
            {
                vali = false;
            }
            return vali;
        }

        private void frmEditUnidad_Load(object sender, EventArgs e)
        {
            CargarComboChofer();
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

        private void txt_capacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Restricciones re = new Restricciones();
            re.Numeros(e);
        }

        private void bt_recorrido_Click(object sender, EventArgs e)
        {
            try
            {
                frmIngresoRecorrido frmT = new frmIngresoRecorrido();
                frmT.ShowDialog();
                if (frmT.DialogResult == DialogResult.OK)
                {
                    txt_idRecorrido.Text = frmT.rlne.IdRecorridoLinea.ToString();              
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
    }
}

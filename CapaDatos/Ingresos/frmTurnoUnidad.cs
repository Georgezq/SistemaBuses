using System;
using System.IO;
using System.Windows.Forms;
using CapaEntidades.Clases_Personalizadas;
using CapaEntidades.Ingresos;
using CapaNegocio.Clase_Personalizada;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmTurnoUnidad : Form
    {
        public frmTurnoUnidad()
        {
            InitializeComponent();
            MostrarPlaca();
        }

        TurnoUnidadE tue = new TurnoUnidadE();
        TurnoUnidadLN tuln = new TurnoUnidadLN();
        UnidadLN unln = new UnidadLN();
        TurnoUnidadPersonalizadoLN tpln = new TurnoUnidadPersonalizadoLN();

        public void MostrarData()
        {
            dataGridView1.DataSource = tpln.ListarTurnoUnidadPersonalizado(cb_unidad.Text);
        }

        public void MostrarPlaca()
        {
            cb_unidad.DataSource = unln.ListarUnidad("");
            cb_unidad.SelectedIndex = 0;
            cb_unidad.DisplayMember = "Placa";
            cb_unidad.ValueMember = "iDUnidad";
        }

        private void frmTurnoUnidad_Load(object sender, EventArgs e)
        {
            MostrarData();          
        }

        

        public void Nuevo()
        {
            frmEditTurnoUnidad frm = new frmEditTurnoUnidad();
            frm.Text = "Ingresar Turno de Unidad";
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {               
                        TurnoUnidadE op = frm.CrearObjeto();
                        tuln.crearTurnoUnidad(op);
                        frm.Close();

            }
            MostrarData();
        }

        public void Actualizar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    frmEditTurnoUnidad frm = new frmEditTurnoUnidad();
                    frm.Text = "Actualizar Turno de Unidad";
                    TurnoUnidadPersonalizadoE op = null;
                    op = dataGridView1.CurrentRow.DataBoundItem as TurnoUnidadPersonalizadoE;

                    frm.SetDatos(op);
                    frm.ShowDialog(this);

                    if (frm.DialogResult == DialogResult.OK)
                    {

                        op = frm.ActualizarObjeto();
                        tuln.UpdateTurnoUnidad(op);
                        frm.Close();
                        MostrarData();
                    }
                }
            }
            catch (Exception ex)
            {
                lb_msn.Text = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }

        public void Eliminar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var resul = MessageBox.Show("¿Quiere eliminar el Turno de Unidad seleccionado?", "Eliminar Turno de Unidad", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        TurnoUnidadPersonalizadoE ta = dataGridView1.CurrentRow.DataBoundItem as TurnoUnidadPersonalizadoE;
                        tuln.deleteTurnoUnidad(ta);
                        MostrarData();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione la fila a eliminar");
                }
            }
            catch (Exception ex)
            {

                lb_msn.Text = ex.Message;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            Nuevo();           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarData();
        }
    }
}

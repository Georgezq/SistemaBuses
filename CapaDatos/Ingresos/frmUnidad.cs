using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmUnidad : Form
    {
        public frmUnidad()
        {
            InitializeComponent();
        }

        UnidadE une = new UnidadE();
        UnidadLN unln = new UnidadLN();

        public void MostrarData(string val)
        {
            dataGridView1.DataSource = unln.ListarUnidad(val);
        }

        private void frmUnidad_Load(object sender, EventArgs e)
        {
            MostrarData("");
        }

        public void Nuevo()
        {
            frmEditUnidad frm = new frmEditUnidad();
            frm.Text = "Ingresar Unidad";
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                UnidadE op = frm.CrearObjeto();
                unln.crearUnidad(op);
                frm.Close();
            }
            MostrarData("");
        }

        public void Actualizar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    frmEditUnidad frm = new frmEditUnidad();
                    frm.Text = "Actualizar Unidad";
                    UnidadE op = null;
                    op = dataGridView1.CurrentRow.DataBoundItem as UnidadE;
                    frm.SetDatos(op);
                    frm.ShowDialog(this);

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        op = frm.ActualizarObjeto();
                        unln.UpdateUnidad(op);
                        frm.Close();
                        MostrarData("");
                    }
                }
            }
            catch (Exception ex)
            {
                lb_msn.Text = ex.Message;
            }
        }

        public void Eliminar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var resul = MessageBox.Show("¿Quiere eliminar la Unidad seleccionado?", "Eliminar Unidad", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        UnidadE ta = dataGridView1.CurrentRow.DataBoundItem as UnidadE;
                        unln.deleteUnidad(ta);
                        MostrarData("");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            MostrarData(txt_busqueda.Text);
        }
    }
}

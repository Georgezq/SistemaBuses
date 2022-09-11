using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmRecorridosLinea : Form
    {
        public frmRecorridosLinea()
        {
            InitializeComponent();
        }

        RecorridosE rle = new RecorridosE();
        RecorridosLineaLN rlln = new RecorridosLineaLN();

        public void MostrarData(string val)
        {
            dataGridView1.DataSource = rlln.ListarRecorridosLineas(val);
        }

        private void frmRecorridosLinea_Load(object sender, EventArgs e)
        {
            MostrarData("");
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            MostrarData(txt_busqueda.Text);
        }

        public void Nuevo()
        {
            frmEditRecorridos frm = new frmEditRecorridos();
            frm.Text = "Ingresar Recorrido";
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                RecorridosE op = frm.CrearObjeto();
                rlln.crearRecorridosLineas(op);
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
                    frmEditRecorridos frm = new frmEditRecorridos();
                    frm.Text = "Actualizar Recorrido";
                    RecorridosE op = null;
                    op = dataGridView1.CurrentRow.DataBoundItem as RecorridosE;
                    frm.SetDatos(op);
                    frm.ShowDialog(this);

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        op = frm.ActualizarObjeto();
                        rlln.UpdateRecorridosLineas(op);
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
                    var resul = MessageBox.Show("¿Quiere eliminar el Recorrido seleccionado?", "Eliminar Recorrido", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        RecorridosE ta = dataGridView1.CurrentRow.DataBoundItem as RecorridosE;
                        rlln.deleteRecorridosLineas(ta);
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
    }
}

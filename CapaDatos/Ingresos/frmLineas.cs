using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmLineas : Form
    {
        public frmLineas()
        {
            InitializeComponent();
        }

        LineasE lie = new LineasE();
        LineasLN liln = new LineasLN();

        public void MostrarData(string val)
        {
            dataGridView1.DataSource = liln.ListarLineas(val);
        }

        private void frmLineas_Load(object sender, EventArgs e)
        {
            MostrarData("");
        }

        public void Nuevo()
        {
            frmEditLineas frm = new frmEditLineas();
            frm.Text = "Ingresar Linea";
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                LineasE op = frm.CrearObjetos();
                liln.crearLineas(op);
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
                    frmEditLineas frm = new frmEditLineas();
                    frm.Text = "Actualizar Linea";
                    LineasE op = null;
                    op = dataGridView1.CurrentRow.DataBoundItem as LineasE;
                    frm.SetDatos(op);
                    frm.ShowDialog(this);

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        op = frm.ActualizarObjeto();
                        liln.UpdateLineas(op);
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
                    var resul = MessageBox.Show("¿Quiere eliminar la Linea seleccionada?", "Eliminar Linea", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        LineasE ta = dataGridView1.CurrentRow.DataBoundItem as LineasE;
                        liln.deleteLineas(ta);
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

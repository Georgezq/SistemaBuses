using System;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using CapaEntidades.Clases_Personalizadas;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmPagos : Form
    {
        private UsuarioRolE use;

        public frmPagos(UsuarioRolE us = null)
        {
            InitializeComponent();
            use = us;
        }

        PagosE pae = new PagosE();
        PagosLN paln = new PagosLN();

        public void MostrarData(string val)
        {
            dataGridView1.DataSource = paln.ListarPagos(val);
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            MostrarData("");
          
        }

        public void Nuevo()
        {
            frmEditPagos frm = new frmEditPagos(use);
            frm.Text = "Ingresar Pago";
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                PagosE op = frm.CrearObjeto();
                paln.crearPagos(op);
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
                    frmEditPagos frm = new frmEditPagos(use);
                    frm.Text = "Actualizar Pago";
                    PagosE op = null;
                    op = dataGridView1.CurrentRow.DataBoundItem as PagosE;
                    frm.SetDatos(op);
                    frm.ShowDialog(this);

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        op = frm.ActualizarObjeto();
                        paln.UpdatePagos(op);
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
                    var resul = MessageBox.Show("¿Quiere eliminar el pago seleccionado?", "Eliminar Pago", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        PagosE ta = dataGridView1.CurrentRow.DataBoundItem as PagosE;
                        paln.deletePagos(ta);
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

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            MostrarData(txt_busqueda.Text);
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

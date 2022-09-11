using System;
using System.Drawing;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;
using CapaPresentacion.Menu;

namespace CapaPresentacion.Ingresos
{
    public partial class frmAfiliados : Form
    {
        public frmAfiliados()
        {
            InitializeComponent();
        }

        AfiliadoE afe = new AfiliadoE();
        AfiliadosLN afln = new AfiliadosLN();

        public void MostrarData(string val)
        {
            dataGridView1.DataSource = afln.ListarAfiliado(val);
        }

        private void frmAfiliados_Load(object sender, EventArgs e)
        {
            MostrarData("");
        }

        public void Nuevo()
        {
            frmEditAfiliados frm = new frmEditAfiliados();
            frm.Text = "Ingresar Usuario Afiliado";
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                AfiliadoE op = frm.CrearObjeto();
                afln.crearAfiliado(op);
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
                    frmEditAfiliados frm = new frmEditAfiliados();
                    frm.Text = "Actualizar Usuario Afiliado";
                    AfiliadoE op = null;
                    op = dataGridView1.CurrentRow.DataBoundItem as AfiliadoE;

                    frm.SetDatos(op);
                    frm.ShowDialog(this);

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        op = frm.ActualizarObjeto();
                        afln.UpdateAfiliado(op);
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
                    var resul = MessageBox.Show("¿Quiere eliminar al Usuario afiliado seleccionado?", "Eliminar Usuario afiliado", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        AfiliadoE ta = dataGridView1.CurrentRow.DataBoundItem as AfiliadoE;
                        afln.deleteAfiliado(ta);
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

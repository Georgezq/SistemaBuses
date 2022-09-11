using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;
using CapaNegocio.Clase_Personalizada;
using CapaEntidades.Clases_Personalizadas;

namespace CapaPresentacion.Ingresos
{
    public partial class frmCobro : Form
    {
        private UsuarioRolE us;
        public frmCobro(UsuarioRolE use = null)
        {
            InitializeComponent();
            us = use;
        }

        CobroE coe = new CobroE();
        CobrosLN coln = new CobrosLN();
        CobroPersonalizadoLN cpln = new CobroPersonalizadoLN();

        public void MostrarData(string val)
        {
            dataGridView1.DataSource = cpln.ListarCobroPersonalizado(val);
        }

        private void frmCobro_Load(object sender, EventArgs e)
        {
            MostrarData("");
        }

        public void Nuevo()
        {
            frmEditCobro frm = new frmEditCobro(us);
            frm.Text = "Ingresar Cobro";
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                CobroE op = frm.CrearObjeto();
                coln.crearCobros(op);
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
                    frmEditCobro frm = new frmEditCobro(us);
                    frm.Text = "Actualizar Cobro";
                    viewUsuarioAfiliadoCobro op = null;
                    op = dataGridView1.CurrentRow.DataBoundItem as viewUsuarioAfiliadoCobro;

                    frm.SetDatos(op);
                    frm.ShowDialog(this);

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        op = frm.ActualizarObjeto();
                        coln.UpdateCobros(op);
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
                    var resul = MessageBox.Show("¿Quiere eliminar el cobro seleccionado?", "Eliminar Cobro", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        viewUsuarioAfiliadoCobro ta = dataGridView1.CurrentRow.DataBoundItem as viewUsuarioAfiliadoCobro;
                        coln.deleteCobros(ta);
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

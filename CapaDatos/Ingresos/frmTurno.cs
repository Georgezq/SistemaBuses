using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmTurno : Form
    {
        public frmTurno()
        {
            InitializeComponent();
        }

        TurnoE tue = new TurnoE();
        TurnoLN tuln = new TurnoLN();

        public void MostrarData(string val)
        {
            dataGridView1.DataSource = tuln.ListarTurno(val);
        }

        private void frmTurno_Load(object sender, EventArgs e)
        {
            MostrarData("");
        }

        public void Nuevo()
        {
            frmEditTurno frm = new frmEditTurno();
            frm.Text = "Ingresar Turno";
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                TurnoE op = frm.CrearObjeto();
                tuln.crearTurno(op);
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
                    frmEditTurno frm = new frmEditTurno();
                    frm.Text = "Actualizar Turno";
                    TurnoE op = null;
                    op = dataGridView1.CurrentRow.DataBoundItem as TurnoE;
                    frm.SetDatos(op);
                    frm.ShowDialog(this);

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        op = frm.ActualizarObjeto();
                        tuln.UpdateTurno(op);
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
                    var resul = MessageBox.Show("¿Quiere eliminar el turno seleccionado?", "Eliminar turno", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        TurnoE ta = dataGridView1.CurrentRow.DataBoundItem as TurnoE;
                        tuln.deleteTurno(ta);
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

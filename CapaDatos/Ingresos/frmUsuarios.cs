using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        UsuarioE use = new UsuarioE();
        UsuariosLN usln = new UsuariosLN();

        public void MostrarData(string val)
        {
            dataGridView1.DataSource = usln.Listar(val);
        }

        public void DeleteUsr()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var resul = MessageBox.Show("¿Quiere eliminar al Usuario seleccionado?", "Eliminar Usuario", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        UsuarioE ta = dataGridView1.CurrentRow.DataBoundItem as UsuarioE;
                        usln.deleteUsuario(ta);
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

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarData("");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEditUsuarios frm = new frmEditUsuarios();
            frm.Text = "Ingresar Usuario";
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                UsuarioE op = frm.CrearObjeto();
                usln.crearUsuario(op);
                frm.Close();
            }
            MostrarData("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    frmEditUsuarios frm = new frmEditUsuarios();
                    frm.Text = "Actualizar Usuario";
                    UsuarioE op = null;
                    op = dataGridView1.CurrentRow.DataBoundItem as UsuarioE;

                    frm.SetDatos(op);
                    frm.ShowDialog(this);

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        op = frm.ActualizarObjeto();
                        usln.UpdateUsuario(op);
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

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteUsr();
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            MostrarData(txt_busqueda.Text);
        }
    }
}

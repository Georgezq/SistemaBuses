using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmTurnoChofer : Form
    {
        public frmTurnoChofer()
        {
            InitializeComponent();
            MostrarChofer();
        }

        viewChoferTurnoLN ctln = new viewChoferTurnoLN();
        ChoferLN cln = new ChoferLN();

        public void MostrarChofer()
        {
            cb_choferes.DataSource = cln.ListarChofer("");
            cb_choferes.SelectedIndex = 0;
            cb_choferes.DisplayMember = "Nombre";
            cb_choferes.ValueMember = "IdChofer";
        }

        public void MostrarData()
        {
            dataGridView1.DataSource = ctln.ListarChoferTurno(cb_choferes.Text);
        }

       
        private void frmTurnoChofer_Load(object sender, EventArgs e)
        {
            MostrarData();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarData();
        }
    }
}

using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmIngresoTurno : Form
    {
        public frmIngresoTurno()
        {
            InitializeComponent();
        }

        public TurnoE tue;
        TurnoLN tuln = new TurnoLN();

        public void MostrarData(string val)
        {
            dataGridView1.DataSource = tuln.ListarTurno(val);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmIngresoTurno_Load(object sender, EventArgs e)
        {
            MostrarData("");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;

            if (iRow >= 0 && iCol >= 0)
            {
                tue = new TurnoE()
                {
                    IdTurno = Convert.ToInt32(dataGridView1.Rows[iRow].Cells["IdTurno"].Value.ToString()),
                    Tipo = dataGridView1.Rows[iRow].Cells["Tipo"].Value.ToString(),
                    Hora_Inicio = dataGridView1.Rows[iRow].Cells["HoradeInicio"].Value.ToString(),
                    Hora_Terminacion = dataGridView1.Rows[iRow].Cells["Hora_terminacion"].Value.ToString(),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

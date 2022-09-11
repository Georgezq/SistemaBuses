using System;
using System.Windows.Forms;
using CapaNegocio.Ingresos;
using CapaEntidades.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmIngresoUnidad : Form
    {
        public frmIngresoUnidad()
        {
            InitializeComponent();
        }

        UnidadLN unln = new UnidadLN();
        public UnidadE une;

        public void MostrarData(string val)
        {
            dataGridView1.DataSource = unln.ListarUnidad(val);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
    }

        private void frmIngresoUnidad_Load(object sender, EventArgs e)
        {
            MostrarData("");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;

            if (iRow >= 0 && iCol >= 0)
            {
                une = new UnidadE()
                {
                    IdUnidad = Convert.ToInt32(dataGridView1.Rows[iRow].Cells["IdUnidad"].Value.ToString()),
                    Placa = dataGridView1.Rows[iRow].Cells["Placa"].Value.ToString(),
                    Modelo = dataGridView1.Rows[iRow].Cells["Modelo"].Value.ToString(),
                    Capacidad = Convert.ToInt32(dataGridView1.Rows[iRow].Cells["Capacidad"].Value.ToString()),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmIngresoRecorrido : Form
    {
        public frmIngresoRecorrido()
        {
            InitializeComponent();
        }

        RecorridosE rle = new RecorridosE();
        RecorridosLineaLN rlln = new RecorridosLineaLN();
        public RecorridosE rlne;


        public void MostrarData()
        {
            dataGridView1.DataSource = rlln.ListarRecorridosLineas("");
        }

        private void frmIngresoRecorrido_Load(object sender, EventArgs e)
        {
            MostrarData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;

            if (iRow >= 0 && iCol >= 0)
            {
                rlne = new RecorridosE()
                {
                    IdRecorridoLinea = Convert.ToInt32(dataGridView1.Rows[iRow].Cells["IdRecorrido"].Value.ToString()),
                    Descripcion = dataGridView1.Rows[iRow].Cells["Descripcion"].Value.ToString(),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

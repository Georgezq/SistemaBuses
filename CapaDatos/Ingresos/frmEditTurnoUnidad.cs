using System;
using System.Windows.Forms;
using CapaEntidades.Clases_Personalizadas;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmEditTurnoUnidad : Form
    {
        public frmEditTurnoUnidad()
        {
            InitializeComponent();
        }

        frmTurnoUnidad frmUni = new frmTurnoUnidad();

        public void SetDatos(TurnoUnidadPersonalizadoE tue)
        {
            txt_idTurnoUni.Text = tue.IdTurnoUnidad.ToString();
            rtb_turno.Text = "Turno: " + tue.IdTurno.ToString() + "\n" + "Tipo: " + tue.Tipo;
            rtb_unidad.Text = "Unidad: " + tue.IdUnidad.ToString() + "\n" + "Placa: " + tue.Placa
                + "\n" + "Marca: " + tue.Marca;

            rtb_recorrido.Text = "Recorrido: " + tue.IdRecorrido.ToString() + "\n" + "Descripcion: " + tue.Descripcion_recorrido;
              

            txt_idTurno.Text = tue.IdTurno.ToString();
            txt_idUni.Text = tue.IdUnidad.ToString();
            txt_idRecorido.Text = tue.IdRecorrido.ToString(); 
            dateTimePicker1.Value = tue.Fecha;
        }

        public TurnoUnidadE CrearObjeto()
        {
            int idUnidad = int.Parse(txt_idUni.Text);
            int idTurno = int.Parse(txt_idTurno.Text);
            int idRecorrido = int.Parse(txt_idRecorido.Text);
            DateTime fecha = dateTimePicker1.Value;
            TurnoUnidadE ob = new TurnoUnidadE(idUnidad, idTurno, idRecorrido ,fecha);
            return ob;
        }

        public string Unidad()
        {
           string uni = txt_idUni.Text;
            return uni;
        }

        public string Turno()
        {
            string tur = txt_idTurno.Text;
            return tur;
        }

        public TurnoUnidadPersonalizadoE ActualizarObjeto()
        {
            int idTurnoUni = int.Parse(txt_idTurnoUni.Text);
            int idUnidad = int.Parse(txt_idUni.Text);
            int idTurno = int.Parse(txt_idTurno.Text);
            int idRecorrido = int.Parse(txt_idRecorido.Text);
            DateTime fecha = dateTimePicker1.Value;
            TurnoUnidadPersonalizadoE ob = new TurnoUnidadPersonalizadoE(idTurnoUni,idTurno, idUnidad, idRecorrido ,fecha);
            return ob;
        }

        private bool Validar()
        {
            bool vali = true;
            if (rtb_turno.Text.Trim().Length == 0 || rtb_unidad.Text.Trim().Length == 0)
            {
                vali = false;
            }
            return vali;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ingrese correctamente los datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmIngresoTurno frmT = new frmIngresoTurno();
                frmT.ShowDialog();
                if (frmT.DialogResult == DialogResult.OK)
                {
                    rtb_turno.Text = "Turno: " + frmT.tue.IdTurno.ToString() +
                    "\n" + "Tipo: " + frmT.tue.Tipo +
                    "\n" + "Hora de Inicio: " + frmT.tue.Hora_Inicio +
                    "\n" + "Hora de finalización: " + frmT.tue.Hora_Terminacion;

                    txt_idTurno.Text = frmT.tue.IdTurno.ToString();
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmIngresoUnidad frm = new frmIngresoUnidad();
            try
            {              
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    rtb_unidad.Text = "Unidad: " +frm.une.IdUnidad.ToString() +
                    "\n" + "Placa: "  + frm.une.Placa +
                    "\n" + "Modelo: " + frm.une.Modelo +
                    "\n" + "Capacidad: " + frm.une.Capacidad;

                    txt_idUni.Text = frm.une.IdUnidad.ToString();
                }

                
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            
        }

        private void frmEditTurnoUnidad_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmIngresoRecorrido frm = new frmIngresoRecorrido();
            try
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    rtb_recorrido.Text = "Unidad: " + frm.rlne.IdRecorridoLinea.ToString() +
                    "\n" + "Placa: " + frm.rlne.Descripcion;

                    txt_idRecorido.Text = frm.rlne.IdRecorridoLinea.ToString();
                }


            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
    }
}

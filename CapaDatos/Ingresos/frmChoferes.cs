﻿using System;
using System.Windows.Forms;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace CapaPresentacion.Ingresos
{
    public partial class frmChoferes : Form
    {
        public frmChoferes()
        {
            InitializeComponent();
        }

        ChoferE che = new ChoferE();
        ChoferLN chln = new ChoferLN();

        public void MostrarData(string val)
        {
            dataGridView1.DataSource = chln.ListarChofer(val);
        }

        private void frmChoferes_Load(object sender, EventArgs e)
        {
            MostrarData("");
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            MostrarData(txt_busqueda.Text);
        }


        public void Nuevo()
        {
            frmEditChoferes frm = new frmEditChoferes();
            frm.Text = "Ingresar Chofer";
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                ChoferE op = frm.CrearObjetos();
                chln.crearChofer(op);
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
                    frmEditChoferes frm = new frmEditChoferes();
                    frm.Text = "Actualizar Chofer";
                    ChoferE op = null;
                    op = dataGridView1.CurrentRow.DataBoundItem as ChoferE;
                    frm.SetDatos(op);
                    frm.ShowDialog(this);

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        op = frm.ActualizarObjeto();
                        chln.UpdateChofer(op);
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
                    var resul = MessageBox.Show("¿Quiere eliminar al chofer seleccionado?", "Eliminar Chofer", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        ChoferE ta = dataGridView1.CurrentRow.DataBoundItem as ChoferE;
                        chln.deleteChofer(ta);
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
    }
}

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades.Clases_Personalizadas;
using CapaNegocio.Clase_Personalizada;
using CapaPresentacion.Menu;

namespace CapaDatos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        UsuarioRolLN us = new UsuarioRolLN();



        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            UsuarioRolE osuer = us.Listar("").Where(n => n.Usuario == user.Text && n.Contraseña == password.Text).FirstOrDefault();

            if (osuer != null)
            {
                MenuPrincipal frmInicio = new MenuPrincipal(osuer);  
                frmInicio.Show();
                this.Hide();
                frmInicio.FormClosing += Cierre;
            }
            else
            {
                MessageBox.Show("No se encuentra al usuario ingresado, por favor intente de nuevo.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Cierre(object set, FormClosingEventArgs e)
        {
            user.Text = "";
            password.Text = "";
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

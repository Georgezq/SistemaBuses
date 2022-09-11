using CapaEntidades.Clases_Personalizadas;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;
using CapaPresentacion.Ingresos;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CapaPresentacion.Menu
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(UsuarioRolE objUser = null)
        {
            if (objUser == null) useridActual = new UsuarioRolE() { Usuario = "George", IdRol = 1 };
            else
                useridActual = objUser;
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private static UsuarioRolE useridActual;
        public ToolStripMenuItem MenuActivo = null;
        private static Form formActivo = null;

        private void AbrirFormulario(ToolStripMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.AliceBlue;
            }
          
            MenuActivo = menu;
            if (formActivo != null)
            {
                formActivo.Close();

            }

            formActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;
            container.Controls.Add(formulario);

            formulario.Show();
        }



        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            List<PermisosE> ListaPermisos = new PermisosLN().viewPermisos(useridActual.IdRol.ToString());
            foreach (ToolStripMenuItem Item in all_menu.Items)
            {
                bool encontrado = ListaPermisos.Any(n => n.NombreMenu == Item.Name);
                if (encontrado == false)
                {
                    Item.Visible = false;
                }
            }

            //txt_user.Text = useridActual.Usuario.ToString();
            //lb_rol.Text = useridActual.Tipo.ToString();
            txt_user.Enabled = true;
            label4.BackColor = Color.LightSteelBlue;
            label2.BackColor = Color.LightSteelBlue;

            txt_user.BackColor = Color.LightSteelBlue;
            lb_rol.BackColor = Color.LightSteelBlue;
        }


        private void menuusuario_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmUsuarios());
        }

        private void menuafiliado_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmAfiliados());
        }

        private void menuunidad_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmUnidad());
        }

        private void menuchofer_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmChoferes());
        }

        private void menupago_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmPagos(useridActual));
        }

        private void menurecorrido_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmRecorridosLinea());
        }

        private void menuturno_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmTurno());
        }

        private void menuturnounidad_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmTurnoUnidad());
        }

        private void menulineas_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmLineas());
        }

        private void menucobro_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmCobro(useridActual));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmTurnoChofer());
        }
    }
}

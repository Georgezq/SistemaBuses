using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades.Ingresos;
using CapaNegocio.Ingresos;

namespace WebCapa
{
    public partial class users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarData("");
        }

        UsuariosLN usln = new UsuariosLN();

        public void MostrarData(string val)
        {
            gd_usuarios.DataSource = usln.Listar(val);
            gd_usuarios.DataBind();
        }

        public void Filtrar()
        {
            gd_usuarios.DataSource = usln.Listar(this.TextBox1.Text);
            gd_usuarios.DataBind();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            MostrarData(this.TextBox1.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Filtrar();
        }



    }
}
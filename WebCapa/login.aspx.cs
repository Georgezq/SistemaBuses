using System;
using System.Linq;
using CapaEntidades.Clases_Personalizadas;
using CapaNegocio.Clase_Personalizada;

namespace WebCapa
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        UsuarioRolLN us = new UsuarioRolLN();

       
        protected void Button1_Click(object sender, EventArgs e)
        {
            string usuario = this.TextBox1.Text;
            string pass = this.TextBox2.Text;
            UsuarioRolE osuer = us.Listar("").Where(n => n.Usuario == TextBox1.Text && n.Contraseña == TextBox2.Text).FirstOrDefault();

            if (osuer != null)
            {            
                Response.Redirect("index.aspx");
            }
            else
            {
                txt_mensaje.Text = "¡Identificaciones incorrectas!";
            }

        }

    }
}
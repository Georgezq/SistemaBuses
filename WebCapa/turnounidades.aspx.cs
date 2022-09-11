using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades.Ingresos;
using CapaNegocio.Clase_Personalizada;
using CapaNegocio.Ingresos;

namespace WebCapa
{
    public partial class turnounidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarData();
        }

        TurnoUnidadPersonalizadoLN tuln = new TurnoUnidadPersonalizadoLN();



        public void MostrarData()
        {
            gd_turnousuario.DataSource = tuln.ListarTurnoUnidadPersonalizado("");
            gd_turnousuario.DataBind();
        }

        public void Filtrar()
        {
            gd_turnousuario.DataSource = tuln.ListarTurnoUnidadPersonalizado(this.TextBox1.Text);
            gd_turnousuario.DataBind();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Filtrar();
        }



    }
}
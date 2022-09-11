using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio.Ingresos;
using CapaEntidades.Ingresos;

namespace WebCapa
{
    public partial class unidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarData();
        }

        UnidadLN unln = new UnidadLN();

        public void MostrarData()
        {
            gd_unidades.DataSource = unln.ListarUnidad("");
            gd_unidades.DataBind();
        }


        public void Filtrar()
        {
            gd_unidades.DataSource = unln.ListarUnidad(this.TextBox1.Text);
            gd_unidades.DataBind();
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
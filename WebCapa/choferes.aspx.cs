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
    public partial class choferes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarData();
        }

        ChoferLN chln = new ChoferLN();


        public void MostrarData()
        {
            gd_choferes.DataSource = chln.ListarChofer("");
            gd_choferes.DataBind();
        }

        public void Filtrar()
        {
            gd_choferes.DataSource = chln.ListarChofer(this.TextBox1.Text);
            gd_choferes.DataBind();
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
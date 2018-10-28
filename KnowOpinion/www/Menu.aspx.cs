using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace www
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("Añadir.aspx");
        }

        protected void btnborrar_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("Borrar.aspx");
        }

        protected void btnmodificar_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("Modificar.aspx");
        }

        protected void btnencuesta_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("Activar-Desactivar.aspx");
        }
    }
}
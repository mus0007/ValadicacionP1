using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace www
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("InicioSesion.aspx");
        }

        protected void ImagenBoton_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void BotonAdd_Click(object sender, ImageClickEventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("SugerirEncuesta.aspx");
        }
    }
}
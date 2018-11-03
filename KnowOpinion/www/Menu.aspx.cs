using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibClases;

namespace www
{
    public partial class Menu : System.Web.UI.Page
    {
        DataBase db;

        protected void Page_Load(object sender, EventArgs e)
        {
            db = (DataBase)Session["db"];
            string usuario = (string)Session["CuentaUsuario"];
            if (db.getUsuario(usuario) != null)
            {
                db = (DataBase)Session["db"];
                if (db == null)
                {
                    db = new DataBase();
                    Session["db"] = db;
                }
              
            }
            else
            {
                Response.BufferOutput = true;
                Response.Redirect("InicioSesion.aspx");
            }
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
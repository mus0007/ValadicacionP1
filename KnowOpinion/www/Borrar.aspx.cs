using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibClases;

namespace www
{
    public partial class Borrar : System.Web.UI.Page
    {
        DataBase db;

        protected void Page_Load(object sender, EventArgs e)
        {
            db = (DataBase)Session["db"];
            string usuario = (string)Session["CuentaUsuario"];
            if (db.getUsuario(usuario) != null)
            {
                if (!IsPostBack)
                {
                    Session["EncuestaBorrar"] = null;

                    db = (DataBase)Session["db"];
                    if (db == null)
                    {
                        db = new DataBase();
                        Session["db"] = db;
                    }
                }

                string encuestas = "";
                foreach (Encuesta en in db.getEncuestas())
                {
                    encuestas += en.Nombre + " ";
                }
                lblListaEncuestas.Text = encuestas;
            } else
            {
                Response.BufferOutput = true;
                Response.Redirect("InicioSesion.aspx");
            }
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Session["EncuestaBorrar"] = db.getEncuesta(txtEncuestaSeleccionada.Text);
            
            if(Session["EncuestaBorrar"] != null)
            {
                Encuesta encuesta = (Encuesta)Session["EncuestaBorrar"];
                lblPregunta.Text = encuesta.Descripcion;
            } else
            {
                lblPregunta.Text = "";
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            if(Session["EncuestaBorrar"] != null)
            {
                Encuesta encuesta = (Encuesta)Session["EncuestaBorrar"];

                if(db.getEncuesta(encuesta.Nombre) != null)
                {
                    db.borrarEncuesta(encuesta.Nombre);
                    txtEncuestaSeleccionada.Text = "";
                    lblPregunta.Text = "";
                    lblError.Text = "";
                    Response.BufferOutput = true;
                    Response.Redirect("Borrar.aspx");
                }
                
            } else
            {
                lblError.Text = "ERROR: LA ENCUESTA NO EXISTE";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibClases;

namespace www
{
    public partial class Activar_Desactivar : System.Web.UI.Page
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
                    Session["EncuestaActDes"] = null;

                    db = (DataBase)Session["db"];
                    if (db == null)
                    {
                        db = new DataBase();
                        Session["db"] = db;
                    }
                }

                string encuestasActivas = "";
                foreach (Encuesta en in db.getActivas())
                {
                    encuestasActivas += en.Nombre + " ";
                }
                lblListaEncuestas.Text = encuestasActivas;

                string encuestasNoA = "";
                foreach (Encuesta en in db.getNoActivas())
                {
                    encuestasNoA += en.Nombre + " ";
                }
                lblListaEncuestasNA.Text = encuestasNoA;
            } else
            {
                Response.BufferOutput = true;
                Response.Redirect("InicioSesion.aspx");
            }
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Session["EncuestaActDes"] = db.getEncuesta(txtEncuestaSeleccionada.Text);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Session["EncuestaActDes"] != null)
            {
                Encuesta encuesta = (Encuesta)Session["EncuestaActDes"];

                if (db.getEncuesta(encuesta.Nombre) != null)
                {
                    bool esActiva = db.getEncuesta(encuesta.Nombre).Activa;
                    if (esActiva)
                    {
                        db.getEncuesta(encuesta.Nombre).Activa = false;
                    } else
                    {
                        db.getEncuesta(encuesta.Nombre).Activa = true;
                    }
                    txtEncuestaSeleccionada.Text = "";
                    lblError.Text = "";
                    Response.BufferOutput = true;
                    Response.Redirect("Activar-Desactivar.aspx");
                }
            } else
            {
                lblError.Text = "ERROR: NO EXISTE LA ENCUESTA";
            }
        }
    }
}
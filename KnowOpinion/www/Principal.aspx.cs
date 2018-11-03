using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibClases;

namespace www
{
    public partial class Principal : System.Web.UI.Page
    {
        DataBase db;
        Encuesta encuestaActiva;

        protected void Page_Load(object sender, EventArgs e)
        {
            db = (DataBase)Session["db"];

            Session["CuentaUsuario"] = null;
            Session["PassUsuario"] = null;

            if (!IsPostBack)
            {
                Session["Valoracion"] = null;
                Session["Comentario"] = null;
                Session["Encuesta"] = null;
                

                db = (DataBase)Session["db"];
                if (db == null)
                {
                    db = new DataBase();
                    Session["db"] = db;
                }

                string encuestasActivas = "";
                foreach (Encuesta en in db.getActivas())
                {
                    encuestasActivas += en.Nombre + " ";
                }
                lblListaEncuestas.Text = encuestasActivas;
            }

            encuestaActiva = (Encuesta)Session["Encuesta"];
            if (encuestaActiva != null)
            {
                lblPregunta.Text = encuestaActiva.Descripcion;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("InicioSesion.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Session["Valoracion"] = 1;
        }

        protected void BotonAdd_Click(object sender, ImageClickEventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("SugerirEncuesta.aspx");  
        }

        protected void Boton2_Click(object sender, ImageClickEventArgs e)
        {
            Session["Valoracion"] = 2;
        }

        protected void Boton3_Click(object sender, ImageClickEventArgs e)
        {
            Session["Valoracion"] = 3;
        }

        protected void Boton4_Click(object sender, ImageClickEventArgs e)
        {
            Session["Valoracion"] = 4;
        }


        protected void tdxcomentario_TextChanged(object sender, EventArgs e)
        {
            Session["Comentario"] = tdxcomentario.Text;
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if(Session["Encuesta"] != null && Session["Valoracion"] != null)
            {
                int valoracion = (int)Session["Valoracion"];
                string comentario = (string)Session["Comentario"];
                db.getEncuesta(encuestaActiva.Nombre).setOpinion(valoracion,comentario);
                tdxcomentario.Text = "";
                txtEncuestaSeleccionada.Text = "";
                lblPregunta.Text = "";
                lblError.Text = "";
                Response.BufferOutput = true;
                Response.Redirect("Principal.aspx");
            }
            else
            {
                lblError.Text = "ERROR: NO SE HA SELECCIONADO LA ENCUESTA Y/O LA VALORACIÓN";
            }
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            encuestaActiva = db.getEncuesta(txtEncuestaSeleccionada.Text);
            if (encuestaActiva != null)
            {
                lblPregunta.Text = encuestaActiva.Descripcion;
            }
            Session["Encuesta"] = encuestaActiva;
        }
    }
}
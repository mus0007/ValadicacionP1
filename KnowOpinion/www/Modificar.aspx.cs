using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibClases;

namespace www
{
    public partial class Modificar : System.Web.UI.Page
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
                    Session["EncuestaModificar"] = null;
                    Session["DescripcionModificar"] = null;

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
            Session["EncuestaModificar"] = txtEncuestaSeleccionada.Text;
        }

        protected void txtModificarDescripcion_TextChanged(object sender, EventArgs e)
        {
            Session["DescripcionModificar"] = txtModificarDescripcion.Text;
        }


        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if(Session["EncuestaModificar"] != null && Session["DescripcionModificar"] != null)
            {
                string nombre = (string)Session["EncuestaModificar"];
                string descripcion = (string)Session["DescripcionModificar"];
                if (db.modificarEncuesta(nombre,descripcion))
                {
                    lblError.Text = "";
                    txtEncuestaSeleccionada.Text = "";
                    txtModificarDescripcion.Text = "";
                    Response.BufferOutput = true;
                    Response.Redirect("Modificar.aspx");
                } 
            }
            else
            {
                lblError.Text = "ERROR: ENCUESTA Y/O DESCRIPCION ERRÓNEAS";
            }
        }

        
    }
}
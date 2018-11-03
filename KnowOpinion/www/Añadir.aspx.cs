using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibClases;

namespace www
{
    public partial class Añadir : System.Web.UI.Page
    {
        DataBase db;

        protected void Page_Load(object sender, EventArgs e)
        {
            db = (DataBase)Session["db"];
            string usuario = (string)Session["CuentaUsuario"];
            if (db.getUsuario(usuario) != null) {
                if (!IsPostBack)
                {
                    Session["DesEncuesta"] = null;
                    Session["NomEncuesta"] = null;

                    db = (DataBase)Session["db"];
                    if (db == null)
                    {
                        db = new DataBase();
                        Session["db"] = db;
                    }
                }
            } else
            {
                Response.BufferOutput = true;
                Response.Redirect("InicioSesion.aspx");
            }        
        }

        protected void txtAñadirDescripcion_TextChanged(object sender, EventArgs e)
        {
            Session["DesEncuesta"] = txtAñadirDescripcion.Text;
        }

        protected void txtAñadirNombre_TextChanged(object sender, EventArgs e)
        {
            Session["NomEncuesta"] = txtAñadirNombre.Text;
        }

        protected void add(object sender, EventArgs e)
        {
            if (Session["NomEncuesta"] != null && Session["DesEncuesta"] != null)
            {
                string nombre = (string)Session["NomEncuesta"];
                string descripcion = (string)Session["DesEncuesta"];
                if(db.addEncuesta(nombre, descripcion, false))
                {
                    lblError1.Text = "";
                    txtAñadirDescripcion.Text = "";
                    txtAñadirNombre.Text = "";
                    Response.BufferOutput = true;
                    Response.Redirect("Añadir.aspx");
                } else
                {
                    txtAñadirDescripcion.Text = "";
                    txtAñadirNombre.Text = "";
                    Session["NomEncuesta"] = null;
                    Session["DesEncuesta"] = null;
                    lblError1.Text = "ERROR: LA INSERCCIÓN DE LA ENCUESTA FALLÓ";
                } 
            }
            else
            {
                txtAñadirDescripcion.Text = "";
                txtAñadirNombre.Text = "";
                Session["NomEncuesta"] = null;
                Session["DesEncuesta"] = null;
                lblError1.Text = "ERROR: NO SE HA ESCRITO EL NOMBRE Y/O LA DESCRIPCIÓN";
            }
        }
    }
}
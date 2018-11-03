using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibClases;

namespace www
{
    public partial class SugerirEncuesta : System.Web.UI.Page
    {
        DataBase db;

        protected void Page_Load(object sender, EventArgs e)
        {
            db = (DataBase)Session["db"];
            Session["CuentaUsuario"] = null;
            Session["PassUsuario"] = null;

            if (!IsPostBack)
            {
                Session["DesEncuestaSugerida"] = null;
                Session["NomEncuestaSugerida"] = null;
                

                db = (DataBase)Session["db"];
                if (db == null)
                {
                    db = new DataBase();
                    Session["db"] = db;
                }
            }

        }

        protected void txtSugerirDescripcion_TextChanged(object sender, EventArgs e)
        {
            Session["DesEncuestaSugerida"] = txtSugerirDescripcion.Text;
        }

        protected void txtSugerirNombre_TextChanged(object sender, EventArgs e)
        {
            Session["NomEncuestaSugerida"] = txtSugerirNombre.Text;
        }

        protected void enviar(object sender, EventArgs e)
        {
            if (Session["NomEncuestaSugerida"] != null && Session["DesEncuestaSugerida"]!=null)
            {
                string nombre = (string)Session["NomEncuestaSugerida"];
                string descripcion = (string)Session["DesEncuestaSugerida"];
                db.sugerirEncuesta(nombre, descripcion);
                lblError.Text = "";
                txtSugerirDescripcion.Text = "";
                txtSugerirNombre.Text = "";
                Response.BufferOutput = true;
                Response.Redirect("SugerirEncuesta.aspx");
            }
            else
            {
                lblError.Text = "ERROR: NO SE HA ESCRITO EL NOMBRE Y/O LA DESCRIPCIÓN";
            }
        }
    }
}
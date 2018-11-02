using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibClases;

namespace www
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        DataBase db;

        protected void Page_Load(object sender, EventArgs e)
        {
            db = (DataBase)Session["db"];

            if (!IsPostBack)
            {
                Session["CuentaUsuario"] = null;
                Session["PassUsuario"] = null;

                db = (DataBase)Session["db"];
                if (db == null)
                {
                    db = new DataBase();
                    Session["db"] = db;
                }
            }
        }

        protected void txtcuenta_TextChanged(object sender, EventArgs e)
        {
            Session["CuentaUsuario"] = txtcuenta.Text;
        }

        protected void txtcontrena_TextChanged(object sender, EventArgs e)
        {
            Session["PassUsuario"] = txtcontrena.Text;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(Session["CuentaUsuario"]!=null && Session["PassUsuario"] != null)
            {
                lblError2.Text = "";
                string usuario = (string)Session["CuentaUsuario"];
                string pass = (string)Session["PassUsuario"];

                if(db.getUsuario(usuario) != null && db.getUsuario(usuario).comprobarPass(pass))
                {
                    Response.BufferOutput = true;
                    Response.Redirect("Menu.aspx");
                    lblError1.Text = "";
                }else
                {
                    lblError1.Text = "ERROR: CUENTA Y/O CONTRASEÑA INCORRECTO/S";
                } 
            } else
            {
                lblError2.Text = "ERROR: CUENTA Y/O CONTRASEÑA ESTÁN INCOMPLETO/S";
            }
            //Session["CuentaUsuario"] = null;
            //Session["PassUsuario"] = null;
        }
    }
}
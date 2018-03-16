using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["IdUsuario"] != null)
                {
                    Response.Redirect("Default.aspx");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void Logar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Usuario usuLog = new Entidades.Usuario();
                BLL.Usuario Bllusu = new BLL.Usuario();
                //usuLog = Bllusu.VerificaLogin2(LoginUsu.Text, SenhaClie.Text);
                usuLog = Bllusu.UsuarioLogin(LoginUsu.Text, SenhaClie.Text);

                if (usuLog.IdUsuario != 0)
                {
                    lblmsg.Visible = false;
                    lblmsg.InnerText = "";

                    Session["usuarioid"] = usuLog.IdUsuario;
                    Session["Nome"] = usuLog.Nome;

                    Response.Redirect("Home.aspx", false);
                }
                else
                {
                    lblmsg.Visible = true;
                    lblmsg.InnerText = "Login e/ou senha incorretos!";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
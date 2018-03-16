using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using RaiCore;
using System.Configuration;
using System.Web.Security;

namespace Interface
{
    public class PaginaBase : System.Web.UI.Page
    {
        public string IPCorrente()
        {
            try
            {
                return Request.ServerVariables["REMOTE_ADDR"] as string;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string RecursoCorrente()
        {
            try
            {
                return this.Request.Url.AbsolutePath;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string UsuarioCorrente()
        {
            try
            {
                return Page.User.Identity.Name.Substring(Page.User.Identity.Name.Length - (Page.User.Identity.Name.Length - 14));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void TratarErro(Exception ex)
        {
            Email e = new Email("Email@rai.com.br", 
                                new string[] {ConfigurationManager.AppSettings["EmailErroGeral"].ToString() },
                                null,
                                "Erro em " + ConfigurationManager.AppSettings["Sistema"].ToString(),
                                "Sistema: " + ConfigurationManager.AppSettings["Sistema"].ToString() + Environment.NewLine +
                                "Recurso: " + RecursoCorrente() + Environment.NewLine +
                                "Usuario: " + UsuarioCorrente() + Environment.NewLine +
                                "Ip: " + IPCorrente() +
                                Environment.NewLine +
                                Environment.NewLine +
                                Environment.NewLine +
                                "Erro:" + ex.Message +
                                Environment.NewLine +
                                Environment.NewLine +
                                Environment.NewLine +
                                "Trace:" + ex.StackTrace, System.Net.Mail.MailPriority.High, null, "smtp.rai.com.br");

            e.SendEmail();
        }

        public Boolean IsNumeric(String num)
        {
            Int32 numero;

            return Int32.TryParse(num, out numero);
        }

        public Boolean IsNumeric(Object num)
        {
            Int32 numero;

            return Int32.TryParse(num.ToString(), out numero);
        }

        public String Upper(String texto)
        {
            return texto.ToUpper();
        }

        public String Lower(String texto)
        {
            return texto.ToLower();
        }

        public Boolean IsDate(String date)
        {
            DateTime data;

            return DateTime.TryParse(date.ToString(), out data);
        }

        public Boolean IsDate(Object date)
        {
            DateTime data;

            return DateTime.TryParse(date.ToString(), out data);
        }

        public void VerificaPermisaoAcesso()
        {

        }
        /// <summary>
        /// Não Implementado
        /// </summary>
        /// <returns>True ou False</returns>
        public Boolean VerificaPermisao()
        {
            return true;
        }

        /// <summary>
        /// Se baseia pela session IdUsuario
        /// </summary>
        /// <returns>Usuario Logado ou não</returns>
        public Boolean VerificaUsuarioLogado()
        {
            if (Session["IdUsuario"] == null)
            {
                return false;
            }
            return true;
        }
    }
}
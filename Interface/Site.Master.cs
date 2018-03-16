using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Threading;
using System.Diagnostics;
using System.Timers;
using System.Threading.Tasks;

namespace Interface
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                //ComputeResultWithTimeout();

                if (Session["usuarioid"] == null)
                {
                    //Response.Redirect("login.aspx", false);
                }

                //Entidades.Positivador tipoPosi = new Entidades.Positivador();
                //tipoPosi = this.verificaLogin();

              
            }
            catch (Exception)
            {
                
               //Response.Redirect("login.aspx", false);
            }
        }

        public void ComputeResultWithTimeout()
        {
            var task = Task.Factory.StartNew(() => ComputeResult("bla"));

            //task.Wait(0999);
            task.Wait(1000);

            if (task.IsCompleted)
                Console.WriteLine("OK, got: " + task.Result);
            else
                //Console.WriteLine("Erro");
                Response.Redirect("Index.aspx");
        }


        public int ComputeResult(string someParameter)
        {
            Thread.Sleep(1000);
            return 42;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface
{
    public partial class Cadastro_Imagens : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    frase.Visible = false;
                    int produto = Convert.ToInt32(Request.QueryString["prt"]);
                    CarregaProduto(produto);
                    CarregaFotos(produto);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void CarregaProduto(int produto)
        {
            try
            {
                idProduto.Text = produto.ToString();

                Entidades.Produtos Ent = new Entidades.Produtos();
                BLL.Produtos Bll = new BLL.Produtos();

                Ent = Bll.CarregaProdutoGetSelected(produto);

                NomeProd.Text = Ent.NomeProduto.ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }


        protected void Gravar_Click(object sender, EventArgs e)
        {
            try
            {

                var mensagem = string.Empty;

                if (this.IMG.HasFile)
                {

                    //this.IMG.SaveAs(Server.MapPath("images/produtos/" + IMG.FileName));
                    this.IMG.SaveAs(Server.MapPath("images/produtos/" + IMG.FileName));



                    mensagem = "Imagem gravada com sucesso!";

                    Entidades.Produtos Ent = new Entidades.Produtos();
                    BLL.Produtos BLL = new global::BLL.Produtos();

                    Ent.IdProduto = Convert.ToInt32(idProduto.Text);
                    Ent.Imagem = IMG.FileName;

                    BLL.InseriImagem(Ent);


                    int prod = Convert.ToInt32(Request.QueryString["prt"]);

                    Response.Redirect("Cadastro_Imagens.aspx?prt=" + prod + "", false);

                }
                else
                {
                    frase.Visible = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void CarregaFotos(int produto)
        {
            try
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                Entidades.ProdutosCollection EntColl = new Entidades.ProdutosCollection();
                BLL.Produtos Bll = new BLL.Produtos();

                EntColl = Bll.CarregaFotos(produto);

                //sb.AppendLine("");


                sb.AppendLine("<ul>");

                foreach (var fot in EntColl)
                {
                    sb.AppendLine("<li><img src='images/produtos/" + fot.Imagem + "' width='200px' /><p style='cursor:pointer;' onclick=\"return RemoveImagem('" + fot.idImagem + "')\">remover</p></li>");
                }

                sb.AppendLine("</ul>");

                litFotos.Text = sb.ToString();


            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void RemoveImagemId_Click(object sender, EventArgs e)
        {
            try
            {
                int Foto = Convert.ToInt32(hdnProd.Value);
                string pro = Request.QueryString["prt"];

                BLL.Produtos BLL = new BLL.Produtos();

                BLL.RemoveFotos(Foto);

                Response.Redirect("Cadastro_Imagens.aspx?prt=" + pro + "");
            }
            catch (Exception)
            {

                throw;
            }
        }




    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface
{
    public partial class Editar_Produto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CarregaCategorias();
                    //int produto = Convert.ToInt32(Request.QueryString["prt"]);
                    //CarregaProduto(produto);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CarregaCategorias()
        {
            try
            {
                Entidades.ProdutosCollection EntColl = new Entidades.ProdutosCollection();
                BLL.Produtos BLL = new BLL.Produtos();
                EntColl = BLL.CarregaCategorias();
                ddlCategoria.DataTextField = "NomeCategoria";
                ddlCategoria.DataValueField = "IdCategoria";
                ddlCategoria.DataSource = EntColl;
                ddlCategoria.DataBind();
                ddlCategoria.Items.Insert(0, "Selecione");
                ddlCategoria.SelectedIndex = 0;
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
                Entidades.Produtos Ent = new Entidades.Produtos();
                BLL.Produtos Bll = new BLL.Produtos();

                Ent = Bll.CarregaProdutoGetSelected(produto);

                string Descri = Ent.Descricao.ToString();
                string Especi = Ent.Especificacoes.ToString();

                Descri = Descri.Replace("<br>", "\r\n");
                Especi = Especi.Replace("<br>", "\r\n");
                CodProd.Text = Ent.CodProduto.ToString();
                NomeProd.Text = Ent.NomeProduto.ToString();
                Descricao.Text = Descri;
                Especificacoes.Text = Especi;
                ddlCategoria.SelectedValue = Convert.ToString(Ent.Categoria);
                string imagem = Ent.Imagem.ToString();
                CarregaFotos(imagem);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CarregaFotos(string imagem)
        {
            try
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                //sb.AppendLine("");
                sb.AppendLine("<ul>");
                sb.AppendLine("<li><img src='images/thumb/" + imagem + "' width='200px' /></li>");
                sb.AppendLine("</ul>");
                litFotos.Text = sb.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int produto = Convert.ToInt32(Request.QueryString["prt"]);
                var mensagem = string.Empty;

                if (this.IMG.HasFile)
                {
                    this.IMG.SaveAs(Server.MapPath("images/thumb/" + IMG.FileName));
                    mensagem = "Imagem gravada com sucesso!";

                    Entidades.Produtos Ent = new Entidades.Produtos();
                    BLL.Produtos BLL = new global::BLL.Produtos();

                    string Descri = Descricao.Text.Replace("\r\n", "<br>");
                    string Especi = Especificacoes.Text.Replace("\r\n", "<br>");

                    //string Descri = Descricao.Text.Replace("<br>", System.Environment.NewLine);
                    //string Especi = Especificacoes.Text.Replace("<br>", System.Environment.NewLine);
                    //string Descri = Descricao.Text.Replace(vbCrLf, "<br>");
                    //string Especi = Especificacoes.Text.Replace(vbCrLf, "<br>");

                    Ent.CodProduto = CodProd.Text;
                    Ent.NomeProduto = NomeProd.Text;
                    Ent.Descricao = Descri;
                    Ent.Especificacoes = Especi;
                    Ent.Categoria = Convert.ToInt32(ddlCategoria.SelectedValue.ToString());
                    Ent.Imagem = IMG.FileName;
                    BLL.AlteraProduto(produto, Ent);
                    Response.Redirect("Produto_Lista.aspx");
                }
                else
                {
                    Entidades.Produtos Ent = new Entidades.Produtos();
                    BLL.Produtos BLL = new global::BLL.Produtos();
                    string Descri = Descricao.Text.Replace("\r\n", "<br>");
                    string Especi = Especificacoes.Text.Replace("\r\n", "<br>");

                    //string Descri = Descricao.Text.Replace("<br>", System.Environment.NewLine);
                    //string Especi = Especificacoes.Text.Replace("<br>", System.Environment.NewLine);

                    //string Descri = Descricao.Text.Replace(vbCrLf, "<br>");
                    //string Especi = Especificacoes.Text.Replace(vbCrLf, "<br>");

                    Ent.CodProduto = CodProd.Text;
                    Ent.NomeProduto = NomeProd.Text;
                    Ent.Descricao = Descri;
                    Ent.Especificacoes = Especi;
                    Ent.Categoria = Convert.ToInt32(ddlCategoria.SelectedValue.ToString());
                    Ent.Imagem = IMG.FileName;
                    BLL.AlteraProduto(produto, Ent);
                    Response.Redirect("Produto_Lista.aspx");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
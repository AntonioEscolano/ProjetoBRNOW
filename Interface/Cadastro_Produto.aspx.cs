using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface
{
    public partial class Cadastro_Produto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CarregaCategorias();
                }
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

                    BLL.InseriProduto(Ent);

                    Response.Redirect("Default.aspx");

                }
                else
                {

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

    }
}
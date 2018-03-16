using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface
{
    public partial class Cadastro_Imovel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CarregaCategorias();
                    CarregaSubCategorias();
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        protected void Gravar_Click(object sender, EventArgs e)
        {
            try
            {
                var mensagem = string.Empty;
                
                Entidades.Imovel Ent = new Entidades.Imovel();
                BLL.Imovel BLL = new global::BLL.Imovel();
                
                Ent.Nome_Imovel = Nome_Imovel.Text;
                Ent.Numero = Convert.ToInt32(Numero.Text.ToString());
                Ent.Preco = Convert.ToDouble(Preco.Text.ToString());
                //Ent.Ativo = Convert.ToInt32(Ativo.Text.ToString());
                Ent.Categoria = Convert.ToInt32(ddlCategoria.SelectedValue.ToString());
                Ent.SubCategoria = Convert.ToInt32(SubCategoria.Text.ToString());
                BLL.InserirImovel(Ent);
                //Response.Redirect("Default.aspx");

                //if (this.IMG.HasFile)
                //{
                //    this.IMG.SaveAs(Server.MapPath("images/thumb/" + IMG.FileName));
                //    mensagem = "Imagem gravada com sucesso!";
                //    Entidades.Produtos Ent = new Entidades.Produtos();
                //    BLL.Produtos BLL = new global::BLL.Produtos();
                //    string Descri = Descricao.Text.Replace("\r\n", "<br>");
                //    string Especi = Especificacoes.Text.Replace("\r\n", "<br>");
                    //string Descri = Descricao.Text.Replace("<br>", System.Environment.NewLine);
                    //string Especi = Especificacoes.Text.Replace("<br>", System.Environment.NewLine);
                    //string Descri = Descricao.Text.Replace(vbCrLf, "<br>");
                    //string Especi = Especificacoes.Text.Replace(vbCrLf, "<br>");
                //    Ent.CodProduto = CodProd.Text;
                //    Ent.NomeProduto = NomeProd.Text;
                //    Ent.Descricao = Descri;
                //    Ent.Especificacoes = Especi;
                //    Ent.Categoria = Convert.ToInt32(ddlCategoria.SelectedValue.ToString());
                //    Ent.Imagem = IMG.FileName;
                //    BLL.InseriProduto(Ent);
                //    Response.Redirect("Default.aspx");
                //}
                //else
                //{

                //}
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void CarregaCategorias()
        {
            try
            {
                Entidades.ImovelColletion EntColl = new Entidades.ImovelColletion();
                BLL.Imovel BLL = new BLL.Imovel();

                EntColl = BLL.CarregaCategorias();

                ddlCategoria.DataTextField = "tipoImovel";
                ddlCategoria.DataValueField = "idTipoImovel";

                ddlCategoria.DataSource = EntColl;
                ddlCategoria.DataBind();

                ddlCategoria.Items.Insert(0, "Selecione");
                ddlCategoria.SelectedIndex = 0;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public void CarregaSubCategorias()
        {
            try
            {
                Entidades.ImovelColletion EntColl = new Entidades.ImovelColletion();
                BLL.Imovel BLL = new BLL.Imovel();
                EntColl = BLL.CarregaSubCategorias();
                
                SubCategoria.DataTextField = "Nome";
                SubCategoria.DataValueField = "id_SubCategoria";

                SubCategoria.DataSource = EntColl;
                SubCategoria.DataBind();

                SubCategoria.Items.Insert(0, "Selecione");
                SubCategoria.SelectedIndex = 0;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}
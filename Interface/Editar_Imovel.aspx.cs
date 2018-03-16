using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface
{
    public partial class Editar_Imovel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CarregaCategorias();
                    CarregaSubCategorias();
                    //int imovel = Convert.ToInt32(Request.QueryString["prt"]);
                    //CarregaImovel(imovel);
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
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

                ddlSubCategoria.DataTextField = "Nome";
                ddlSubCategoria.DataValueField = "id_SubCategoria";

                ddlSubCategoria.DataSource = EntColl;
                ddlSubCategoria.DataBind();

                ddlSubCategoria.Items.Insert(0, "Selecione");
                ddlSubCategoria.SelectedIndex = 0;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public void CarregaImovel(int imovel)
        {
            try
            {
                Entidades.Imovel Ent = new Entidades.Imovel();
                BLL.Imovel BLL = new BLL.Imovel();
                Ent = BLL.CarregaImovelGetSelected(imovel);
                string Nume = Ent.Numero.ToString();
                string Prec = Ent.Numero.ToString();

                Nume = Nume.Replace("<BR>", "\r\n");
                Prec = Prec.Replace("BR", "\r\n");

                Numero.Text = Ent.Numero.ToString();
                Preco.Text = Ent.Preco.ToString();

                Numero.Text = Nume;
                Preco.Text = Prec;

                ddlCategoria.SelectedValue = Convert.ToString(Ent.Categoria);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int imovel = Convert.ToInt32(Request.QueryString["prt"]);

                Entidades.Imovel Ent = new Entidades.Imovel();
                BLL.Imovel BLL = new global::BLL.Imovel();

                string NomeImo = NomeImov.Text.Replace("\r\n", "<BR>");
                string NumeroImo = Numero.Text.Replace("\r\n", "<BR>");

                Ent.Nome = NomeImov.Text;
                Ent.Numero = Convert.ToInt32(Numero.Text);
                Ent.Preco = Convert.ToDouble(Preco.Text);
                Ent.Categoria = Convert.ToInt32(ddlCategoria);
                Ent.SubCategoria = Convert.ToInt32(ddlSubCat);
                BLL.AlteraImovel(imovel, Ent);
                Response.Redirect("Produto_Lista.aspx");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
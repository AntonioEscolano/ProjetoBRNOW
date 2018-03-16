using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface
{
    public partial class Produto_Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CarregaProdutos();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CarregaProdutos()
        {
            try
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                Entidades.ProdutosCollection EntColl = new Entidades.ProdutosCollection();
                BLL.Produtos Bll = new BLL.Produtos();
                EntColl = Bll.CarregaProdutos();
                sb.AppendLine(@"<div class='table-responsive'>
                            <table class='table' id='table2'>
                                <thead>
                                    <tr>
                                        <th width='20%'>Produto</th>
                                        <th width='7%'>Código</th>
                                        <th>Descrição</th>
                                        <th width='15%'>Categoria</th>
                                        <th width='10%'>Ações</th>
                                    </tr>
                                </thead>
                                <tbody>");
                string cssli = "";

                foreach (var prod in EntColl)
                {
                    if (cssli == "odd")
                    {
                        cssli = "even";
                    }
                    else
                    {
                        cssli = "odd";
                    }
                    sb.AppendLine(@"
                        <tr class='" + cssli + @" gradeA'>
                            <td>" + prod.NomeProduto + @"</td>
                            <td>" + prod.CodProduto + @"</td>");
                    string descri = prod.Descricao.ToString();
                    //descri.Substring(0, descri.IndexOf(' ', 48));
                    sb.AppendLine("<td>" + descri + "</td>");
                    sb.AppendLine("<td>" + prod.NomeCategoria + @"</td>");
                    sb.AppendLine("<td class='center'>");
                    sb.AppendLine("<a href='Cadastro_Imagens.aspx?prt=" + prod.IdProduto + "'><img src='images/adicionar.png' /></a>");
                    sb.AppendLine("<img style='cursor:pointer;' onclick=\"return RemoveProduto('" + prod.IdProduto + "')\" src='images/remover.png' />");
                    sb.AppendLine("<a href='Editar_Produto.aspx?prt=" + prod.IdProduto + "'><img src='images/editar.png' /></a>");
                    sb.AppendLine("</td>");
                    sb.AppendLine("</tr>");
                }
                sb.AppendLine(@"</tbody>
                            </table>
                        </div>");
                sb.AppendLine("");
                litLista.Text = sb.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void RemoveProduto_Click(object sender, EventArgs e)
        {
            try
            {
                int idProduto = Convert.ToInt32(hdnProd.Value);
                BLL.Produtos BLL = new BLL.Produtos();
                BLL.RemoveProduto(idProduto);
                Response.Redirect("Produto_Lista.aspx");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
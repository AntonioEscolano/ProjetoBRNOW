using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface
{
    public partial class Lista_Imovel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CarregaImovel();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CarregaImovel()
        {
            try
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                Entidades.ImovelColletion EntColl = new Entidades.ImovelColletion();
                BLL.Imovel Bll = new BLL.Imovel();
                EntColl = Bll.CarregaImovel();
                sb.AppendLine(@"<div class='table-responsive'>
                            <table class='table' id='table2'>
                                <thead>
                                    <tr>
                                        <th width='20%'>Nome Imóvel</th>
                                        <th width='7%'>Número</th>
                                        <th>Preço</th>
                                        <th width='15%'>Categoria</th>
                                        <th width='10%'>Ações</th>
                                    </tr>
                                </thead>
                                <tbody>");
                string cssli = "";

                foreach (var imovel in EntColl)
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
                            <td>" + imovel.Nome_Imovel + @"</td>
                            <td>" + imovel.Numero + @"</td>
                            <td>" + imovel.Preco + @" </td>");
                    string descri = imovel.Categoria.ToString();
                    //descri.Substring(0, descri.IndexOf(' ', 48));
                    //sb.AppendLine("<td>" + descri + "</td>");
                    sb.AppendLine("<td>" + imovel.Categoria + @"</td>");
                    sb.AppendLine("<td class='center'>");
                    //sb.AppendLine("<a href='Cadastro_Imagens.aspx?prt=" + imovel.IdProduto + "'><img src='images/adicionar.png' /></a>");
                    sb.AppendLine("<img style='cursor:pointer;' onclick=\"return RemoveImovel('" + imovel.ID_Imovel + "')\" src='images/remover.png' />");
                    sb.AppendLine("<a href='Editar_Imovel.aspx?prt=" + imovel.ID_Imovel + "'><img src='images/editar.png' /></a>");
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

        protected void RemoveImovelId_Click(object sender, EventArgs e)
        {
            try
            {
                int ID_Imovel = Convert.ToInt32(hdnImov.Value);
                BLL.Imovel BLL = new BLL.Imovel();
                BLL.RemoveImovel(ID_Imovel);
                Response.Redirect("Lista_Imovel.aspx");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
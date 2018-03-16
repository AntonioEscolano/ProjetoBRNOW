using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Produtos
    {
        public void InseriProduto(Entidades.Produtos Ent)
        {
            try
            {
                DAL.Produtos DAL = new DAL.Produtos();
                DAL.InseriProduto(Ent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// --------------------------------------------------------------------------------------------

        public void InseriProdutoHome(Entidades.Produtos Ent)
        {
            try
            {
                DAL.Produtos DAL = new DAL.Produtos();
                DAL.InseriProdutoHome(Ent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// --------------------------------------------------------------------------------------------

        public Entidades.ProdutosCollection CarregaCategorias()
        {
            try
            {
                DAL.Produtos DAL = new DAL.Produtos();
                return DAL.CarregaCategorias();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// --------------------------------------------------------------------------------------------

        public Entidades.ProdutosCollection CarregaProdutos()
        {
            try
            {
                DAL.Produtos DAL = new DAL.Produtos();
                return DAL.CarregaProdutos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// --------------------------------------------------------------------------------------------

        public void RemoveProduto(Int32 Produto)
        {
            try
            {
                DAL.Produtos DAL = new DAL.Produtos();
                DAL.RemoveProduto(Produto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// --------------------------------------------------------------------------------------------

        public void InseriImagem(Entidades.Produtos Ent)
        {
            try
            {
                DAL.Produtos DAL = new DAL.Produtos();
                DAL.InseriImagem(Ent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// --------------------------------------------------------------------------------------------

        public Entidades.Produtos CarregaProdutoGetSelected(Int32 produto)
        {
            try
            {
                DAL.Produtos DAL = new DAL.Produtos();
                return DAL.CarregaProdutoGetSelected(produto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// --------------------------------------------------------------------------------------------

        public Entidades.ProdutosCollection CarregaFotos(Int32 produto)
        {
            try
            {
                DAL.Produtos DAL = new DAL.Produtos();
                return DAL.CarregaFotos(produto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// --------------------------------------------------------------------------------------------

        public void RemoveFotos(Int32 Foto)
        {
            try
            {
                DAL.Produtos DAL = new DAL.Produtos();
                DAL.RemoveFotos(Foto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// --------------------------------------------------------------------------------------------

        public void AlteraProduto(Int32 Produto , Entidades.Produtos Ent)
        {
            try
            {
                DAL.Produtos DAL = new DAL.Produtos();
                DAL.AlteraProduto(Produto, Ent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

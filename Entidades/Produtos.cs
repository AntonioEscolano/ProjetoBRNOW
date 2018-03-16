using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Produtos
    {

        private String _CodProduto;

        public String CodProduto
        {
            get { return _CodProduto; }
            set { _CodProduto = value; }
        }

        private String _NomeProduto;

        public String NomeProduto
        {
            get { return _NomeProduto; }
            set { _NomeProduto = value; }
        }

        private String _Descricao;

        public String Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }

        private String _Especificacoes;

        public String Especificacoes
        {
            get { return _Especificacoes; }
            set { _Especificacoes = value; }
        }

        private Int32 _Categoria;

        public Int32 Categoria
        {
            get { return _Categoria; }
            set { _Categoria = value; }
        }

        private String _Imagem;

        public String Imagem
        {
            get { return _Imagem; }
            set { _Imagem = value; }
        }

        private Int32 _IdProduto;

        public Int32 IdProduto
        {
            get { return _IdProduto; }
            set { _IdProduto = value; }
        }

        private Int32 _IdCategoria;

        public Int32 IdCategoria
        {
            get { return _IdCategoria; }
            set { _IdCategoria = value; }
        }

        private String _NomeCategoria;

        public String NomeCategoria
        {
            get { return _NomeCategoria; }
            set { _NomeCategoria = value; }
        }

        private Int32 _idImagem;

        public Int32 idImagem
        {
            get { return _idImagem; }
            set { _idImagem = value; }
        }
    }
    public class ProdutosCollection : List<Produtos> { }
}

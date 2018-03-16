using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Imovel
    {
        private int _ID_Imovel;

        public int ID_Imovel
        {
            get { return _ID_Imovel; }
            set { _ID_Imovel = value; }
        }


        private String _Nome_Imovel;

        public String Nome_Imovel
        {
            get { return _Nome_Imovel; }
            set { _Nome_Imovel = value; }
        }

        private int _Numero;

        public int Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        private Double _Preco;

        public Double Preco
        {
            get { return _Preco; }
            set { _Preco = value; }
        }

        private int _Ativo;

        public int Ativo
        {
            get { return _Ativo; }
            set { _Ativo = value; }
        }

        private int _Categoria;

        public int Categoria
        {
            get { return _Categoria; }
            set { _Categoria = value; }
        }

        private int _SubCategoria;

        public int SubCategoria
        {
            get { return _SubCategoria; }
            set { _SubCategoria = value; }
        }

        //private int _idTipoImovel;

        //public int idTipoImovel
        //{
        //    get { return _idTipoImovel; }
        //    set { _idTipoImovel = value; }
        //}
        private int _IdTipoImovel;

        public int IdTipoImovel
        {
            get { return _IdTipoImovel; }
            set { _IdTipoImovel = value; }
        }


        private String _TipoImovel;

        public String TipoImovel
        {
            get { return _TipoImovel; }
            set { _TipoImovel = value; }
        }

        private int _Id_SubCategoria;

        public int Id_SubCategoria
        {
            get { return _Id_SubCategoria; }
            set { _Id_SubCategoria = value; }
        }

        private int _IdCategoria;

        public int IdCategoria
        {
            get { return _IdCategoria; }
            set { _IdCategoria = value; }
        }

        private String _Nome;

        public String Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private String _NomeCategoria;

        public String NomeCategoria
        {
            get { return _NomeCategoria; }
            set { _NomeCategoria = value; }
        }

    }
    public class ImovelColletion : List<Imovel> { }
}

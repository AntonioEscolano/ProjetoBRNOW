using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        private String _CNPJ;
        public String CNPJ
        {
            get { return _CNPJ; }
            set { _CNPJ = value; }
        }

        private String _NomeFantasia;
        public String NomeFantasia
        {
            get { return _NomeFantasia; }
            set { _NomeFantasia = value; }
        }

        private Int32 _IdUsuario;
        public Int32 IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        private Int32 _IdTipoUsuario;
        public Int32 IdTipoUsuario
        {
            get { return _IdTipoUsuario; }
            set { _IdTipoUsuario = value; }
        }

        private Boolean _PrimeiroAcesso;
        public Boolean PrimeiroAcesso
        {
            get { return _PrimeiroAcesso; }
            set { _PrimeiroAcesso = value; }
        }

        // ------------------------------------------------------

        private String _Nome;
        public String Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private String _Login;
        public String Login
        {
            get { return _Login; }
            set { _Login = value; }
        }

        private String _Senha;
        public String Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }

        private String _Email;
        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private Boolean _Ativo;
        public Boolean Ativo
        {
            get { return _Ativo; }
            set { _Ativo = value; }
        }

        private Int32 _IdPositivador;
        public Int32 IdPositivador
        {
            get { return _IdPositivador; }
            set { _IdPositivador = value; }
        }

        private DateTime _DataCadastro;
        public DateTime DataCadastro
        {
            get { return _DataCadastro; }
            set { _DataCadastro = value; }
        }

        private Int32 _IdEquipe;
        public Int32 IdEquipe
        {
            get { return _IdEquipe; }
            set { _IdEquipe = value; }
        }
    }

    public class UsuarioCollection : List<Usuario>
    {
    }
}

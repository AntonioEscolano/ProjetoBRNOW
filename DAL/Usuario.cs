using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Data.Odbc;


namespace DAL
{
    public class Usuario
    {
        //private MySqlConnection bdConn; //MySQL
        //private MySqlDataAdapter bdAdapter;
        //private DataSet bdDataSet; //MySQL

        private MySqlConnection conexao;

        //public int VerificaLogin(string Login, string Senha)
        //{
        //    Entidades.Usuario UsuEnt = new Entidades.Usuario();
        //    int retorno = -1;
        //    //Definição do dataset
        //    bdDataSet = new DataSet();
        //    //Define string de conexão
        //    bdConn = new MySqlConnection("server=mysql.brnow.com.br;database=brnow01;uid=brnow01;pwd=buffalo");
        //    //bdConn = new MySqlConnection("server=108.179.192.29;database=agile247_BD;uid=agile247_BD;pwd=webtecf1b1");
        //    //Abre conecção
        //    try
        //    {
        //        bdConn.Open();
        //        if (bdConn.State == ConnectionState.Open)
        //        {
        //            string comando = "SELECT COUNT(*) FROM tb_BU_Usuario WHERE Login = @Usuario AND Senha = @Senha";
        //            MySqlCommand cmd = new MySqlCommand(comando, bdConn);
        //            cmd.Parameters.AddWithValue("@Usuario", Login);
        //            cmd.Parameters.AddWithValue("@Senha", Senha);
        //            retorno = Convert.ToInt32(cmd.ExecuteScalar());
        //            bdConn.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return retorno;
        //}
        //-------------------------------------------------------------------------------------
        //public Entidades.Usuario VerificaLogin2(string Login, string Senha)
        //{
        //    Entidades.Usuario UsuEnt = new Entidades.Usuario();
        //    //Definição do dataset
        //    bdDataSet = new DataSet();
        //    //Define string de conexão
        //    //bdConn = new MySqlConnection("server=www.buffalonet.com.brk;database=agile247_BD;uid=agile247_BD;pwd=webtecf1b1");
        //    bdConn = new MySqlConnection("server=mysql.brnow.com.br;database=brnow01;uid=brnow01;pwd=buffalo");
        //    //Abre conecção
        //    try
        //    {
        //        bdConn.Open();
        //        if (bdConn.State == ConnectionState.Open)
        //        {
        //            string comando = "SELECT * FROM tb_BU_Usuario WHERE Login = @Usuario AND Senha = @Senha";
        //            MySqlCommand cmd = new MySqlCommand(comando, bdConn);
        //            cmd.Parameters.AddWithValue("@Usuario", Login);
        //            cmd.Parameters.AddWithValue("@Senha", Senha);
        //            MySqlDataReader reader = cmd.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                UsuEnt.IdUsuario = Convert.ToInt32(reader.GetString("IdUsuario"));
        //                UsuEnt.Nome = reader.GetString("Nome");
        //                //datatxt.Text = reader.GetString("userId");
        //            }
        //            bdConn.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return UsuEnt;
        //}
        //-------------------------------------------------------------------------------------
        public Entidades.Usuario UsuarioLogin(string Login, string Senha)
        {
            try
            {
                Entidades.Usuario UsuEnt = new Entidades.Usuario();

                string banco = "server=mysql.brnow.com.br;database=brnow;uid=brnow;pwd=e7p5a7";
                conexao = new MySqlConnection(banco);

                //string banco = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=buffalobr.mysql.uhserver.com; DATABASE=buffalobr; UID=buffalobr;PASSWORD=gab97081@@--; OPTION=3";
                //string banco = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=server=mysql.brnow.com.br; DATABASE=brnow; UID=brnow;PASSWORD=e7p5a7; OPTION=3";
                //OdbcConnection conexao = new OdbcConnection(banco);
                //OdbcCommand cmd = new OdbcCommand(comando, conexao);
                //OdbcDataReader reader = cmd.ExecuteReader();

                conexao.Open();

                string comando = "SELECT * FROM tb_Usuario WHERE Login = '" + Login + "' AND Senha = '" + Senha + "' AND Ativo = 1";
                MySqlCommand cmd = new MySqlCommand(comando, conexao);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    UsuEnt.IdUsuario = reader.GetInt32(0);
                    UsuEnt.Nome = reader.GetString(1);
                }

                conexao.Close();
                return UsuEnt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Entidades.UsuarioCollection CarregaProdutos()
        {
            try
            {
                Entidades.Usuario Ent = new Entidades.Usuario();
                Entidades.UsuarioCollection EntCol = new Entidades.UsuarioCollection();

                string banco = "server=mysql.brnow.com.br;database=brnow;uid=brnow;pwd=e7p5a7";
                conexao = new MySqlConnection(banco);

                //string banco = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=buffalobr.mysql.uhserver.com; DATABASE=buffalobr; UID=buffalobr;PASSWORD=gab97081@@--; OPTION=3";
                //OdbcConnection conexao = new OdbcConnection(banco);

                conexao.Open();

                string comando = @"SELECT
	                                TBP.IdUsuario,
	                                TBP.Nome,
	                                TBP.Email,
	                                TBP.Login,
	                                TBP.Ativo,
	                                TBP.DataCadastro,
                                FROM
	                                `tb_Usuario` 
                                WHERE
	                                TBP.Ativo = 1 ORDER BY IdUsuario DESC;";

                //OdbcCommand cmd = new OdbcCommand(comando, conexao);
                //OdbcDataReader reader = cmd.ExecuteReader();

                MySqlCommand cmd = new MySqlCommand(comando, conexao);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Ent = new Entidades.Usuario();
                    Ent.IdUsuario = reader.GetInt32(0);
                    Ent.IdTipoUsuario = reader.GetInt32(1);
                    Ent.Nome = reader.GetString(2);
                    Ent.Login = reader.GetString(3);
                    Ent.Email = reader.GetString(4);
                    Ent.Ativo = reader.GetBoolean(5);
                    Ent.DataCadastro = reader.GetDateTime(6);
                    //Ent.Imagem = reader.GetString(7);
                    //Ent.IdProduto = Convert.ToInt32(reader.GetString("idProduto"));
                    //Ent.CodProduto = reader.GetString("Codigo");
                    //Ent.NomeProduto = reader.GetString("NomeProduto");
                    //Ent.Descricao = reader.GetString("Descricao");
                    //Ent.Especificacoes = reader.GetString("Especificacoes");
                    //Ent.IdCategoria = Convert.ToInt32(reader.GetString("Categoria"));
                    //Ent.NomeCategoria = reader.GetString("NomeCategoria");
                    //Ent.Imagem = reader.GetString("Imagem");

                    EntCol.Add(Ent);
                }
                conexao.Close();
                return EntCol;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


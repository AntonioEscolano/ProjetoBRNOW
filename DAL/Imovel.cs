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
    public class Imovel
    {
        private MySqlConnection conexao;

        public void InserirImovel(Entidades.Imovel Ent)
        {
            try
            {
                string banco = "server=mysql.brnow.com.br;database=brnow;uid=brnow;pwd=e7p5a7";
                conexao = new MySqlConnection(banco);
                conexao.Open();
                string comando = "INSERT INTO TB_Imovel (Nome_Imovel,Numero,Preco,Ativo,Categoria,SubCategoria)VALUES(@Nome_Imovel,@Numero,@Preco,@Ativo,@Categoria,@SubCategoria)";
                MySqlCommand cmd = new MySqlCommand(comando, conexao);
                cmd.Parameters.AddWithValue("@Nome_Imovel", Ent.Nome_Imovel);
                cmd.Parameters.AddWithValue("@Numero", Ent.Numero);
                cmd.Parameters.AddWithValue("@Preco", Ent.Preco);
                cmd.Parameters.AddWithValue("@Ativo", Ent.Ativo);
                cmd.Parameters.AddWithValue("@Categoria", Ent.Categoria);
                cmd.Parameters.AddWithValue("@SubCategoria", Ent.SubCategoria);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (global::System.Exception ex)
            {
                throw ex;
            }
        }
        // --------------------------------------------------------------------------------------------
        public Entidades.ImovelColletion CarregaCategorias()
        {
            try
            {
                Entidades.Imovel Ent = new Entidades.Imovel();
                Entidades.ImovelColletion EntCol = new Entidades.ImovelColletion();

                string banco = "server=mysql.brnow.com.br;database=brnow;uid=brnow;pwd=e7p5a7";
                conexao = new MySqlConnection(banco);

                conexao.Open();

                string comando = "SELECT * FROM tb_Categoria WHERE Ativo = 1";
                MySqlCommand cmd = new MySqlCommand(comando, conexao);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Ent = new Entidades.Imovel();

                    Ent.IdTipoImovel = reader.GetInt32(0);
                    Ent.TipoImovel = reader.GetString(1);

                    EntCol.Add(Ent);
                }

                conexao.Close();
                return EntCol;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// --------------------------------------------------------------------------------------------
        public Entidades.ImovelColletion CarregaSubCategorias()
        {
            try
            {
                Entidades.Imovel Ent = new Entidades.Imovel();
                Entidades.ImovelColletion EntCol = new Entidades.ImovelColletion();

                string banco = "server=mysql.brnow.com.br;database=brnow;uid=brnow;pwd=e7p5a7";
                conexao = new MySqlConnection(banco);
                conexao.Open();

                string comando = "SELECT * FROM tb_SubCategoria WHERE Ativo = 1";
                MySqlCommand cmd = new MySqlCommand(comando, conexao);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Ent = new Entidades.Imovel();

                    Ent.Id_SubCategoria = reader.GetInt32(0);
                    Ent.Nome = reader.GetString(1);

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
        // --------------------------------------------------------------------------------------------
        public Entidades.ImovelColletion CarregaImovel()
        {
            try
            {
                Entidades.Imovel Ent = new Entidades.Imovel();
                Entidades.ImovelColletion EntCol = new Entidades.ImovelColletion();
                string banco = "server=mysql.brnow.com.br;database=brnow;uid=brnow;pwd=e7p5a7";
                conexao = new MySqlConnection(banco);
                //string banco = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=buffalobr.mysql.uhserver.com; DATABASE=buffalobr; UID=buffalobr;PASSWORD=gab97081@@--; OPTION=3";
                //OdbcConnection conexao = new OdbcConnection(banco);
                conexao.Open();
                string comando = @"SELECT
	                                TBP.ID_Imovel,
	                                TBP.Nome_Imovel,
	                                TBP.Numero,
	                                TBP.Preco,
	                                TBP.Categoria,
	                                TBP.SubCategoria,
	                                TBC.tipoImovel
                                FROM
	                                `TB_Imovel` TBP INNER JOIN tb_Categoria TBC ON TBP.Categoria = TBC.idTipoImovel
                                WHERE
	                                TBP.Ativo = 1 ORDER BY ID_Imovel DESC;";
                MySqlCommand cmd = new MySqlCommand(comando, conexao);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Ent = new Entidades.Imovel();
                    Ent.ID_Imovel = reader.GetInt32(0);
                    Ent.Nome_Imovel = reader.GetString(1);
                    Ent.Numero = reader.GetInt32(2);
                    Ent.Preco = reader.GetDouble(3);
                    Ent.Categoria = reader.GetInt32(4);
                    Ent.SubCategoria = reader.GetInt32(5);
                    Ent.TipoImovel = reader.GetString(6);
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
        }// --------------------------------------------------------------------------------------------
        public void RemoveImovel(Int32 Imovel)
        {
            ////Definição do dataset
            //bdDataSet = new DataSet();
            ////Define string de conexão
            //bdConn = new MySqlConnection("server=buffalobr.mysql.uhserver.com;database=buffalobr;uid=buffalobr;pwd=gab97081@@--");
            string banco = "server=mysql.brnow.com.br;database=brnow01;uid=brnow01;pwd=buffalo";
            //string banco = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=buffalobr.mysql.uhserver.com; DATABASE=buffalobr; UID=buffalobr;PASSWORD=gab97081@@--; OPTION=3";
            OdbcConnection conexao = new OdbcConnection(banco);
            //Abre conecção
            try
            {
                conexao.Open();
                string comando = "UPDATE TB_Imovel SET Ativo = 0 WHERE ID_Imovel = " + Imovel + " AND Ativo = 1;";
                OdbcCommand cmd = new OdbcCommand(comando, conexao);
                //cmd.Parameters.AddWithValue("@Produto", Produto);
                //MySqlCommand cmd = new MySqlCommand(comando, bdConn);
                //MySqlDataReader reader = cmd.ExecuteReader();
                //cmd.ExecuteNonQuery();
                OdbcDataReader reader = cmd.ExecuteReader();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// --------------------------------------------------------------------------------------------
        public void AlteraImovel(Int32 Imovel, Entidades.Imovel Ent)
        {
            string banco = "server=mysql.brnow.com.br;database=brnow01;uid=brnow01;pwd=buffalo";
            OdbcConnection conexao = new OdbcConnection(banco);
            try
            {
                conexao.Open();
                string comando = "UPDATE TB_Imovel SET Nome_Imovel = '" + Ent.Nome_Imovel + "', Numero = " + Ent.Numero + "', Preco = " + Ent.Preco + "', Categoria = " + Ent.Categoria + "', SubCategoria = " + Ent.SubCategoria + " WHERE ID_Imovel = " + Imovel + "";
                OdbcCommand cmd = new OdbcCommand(comando, conexao);
                cmd.ExecuteReader();
                conexao.Close();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }// --------------------------------------------------------------------------------------------
        public Entidades.Imovel CarregaImovelGetSelected(Int32 imovel)
        {
            try
            {
                Entidades.Imovel Ent = new Entidades.Imovel();
                string banco = "server=mysql.brnow.com.br,database=brnow;uid=brnow;pwd=e7p5a7";
                conexao = new MySqlConnection(banco);
                conexao.Open();
                string comando = @"SELECT * FROM TB_Imovel WHERE ID_Imovel = '" + imovel + "' AND Ativo = 1;";
                MySqlCommand cmd = new MySqlCommand(comando, conexao);
                cmd.Parameters.AddWithValue("@imovel", imovel);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ent = new Entidades.Imovel();
                    Ent.ID_Imovel = reader.GetInt32(0);
                    Ent.Nome_Imovel = reader.GetString(1);
                    Ent.Numero = reader.GetInt32(2);
                    Ent.Preco = reader.GetDouble(3);
                    Ent.Categoria = reader.GetInt32(4);
                    Ent.SubCategoria = reader.GetInt32(5);
                }
                conexao.Close();
                return Ent;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}

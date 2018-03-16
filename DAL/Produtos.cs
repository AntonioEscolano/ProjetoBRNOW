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
    public class Produtos
    {
        //private MySqlConnection bdConn; //MySQL
        //private MySqlDataAdapter bdAdapter;
        //private DataSet bdDataSet; //MySQL
        private MySqlConnection conexao;

        public void InseriProduto(Entidades.Produtos Ent)
        {
            //Definição do dataset
            //bdDataSet = new DataSet();
            //Define string de conexão
            //bdConn = new MySqlConnection("server=buffalobr.mysql.uhserver.com;database=buffalobr;uid=buffalobr;pwd=gab97081@@--");
            //Abre conexão

            try
            {
                //string comando = "INSERT INTO tb_BU_Produto (Codigo,NomeProduto,Descricao,Especificacoes,Categoria,Ativo,Imagem)VALUES	(@Codigo,@Nome,@Descricao,@Especificacoes,@Categoria,@Ativo,@Imagem)";
                //MySqlCommand cmd = new MySqlCommand(comando, bdConn);

                string banco = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=buffalobr.mysql.uhserver.com; DATABASE=buffalobr; UID=buffalobr;PASSWORD=gab97081@@--; OPTION=3";
                OdbcConnection conexao = new OdbcConnection(banco);

                //bdConn.Open();
                conexao.Open();

                //if (bdConn.State == ConnectionState.Open)

                string comando = "INSERT INTO tb_BU_Produto (Codigo,NomeProduto,Descricao,Especificacoes,Categoria,Ativo,Imagem)VALUES	('" + Ent.CodProduto + "','" + Ent.NomeProduto + "','" + Ent.Descricao + "','" + Ent.Especificacoes + "','" + Ent.Categoria + "',1,'" + Ent.Imagem + "')";
                OdbcCommand cmd = new OdbcCommand(comando, conexao);

                //OdbcDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();

                //cmd.Parameters.AddWithValue("@Codigo", Ent.CodProduto);
                //cmd.Parameters.AddWithValue("@Nome", Ent.NomeProduto);
                //cmd.Parameters.AddWithValue("@Descricao", Ent.Descricao);
                //cmd.Parameters.AddWithValue("@Especificacoes", Ent.Especificacoes);
                //cmd.Parameters.AddWithValue("@Categoria", Ent.Categoria);
                //cmd.Parameters.AddWithValue("@Ativo", 1);
                //cmd.Parameters.AddWithValue("@Imagem", Ent.Imagem);
                //MySqlDataReader reader = cmd.ExecuteReader();
                //bdConn.Close();

                conexao.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InseriProdutoHome(Entidades.Produtos Ent)
        {
            try
            {
                //string banco = "server=mysql.brnow.com.br;database=brnow01;uid=brnow01;pwd=buffalo";
                string banco = "server=buffalobr.mysql.uhserver.com;database=buffalobr;uid=buffalobr;pwd=gab97081@@--";
                conexao = new MySqlConnection(banco);
                conexao.Open();

                string comando = "INSERT INTO tb_BU_Produto (Codigo,NomeProduto,Descricao,Especificacoes,Categoria,Ativo,Imagem)VALUES(@Codigo,@Nome,@Descricao,@Especificacoes,@Categoria,@Ativo,@Imagem)";

                MySqlCommand cmd = new MySqlCommand(comando, conexao);

                cmd.Parameters.AddWithValue("@Codigo", Ent.CodProduto);
                cmd.Parameters.AddWithValue("@Nome", Ent.NomeProduto);
                cmd.Parameters.AddWithValue("@Descricao", Ent.Descricao);
                cmd.Parameters.AddWithValue("@Especificacoes", Ent.Especificacoes);
                cmd.Parameters.AddWithValue("@Categoria", Ent.Categoria);
                cmd.Parameters.AddWithValue("@Ativo", 1);
                cmd.Parameters.AddWithValue("@Imagem", Ent.Imagem);

                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // --------------------------------------------------------------------------------------------
        public Entidades.ProdutosCollection CarregaCategorias()
        {
            try
            {
                Entidades.Produtos Ent = new Entidades.Produtos();
                Entidades.ProdutosCollection EntCol = new Entidades.ProdutosCollection();

                //string banco = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=buffalobr.mysql.uhserver.com; DATABASE=buffalobr; UID=buffalobr;PASSWORD=gab97081@@--; OPTION=3";
                //OdbcConnection conexao = new OdbcConnection(banco);

                string banco = "server=mysql.brnow.com.br;database=brnow;uid=brnow;pwd=e7p5a7";
                conexao = new MySqlConnection(banco);

                conexao.Open();

                string comando = "SELECT * FROM tb_BU_Categoria WHERE Ativo = 1";
                MySqlCommand cmd = new MySqlCommand(comando, conexao);
                MySqlDataReader reader = cmd.ExecuteReader();

                //OdbcCommand cmd = new OdbcCommand(comando, conexao);
                //OdbcDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Ent = new Entidades.Produtos();

                    //Ent.IdCategoria = Convert.ToInt32(reader.GetString("idCategoria"));
                    //Ent.NomeCategoria = reader.GetString("NomeCategoria");

                    Ent.IdCategoria = reader.GetInt32(0);
                    Ent.NomeCategoria = reader.GetString(1);

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
        public Entidades.ProdutosCollection CarregaProdutos()
        {
            try
            {
                Entidades.Produtos Ent = new Entidades.Produtos();
                Entidades.ProdutosCollection EntCol = new Entidades.ProdutosCollection();

                string banco = "server=mysql.brnow.com.br;database=brnow;uid=brnow;pwd=e7p5a7";
                conexao = new MySqlConnection(banco);

                //string banco = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=buffalobr.mysql.uhserver.com; DATABASE=buffalobr; UID=buffalobr;PASSWORD=gab97081@@--; OPTION=3";
                //OdbcConnection conexao = new OdbcConnection(banco);

                conexao.Open();

                string comando = @"SELECT
	                                TBP.idProduto,
	                                TBP.Codigo,
	                                TBP.NomeProduto,
	                                TBP.Descricao,
	                                TBP.Especificacoes,
	                                TBP.Categoria,
	                                TBC.NomeCategoria,
	                                TBP.Imagem
                                FROM
	                                `tb_BU_Produto` TBP INNER JOIN tb_BU_Categoria TBC ON TBP.Categoria = TBC.idCategoria
                                WHERE
	                                TBP.Ativo = 1 ORDER BY idProduto DESC;";

                //OdbcCommand cmd = new OdbcCommand(comando, conexao);
                //OdbcDataReader reader = cmd.ExecuteReader();

                MySqlCommand cmd = new MySqlCommand(comando, conexao);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Ent = new Entidades.Produtos();
                    Ent.IdProduto = reader.GetInt32(0);
                    Ent.CodProduto = reader.GetString(1);
                    Ent.NomeProduto = reader.GetString(2);
                    Ent.Descricao = reader.GetString(3);
                    Ent.Especificacoes = reader.GetString(4);
                    Ent.IdCategoria = reader.GetInt32(5);
                    Ent.NomeCategoria = reader.GetString(6);
                    Ent.Imagem = reader.GetString(7);
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
        // --------------------------------------------------------------------------------------------
        public void RemoveProduto(Int32 Produto)
        {

            ////Definição do dataset
            //bdDataSet = new DataSet();
            ////Define string de conexão
            //bdConn = new MySqlConnection("server=buffalobr.mysql.uhserver.com;database=buffalobr;uid=buffalobr;pwd=gab97081@@--");


            //string banco = "server=mysql.brnow.com.br;database=brnow01;uid=brnow01;pwd=buffalo";
            string banco = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=buffalobr.mysql.uhserver.com; DATABASE=buffalobr; UID=buffalobr;PASSWORD=gab97081@@--; OPTION=3";
            OdbcConnection conexao = new OdbcConnection(banco);


            //Abre conecção
            try
            {
                conexao.Open();


                string comando = "UPDATE tb_BU_Produto SET Ativo = 0 WHERE idProduto = " + Produto + " AND Ativo = 1;";
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




        }
        // --------------------------------------------------------------------------------------------
        public void InseriImagem(Entidades.Produtos Ent)
        {
            ////Definição do dataset
            //bdDataSet = new DataSet();
            ////Define string de conexão
            //bdConn = new MySqlConnection("server=buffalobr.mysql.uhserver.com;database=buffalobr;uid=buffalobr;pwd=gab97081@@--");
            string banco = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=buffalobr.mysql.uhserver.com; DATABASE=buffalobr; UID=buffalobr;PASSWORD=gab97081@@--; OPTION=3";
            OdbcConnection conexao = new OdbcConnection(banco);
            //Abre conecção
            try
            {
                conexao.Open();
                string comando = "INSERT INTO tb_BU_Imagens (Imagem , IdProduto, Ativo) VALUES ('" + Ent.Imagem + "', " + Ent.IdProduto + ", 1) ";
                OdbcCommand cmd = new OdbcCommand(comando, conexao);
                //MySqlCommand cmd = new MySqlCommand(comando, bdConn);

                cmd.Parameters.AddWithValue("@IdProduto", Ent.IdProduto);
                cmd.Parameters.AddWithValue("@Imagem", Ent.Imagem);
                cmd.Parameters.AddWithValue("@Ativo", 1);

                //MySqlDataReader reader = cmd.ExecuteReader();
                //cmd.ExecuteNonQuery();
                OdbcDataReader reader = cmd.ExecuteReader();
                
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // --------------------------------------------------------------------------------------------
        public Entidades.Produtos CarregaProdutoGetSelected(Int32 produto)
        {
            try
            {
                Entidades.Produtos Ent = new Entidades.Produtos();

                string banco = "server=mysql.brnow.com.br;database=brnow;uid=brnow;pwd=e7p5a7";
                conexao = new MySqlConnection(banco);

                //string banco = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=buffalobr.mysql.uhserver.com; DATABASE=buffalobr; UID=buffalobr;PASSWORD=gab97081@@--; OPTION=3";
                //OdbcConnection conexao = new OdbcConnection(banco);

                conexao.Open();

                string comando = @"SELECT * FROM 'tb_BU_Produto' WHERE idProduto = " + produto + " AND Ativo = 1;";

                MySqlCommand cmd = new MySqlCommand(comando, conexao);
                //OdbcCommand cmd = new OdbcCommand(comando, conexao);

                cmd.Parameters.AddWithValue("@produto", produto);

                MySqlDataReader reader = cmd.ExecuteReader();
                //OdbcDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Ent = new Entidades.Produtos();

                    //Ent.IdProduto = Convert.ToInt32(reader.GetString("idProduto"));
                    //Ent.CodProduto = reader.GetString("Codigo");
                    //Ent.NomeProduto = reader.GetString("NomeProduto");
                    //Ent.Descricao = reader.GetString("Descricao");
                    //Ent.Especificacoes = reader.GetString("Especificacoes");

                    Ent.IdProduto = reader.GetInt32(0);
                    Ent.CodProduto = reader.GetString(1);
                    Ent.NomeProduto = reader.GetString(2);
                    Ent.Descricao = reader.GetString(3);
                    Ent.Especificacoes = reader.GetString(4);
                    Ent.Categoria = Convert.ToInt32(reader.GetString(6));
                    Ent.Imagem = reader.GetString(8);
                }
                conexao.Close();
                return Ent;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // --------------------------------------------------------------------------------------------
        public Entidades.ProdutosCollection CarregaFotos(Int32 produto)
        {
            try
            {
                Entidades.Produtos Ent = new Entidades.Produtos();
                Entidades.ProdutosCollection EntCol = new Entidades.ProdutosCollection();
                string banco = "server=mysql.brnow.com.br;database=brnow;uid=brnow;pwd=e7p5a7";
                conexao = new MySqlConnection(banco);

                //string banco = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=buffalobr.mysql.uhserver.com; DATABASE=buffalobr; UID=buffalobr;PASSWORD=gab97081@@--; OPTION=3";
                //OdbcConnection conexao = new OdbcConnection(banco);

                conexao.Open();
                string comando = @"SELECT * FROM `tb_BU_Imagens` WHERE IdProduto = " + produto + " AND Ativo = 1 ORDER BY idImagem;";

                //OdbcCommand cmd = new OdbcCommand(comando, conexao);

                MySqlCommand cmd = new MySqlCommand(comando, conexao);
                cmd.Parameters.AddWithValue("@produto", produto);
                MySqlDataReader reader = cmd.ExecuteReader();

                //OdbcDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Ent = new Entidades.Produtos();
                    //Ent.IdProduto = Convert.ToInt32(reader.GetString("idProduto"));
                    //Ent.Imagem = reader.GetString("Imagem");
                    Ent.idImagem = reader.GetInt32(0); ;
                    Ent.Imagem = reader.GetString(1);
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
        public void RemoveFotos(Int32 Foto)
        {
            ////Definição do dataset
            //bdDataSet = new DataSet();
            ////Define string de conexão
            //bdConn = new MySqlConnection("server=buffalobr.mysql.uhserver.com;database=buffalobr;uid=buffalobr;pwd=gab97081@@--");
            //string banco = "server=mysql.brnow.com.br;database=brnow01;uid=brnow01;pwd=buffalo";
            string banco = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=buffalobr.mysql.uhserver.com; DATABASE=buffalobr; UID=buffalobr;PASSWORD=gab97081@@--; OPTION=3";
            OdbcConnection conexao = new OdbcConnection(banco);
            //Abre conecção
            try
            {
                conexao.Open();
                string comando = "UPDATE tb_BU_Imagens SET Ativo = 0 WHERE idImagem = " + Foto + " AND Ativo = 1;";
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
        }
        // --------------------------------------------------------------------------------------------
        public void AlteraProduto(Int32 Produto, Entidades.Produtos Ent)
        {
            //Abre conexão
            try
            {
                string banco = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=buffalobr.mysql.uhserver.com; DATABASE=buffalobr; UID=buffalobr;PASSWORD=gab97081@@--; OPTION=3";
                OdbcConnection conexao = new OdbcConnection(banco);
                conexao.Open();
                string comando = "";

                if (Ent.Imagem.ToString() != "")
                {
                    comando = "UPDATE tb_BU_Produto SET Codigo = '" + Ent.CodProduto + "', NomeProduto = '" + Ent.NomeProduto + "', Descricao = '" + Ent.Descricao + "', Especificacoes = '" + Ent.Especificacoes + "', Categoria = " + Ent.Categoria + ", Imagem = '" + Ent.Imagem + "' WHERE idProduto = " + Produto + ""; 
                }
                else
                {
                    comando = "UPDATE tb_BU_Produto SET Codigo = '" + Ent.CodProduto + "', NomeProduto = '" + Ent.NomeProduto + "', Descricao = '" + Ent.Descricao + "', Especificacoes = '" + Ent.Especificacoes + "', Categoria = " + Ent.Categoria + " WHERE idProduto = " + Produto + "";
                }
                //string comando = "INSERT INTO tb_BU_Produto (Codigo,NomeProduto,Descricao,Especificacoes,Categoria,Ativo,Imagem)VALUES	('" + Ent.CodProduto + "','" + Ent.NomeProduto + "','" + Ent.Descricao + "','" + Ent.Especificacoes + "','" + Ent.Categoria + "',1,'" + Ent.Imagem + "')";
                OdbcCommand cmd = new OdbcCommand(comando, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

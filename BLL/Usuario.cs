using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;



namespace BLL
{
    public class Usuario
    {
        //public int VerificaLogin(string Login, string Senha)
        //{
        //    try
        //    {
        //        DAL.Usuario verUsua = new DAL.Usuario();
        //        return verUsua.VerificaLogin(Login, Senha);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public Entidades.Usuario VerificaLogin2(string Login, string Senha)
        //{
        //    try
        //    {
        //        DAL.Usuario verUsua = new DAL.Usuario();
        //        return verUsua.VerificaLogin2(Login, Senha);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public Entidades.Usuario UsuarioLogin(string Login, string Senha)
        {
            try
            {
                DAL.Usuario verUsua = new DAL.Usuario();
                return verUsua.UsuarioLogin(Login, Senha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // --------------------------------------------------------------------------------------------

        //public Entidades.Usuario CarregaUsuarioGetSelected(Int32 usuario)
        //{
        //    try
        //    {
        //        DAL.Usuario DAL = new DAL.Usuario();
        //        //return DAL.CarregaUsuarioGetSelected(usuario);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        // --------------------------------------------------------------------------------------------

        //public Entidades.UsuarioCollection CarregaUsuario()
        //{
        //    try
        //    {
        //        DAL.Usuario DAL = new DAL.Usuario();
        //        //return DAL.CarregaUsuario();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}

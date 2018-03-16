using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Imovel
    {
        public void InserirImovel(Entidades.Imovel Ent)
        {
            try
            {
                DAL.Imovel DAL = new DAL.Imovel();
                DAL.InserirImovel(Ent);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }// --------------------------------------------------------------------------------------------
        public Entidades.ImovelColletion CarregaImovel()
        {
            try
            {
                DAL.Imovel DAL = new DAL.Imovel();
                return DAL.CarregaImovel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//--------------------------------------------------------------------------------------------
        public Entidades.ImovelColletion CarregaCategorias()
        {
            try
            {
                DAL.Imovel DAL = new DAL.Imovel();
                return DAL.CarregaCategorias();
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
                DAL.Imovel DAL = new DAL.Imovel();
                return DAL.CarregaSubCategorias();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// --------------------------------------------------------------------------------------------
        public void RemoveImovel(Int32 Imovel)
        {
            try
            {
                DAL.Imovel DAL = new DAL.Imovel();
                DAL.RemoveImovel(Imovel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// --------------------------------------------------------------------------------------------

        public Entidades.Imovel CarregaImovelGetSelected(Int32 imovel)
        {
            try
            {
                DAL.Imovel DAL = new DAL.Imovel();
                return DAL.CarregaImovelGetSelected(imovel);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }// --------------------------------------------------------------------------------------------

        public void AlteraImovel(Int32 Imovel, Entidades.Imovel Ent)
        {
            try
            {
                DAL.Imovel DAL = new DAL.Imovel();
                DAL.AlteraImovel(Imovel, Ent);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}

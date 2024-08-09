using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_BLL;

namespace FACADE
{
    public class PreferenciasFD
    {
        PreferenciasDAO objPreferenciasDAO;

        public List<String> impBdConect()
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.impbdConect();
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public List<String> impBdDesconect()
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.impbdDesconect();
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public DataTable consultarBd(string strDescricao)
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.consultarBd(strDescricao);
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public bool inserirBd(string strParPreferencias)
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.inserirBd(strParPreferencias);
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public bool excluirBd(string strParDelPreferencias)
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.exluirBd(strParDelPreferencias);
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public bool alterarBd(string strParValorNovo, string strParValorAntigo)
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.alterarbd(strParValorNovo, strParValorAntigo);
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

    }
}

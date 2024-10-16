using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_BLL;
using Model_VO;


namespace FACADE_BLL
{
    public class PreferenciasFD
    {
        PreferenciasDAO objPreferenciasDAO;

        public List<String> impBdConect()
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.impBdConect();
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public List<String> impBdDescon()
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.impBdDesconect();
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public DataTable consultarBd(PreferenciasVO objParPreferenciasVO)
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.consultarBd(objParPreferenciasVO);
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public bool inserirBd(PreferenciasVO objParPreferenciasVO)
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.inserirBd(objParPreferenciasVO);
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public bool excluirBd(PreferenciasVO objParPreferenciasVO)
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.exluirBd(objParPreferenciasVO);
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public bool alterarBd(PreferenciasVO objParPreferenciasVO)
        {
            try
            {
                objPreferenciasDAO = new PreferenciasDAO();
                return objPreferenciasDAO.alterarBd(objParPreferenciasVO);
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }
    }
}

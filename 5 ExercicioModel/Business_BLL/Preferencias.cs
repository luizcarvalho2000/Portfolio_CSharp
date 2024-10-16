using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FACADE_BLL;
using Model_VO;

namespace Business_BLL
{
    public class Preferencias
    {
        StreamReader objLeitor;
        string strLinhaDoArquivo;

        PreferenciasFD objPreferenciasFD;

        public List<String> impTxtWhile()
        {
            try
            {
                List<String> lista = new List<String>();
                objLeitor = new StreamReader("C:\\Curso programar\\C#\\Preferencias\\importar texto.txt");
                strLinhaDoArquivo = objLeitor.ReadLine();

                while (strLinhaDoArquivo != null)
                {
                    lista.Add(strLinhaDoArquivo);
                    strLinhaDoArquivo = objLeitor.ReadLine();
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
            finally
            {
                objLeitor.Close();
            }
        }

        public List<String> impBdConect()
        {
            try
            {
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.impBdConect();
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }           
        }

        public List<String> ImpBdDesconect()
        {
            try
            {
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.impBdDescon();
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
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.consultarBd(objParPreferenciasVO);
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
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.inserirBd(objParPreferenciasVO);
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
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.excluirBd(objParPreferenciasVO);
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
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.alterarBd(objParPreferenciasVO);
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

    }
}

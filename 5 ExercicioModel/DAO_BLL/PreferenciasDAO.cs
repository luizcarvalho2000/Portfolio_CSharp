using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_VO;

namespace DAO_BLL
{
    public class PreferenciasDAO : DB_DAO
    {
        OleDbConnection objConexao;
        OleDbCommand objComando;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objLeitorBd;
        DataTable objTabela;

        PreferenciasVO objPreferenciasVO;

        bool resposta = false;

        public List<String> impBdConect()
        {
            try
            {
                AbrirConexao();
                List<String> lista = new List<string>();
                StringBuilder strSQL =  new StringBuilder();
                strSQL.Append("SELECT");
                strSQL.Append(" ID");
                strSQL.Append(", Descricao");
                strSQL.Append(" FROM");
                strSQL.Append(" Preferencias_3");

                objComando = new OleDbCommand(strSQL.ToString(), GetConnection());
                objLeitorBd = objComando.ExecuteReader();

                while (objLeitorBd.Read())
                {
                    lista.Add(objLeitorBd["Descricao"].ToString());
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<String> impBdDesconect()
        {
            try
            {
                AbrirConexao();
                List<String> lista = new List<string>();
                StringBuilder strSQL = new StringBuilder();
                strSQL.Append("SELECT");
                strSQL.Append(" ID");
                strSQL.Append(", Descricao");
                strSQL.Append(" FROM");
                strSQL.Append(" Preferencias_3");

                objComando = new OleDbCommand(strSQL.ToString(), GetConnection());
                objAdaptador = new OleDbDataAdapter(objComando);
                objTabela = new DataTable();
                objAdaptador.Fill(objTabela);

                foreach (DataRow objLinhaLida in objTabela.Rows)
                {
                    lista.Add(objLinhaLida["Descricao"].ToString());
                }
                return lista;

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
                AbrirConexao();
                StringBuilder strSQL = new StringBuilder();
                strSQL.Append("SELECT");
                strSQL.Append(" ID");
                strSQL.Append(",Descricao");
                strSQL.Append(" FROM");
                strSQL.Append(" Preferencias_3");


                if (!string.IsNullOrEmpty(objParPreferenciasVO.getDescricao()))
                {
                    strSQL.Append(" WHERE");
                    strSQL.Append(" Descricao = :strParDescricao");
                    objComando = new OleDbCommand(strSQL.ToString(), GetConnection());
                    objComando.Parameters.AddWithValue("strParDescricao", objParPreferenciasVO.getDescricao());

                }
                else
                {
                    objComando = new OleDbCommand(strSQL.ToString(), GetConnection());
                }

                objAdaptador = new OleDbDataAdapter(objComando);
                objTabela = new DataTable();
                objAdaptador.Fill(objTabela);

                return objTabela;
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
                AbrirConexao();
                StringBuilder strSQL = new StringBuilder();
                strSQL.Append("INSERT INTO");
                strSQL.Append(" Preferencias_3 (");
                strSQL.Append(" Descricao");
                strSQL.Append(" ) VALUES (");
                strSQL.Append(" :strParPreferencias");
                strSQL.Append(" )");

                objComando = new OleDbCommand(strSQL.ToString(), GetConnection());
                objComando.Parameters.AddWithValue("strParPreferencias", objParPreferenciasVO.getDescricao());

                if (objComando.ExecuteNonQuery() > 0)
                {
                    resposta = true;
                }
                else
                {
                    resposta = false;
                }

                return resposta;
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
            finally
            {
                FecharConexao();
            }
        }

        public bool exluirBd(PreferenciasVO objParPreferenciasVO)
        {
            try
            {
                AbrirConexao();
                StringBuilder strSQL = new StringBuilder();
                strSQL.Append("DELETE FROM");
                strSQL.Append(" Preferencias_3");
                strSQL.Append(" WHERE");
                strSQL.Append(" ID = (");
                strSQL.Append(" :intParDelPreferencias");
                strSQL.Append(" )");

                objComando = new OleDbCommand(strSQL.ToString(), GetConnection());
                objComando.Parameters.AddWithValue("intParDelPreferencias", objParPreferenciasVO.getId());

                if (objComando.ExecuteNonQuery() > 0)
                {
                    resposta = true;
                }
                else
                {
                    resposta = false;
                }

                return resposta;
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
            finally
            {
                FecharConexao();
            }
        }

        public bool alterarBd(PreferenciasVO objParPreferenciasVO)
        {
            try
            {
                AbrirConexao();
                StringBuilder strSQL = new StringBuilder();
                strSQL.Append("UPDATE");
                strSQL.Append("  Preferencias_3 SET");
                strSQL.Append(" Descricao =");
                strSQL.Append(" :strParValorNovo");
                strSQL.Append(" WHERE");
                strSQL.Append(" ID =");
                strSQL.Append(" :intId");

                objComando = new OleDbCommand(strSQL.ToString(), GetConnection());
                objComando.Parameters.AddWithValue("strParValorNovo", objParPreferenciasVO.getDescricao());
                objComando.Parameters.AddWithValue("intId", objParPreferenciasVO.getId());

                if (objComando.ExecuteNonQuery() > 0)
                {
                    resposta = true;
                }
                else
                {
                    resposta = false;
                }

                return resposta;
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
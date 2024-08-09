
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO_BLL
{
    public class PreferenciasDAO
    {
        OleDbConnection objConexao;
        OleDbCommand objComando;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objLeitorBd;
        DataTable objTabela;

        bool resposta = false;


        public List<String> impbdConect()
        {
            try
            {

                List<String> lista = new List<string>();
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");
                objConexao.Open();

                StringBuilder strSQL = new StringBuilder();
                strSQL.Append("SELECT");
                strSQL.Append(" ID");
                strSQL.Append(",Descricao");
                strSQL.Append(" FROM");
                strSQL.Append(" Preferencias_3");                

                objComando = new OleDbCommand(strSQL.ToString(), objConexao);
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
                objConexao.Close();
            }
        }

        public List<String> impbdDesconect()
        {
            try
            {
                List<String> lista = new List<string>();
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");

                StringBuilder strSQL = new StringBuilder();
                strSQL.Append("SELECT");
                strSQL.Append(" ID");
                strSQL.Append(",Descricao");
                strSQL.Append(" FROM");
                strSQL.Append(" Preferencias_3");

                objComando = new OleDbCommand(strSQL.ToString(), objConexao);
                objAdaptador = new OleDbDataAdapter(objComando);
                objTabela = new DataTable();
                objAdaptador.Fill(objTabela);

                foreach (DataRow objLinhaRow in objTabela.Rows)
                {
                    lista.Add(objLinhaRow["Descricao"].ToString());
                }

                return lista;
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
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");

                StringBuilder strSQL = new StringBuilder();
                strSQL.Append("SELECT");
                strSQL.Append(" ID");
                strSQL.Append(",Descricao");
                strSQL.Append(" FROM");
                strSQL.Append(" Preferencias_3");
               

                if (!string.IsNullOrEmpty(strDescricao))
                {
                    strSQL.Append(" WHERE");
                    strSQL.Append(" Descricao = :strParDescricao");
                    objComando = new OleDbCommand(strSQL.ToString(), objConexao);
                    objComando.Parameters.AddWithValue("strParDescricao", strDescricao);

                }
                else
                {
                    objComando = new OleDbCommand(strSQL.ToString(), objConexao);
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

        public bool inserirBd(string strParPreferencias)
        {
            try
            {
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");
                objConexao.Open();

                StringBuilder strSQL = new StringBuilder();
                strSQL.Append("INSERT INTO");
                strSQL.Append(" Preferencias_3 (");
                strSQL.Append(" Descricao");
                strSQL.Append(" ) VALUES (");
                strSQL.Append(" :strParPreferencias");
                strSQL.Append(" )");
                
                objComando = new OleDbCommand(strSQL.ToString(), objConexao);
                objComando.Parameters.AddWithValue("strParPreferencias", strParPreferencias);

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
                objConexao.Close();
            }
        }

        public bool exluirBd(string strParDelPreferencias)
        {
            try
            {
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");
                objConexao.Open();

                StringBuilder strSQL = new StringBuilder();
                strSQL.Append("DELETE FROM");
                strSQL.Append(" Preferencias_3");
                strSQL.Append(" WHERE");
                strSQL.Append(" Descricao = (");
                strSQL.Append(" :strParDelPreferencias");
                strSQL.Append(" )");

                objComando = new OleDbCommand(strSQL.ToString(), objConexao);
                objComando.Parameters.AddWithValue("strParDelPreferencias", strParDelPreferencias);

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
                objConexao.Close();
            }
        }

        public bool alterarbd(string strParValorNovo, string strParValorAntigo)
        {
            try
            {
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");
                objConexao.Open();

                StringBuilder strSQL = new StringBuilder();
                strSQL.Append("UPDATE");
                strSQL.Append("  Preferencias_3 SET");
                strSQL.Append(" Descricao =");
                strSQL.Append(" :strParValorNovo");
                strSQL.Append(" WHERE");
                strSQL.Append(" Descricao =");
                strSQL.Append(" :strParValorAntigo");

                objComando = new OleDbCommand(strSQL.ToString(), objConexao);
                objComando.Parameters.AddWithValue("strParValorNovo", strParValorNovo);
                objComando.Parameters.AddWithValue("strParValorAntigo", strParValorAntigo);

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
                objConexao.Close();
            }
        }
    }
}

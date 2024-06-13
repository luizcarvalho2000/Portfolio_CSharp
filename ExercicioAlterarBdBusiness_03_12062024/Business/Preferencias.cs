using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Preferencias
    {
        StreamReader objLeitor;
        string strLinhaDoArquivo;

        OleDbConnection objConexao;
        OleDbCommand objComando;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objLeitorBd;
        DataTable objTabela;

        bool resposta = false;

        public List<String> impTxtWhile()
        {
            try
            {
                List<String> lista = new List<string>();
                objLeitor = new StreamReader(@"C:\Curso programar\C#\Preferencias\importar texto.txt");
                strLinhaDoArquivo = objLeitor.ReadLine();

                while (strLinhaDoArquivo != null)
                {
                    lista.Add(strLinhaDoArquivo);
                    strLinhaDoArquivo = objLeitor.ReadLine();
                }
                objLeitor.Close();
                return lista;
            }
            catch (Exception ex)
            {                
                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public List<String> impbdConect()
        {
            try
            {
                List<String> lista = new List<string>();
                objConexao = 
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");
                objConexao.Open();

                objComando = new OleDbCommand("SELECT ID, Descricao FROM Preferencias_3 ORDER BY ID", objConexao);
                objLeitorBd = objComando.ExecuteReader();

                while (objLeitorBd.Read())
                {
                    lista.Add(objLeitorBd["Descricao"].ToString());
                }
                objLeitorBd.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public List<String> impbdDesconect()
        {
            try
            {
                List<String> lista = new List<string>();
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");
                

                objComando = new OleDbCommand("SELECT ID, Descricao FROM Preferencias_3 ORDER BY ID", objConexao);
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

        public DataTable consultarBd(string strDescricao = null)
        {
            try
            {
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");
                if (!string.IsNullOrEmpty(strDescricao))
                {
                    objComando = new OleDbCommand("SELECT ID, Descricao FROM Preferencias_3 WHERE Descricao = '" + strDescricao + "' OREDER BY ID", objConexao);
                }
                else
                {
                    objComando = new OleDbCommand("SELECT ID, Descricao FROM Preferencias_3 ORDER BY ID", objConexao);
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

                objComando = new OleDbCommand("INSERT INTO Preferencias_3 (Descricao) VALUES  ('" + strParPreferencias + "') ", objConexao);

                if (objComando.ExecuteNonQuery() > 0)
                {
                    resposta = true;
                }
                else
                {
                    resposta = false;
                }
                objConexao.Close();

                return resposta;
            }
            catch (Exception ex)
            {                
                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public bool exluirBd(string strParDelPreferencias)
        {
            try
            {
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");
                objConexao.Open();

                objComando = new OleDbCommand("DELETE FROM Preferencias_3 WHERE Descricao = ('" + strParDelPreferencias + "' )", objConexao);

                if (objComando.ExecuteNonQuery() > 0)
                {
                    resposta = true;
                }
                else
                {
                    resposta = false;
                }
                objConexao.Close();

                return resposta;
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public bool alterarbd(string strParValorNovo, string strParValorAntigo)
        {
            try
            {
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");
                objConexao.Open();

                objComando = new OleDbCommand("UPDATE Preferencias_3 SET Descricao = '" + strParValorNovo + "' WHERE Descricao = '" + strParValorAntigo + "' ", objConexao);

                if (objComando.ExecuteNonQuery() > 0)
                {
                    resposta = true;
                }
                else
                {
                    resposta = false;
                }
                objConexao.Close();

                return resposta;
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }
    }
}

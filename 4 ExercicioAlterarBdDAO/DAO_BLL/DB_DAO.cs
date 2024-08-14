using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.OleDb;

namespace DAO_BLL
{
    public class DB_DAO
    {
        private static OleDbConnection objConexao;
        public static OleDbConnection GetConnection()
        {
            if (objConexao == null)
            {
                objConexao = new OleDbConnection(ConfigurationSettings.AppSettings["connectionString"].ToString());
            }
            return objConexao;
        }

        public void AbrirConexao()
        {
            if (GetConnection().State == System.Data.ConnectionState.Closed)
            {
                objConexao.Open();
            }
        }

        public void FecharConexao()
        {
            if (GetConnection().State == System.Data.ConnectionState.Open)
            {
                objConexao.Close();
                objConexao.Dispose();
                objConexao = null;
            }
        }
    }
}

using IronMountainEx1.Utils.Crypto;
using System.Configuration;

namespace IronMountainEx1.Utils.Sql
{
    public abstract class SQLConnectionHelper
    {
        private static string ironDBConn = ConfigurationManager.AppSettings["ConnectionIronMountainDB"].ToString();
        protected static string GetIronDBConnection()
        {
            System.Data.SqlClient.SqlConnectionStringBuilder csb = new System.Data.SqlClient.SqlConnectionStringBuilder(ironDBConn);
            csb.Password = Decrypt.MD5(csb.Password);
            return csb.ToString();
        }
    }
}

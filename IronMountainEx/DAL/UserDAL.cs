using IronMountainEx1.DTO;
using IronMountainEx1.Utils;
using IronMountainEx1.Utils.Crypto;
using IronMountainEx1.Utils.Sql;
using System;
using System.Data;
using System.Data.SqlClient;

namespace IronMountainEx1.DAL
{
    public class UserDAL : SQLConnectionHelper
    {
        public static UserDTO Login(string username, string password)
        {
            try
            {
                UserDTO user = null;
                string querySQL = "SELECT U.id as idUser, U.username, U.roleId FROM Users U WHERE U.username = @username AND U.password = @password";
                var reader = SqlHelper.ExecuteDataset(GetIronDBConnection(), System.Data.CommandType.Text, querySQL,
                        new SqlParameter() { ParameterName = "@username", Value = username, SqlDbType = System.Data.SqlDbType.NVarChar },
                        new SqlParameter() { ParameterName = "@password", Value = Encrypt.MD5(password), SqlDbType = System.Data.SqlDbType.NVarChar }).Tables[0];
                if (reader.Rows.Count > 0) user = new UserDTO(Convert.ToInt32(reader.Rows[0]["idUser"]), reader.Rows[0]["username"].ToString(), (Utils.Enum.Role)Convert.ToInt32(reader.Rows[0]["roleId"]));
                return user;
            }
            catch (Exception ex) { throw ex; }
        }

        public static DataTable GetUsersForAdmin()
        {
            try
            {
                string querySQL = "SELECT U.id as Id, U.username, R.role FROM Users U LEFT JOIN Roles R ON U.roleId = R.id";
                DataTable dt = SqlHelper.ExecuteDataset(GetIronDBConnection(), System.Data.CommandType.Text, querySQL).Tables[0];
                return dt;
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool UpdateUserByAdmin(UserDTO user)
        {
            try
            {
                string querySQL = "UPDATE Users SET username=@username, roleId=@roleId WHERE id = @id SELECT @@ROWCOUNT";
                int rowCount = (int)SqlHelper.ExecuteNonQuery(GetIronDBConnection(), System.Data.CommandType.Text, querySQL,
                       new SqlParameter() { ParameterName = "@username", Value = user.username, SqlDbType = System.Data.SqlDbType.NVarChar },
                       new SqlParameter() { ParameterName = "@roleId", Value = (int)user.rolUser, SqlDbType = System.Data.SqlDbType.Int },
                       new SqlParameter() { ParameterName = "@id", Value = (int)user.idUser, SqlDbType = System.Data.SqlDbType.Int });

                return rowCount == 1 ? true : false;
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool DeleteUserByAdmin(int idUser)
        {
            try
            {
                string querySQL = "DELETE FROM Users WHERE id = @id SELECT @@ROWCOUNT";
                int rowCount = (int)SqlHelper.ExecuteNonQuery(GetIronDBConnection(), System.Data.CommandType.Text, querySQL,
                       new SqlParameter() { ParameterName = "@id", Value = idUser, SqlDbType = System.Data.SqlDbType.Int });
                return rowCount == 1 ? true : false;
            }
            catch (Exception ex) { throw ex; }
        }

        public static int InsertUserByAdmin(UserDTO user)
        {
            try
            {
                string querySQL = "INSERT INTO Users(username,password,roleId) values(@username,@password,@roleId) ";
                int rowCount = (int)SqlHelper.ExecuteNonQuery(GetIronDBConnection(), System.Data.CommandType.Text, querySQL,
                      new SqlParameter() { ParameterName = "@username", Value = user.username, SqlDbType = System.Data.SqlDbType.NVarChar },
                      new SqlParameter() { ParameterName = "@password", Value = Encrypt.MD5(user.password), SqlDbType = System.Data.SqlDbType.NVarChar },
                      new SqlParameter() { ParameterName = "@roleId", Value = (int)user.rolUser, SqlDbType = System.Data.SqlDbType.Int });
                return rowCount;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}

using IronMountainEx1.DAL;
using IronMountainEx1.DTO;
using System;
using System.Data;

namespace IronMountainEx1.BLL
{
    public class UserBLL
    {
        public static UserDTO Login(string username, string password)
        {
            try
            {
                return UserDAL.Login(username, password);
            }
            catch (Exception ex) { throw ex; }
        }

        public static DataTable GetUsersForAdmin()
        {
            try
            {
                return UserDAL.GetUsersForAdmin();
            }
            catch(Exception ex) { throw ex; }
        }

        public static bool UpdateUserByAdmin(UserDTO user)
        {
            try
            {
                return UserDAL.UpdateUserByAdmin(user);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool DeleteUserByAdmin(int idUser)
        {
            try
            {
                return UserDAL.DeleteUserByAdmin(idUser);
            }
            catch (Exception ex) { throw ex; }
        }

        public static int InsertUserByAdmin(UserDTO user)
        {
            try
            {
                return UserDAL.InsertUserByAdmin(user);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}

using IronMountainEx1.BLL;
using IronMountainEx1.DTO;
using System;
using System.Data;

namespace IronMountainEx1.Controller
{
    public class AdminCRUDController
    {
        public static DataTable ReadDataAdmin()
        {
            try
            {
                return UserBLL.GetUsersForAdmin();
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool UpdateUserByAdmin(UserDTO user)
        {
            try
            {
                return UserBLL.UpdateUserByAdmin(user);
            }
            catch(Exception ex) { throw ex; }
        }

        public static bool DeleteUserByAdmin(int idUser)
        {
            try
            {
                return UserBLL.DeleteUserByAdmin(idUser);
            }
            catch (Exception ex) { throw ex; }
        }

        public static int InsertUserByAdmin(UserDTO user)
        {
            try
            {
                return UserBLL.InsertUserByAdmin(user);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}

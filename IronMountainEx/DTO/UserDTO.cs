using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMountainEx1.Utils.Enum;

namespace IronMountainEx1.DTO
{
    public class UserDTO 
    {
        public int idUser { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Utils.Enum.Role rolUser { get; set; }


        public UserDTO(int idUser, string username, Role rolUser)
        {
            this.idUser = idUser;
            this.username = username;
            this.rolUser = rolUser;
        }

        public UserDTO(int idUser, string username, string password, Role rolUser)
        {
            this.idUser = idUser;
            this.username = username;
            this.password = password;
            this.rolUser = rolUser;
        }

    }
}

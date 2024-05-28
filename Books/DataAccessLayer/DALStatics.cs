using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALStatics
    {
        public static List<UserInfo> Users = new List<UserInfo>()
        {
            new UserInfo()
            {
                Username = "jmn_admin",
                EmailAddress = "jmn.admin@tatvasoft.com",
                Password = "jmn123",
                GivenName = "Janmajey",
                Surname = "Nathvani",
                Role = "Administrator"
            },

            new UserInfo()
            {
                Username = "smit_reader",
                EmailAddress = "smit.user@tatvasoft.com",
                Password = "smit123",
                GivenName = "Smit",
                Surname = "Namha",
                Role = "BookUser"
            },
        };
    }
}

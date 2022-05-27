using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LowLevelDesign.HotelManagement
{
    public class Account
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public AccountStatus AccountStatus { get; set; }

        public bool ResetPassword()
        {

            return true;
        }
    }
}

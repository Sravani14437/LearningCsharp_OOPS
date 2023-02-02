using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialTypes
{
    partial class UserProfile
    {
        private string _username;
        public string Username
        {
            set { _username = value; }
        }
        private string _password;
        public string Password
        {
            set { _password = value; }
        }
        private int _uid;
        public int UID
        {
            set
            {
                _uid = value;
            }
        }
    }
}

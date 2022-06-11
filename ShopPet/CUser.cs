using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopPet
{
    public class CUser
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public CUser(string fullname, string email, string password)
        {
            this.name = fullname;
            this.email = email;
            this.password = password;
        }

        public CUser()
        {
        }
    }
}
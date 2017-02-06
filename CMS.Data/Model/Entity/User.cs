using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Data.Model.Entity
{
    public class User
    {
        public int Id { get; set; }

        public string LoginName { get; set; }

        public string  Password { get; set; }

        public string NickName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }


    }
}

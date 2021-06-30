using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Models
{
    partial class user
    {
        public user(string username, string pwd, string name, string email, string home_address, System.DateTime join_date)
        {
            this.username = username;
            this.pwd = pwd;
            this.name = name;
            this.email = email;
            this.home_address = home_address;
            this.join_date = join_date;
        }

        
    }
}

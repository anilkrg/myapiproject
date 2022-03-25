using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapiproject.Models
{
    public class Tbl_Users
    {

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }

    }
}

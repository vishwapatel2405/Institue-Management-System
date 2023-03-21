using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS_WebAPI.Models
{
    public class t_user
    {
        public int c_userid { get; set; }
        public string c_name { get; set; }
        public string c_email { get; set; }
        public string c_password { get; set; }
        public string  c_gender { get; set; }
        public string c_address { get; set; }
        public string c_city { get; set; }
        public int c_contact { get; set; }
        public int c_roleid { get; set; }
        public int c_courseid { get; set; }
    }
}
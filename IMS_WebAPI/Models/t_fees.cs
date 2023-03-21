using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS_WebAPI.Models
{
    public class t_fees
    {
        public int c_feesid { get; set; }
        public DateTime c_feesdate { get; set; }
        public string c_description { get; set; }
        public string c_mode { get; set; }
        public int c_amount { get; set; }
    }
}
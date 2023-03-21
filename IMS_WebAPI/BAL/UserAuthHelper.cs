using IMS_WebAPI.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS_WebAPI.BAL
{
    public class UserAuthHelper:Helper
    {
        public void Register(t_user data)
        {

            NpgsqlCommand comm = new NpgsqlCommand("INSERT INTO t_user(c_name, c_email, c_password, c_gender, c_address, c_city, c_contact, c_roleid, c_courseid) VALUES(@c_name, @c_email, @c_password, @c_gender, @c_address, @c_city, @c_contact, @c_roleid, @c_courseid)", conn);
            comm.Parameters.AddWithValue("@c_name", data.c_name);
            comm.Parameters.AddWithValue("@c_email", data.c_email);
            comm.Parameters.AddWithValue("@c_password", data.c_password);
            comm.Parameters.AddWithValue("@c_gender", data.c_gender);
            comm.Parameters.AddWithValue("@c_address", data.c_address);
            comm.Parameters.AddWithValue("@c_city", data.c_city);
            comm.Parameters.AddWithValue("@c_contact", data.c_contact);
            comm.Parameters.AddWithValue("@c_roleid", data.c_roleid);
            comm.Parameters.AddWithValue("@c_courseid", data.c_courseid);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
          
        }
        public bool Login(vm_login data)
        {
            NpgsqlCommand comm = new NpgsqlCommand("SELECT c_userid,c_name,c_email,c_password FROM t_user WHERE c_email=@c_email and c_password=@c_password", conn);
            comm.Parameters.AddWithValue("@c_email", data.c_email);
            comm.Parameters.AddWithValue("@c_password", data.c_password);
            conn.Open();
            NpgsqlDataReader datar = comm.ExecuteReader();
            if(datar.Read())
            {
                HttpContext.Current.Session["Userid"] = datar["c_userid"].ToString();
                HttpContext.Current.Session["UserName"] = datar["c_name"].ToString();
                return true;
            }
            return false;
        }
    }
}
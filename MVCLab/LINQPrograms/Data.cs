using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LINQPrograms
{
    class Data
    {
        string connectionString = "Server=DHEERAJ-PC\\SQLEXPRESS; Database=School; User Id=sa; Password=Password1;";

        public List<User> Get()
        {
            List<User> users = new List<User>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from [User]", con);
                cmd.CommandType = System.Data.CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    User user = new User();
                    user.ID = Convert.ToInt32(rdr["ID"]);
                    user.Age = Convert.ToInt32(rdr["Age"]);
                    user.Name = rdr["Name"].ToString();
                    user.City = rdr["City"].ToString();
                    users.Add(user);
                }
                con.Close();
            }
            return users;
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

using System.Collections.Generic;

namespace CloudDevelopment.Models
{
    public class userTable
    {


        //public static string con_string = "Server=tcp:clouddev-sql-server.database.windows.net,1433;Initial Catalog=CLDVDatabase;Persist Security Info=False;User ID=Byron;Password=RockeyM12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public static string con_string = "Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=test;Data Source=labVMH8OX\\SQLEXPRESS";

        public static SqlConnection con = new SqlConnection(con_string);

        public string  Name { get; set; }
        //public int ID { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        

        public int insert_User(userTable m)
        {
            //declaring string with object name "sql" where we will write the insert statements
            //string sql = @"insert into userTable([[userName], [userSurname], [userEmail]) values(" + m.Name + ", " + m.Surname + ", " + m.Email + ")";


            //SqlCommand cmd = new SqlCommand(sql, con);


            //return cmd.ExecuteNonQuery();


            //same methods below, but as you can see.. much longer to complete


            try
            {
                string sql = "INSERT INTO userTable (userName, userSurname, userEmail) VALUES (@Name, @Surname, @Email)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", m.Name);
                cmd.Parameters.AddWithValue("@Surname", m.Surname);
                cmd.Parameters.AddWithValue("@Email", m.Email);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                // For now, rethrow the exception
                throw ex;
            }
            

        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Admin
{
    internal class User9
    {
        private static string connectionString = "your_connection_string_here"; // Replace with your actual connection string

        public static bool UpdateUserName(string oldUserName, string newUserName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\alial\\source\\repos\\Ali1767\\DeepSleepResturant\\Resturant\\Database1.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "UPDATE Users SET UserName = @NewUserName WHERE UserName = @OldUserName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewUserName", newUserName);
                        cmd.Parameters.AddWithValue("@OldUserName", oldUserName);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
                return false;
            }
        }

        public static bool UpdatePassword(string oldPassword, string newPassword)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\alial\\source\\repos\\Ali1767\\DeepSleepResturant\\Resturant\\Database1.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "UPDATE Users SET Password = @NewPassword WHERE Password = @OldPassword";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        cmd.Parameters.AddWithValue("@OldPassword", oldPassword);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
                return false;
            }
        }

        public static bool UpdateEmail(string oldEmail, string newEmail)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\alial\\source\\repos\\Ali1767\\DeepSleepResturant\\Resturant\\Database1.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "UPDATE Users SET Email = @NewEmail WHERE Email = @OldEmail";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewEmail", newEmail);
                        cmd.Parameters.AddWithValue("@OldEmail", oldEmail);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
                return false;
            }
        }
    }
}

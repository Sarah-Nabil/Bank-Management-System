
using Bank_Utilities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BankDataLayer
{
    public class clsUserData
    {
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con =
                new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd =
                new SqlCommand("SELECT * FROM VW_UsersWithRoles", con))
            {
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }

        public static bool GetUserByID(
            int UserID,
            ref string UserName,
            ref string Password,
            ref string FullName,
            ref string Email,
            ref string Phone,
            ref int RoleID,
            ref int Permissions,
            ref bool IsActive)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("SP_GetUserByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            return false;

                        UserName = reader["UserName"].ToString();
                        Password = reader["Password"].ToString();
                        FullName = reader["FullName"].ToString();
                        Email = reader["Email"] == DBNull.Value
                            ? "" : reader["Email"].ToString();
                        Phone = reader["Phone"] == DBNull.Value
                            ? "" : reader["Phone"].ToString();
                        RoleID = Convert.ToInt32(reader["RoleID"]);
                        Permissions = reader["Permissions"] == DBNull.Value
                            ? 0 : Convert.ToInt32(reader["Permissions"]);
                        IsActive = Convert.ToBoolean(reader["IsActive"]);

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
                return false;
            }
        }

        // Login: retrieve user and stored password by username.
        public static bool GetUserByUserNameAndPassword(
            string UserName,
            ref int UserID,
            ref string Password,
            ref string FullName,
            ref string Email,
            ref string Phone,
            ref int RoleID,
            ref int Permissions,
            ref bool IsActive)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand(
                        "SP_GetUserByUserNameAndPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", UserName);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            return false;

                        UserID = Convert.ToInt32(reader["UserID"]);
                        Password = reader["Password"].ToString();
                        FullName = reader["FullName"].ToString();
                        Email = reader["Email"] == DBNull.Value
                            ? "" : reader["Email"].ToString();
                        Phone = reader["Phone"] == DBNull.Value
                            ? "" : reader["Phone"].ToString();
                        RoleID = Convert.ToInt32(reader["RoleID"]);
                        Permissions = reader["Permissions"] == DBNull.Value
                            ? 0 : Convert.ToInt32(reader["Permissions"]);
                        IsActive = Convert.ToBoolean(reader["IsActive"]);

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
                return false;
            }
        }

        public static int AddNewUser(
            string UserName,
            string Password,
            string FullName,
            string Email,
            string Phone,
            int RoleID,
            int Permissions,
            bool IsActive)
        {
            int UserID = -1;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("SP_AddNewUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@FullName", FullName);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@RoleID", RoleID);
                    command.Parameters.AddWithValue("@Permissions", Permissions);
                    command.Parameters.AddWithValue("@IsActive", IsActive);

                    SqlParameter outputId = new SqlParameter(
                        "@NewUserID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(outputId);

                    connection.Open();
                    command.ExecuteNonQuery();

                    if (outputId.Value != DBNull.Value)
                        UserID = Convert.ToInt32(outputId.Value);
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
            }

            return UserID;
        }

        public static bool UpdateUser(
            int UserID,
            string UserName,
            string Password,
            string FullName,
            string Email,
            string Phone,
            int RoleID,
            int Permissions,
            bool IsActive)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("SP_UpdateUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@FullName", FullName);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@RoleID", RoleID);
                    command.Parameters.AddWithValue("@Permissions", Permissions);
                    command.Parameters.AddWithValue("@IsActive", IsActive);

                    connection.Open();
                    command.ExecuteNonQuery();

                    // Avoid relying on ExecuteNonQuery's row count,
                    // which may be -1 when the stored procedure uses NOCOUNT.
                    return true;
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
                return false;
            }
        }

        public static bool DeleteUser(int UserID)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("SP_DeleteUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);

                    connection.Open();
                    command.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
                return false;
            }
        }

        public static bool IsUserExist(int UserID)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("SP_IsUserExistByUserID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);

                    connection.Open();

                    object result = command.ExecuteScalar();
                    return result != null && result != DBNull.Value;
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
                return false;
            }
        }

        public static bool IsUserExist(string UserName)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("SP_IsUserExistByUserName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", UserName);

                    connection.Open();

                    object result = command.ExecuteScalar();
                    return result != null && result != DBNull.Value;
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
                return false;
            }
        }

        // The Business Layer must hash NewPassword before calling this method.
        public static bool ChangeUserPassword(int UserID, string NewPassword)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("SP_ChangeUserPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@NewPassword", NewPassword);

                    connection.Open();
                    command.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
                return false;
            }
        }

        public static bool UpdatePasswordHash(
            int UserID, string PasswordHash)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(
                    @"UPDATE dbo.Users
                      SET Password = @Password
                      WHERE UserID = @UserID", connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Password", PasswordHash);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
                return false;
            }
        }

        // Forgot Password: SP returns RowsAffected as a result set.
        // Pass a HASHED password from the Business Layer.
        public static bool ResetUserPassword(
            string UserName,
            string Email,
            string NewPasswordHash)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("sp_ResetUserPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue(
                        "@NewPassword", NewPasswordHash);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    return result != null
                        && result != DBNull.Value
                        && Convert.ToInt32(result) > 0;
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
                return false;
            }
        }


        public static DataTable GetUsers(string userName = "")
        {
            DataTable dt = new DataTable();

            string connectionString =
                ConfigurationManager.ConnectionStrings["BankDB"].ConnectionString;

            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            using (SqlCommand command =
                   new SqlCommand("SP_Users_GetAll", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    "@UserName",
                    SqlDbType.NVarChar,
                    100
                ).Value = string.IsNullOrWhiteSpace(userName)
                    ? (object)DBNull.Value
                    : userName.Trim();

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }














    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using Bank_Utilities;

namespace BankDataLayer
{
    public class clsRoleData
    {
        public static DataTable GetAllRoles()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command =
                        new SqlCommand("SP_GetAllRoles", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        using (SqlDataReader reader =
                            command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
            }

            return dt;
        }



        public static bool GetRoleByID(int RoleID, ref string RoleName)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command =
                        new SqlCommand("SP_GetRoleByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@RoleID", RoleID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                RoleName = reader["RoleName"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
            }

            return IsFound;
        }

















    }
}

using Bank_Utilities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataLayer
{
    public class clsClientData
    {
        public static int AddClient(
            string AccountNumber,
            string FullName,
            string NationalID,
            string PinCode,
            decimal Balance,
            int CreatedBy,
            string Phone,
            string Email)
        {
            int ClientID = -1;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("sp_AddClient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    command.Parameters.AddWithValue("@FullName", FullName);
                    command.Parameters.AddWithValue("@NationalID", NationalID);
                    command.Parameters.AddWithValue("@PinCode", PinCode);
                    command.Parameters.AddWithValue("@Balance", Balance);
                    command.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email);

                    SqlParameter outputId =
                        new SqlParameter("@NewClientID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                    command.Parameters.Add(outputId);

                    connection.Open();
                    command.ExecuteNonQuery();

                    ClientID = Convert.ToInt32(outputId.Value);
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
            }

            return ClientID;
        }


        public static bool UpdateClient(
            int ClientID,
            string AccountNumber,
            string FullName,
            string NationalID,
            string PinCode,
            decimal Balance,
            string Phone,
            string Email,
            int CreatedBy)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("sp_UpdateClient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ClientID", ClientID);
                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    command.Parameters.AddWithValue("@FullName", FullName);
                    command.Parameters.AddWithValue("@NationalID", NationalID);
                    command.Parameters.AddWithValue("@PinCode", PinCode);
                    command.Parameters.AddWithValue("@Balance", Balance);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@CreatedBy", CreatedBy);

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

        public static DataTable GetAllClients()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("sp_GetAllClients", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
            }

            return dt;
        }

        public static bool DeleteClient(int ClientID)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("sp_DeleteClient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ClientID", ClientID);

                    connection.Open();

                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
                return false;
            }
        }



        public static DataRow GetClientByID(int ClientID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("sp_GetClientByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ClientID", ClientID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }









        public static bool DepositBalance(string AccountNumber, decimal Amount)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("SP_DepositBalance", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@AccountNumber", SqlDbType.VarChar, 50)
                        .Value = AccountNumber;

                    SqlParameter amountParameter =
                        command.Parameters.Add("@Amount", SqlDbType.Decimal);

                    amountParameter.Precision = 18;
                    amountParameter.Scale = 2;
                    amountParameter.Value = Amount;

                    connection.Open();

                    int result = Convert.ToInt32(command.ExecuteScalar());

                    return result == 1;
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
                return false;
            }
        }



        public static bool IsClientExist(string AccountNO)
        {
            bool IsClientExist = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select AccountNumber From Clients Where AccountNumber = @AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNO);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    IsClientExist = true;
                }
            }
            catch (Exception ex)
            {
                IsClientExist = false;
            }
            finally
            {
                connection.Close();
            }

            return IsClientExist;
        }



        public static DataTable FindClientByAccNO(string AccountNumber)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("SP_FindClientByAccNO", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@AccountNumber", SqlDbType.VarChar, 50)
                        .Value = AccountNumber;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
            }

            return dt;
        }


        public static bool WithdrawBalance(string AccountNumber, decimal Amount)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("SP_WithdrawBalance", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@AccountNumber", SqlDbType.VarChar, 50)
                        .Value = AccountNumber;

                    SqlParameter amountParameter =
                        command.Parameters.Add("@Amount", SqlDbType.Decimal);

                    amountParameter.Precision = 18;
                    amountParameter.Scale = 2;
                    amountParameter.Value = Amount;

                    connection.Open();

                    int result = Convert.ToInt32(command.ExecuteScalar());

                    return result == 1;
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
                return false;
            }
        }


        public static bool TransferBalance(
            string fromAccount,
            string toAccount,
            decimal amount,
            string username)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("SP_TransferBalance", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@FromAccount", SqlDbType.VarChar, 50)
                        .Value = fromAccount;

                    command.Parameters.Add("@ToAccount", SqlDbType.VarChar, 50)
                        .Value = toAccount;

                    SqlParameter amountParameter =
                        command.Parameters.Add("@Amount", SqlDbType.Decimal);

                    amountParameter.Precision = 18;
                    amountParameter.Scale = 2;
                    amountParameter.Value = amount;

                    command.Parameters.Add("@Username", SqlDbType.NVarChar, 100)
                        .Value = username;

                    connection.Open();

                    return Convert.ToInt32(command.ExecuteScalar()) == 1;
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
                return false;
            }
        }


       
        public static DataTable GetAllTransferLog()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command =
                    new SqlCommand("SP_GetAllTransferLog", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                EventLogger.LogException(ex);
            }

            return dt;
        }

















    }
}

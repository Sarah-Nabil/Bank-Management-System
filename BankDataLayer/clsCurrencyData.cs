using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class CurrencyDataAccess
{
    public static DataTable GetCurrencies(string countryName = "")
    {
        DataTable dt = new DataTable();

        string connectionString =
            ConfigurationManager.ConnectionStrings["BankDB"].ConnectionString;

        using (SqlConnection connection = new SqlConnection(connectionString))
        using (SqlCommand command = new SqlCommand(
            "SP_Currencies_GetAll", connection))
        {
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(
                "@CountryName",
                SqlDbType.NVarChar,
                100
            ).Value = string.IsNullOrWhiteSpace(countryName)
                ? (object)DBNull.Value
                : countryName.Trim();

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dt);
            }
        }

        return dt;
    }
}
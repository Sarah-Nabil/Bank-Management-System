using System.Data;
// ضيفي Namespace بتاع الـ Data Access Layer

public class CurrencyBusiness
{
    public static DataTable GetCurrencies(string countryName = "")
    {
        return CurrencyDataAccess.GetCurrencies(countryName);
    }
}
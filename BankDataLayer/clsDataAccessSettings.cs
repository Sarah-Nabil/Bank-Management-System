using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace BankDataLayer
{
    public class clsDataAccessSettings
    {

        // public static string ConnectionString = "Server=.;Database=BANKDB;User Id=sa;Password=sa123456;Integrated Security=true;TrustServerCertificate=true;";

        public static string ConnectionString = ConfigurationManager.ConnectionStrings["BankDB"].ConnectionString;

       

    }
}

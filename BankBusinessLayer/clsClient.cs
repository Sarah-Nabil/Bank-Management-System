
using BankDataLayer;
using System;
using System.Data;
using System.Linq;

namespace BankBusinessLayer
{
    public class clsClient
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        public enMode Mode { get; private set; }

        public int ClientID { get; private set; }
        public string AccountNumber { get; set; }
        public string FullName { get; set; }
        public string NationalID { get; set; }
        public string PinCode { get; set; }
        public decimal Balance { get; set; }
        public int CreatedBy { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public clsClient()
        {
            ClientID = -1;
            AccountNumber = "";
            FullName = "";
            NationalID = "";
            PinCode = "";
            Balance = 0;
            CreatedBy = -1;
            Phone = "";
            Email = "";
            Mode = enMode.AddNew;
        }

        private clsClient(
            int clientID,
            string accountNumber,
            string fullName,
            string nationalID,
            string pinCode,
            decimal balance,
            int createdBy,
            string phone,
            string email)
        {
            ClientID = clientID;
            AccountNumber = accountNumber;
            FullName = fullName;
            NationalID = nationalID;
            PinCode = pinCode;
            Balance = balance;
            CreatedBy = createdBy;
            Phone = phone;
            Email = email;
            Mode = enMode.Update;
        }

        public static DataTable GetAllClients()
        {
            return clsClientData.GetAllClients();
        }

        private bool _AddNewClient()
        {
            ClientID = clsClientData.AddClient(
                AccountNumber,
                FullName,
                NationalID,
                PinCode,
                Balance,
                CreatedBy,
                Phone,
                Email);

            return ClientID != -1;
        }

        private bool _UpdateClient()
        {
            return clsClientData.UpdateClient(
                ClientID,
                AccountNumber,
                FullName,
                NationalID,
                PinCode,
                Balance,
                Phone,
                Email,
                CreatedBy);
        }

        public bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                if (_AddNewClient())
                {
                    Mode = enMode.Update;
                    return true;
                }

                return false;
            }

            return _UpdateClient();
        }

        public static bool Delete(int clientID)
        {
            return clsClientData.DeleteClient(clientID);
        }


        public static clsClient Find(int clientID)
        {
            DataRow row = clsClientData.GetClientByID(clientID);

            if (row == null)
                return null;

            return new clsClient(
                Convert.ToInt32(row["ClientID"]),
                row["AccountNumber"].ToString(),
                row["FullName"].ToString(),
                row["NationalID"].ToString(),
                row["PinCode"].ToString(),
                Convert.ToDecimal(row["Balance"]),
                Convert.ToInt32(row["CreatedBy"]),
                row["Phone"].ToString(),
                row["Email"].ToString()
            );
        }


        public bool Deposite(decimal Amount)
        {
            if (Amount <= 0)
                return false;

            return clsClientData.DepositBalance(this.AccountNumber, Amount);
        }


        public static bool IsClientExist(string accountNo)
        {
            return clsClientData.IsClientExist(accountNo);
        }

        public static DataTable FindClientByAccNO(string AccountNumber)
        {

            return clsClientData.FindClientByAccNO(AccountNumber);

        }


        public static clsClient GetClientInfoByAccountNum(string accountNumber)
        {
            DataTable dt = clsClientData.FindClientByAccNO(accountNumber);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new clsClient(
                Convert.ToInt32(row["ClientID"]),
                row["AccountNumber"].ToString(),
                row["FullName"].ToString(),
                row["NationalID"].ToString(),
                row["PinCode"].ToString(),
                Convert.ToDecimal(row["Balance"]),
                Convert.ToInt32(row["CreatedBy"]),
                row["Phone"].ToString(),
                row["Email"].ToString()
            );
        }


        public bool Withdraw(decimal Amount)
        {
            if (Amount <= 0)
                return false;

            return clsClientData.WithdrawBalance(this.AccountNumber, Amount);
        }





        public static bool TransferBalance(
            string fromAccount,
            string toAccount,
            decimal amount,
            string username)
        {
            if (string.IsNullOrWhiteSpace(fromAccount) ||
                string.IsNullOrWhiteSpace(toAccount) ||
                string.IsNullOrWhiteSpace(username) ||
                fromAccount == toAccount ||
                amount <= 0)
            {
                return false;
            }

            return clsClientData.TransferBalance(
                fromAccount,
                toAccount,
                amount,
                username);
        }




         public static DataTable GetAllTransferLog()
        {
            return clsClientData.GetAllTransferLog();
        }


    }
}

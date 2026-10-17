
using BankDataLayer;
using Bank_Utilities;
using System.Data;
using System;

namespace BankBusinessLayer
{
    public class clsUser
    {
        public enum enPermissions
        {
            eAll = -1,
            pClientList = 1,
            pManageUsers = 2,
            pTransactions = 4,
            pCurrencyExchange = 8,
            pLoginRegisters = 16
        }

        public enum enActionsPermissions
        {
            Add = 1,
            Update = 2,
            Delete = 4
        }

        public enum enMode
        {
            Add = 0,
            Update = 1
        }

        public enMode Mode = enMode.Add;

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int RoleID { get; set; }
        public int Permissions { get; set; }
        public bool IsActive { get; set; }

        public clsRole RoleInfo
        {
            get { return clsRole.Find(RoleID); }
        }

        public clsUser()
        {
            UserID = -1;
            UserName = "";
            Password = "";
            FullName = "";
            Email = "";
            Phone = "";
            RoleID = -1;
            Permissions = 0;
            IsActive = false;
            Mode = enMode.Add;
        }

        private clsUser(
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
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.FullName = FullName;
            this.Email = Email;
            this.Phone = Phone;
            this.RoleID = RoleID;
            this.Permissions = Permissions;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }

        private int _GetRoleActionsPermissions()
        {
            switch (RoleID)
            {
                case 1:
                    return 7;

                case 2:
                    return 3;

                case 3:
                    return 0;

                default:
                    return 0;
            }
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static clsUser Find(int userID)
        {
            string userName = "";
            string password = "";
            string fullName = "";
            string email = "";
            string phone = "";

            int roleID = 0;
            int permissions = 0;
            bool isActive = false;

            bool isFound = clsUserData.GetUserByID(
                userID,
                ref userName,
                ref password,
                ref fullName,
                ref email,
                ref phone,
                ref roleID,
                ref permissions,
                ref isActive
            );

            if (!isFound)
                return null;

            return new clsUser(
                userID,
                userName,
                password,
                fullName,
                email,
                phone,
                roleID,
                permissions,
                isActive
            );
        }

        // ========================
        // Login
        // ========================
        public static clsUser FindByUserNameAndPassword(
            string userName, string password)
        {
            int userID = 0;
            string storedPassword = "";
            string fullName = "";
            string email = "";
            string phone = "";

            int roleID = 0;
            int permissions = 0;
            bool isActive = false;

            bool isFound =
                clsUserData.GetUserByUserNameAndPassword(
                    userName,
                    ref userID,
                    ref storedPassword,
                    ref fullName,
                    ref email,
                    ref phone,
                    ref roleID,
                    ref permissions,
                    ref isActive
                );

            if (!isFound)
                return null;

            bool isPasswordValid;

            if (storedPassword.StartsWith("PBKDF2$"))
            {
                isPasswordValid =
                    clsPasswordHelper.VerifyPassword(
                        password, storedPassword);
            }
            else
            {
                // Temporary support for old plain-text passwords.
                isPasswordValid = password == storedPassword;

                if (isPasswordValid)
                {
                    string passwordHash =
                        clsPasswordHelper.HashPassword(password);

                    if (clsUserData.UpdatePasswordHash(
                        userID, passwordHash))
                    {
                        storedPassword = passwordHash;
                    }
                }
            }

            if (!isPasswordValid)
                return null;

            return new clsUser(
                userID,
                userName,
                storedPassword,
                fullName,
                email,
                phone,
                roleID,
                permissions,
                isActive
            );
        }

        // ========================
        // Add
        // ========================
        private bool _Add()
        {
            if (string.IsNullOrWhiteSpace(Password))
                return false;

            string passwordHash =
                clsPasswordHelper.HashPassword(Password);

            int newUserID = clsUserData.AddNewUser(
                UserName,
                passwordHash,
                FullName,
                Email,
                Phone,
                RoleID,
                Permissions,
                IsActive
            );

            if (newUserID == -1)
                return false;

            UserID = newUserID;
            Password = passwordHash;

            return true;
        }

        // ========================
        // Update
        // ========================
        private bool _Update()
        {
            if (string.IsNullOrWhiteSpace(Password))
                return false;

            string passwordToSave;

            if (Password.StartsWith("PBKDF2$"))
            {
                // Already hashed: do not hash it again.
                passwordToSave = Password;
            }
            else
            {
                passwordToSave =
                    clsPasswordHelper.HashPassword(Password);
            }

            bool isUpdated = clsUserData.UpdateUser(
                UserID,
                UserName,
                passwordToSave,
                FullName,
                Email,
                Phone,
                RoleID,
                Permissions,
                IsActive
            );

            if (isUpdated)
                Password = passwordToSave;

            return isUpdated;
        }

        // ========================
        // Save
        // ========================
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return _Update();

                default:
                    return false;
            }
        }

        // ========================
        // Change Password
        // ========================
        public static bool ChangePassword(
            int userID, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(newPassword))
                return false;

            string passwordHash =
                clsPasswordHelper.HashPassword(newPassword);

            return clsUserData.ChangeUserPassword(
                userID, passwordHash);
        }

        // ========================
        // Forgot Password
        // ========================
        public static bool ResetPassword(
            string userName,
            string email,
            string newPassword)
        {
            if (string.IsNullOrWhiteSpace(userName)
                || string.IsNullOrWhiteSpace(email)
                || string.IsNullOrWhiteSpace(newPassword))
            {
                return false;
            }

            string passwordHash =
                clsPasswordHelper.HashPassword(newPassword);

            return clsUserData.ResetUserPassword(
                userName,
                email,
                passwordHash);
        }

        // ========================
        // Delete
        // ========================
        public static bool Delete(int userID)
        {
            return clsUserData.DeleteUser(userID);
        }

        // ========================
        // Exists
        // ========================
        public static bool IsExist(int userID)
        {
            return clsUserData.IsUserExist(userID);
        }

        public static bool IsExist(string userName)
        {
            return clsUserData.IsUserExist(userName);
        }

        // ========================
        // Permissions
        // ========================
        public bool HasPermission(enPermissions Permission)
        {
            if (Permissions == (int)enPermissions.eAll)
                return true;

            return ((int)Permission & Permissions)
                == (int)Permission;
        }

        public bool HasActionPermission(
            enActionsPermissions permission)
        {
            return (_GetRoleActionsPermissions()
                & (int)permission) == (int)permission;
        }



        public static DataTable GetUsers(string userName = "")
        {
            return clsUserData.GetUsers(userName);
        }
















    }
}

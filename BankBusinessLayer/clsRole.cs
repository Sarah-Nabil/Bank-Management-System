using BankDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankBusinessLayer.clsUser;

namespace BankBusinessLayer
{
    public class clsRole
    {
        public int RoleID { get; set; }

        public string RoleName { get; set; }

        public enum enMode { Add = 0, Update = 1 };
        public enMode Mode = enMode.Add;
        public clsRole()
        {
            RoleID = -1;
            RoleName = "";
            Mode = enMode.Add;
        }

        private clsRole(int RoleID, string RoleName)
        {
            this.RoleID = RoleID;
            this.RoleName = RoleName;

            Mode = enMode.Update;
        }

        public static DataTable GetAllRoles()
        {
            return clsRoleData.GetAllRoles();
        }

        public static clsRole Find(int RoleID)
        {
            string RoleName = "";

            bool IsFound =
                clsRoleData.GetRoleByID(RoleID, ref RoleName);

            if (IsFound)
                return new clsRole(RoleID, RoleName);
            else
                return null;
        }
    }
}

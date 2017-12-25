using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using VSM.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace VSM.Rules
{
	public partial class M_KioskBusinessRules : VSM.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view after an action
        /// with a command name that matches "Delete".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(System.Guid? kiosk_ID, string kiosk_Code, string kiosk_Name, string mac_Address, string hD_Serial, string iP_Address, string kioskType_Code, string kioskType_KioskType_Name, System.Guid? location_ID, string location_Location_Address, string location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            // This is the placeholder for method implementation.

            try
            {
                SqlConnection SQLConn = new SqlConnection();
                if (SQLConn.State == ConnectionState.Open) SQLConn.Close();
                SQLConn.ConnectionString = ConfigurationManager.ConnectionStrings["VSM"].ToString();
                SQLConn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"DELETE T_Kiosk_Signal
                                    WHERE Kiosk_ID = '" + kiosk_ID + "'";
                cmd.Connection = SQLConn;
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
        }
    }
}

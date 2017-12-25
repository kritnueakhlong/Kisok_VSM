using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using VSM.Data;
using VSM.Security;

namespace VSM.Rules
{
	public partial class EmployeeBusinessRules : VSM.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view before an action
        /// with a command name that matches "Update|Insert".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(System.Guid? emp_id, string emp_code, FieldValue password, string emp_fname, string emp_lname, string emp_email, int? team_id, string telephone, string created_by, DateTime? created_on, string updated_by, DateTime? updated_on, string createname, string updatename)
        {
            // This is the placeholder for method implementation.
            if (password != null && password.Modified)
            {
                ApplicationMembershipProvider.ValidateUserPassword(emp_code,
                    password.NewValue.ToString());
                password.NewValue =
                    ApplicationMembershipProvider.EncodeUserPassword(password.NewValue.ToString());


            }
        }
    }
}

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
	public partial class HelpDeskBusinessRules : VSM.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view before an action
        /// with a command name that matches "Update|Insert".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(System.Guid? helpDesk_ID, string personnel_no, string helpDesk_FirstName, string helpDesk_LastName, FieldValue helpDesk_AuthenPassword, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            // This is the placeholder for method implementation.
            if (helpDesk_AuthenPassword != null && helpDesk_AuthenPassword.Modified)
            {
                ApplicationMembershipProvider.ValidateUserPassword(personnel_no,
                    helpDesk_AuthenPassword.NewValue.ToString());
                helpDesk_AuthenPassword.NewValue =
                    ApplicationMembershipProvider.EncodeUserPassword(helpDesk_AuthenPassword.NewValue.ToString());


            }
        }
    }
}

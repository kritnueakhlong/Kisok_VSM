using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using VSM.Data;

namespace VSM.Models
{
	public partial class HelpDeskModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _helpDesk_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personnel_no;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _helpDesk_FirstName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _helpDesk_LastName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _helpDesk_AuthenPassword;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        public HelpDeskModel()
        {
        }
        
        public HelpDeskModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public System.Guid? HelpDesk_ID
        {
            get
            {
                return _helpDesk_ID;
            }
            set
            {
                _helpDesk_ID = value;
                UpdateFieldValue("HelpDesk_ID", value);
            }
        }
        
        public string Personnel_no
        {
            get
            {
                return _personnel_no;
            }
            set
            {
                _personnel_no = value;
                UpdateFieldValue("Personnel_no", value);
            }
        }
        
        public string HelpDesk_FirstName
        {
            get
            {
                return _helpDesk_FirstName;
            }
            set
            {
                _helpDesk_FirstName = value;
                UpdateFieldValue("HelpDesk_FirstName", value);
            }
        }
        
        public string HelpDesk_LastName
        {
            get
            {
                return _helpDesk_LastName;
            }
            set
            {
                _helpDesk_LastName = value;
                UpdateFieldValue("HelpDesk_LastName", value);
            }
        }
        
        public string HelpDesk_AuthenPassword
        {
            get
            {
                return _helpDesk_AuthenPassword;
            }
            set
            {
                _helpDesk_AuthenPassword = value;
                UpdateFieldValue("HelpDesk_AuthenPassword", value);
            }
        }
        
        public string CreatedBy
        {
            get
            {
                return _createdBy;
            }
            set
            {
                _createdBy = value;
                UpdateFieldValue("CreatedBy", value);
            }
        }
        
        public DateTime? CreatedOn
        {
            get
            {
                return _createdOn;
            }
            set
            {
                _createdOn = value;
                UpdateFieldValue("CreatedOn", value);
            }
        }
        
        public string ModifiedBy
        {
            get
            {
                return _modifiedBy;
            }
            set
            {
                _modifiedBy = value;
                UpdateFieldValue("ModifiedBy", value);
            }
        }
        
        public DateTime? ModifiedOn
        {
            get
            {
                return _modifiedOn;
            }
            set
            {
                _modifiedOn = value;
                UpdateFieldValue("ModifiedOn", value);
            }
        }
    }
}

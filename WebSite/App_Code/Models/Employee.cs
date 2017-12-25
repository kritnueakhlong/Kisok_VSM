using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using VSM.Data;

namespace VSM.Models
{
	public partial class EmployeeModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _emp_id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _emp_code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _password;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _emp_fname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _emp_lname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _emp_email;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _team_id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _telephone;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_Branch_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Branch_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _updatename;
        
        public EmployeeModel()
        {
        }
        
        public EmployeeModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public System.Guid? emp_id
        {
            get
            {
                return _emp_id;
            }
            set
            {
                _emp_id = value;
                UpdateFieldValue("emp_id", value);
            }
        }
        
        public string emp_code
        {
            get
            {
                return _emp_code;
            }
            set
            {
                _emp_code = value;
                UpdateFieldValue("emp_code", value);
            }
        }
        
        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                UpdateFieldValue("password", value);
            }
        }
        
        public string emp_fname
        {
            get
            {
                return _emp_fname;
            }
            set
            {
                _emp_fname = value;
                UpdateFieldValue("emp_fname", value);
            }
        }
        
        public string emp_lname
        {
            get
            {
                return _emp_lname;
            }
            set
            {
                _emp_lname = value;
                UpdateFieldValue("emp_lname", value);
            }
        }
        
        public string emp_email
        {
            get
            {
                return _emp_email;
            }
            set
            {
                _emp_email = value;
                UpdateFieldValue("emp_email", value);
            }
        }
        
        public int? team_id
        {
            get
            {
                return _team_id;
            }
            set
            {
                _team_id = value;
                UpdateFieldValue("team_id", value);
            }
        }
        
        public string telephone
        {
            get
            {
                return _telephone;
            }
            set
            {
                _telephone = value;
                UpdateFieldValue("telephone", value);
            }
        }
        
        public System.Guid? KioskOwner_ID
        {
            get
            {
                return _kioskOwner_ID;
            }
            set
            {
                _kioskOwner_ID = value;
                UpdateFieldValue("KioskOwner_ID", value);
            }
        }
        
        public string KioskOwner_Code
        {
            get
            {
                return _kioskOwner_Code;
            }
            set
            {
                _kioskOwner_Code = value;
                UpdateFieldValue("KioskOwner_Code", value);
            }
        }
        
        public System.Guid? KioskOwner_Branch_ID
        {
            get
            {
                return _kioskOwner_Branch_ID;
            }
            set
            {
                _kioskOwner_Branch_ID = value;
                UpdateFieldValue("KioskOwner_Branch_ID", value);
            }
        }
        
        public string KioskOwner_Branch_Code
        {
            get
            {
                return _kioskOwner_Branch_Code;
            }
            set
            {
                _kioskOwner_Branch_Code = value;
                UpdateFieldValue("KioskOwner_Branch_Code", value);
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
        
        public string createname
        {
            get
            {
                return _createname;
            }
            set
            {
                _createname = value;
                UpdateFieldValue("createname", value);
            }
        }
        
        public string updatename
        {
            get
            {
                return _updatename;
            }
            set
            {
                _updatename = value;
                UpdateFieldValue("updatename", value);
            }
        }
    }
}

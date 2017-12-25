using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using VSM.Data;

namespace VSM.Models
{
	public partial class M_KioskModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kiosk_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Serial;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mac_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _hD_Serial;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iP_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskType_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskType_KioskType_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_Branch_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Branch_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _location_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _location_Location_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        public M_KioskModel()
        {
        }
        
        public M_KioskModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public System.Guid? Kiosk_ID
        {
            get
            {
                return _kiosk_ID;
            }
            set
            {
                _kiosk_ID = value;
                UpdateFieldValue("Kiosk_ID", value);
            }
        }
        
        public string Kiosk_Code
        {
            get
            {
                return _kiosk_Code;
            }
            set
            {
                _kiosk_Code = value;
                UpdateFieldValue("Kiosk_Code", value);
            }
        }
        
        public string Kiosk_Name
        {
            get
            {
                return _kiosk_Name;
            }
            set
            {
                _kiosk_Name = value;
                UpdateFieldValue("Kiosk_Name", value);
            }
        }
        
        public string Kiosk_Serial
        {
            get
            {
                return _kiosk_Serial;
            }
            set
            {
                _kiosk_Serial = value;
                UpdateFieldValue("Kiosk_Serial", value);
            }
        }
        
        public string Mac_Address
        {
            get
            {
                return _mac_Address;
            }
            set
            {
                _mac_Address = value;
                UpdateFieldValue("Mac_Address", value);
            }
        }
        
        public string HD_Serial
        {
            get
            {
                return _hD_Serial;
            }
            set
            {
                _hD_Serial = value;
                UpdateFieldValue("HD_Serial", value);
            }
        }
        
        public string IP_Address
        {
            get
            {
                return _iP_Address;
            }
            set
            {
                _iP_Address = value;
                UpdateFieldValue("IP_Address", value);
            }
        }
        
        public string KioskType_Code
        {
            get
            {
                return _kioskType_Code;
            }
            set
            {
                _kioskType_Code = value;
                UpdateFieldValue("KioskType_Code", value);
            }
        }
        
        public string KioskType_KioskType_Name
        {
            get
            {
                return _kioskType_KioskType_Name;
            }
            set
            {
                _kioskType_KioskType_Name = value;
                UpdateFieldValue("KioskType_KioskType_Name", value);
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
        
        public System.Guid? Location_ID
        {
            get
            {
                return _location_ID;
            }
            set
            {
                _location_ID = value;
                UpdateFieldValue("Location_ID", value);
            }
        }
        
        public string Location_Location_Address
        {
            get
            {
                return _location_Location_Address;
            }
            set
            {
                _location_Location_Address = value;
                UpdateFieldValue("Location_Location_Address", value);
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

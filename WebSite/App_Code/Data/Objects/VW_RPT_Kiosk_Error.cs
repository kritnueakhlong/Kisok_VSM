using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class VW_RPT_Kiosk_Error
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _identity_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mac_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _hD_Serial;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iP_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _location_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _usageStatus_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_Branch_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        public VW_RPT_Kiosk_Error()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Identity_ID
        {
            get
            {
                return _identity_ID;
            }
            set
            {
                _identity_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Kiosk_Code
        {
            get
            {
                return _kiosk_Code;
            }
            set
            {
                _kiosk_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Mac_Address
        {
            get
            {
                return _mac_Address;
            }
            set
            {
                _mac_Address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HD_Serial
        {
            get
            {
                return _hD_Serial;
            }
            set
            {
                _hD_Serial = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IP_Address
        {
            get
            {
                return _iP_Address;
            }
            set
            {
                _iP_Address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Location_Address
        {
            get
            {
                return _location_Address;
            }
            set
            {
                _location_Address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string UsageStatus_Name
        {
            get
            {
                return _usageStatus_Name;
            }
            set
            {
                _usageStatus_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public System.Guid? KioskOwner_ID
        {
            get
            {
                return _kioskOwner_ID;
            }
            set
            {
                _kioskOwner_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public System.Guid? KioskOwner_Branch_ID
        {
            get
            {
                return _kioskOwner_Branch_ID;
            }
            set
            {
                _kioskOwner_Branch_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? CreatedOn
        {
            get
            {
                return _createdOn;
            }
            set
            {
                _createdOn = value;
            }
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Error> Select(string identity_ID, string kiosk_Code, string mac_Address, string hD_Serial, string iP_Address, string location_Address, string usageStatus_Name, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, DateTime? createdOn)
        {
            return new VW_RPT_Kiosk_ErrorFactory().Select(identity_ID, kiosk_Code, mac_Address, hD_Serial, iP_Address, location_Address, usageStatus_Name, kioskOwner_ID, kioskOwner_Branch_ID, createdOn);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Error> Select(VSM.Data.Objects.VW_RPT_Kiosk_Error qbe)
        {
            return new VW_RPT_Kiosk_ErrorFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Error> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new VW_RPT_Kiosk_ErrorFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Error> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new VW_RPT_Kiosk_ErrorFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Error> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new VW_RPT_Kiosk_ErrorFactory().Select(filter, sort, VW_RPT_Kiosk_ErrorFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Error> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new VW_RPT_Kiosk_ErrorFactory().Select(filter, sort, VW_RPT_Kiosk_ErrorFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Error> Select(string filter, BusinessObjectParameters parameters)
        {
            return new VW_RPT_Kiosk_ErrorFactory().Select(filter, null, VW_RPT_Kiosk_ErrorFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Error> Select(string filter, params FieldValue[] parameters)
        {
            return new VW_RPT_Kiosk_ErrorFactory().Select(filter, null, VW_RPT_Kiosk_ErrorFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.VW_RPT_Kiosk_Error SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new VW_RPT_Kiosk_ErrorFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.VW_RPT_Kiosk_Error SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new VW_RPT_Kiosk_ErrorFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public override string ToString()
        {
            return String.Format("");
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class VW_RPT_Kiosk_ErrorFactory
    {
        
        public VW_RPT_Kiosk_ErrorFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("VW_RPT_Kiosk_Error");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("VW_RPT_Kiosk_Error");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("VW_RPT_Kiosk_Error");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("VW_RPT_Kiosk_Error");
            }
        }
        
        public static VW_RPT_Kiosk_ErrorFactory Create()
        {
            return new VW_RPT_Kiosk_ErrorFactory();
        }
        
        protected virtual PageRequest CreateRequest(string identity_ID, string kiosk_Code, string mac_Address, string hD_Serial, string iP_Address, string location_Address, string usageStatus_Name, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, DateTime? createdOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (!(String.IsNullOrEmpty(identity_ID)))
            	filter.Add(("Identity_ID:*" + identity_ID));
            if (!(String.IsNullOrEmpty(kiosk_Code)))
            	filter.Add(("Kiosk_Code:*" + kiosk_Code));
            if (!(String.IsNullOrEmpty(mac_Address)))
            	filter.Add(("Mac_Address:*" + mac_Address));
            if (!(String.IsNullOrEmpty(hD_Serial)))
            	filter.Add(("HD_Serial:*" + hD_Serial));
            if (!(String.IsNullOrEmpty(iP_Address)))
            	filter.Add(("IP_Address:*" + iP_Address));
            if (!(String.IsNullOrEmpty(location_Address)))
            	filter.Add(("Location_Address:*" + location_Address));
            if (!(String.IsNullOrEmpty(usageStatus_Name)))
            	filter.Add(("UsageStatus_Name:*" + usageStatus_Name));
            if (kioskOwner_ID.HasValue)
            	filter.Add(("KioskOwner_ID:=" + kioskOwner_ID.Value.ToString()));
            if (kioskOwner_Branch_ID.HasValue)
            	filter.Add(("KioskOwner_Branch_ID:=" + kioskOwner_Branch_ID.Value.ToString()));
            if (createdOn.HasValue)
            	filter.Add(("CreatedOn:=" + createdOn.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<VSM.Data.Objects.VW_RPT_Kiosk_Error> Select(string identity_ID, string kiosk_Code, string mac_Address, string hD_Serial, string iP_Address, string location_Address, string usageStatus_Name, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, DateTime? createdOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(identity_ID, kiosk_Code, mac_Address, hD_Serial, iP_Address, location_Address, usageStatus_Name, kioskOwner_ID, kioskOwner_Branch_ID, createdOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VW_RPT_Kiosk_Error", dataView, request);
            return page.ToList<VSM.Data.Objects.VW_RPT_Kiosk_Error>();
        }
        
        public List<VSM.Data.Objects.VW_RPT_Kiosk_Error> Select(VSM.Data.Objects.VW_RPT_Kiosk_Error qbe)
        {
            return Select(qbe.Identity_ID, qbe.Kiosk_Code, qbe.Mac_Address, qbe.HD_Serial, qbe.IP_Address, qbe.Location_Address, qbe.UsageStatus_Name, qbe.KioskOwner_ID, qbe.KioskOwner_Branch_ID, qbe.CreatedOn);
        }
        
        public int SelectCount(string identity_ID, string kiosk_Code, string mac_Address, string hD_Serial, string iP_Address, string location_Address, string usageStatus_Name, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, DateTime? createdOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(identity_ID, kiosk_Code, mac_Address, hD_Serial, iP_Address, location_Address, usageStatus_Name, kioskOwner_ID, kioskOwner_Branch_ID, createdOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VW_RPT_Kiosk_Error", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.VW_RPT_Kiosk_Error> Select(string identity_ID, string kiosk_Code, string mac_Address, string hD_Serial, string iP_Address, string location_Address, string usageStatus_Name, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, DateTime? createdOn)
        {
            return Select(identity_ID, kiosk_Code, mac_Address, hD_Serial, iP_Address, location_Address, usageStatus_Name, kioskOwner_ID, kioskOwner_Branch_ID, createdOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<VSM.Data.Objects.VW_RPT_Kiosk_Error> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("VW_RPT_Kiosk_Error", dataView, request);
            return page.ToList<VSM.Data.Objects.VW_RPT_Kiosk_Error>();
        }
        
        public List<VSM.Data.Objects.VW_RPT_Kiosk_Error> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.VW_RPT_Kiosk_Error> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.VW_RPT_Kiosk_Error SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.VW_RPT_Kiosk_Error> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
    }
}

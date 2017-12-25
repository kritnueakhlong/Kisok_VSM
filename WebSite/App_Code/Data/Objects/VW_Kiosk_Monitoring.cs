using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class VW_Kiosk_Monitoring
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kiosk_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_Branch_ID;
        
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
        private string _location_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _img_status;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sTATUS;
        
        public VW_Kiosk_Monitoring()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public System.Guid? Kiosk_ID
        {
            get
            {
                return _kiosk_ID;
            }
            set
            {
                _kiosk_ID = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        public string Kiosk_Name
        {
            get
            {
                return _kiosk_Name;
            }
            set
            {
                _kiosk_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Kiosk_Serial
        {
            get
            {
                return _kiosk_Serial;
            }
            set
            {
                _kiosk_Serial = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? ModifiedOn
        {
            get
            {
                return _modifiedOn;
            }
            set
            {
                _modifiedOn = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string img_status
        {
            get
            {
                return _img_status;
            }
            set
            {
                _img_status = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string STATUS
        {
            get
            {
                return _sTATUS;
            }
            set
            {
                _sTATUS = value;
            }
        }
        
        public static List<VSM.Data.Objects.VW_Kiosk_Monitoring> Select(System.Guid? kiosk_ID, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, string kiosk_Code, string kiosk_Name, string kiosk_Serial, string mac_Address, string hD_Serial, string iP_Address, string location_Address, DateTime? createdOn, DateTime? modifiedOn, string img_status, string sTATUS)
        {
            return new VW_Kiosk_MonitoringFactory().Select(kiosk_ID, kioskOwner_ID, kioskOwner_Branch_ID, kiosk_Code, kiosk_Name, kiosk_Serial, mac_Address, hD_Serial, iP_Address, location_Address, createdOn, modifiedOn, img_status, sTATUS);
        }
        
        public static List<VSM.Data.Objects.VW_Kiosk_Monitoring> Select(VSM.Data.Objects.VW_Kiosk_Monitoring qbe)
        {
            return new VW_Kiosk_MonitoringFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.VW_Kiosk_Monitoring> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new VW_Kiosk_MonitoringFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_Kiosk_Monitoring> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new VW_Kiosk_MonitoringFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.VW_Kiosk_Monitoring> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new VW_Kiosk_MonitoringFactory().Select(filter, sort, VW_Kiosk_MonitoringFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_Kiosk_Monitoring> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new VW_Kiosk_MonitoringFactory().Select(filter, sort, VW_Kiosk_MonitoringFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.VW_Kiosk_Monitoring> Select(string filter, BusinessObjectParameters parameters)
        {
            return new VW_Kiosk_MonitoringFactory().Select(filter, null, VW_Kiosk_MonitoringFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_Kiosk_Monitoring> Select(string filter, params FieldValue[] parameters)
        {
            return new VW_Kiosk_MonitoringFactory().Select(filter, null, VW_Kiosk_MonitoringFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.VW_Kiosk_Monitoring SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new VW_Kiosk_MonitoringFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.VW_Kiosk_Monitoring SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new VW_Kiosk_MonitoringFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public override string ToString()
        {
            return String.Format("");
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class VW_Kiosk_MonitoringFactory
    {
        
        public VW_Kiosk_MonitoringFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("VW_Kiosk_Monitoring");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("VW_Kiosk_Monitoring");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("VW_Kiosk_Monitoring");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("VW_Kiosk_Monitoring");
            }
        }
        
        public static VW_Kiosk_MonitoringFactory Create()
        {
            return new VW_Kiosk_MonitoringFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    System.Guid? kiosk_ID, 
                    System.Guid? kioskOwner_ID, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kiosk_Code, 
                    string kiosk_Name, 
                    string kiosk_Serial, 
                    string mac_Address, 
                    string hD_Serial, 
                    string iP_Address, 
                    string location_Address, 
                    DateTime? createdOn, 
                    DateTime? modifiedOn, 
                    string img_status, 
                    string sTATUS, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (kiosk_ID.HasValue)
            	filter.Add(("Kiosk_ID:=" + kiosk_ID.Value.ToString()));
            if (kioskOwner_ID.HasValue)
            	filter.Add(("KioskOwner_ID:=" + kioskOwner_ID.Value.ToString()));
            if (kioskOwner_Branch_ID.HasValue)
            	filter.Add(("KioskOwner_Branch_ID:=" + kioskOwner_Branch_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kiosk_Code)))
            	filter.Add(("Kiosk_Code:*" + kiosk_Code));
            if (!(String.IsNullOrEmpty(kiosk_Name)))
            	filter.Add(("Kiosk_Name:*" + kiosk_Name));
            if (!(String.IsNullOrEmpty(kiosk_Serial)))
            	filter.Add(("Kiosk_Serial:*" + kiosk_Serial));
            if (!(String.IsNullOrEmpty(mac_Address)))
            	filter.Add(("Mac_Address:*" + mac_Address));
            if (!(String.IsNullOrEmpty(hD_Serial)))
            	filter.Add(("HD_Serial:*" + hD_Serial));
            if (!(String.IsNullOrEmpty(iP_Address)))
            	filter.Add(("IP_Address:*" + iP_Address));
            if (!(String.IsNullOrEmpty(location_Address)))
            	filter.Add(("Location_Address:*" + location_Address));
            if (createdOn.HasValue)
            	filter.Add(("CreatedOn:=" + createdOn.Value.ToString()));
            if (modifiedOn.HasValue)
            	filter.Add(("ModifiedOn:=" + modifiedOn.Value.ToString()));
            if (!(String.IsNullOrEmpty(img_status)))
            	filter.Add(("img_status:*" + img_status));
            if (!(String.IsNullOrEmpty(sTATUS)))
            	filter.Add(("STATUS:*" + sTATUS));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<VSM.Data.Objects.VW_Kiosk_Monitoring> Select(
                    System.Guid? kiosk_ID, 
                    System.Guid? kioskOwner_ID, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kiosk_Code, 
                    string kiosk_Name, 
                    string kiosk_Serial, 
                    string mac_Address, 
                    string hD_Serial, 
                    string iP_Address, 
                    string location_Address, 
                    DateTime? createdOn, 
                    DateTime? modifiedOn, 
                    string img_status, 
                    string sTATUS, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(kiosk_ID, kioskOwner_ID, kioskOwner_Branch_ID, kiosk_Code, kiosk_Name, kiosk_Serial, mac_Address, hD_Serial, iP_Address, location_Address, createdOn, modifiedOn, img_status, sTATUS, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VW_Kiosk_Monitoring", dataView, request);
            return page.ToList<VSM.Data.Objects.VW_Kiosk_Monitoring>();
        }
        
        public List<VSM.Data.Objects.VW_Kiosk_Monitoring> Select(VSM.Data.Objects.VW_Kiosk_Monitoring qbe)
        {
            return Select(qbe.Kiosk_ID, qbe.KioskOwner_ID, qbe.KioskOwner_Branch_ID, qbe.Kiosk_Code, qbe.Kiosk_Name, qbe.Kiosk_Serial, qbe.Mac_Address, qbe.HD_Serial, qbe.IP_Address, qbe.Location_Address, qbe.CreatedOn, qbe.ModifiedOn, qbe.img_status, qbe.STATUS);
        }
        
        public int SelectCount(
                    System.Guid? kiosk_ID, 
                    System.Guid? kioskOwner_ID, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kiosk_Code, 
                    string kiosk_Name, 
                    string kiosk_Serial, 
                    string mac_Address, 
                    string hD_Serial, 
                    string iP_Address, 
                    string location_Address, 
                    DateTime? createdOn, 
                    DateTime? modifiedOn, 
                    string img_status, 
                    string sTATUS, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(kiosk_ID, kioskOwner_ID, kioskOwner_Branch_ID, kiosk_Code, kiosk_Name, kiosk_Serial, mac_Address, hD_Serial, iP_Address, location_Address, createdOn, modifiedOn, img_status, sTATUS, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VW_Kiosk_Monitoring", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.VW_Kiosk_Monitoring> Select(System.Guid? kiosk_ID, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, string kiosk_Code, string kiosk_Name, string kiosk_Serial, string mac_Address, string hD_Serial, string iP_Address, string location_Address, DateTime? createdOn, DateTime? modifiedOn, string img_status, string sTATUS)
        {
            return Select(kiosk_ID, kioskOwner_ID, kioskOwner_Branch_ID, kiosk_Code, kiosk_Name, kiosk_Serial, mac_Address, hD_Serial, iP_Address, location_Address, createdOn, modifiedOn, img_status, sTATUS, null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<VSM.Data.Objects.VW_Kiosk_Monitoring> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("VW_Kiosk_Monitoring", dataView, request);
            return page.ToList<VSM.Data.Objects.VW_Kiosk_Monitoring>();
        }
        
        public List<VSM.Data.Objects.VW_Kiosk_Monitoring> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.VW_Kiosk_Monitoring> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.VW_Kiosk_Monitoring SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.VW_Kiosk_Monitoring> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
    }
}

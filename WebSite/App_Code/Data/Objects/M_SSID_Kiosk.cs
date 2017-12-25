using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_SSID_Kiosk
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _sSID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sSSSID_CODE;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sSKioskOwner_KioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sSRadiusServer_RadiusServer_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kiosk_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Kiosk_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_KioskType_KioskType_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Location_Location_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Location_KioskOwner_KioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        public M_SSID_Kiosk()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? SSID
        {
            get
            {
                return _sSID;
            }
            set
            {
                _sSID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SSSSID_CODE
        {
            get
            {
                return _sSSSID_CODE;
            }
            set
            {
                _sSSSID_CODE = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SSKioskOwner_KioskOwner_Code
        {
            get
            {
                return _sSKioskOwner_KioskOwner_Code;
            }
            set
            {
                _sSKioskOwner_KioskOwner_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SSRadiusServer_RadiusServer_Name
        {
            get
            {
                return _sSRadiusServer_RadiusServer_Name;
            }
            set
            {
                _sSRadiusServer_RadiusServer_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Kiosk_Kiosk_Code
        {
            get
            {
                return _kiosk_Kiosk_Code;
            }
            set
            {
                _kiosk_Kiosk_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Kiosk_KioskType_KioskType_Name
        {
            get
            {
                return _kiosk_KioskType_KioskType_Name;
            }
            set
            {
                _kiosk_KioskType_KioskType_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Kiosk_Location_Location_Address
        {
            get
            {
                return _kiosk_Location_Location_Address;
            }
            set
            {
                _kiosk_Location_Location_Address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Kiosk_Location_KioskOwner_KioskOwner_Code
        {
            get
            {
                return _kiosk_Location_KioskOwner_KioskOwner_Code;
            }
            set
            {
                _kiosk_Location_KioskOwner_KioskOwner_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CreatedBy
        {
            get
            {
                return _createdBy;
            }
            set
            {
                _createdBy = value;
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
        public string ModifiedBy
        {
            get
            {
                return _modifiedBy;
            }
            set
            {
                _modifiedBy = value;
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
        
        public static List<VSM.Data.Objects.M_SSID_Kiosk> Select(System.Guid? sSID, string sSSSID_CODE, string sSKioskOwner_KioskOwner_Code, string sSRadiusServer_RadiusServer_Name, System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_SSID_KioskFactory().Select(sSID, sSSSID_CODE, sSKioskOwner_KioskOwner_Code, sSRadiusServer_RadiusServer_Name, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_SSID_Kiosk> Select(VSM.Data.Objects.M_SSID_Kiosk qbe)
        {
            return new M_SSID_KioskFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_SSID_Kiosk> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_SSID_KioskFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_SSID_Kiosk> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_SSID_KioskFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_SSID_Kiosk> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_SSID_KioskFactory().Select(filter, sort, M_SSID_KioskFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_SSID_Kiosk> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_SSID_KioskFactory().Select(filter, sort, M_SSID_KioskFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_SSID_Kiosk> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_SSID_KioskFactory().Select(filter, null, M_SSID_KioskFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_SSID_Kiosk> Select(string filter, params FieldValue[] parameters)
        {
            return new M_SSID_KioskFactory().Select(filter, null, M_SSID_KioskFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_SSID_Kiosk SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_SSID_KioskFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_SSID_Kiosk SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_SSID_KioskFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_SSID_Kiosk SelectSingle(System.Guid? sSID, System.Guid? kiosk_ID)
        {
            return new M_SSID_KioskFactory().SelectSingle(sSID, kiosk_ID);
        }
        
        public int Insert()
        {
            return new M_SSID_KioskFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_SSID_KioskFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_SSID_KioskFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("SSID: {0}; Kiosk_ID: {1}", this.SSID, this.Kiosk_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_SSID_KioskFactory
    {
        
        public M_SSID_KioskFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_SSID_Kiosk");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_SSID_Kiosk");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_SSID_Kiosk");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_SSID_Kiosk");
            }
        }
        
        public static M_SSID_KioskFactory Create()
        {
            return new M_SSID_KioskFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    System.Guid? sSID, 
                    string sSSSID_CODE, 
                    string sSKioskOwner_KioskOwner_Code, 
                    string sSRadiusServer_RadiusServer_Name, 
                    System.Guid? kiosk_ID, 
                    string kiosk_Kiosk_Code, 
                    string kiosk_KioskType_KioskType_Name, 
                    string kiosk_Location_Location_Address, 
                    string kiosk_Location_KioskOwner_KioskOwner_Code, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (sSID.HasValue)
            	filter.Add(("SSID:=" + sSID.Value.ToString()));
            if (!(String.IsNullOrEmpty(sSSSID_CODE)))
            	filter.Add(("SSSSID_CODE:*" + sSSSID_CODE));
            if (!(String.IsNullOrEmpty(sSKioskOwner_KioskOwner_Code)))
            	filter.Add(("SSKioskOwner_KioskOwner_Code:*" + sSKioskOwner_KioskOwner_Code));
            if (!(String.IsNullOrEmpty(sSRadiusServer_RadiusServer_Name)))
            	filter.Add(("SSRadiusServer_RadiusServer_Name:*" + sSRadiusServer_RadiusServer_Name));
            if (kiosk_ID.HasValue)
            	filter.Add(("Kiosk_ID:=" + kiosk_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kiosk_Kiosk_Code)))
            	filter.Add(("Kiosk_Kiosk_Code:*" + kiosk_Kiosk_Code));
            if (!(String.IsNullOrEmpty(kiosk_KioskType_KioskType_Name)))
            	filter.Add(("Kiosk_KioskType_KioskType_Name:*" + kiosk_KioskType_KioskType_Name));
            if (!(String.IsNullOrEmpty(kiosk_Location_Location_Address)))
            	filter.Add(("Kiosk_Location_Location_Address:*" + kiosk_Location_Location_Address));
            if (!(String.IsNullOrEmpty(kiosk_Location_KioskOwner_KioskOwner_Code)))
            	filter.Add(("Kiosk_Location_KioskOwner_KioskOwner_Code:*" + kiosk_Location_KioskOwner_KioskOwner_Code));
            if (!(String.IsNullOrEmpty(createdBy)))
            	filter.Add(("CreatedBy:*" + createdBy));
            if (createdOn.HasValue)
            	filter.Add(("CreatedOn:=" + createdOn.Value.ToString()));
            if (!(String.IsNullOrEmpty(modifiedBy)))
            	filter.Add(("ModifiedBy:*" + modifiedBy));
            if (modifiedOn.HasValue)
            	filter.Add(("ModifiedOn:=" + modifiedOn.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<VSM.Data.Objects.M_SSID_Kiosk> Select(
                    System.Guid? sSID, 
                    string sSSSID_CODE, 
                    string sSKioskOwner_KioskOwner_Code, 
                    string sSRadiusServer_RadiusServer_Name, 
                    System.Guid? kiosk_ID, 
                    string kiosk_Kiosk_Code, 
                    string kiosk_KioskType_KioskType_Name, 
                    string kiosk_Location_Location_Address, 
                    string kiosk_Location_KioskOwner_KioskOwner_Code, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(sSID, sSSSID_CODE, sSKioskOwner_KioskOwner_Code, sSRadiusServer_RadiusServer_Name, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_SSID_Kiosk", dataView, request);
            return page.ToList<VSM.Data.Objects.M_SSID_Kiosk>();
        }
        
        public List<VSM.Data.Objects.M_SSID_Kiosk> Select(VSM.Data.Objects.M_SSID_Kiosk qbe)
        {
            return Select(qbe.SSID, qbe.SSSSID_CODE, qbe.SSKioskOwner_KioskOwner_Code, qbe.SSRadiusServer_RadiusServer_Name, qbe.Kiosk_ID, qbe.Kiosk_Kiosk_Code, qbe.Kiosk_KioskType_KioskType_Name, qbe.Kiosk_Location_Location_Address, qbe.Kiosk_Location_KioskOwner_KioskOwner_Code, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? sSID, 
                    string sSSSID_CODE, 
                    string sSKioskOwner_KioskOwner_Code, 
                    string sSRadiusServer_RadiusServer_Name, 
                    System.Guid? kiosk_ID, 
                    string kiosk_Kiosk_Code, 
                    string kiosk_KioskType_KioskType_Name, 
                    string kiosk_Location_Location_Address, 
                    string kiosk_Location_KioskOwner_KioskOwner_Code, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(sSID, sSSSID_CODE, sSKioskOwner_KioskOwner_Code, sSRadiusServer_RadiusServer_Name, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_SSID_Kiosk", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_SSID_Kiosk> Select(System.Guid? sSID, string sSSSID_CODE, string sSKioskOwner_KioskOwner_Code, string sSRadiusServer_RadiusServer_Name, System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(sSID, sSSSID_CODE, sSKioskOwner_KioskOwner_Code, sSRadiusServer_RadiusServer_Name, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_SSID_Kiosk SelectSingle(System.Guid? sSID, System.Guid? kiosk_ID)
        {
            List<VSM.Data.Objects.M_SSID_Kiosk> list = Select(sSID, null, null, null, kiosk_ID, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_SSID_Kiosk> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_SSID_Kiosk", dataView, request);
            return page.ToList<VSM.Data.Objects.M_SSID_Kiosk>();
        }
        
        public List<VSM.Data.Objects.M_SSID_Kiosk> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_SSID_Kiosk> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_SSID_Kiosk SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_SSID_Kiosk> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_SSID_Kiosk theM_SSID_Kiosk, VSM.Data.Objects.M_SSID_Kiosk original_M_SSID_Kiosk)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("SSID", original_M_SSID_Kiosk.SSID, theM_SSID_Kiosk.SSID));
            values.Add(new FieldValue("SSSSID_CODE", original_M_SSID_Kiosk.SSSSID_CODE, theM_SSID_Kiosk.SSSSID_CODE, true));
            values.Add(new FieldValue("SSKioskOwner_KioskOwner_Code", original_M_SSID_Kiosk.SSKioskOwner_KioskOwner_Code, theM_SSID_Kiosk.SSKioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("SSRadiusServer_RadiusServer_Name", original_M_SSID_Kiosk.SSRadiusServer_RadiusServer_Name, theM_SSID_Kiosk.SSRadiusServer_RadiusServer_Name, true));
            values.Add(new FieldValue("Kiosk_ID", original_M_SSID_Kiosk.Kiosk_ID, theM_SSID_Kiosk.Kiosk_ID));
            values.Add(new FieldValue("Kiosk_Kiosk_Code", original_M_SSID_Kiosk.Kiosk_Kiosk_Code, theM_SSID_Kiosk.Kiosk_Kiosk_Code, true));
            values.Add(new FieldValue("Kiosk_KioskType_KioskType_Name", original_M_SSID_Kiosk.Kiosk_KioskType_KioskType_Name, theM_SSID_Kiosk.Kiosk_KioskType_KioskType_Name, true));
            values.Add(new FieldValue("Kiosk_Location_Location_Address", original_M_SSID_Kiosk.Kiosk_Location_Location_Address, theM_SSID_Kiosk.Kiosk_Location_Location_Address, true));
            values.Add(new FieldValue("Kiosk_Location_KioskOwner_KioskOwner_Code", original_M_SSID_Kiosk.Kiosk_Location_KioskOwner_KioskOwner_Code, theM_SSID_Kiosk.Kiosk_Location_KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("CreatedBy", original_M_SSID_Kiosk.CreatedBy, theM_SSID_Kiosk.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_SSID_Kiosk.CreatedOn, theM_SSID_Kiosk.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_SSID_Kiosk.ModifiedBy, theM_SSID_Kiosk.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_SSID_Kiosk.ModifiedOn, theM_SSID_Kiosk.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_SSID_Kiosk theM_SSID_Kiosk, VSM.Data.Objects.M_SSID_Kiosk original_M_SSID_Kiosk, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_SSID_Kiosk";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_SSID_Kiosk, original_M_SSID_Kiosk);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_SSID_Kiosk", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_SSID_Kiosk);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_SSID_Kiosk theM_SSID_Kiosk, VSM.Data.Objects.M_SSID_Kiosk original_M_SSID_Kiosk)
        {
            return ExecuteAction(theM_SSID_Kiosk, original_M_SSID_Kiosk, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_SSID_Kiosk theM_SSID_Kiosk)
        {
            return Update(theM_SSID_Kiosk, SelectSingle(theM_SSID_Kiosk.SSID, theM_SSID_Kiosk.Kiosk_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_SSID_Kiosk theM_SSID_Kiosk)
        {
            return ExecuteAction(theM_SSID_Kiosk, new M_SSID_Kiosk(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_SSID_Kiosk theM_SSID_Kiosk)
        {
            return ExecuteAction(theM_SSID_Kiosk, theM_SSID_Kiosk, "Select", "Delete", DeleteView);
        }
    }
}

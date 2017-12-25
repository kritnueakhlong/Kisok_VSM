using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_SSID
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _sSID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sSID_CODE;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sSID_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _radiusServer_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _radiusServer_RadiusServer_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_KioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _item_Flag;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        public M_SSID()
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string SSID_CODE
        {
            get
            {
                return _sSID_CODE;
            }
            set
            {
                _sSID_CODE = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SSID_Name
        {
            get
            {
                return _sSID_Name;
            }
            set
            {
                _sSID_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string RadiusServer_Code
        {
            get
            {
                return _radiusServer_Code;
            }
            set
            {
                _radiusServer_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RadiusServer_RadiusServer_Name
        {
            get
            {
                return _radiusServer_RadiusServer_Name;
            }
            set
            {
                _radiusServer_RadiusServer_Name = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string KioskOwner_KioskOwner_Code
        {
            get
            {
                return _kioskOwner_KioskOwner_Code;
            }
            set
            {
                _kioskOwner_KioskOwner_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? Item_Flag
        {
            get
            {
                return _item_Flag;
            }
            set
            {
                _item_Flag = value;
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
        
        public static List<VSM.Data.Objects.M_SSID> Select(System.Guid? sSID, string sSID_CODE, string sSID_Name, string radiusServer_Code, string radiusServer_RadiusServer_Name, System.Guid? kioskOwner_ID, string kioskOwner_KioskOwner_Code, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_SSIDFactory().Select(sSID, sSID_CODE, sSID_Name, radiusServer_Code, radiusServer_RadiusServer_Name, kioskOwner_ID, kioskOwner_KioskOwner_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_SSID> Select(VSM.Data.Objects.M_SSID qbe)
        {
            return new M_SSIDFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_SSID> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_SSIDFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_SSID> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_SSIDFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_SSID> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_SSIDFactory().Select(filter, sort, M_SSIDFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_SSID> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_SSIDFactory().Select(filter, sort, M_SSIDFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_SSID> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_SSIDFactory().Select(filter, null, M_SSIDFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_SSID> Select(string filter, params FieldValue[] parameters)
        {
            return new M_SSIDFactory().Select(filter, null, M_SSIDFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_SSID SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_SSIDFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_SSID SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_SSIDFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_SSID SelectSingle(System.Guid? sSID)
        {
            return new M_SSIDFactory().SelectSingle(sSID);
        }
        
        public int Insert()
        {
            return new M_SSIDFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_SSIDFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_SSIDFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("SSID: {0}", this.SSID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_SSIDFactory
    {
        
        public M_SSIDFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_SSID");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_SSID");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_SSID");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_SSID");
            }
        }
        
        public static M_SSIDFactory Create()
        {
            return new M_SSIDFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? sSID, string sSID_CODE, string sSID_Name, string radiusServer_Code, string radiusServer_RadiusServer_Name, System.Guid? kioskOwner_ID, string kioskOwner_KioskOwner_Code, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (sSID.HasValue)
            	filter.Add(("SSID:=" + sSID.Value.ToString()));
            if (!(String.IsNullOrEmpty(sSID_CODE)))
            	filter.Add(("SSID_CODE:*" + sSID_CODE));
            if (!(String.IsNullOrEmpty(sSID_Name)))
            	filter.Add(("SSID_Name:*" + sSID_Name));
            if (!(String.IsNullOrEmpty(radiusServer_Code)))
            	filter.Add(("RadiusServer_Code:*" + radiusServer_Code));
            if (!(String.IsNullOrEmpty(radiusServer_RadiusServer_Name)))
            	filter.Add(("RadiusServer_RadiusServer_Name:*" + radiusServer_RadiusServer_Name));
            if (kioskOwner_ID.HasValue)
            	filter.Add(("KioskOwner_ID:=" + kioskOwner_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_KioskOwner_Code)))
            	filter.Add(("KioskOwner_KioskOwner_Code:*" + kioskOwner_KioskOwner_Code));
            if (item_Flag.HasValue)
            	filter.Add(("Item_Flag:=" + item_Flag.Value.ToString()));
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
        public List<VSM.Data.Objects.M_SSID> Select(
                    System.Guid? sSID, 
                    string sSID_CODE, 
                    string sSID_Name, 
                    string radiusServer_Code, 
                    string radiusServer_RadiusServer_Name, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    bool? item_Flag, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(sSID, sSID_CODE, sSID_Name, radiusServer_Code, radiusServer_RadiusServer_Name, kioskOwner_ID, kioskOwner_KioskOwner_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_SSID", dataView, request);
            return page.ToList<VSM.Data.Objects.M_SSID>();
        }
        
        public List<VSM.Data.Objects.M_SSID> Select(VSM.Data.Objects.M_SSID qbe)
        {
            return Select(qbe.SSID, qbe.SSID_CODE, qbe.SSID_Name, qbe.RadiusServer_Code, qbe.RadiusServer_RadiusServer_Name, qbe.KioskOwner_ID, qbe.KioskOwner_KioskOwner_Code, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? sSID, 
                    string sSID_CODE, 
                    string sSID_Name, 
                    string radiusServer_Code, 
                    string radiusServer_RadiusServer_Name, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    bool? item_Flag, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(sSID, sSID_CODE, sSID_Name, radiusServer_Code, radiusServer_RadiusServer_Name, kioskOwner_ID, kioskOwner_KioskOwner_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_SSID", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_SSID> Select(System.Guid? sSID, string sSID_CODE, string sSID_Name, string radiusServer_Code, string radiusServer_RadiusServer_Name, System.Guid? kioskOwner_ID, string kioskOwner_KioskOwner_Code, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(sSID, sSID_CODE, sSID_Name, radiusServer_Code, radiusServer_RadiusServer_Name, kioskOwner_ID, kioskOwner_KioskOwner_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_SSID SelectSingle(System.Guid? sSID)
        {
            List<VSM.Data.Objects.M_SSID> list = Select(sSID, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_SSID> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_SSID", dataView, request);
            return page.ToList<VSM.Data.Objects.M_SSID>();
        }
        
        public List<VSM.Data.Objects.M_SSID> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_SSID> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_SSID SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_SSID> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_SSID theM_SSID, VSM.Data.Objects.M_SSID original_M_SSID)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("SSID", original_M_SSID.SSID, theM_SSID.SSID));
            values.Add(new FieldValue("SSID_CODE", original_M_SSID.SSID_CODE, theM_SSID.SSID_CODE));
            values.Add(new FieldValue("SSID_Name", original_M_SSID.SSID_Name, theM_SSID.SSID_Name));
            values.Add(new FieldValue("RadiusServer_Code", original_M_SSID.RadiusServer_Code, theM_SSID.RadiusServer_Code));
            values.Add(new FieldValue("RadiusServer_RadiusServer_Name", original_M_SSID.RadiusServer_RadiusServer_Name, theM_SSID.RadiusServer_RadiusServer_Name, true));
            values.Add(new FieldValue("KioskOwner_ID", original_M_SSID.KioskOwner_ID, theM_SSID.KioskOwner_ID));
            values.Add(new FieldValue("KioskOwner_KioskOwner_Code", original_M_SSID.KioskOwner_KioskOwner_Code, theM_SSID.KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("Item_Flag", original_M_SSID.Item_Flag, theM_SSID.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_SSID.CreatedBy, theM_SSID.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_SSID.CreatedOn, theM_SSID.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_SSID.ModifiedBy, theM_SSID.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_SSID.ModifiedOn, theM_SSID.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_SSID theM_SSID, VSM.Data.Objects.M_SSID original_M_SSID, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_SSID";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_SSID, original_M_SSID);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_SSID", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_SSID);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_SSID theM_SSID, VSM.Data.Objects.M_SSID original_M_SSID)
        {
            return ExecuteAction(theM_SSID, original_M_SSID, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_SSID theM_SSID)
        {
            return Update(theM_SSID, SelectSingle(theM_SSID.SSID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_SSID theM_SSID)
        {
            return ExecuteAction(theM_SSID, new M_SSID(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_SSID theM_SSID)
        {
            return ExecuteAction(theM_SSID, theM_SSID, "Select", "Delete", DeleteView);
        }
    }
}

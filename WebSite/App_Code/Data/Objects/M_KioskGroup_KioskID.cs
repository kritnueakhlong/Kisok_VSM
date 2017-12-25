using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_KioskGroup_KioskID
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskGroup_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskGroup_KioskGroup_Name;
        
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
        
        public M_KioskGroup_KioskID()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? KioskGroup_ID
        {
            get
            {
                return _kioskGroup_ID;
            }
            set
            {
                _kioskGroup_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string KioskGroup_KioskGroup_Name
        {
            get
            {
                return _kioskGroup_KioskGroup_Name;
            }
            set
            {
                _kioskGroup_KioskGroup_Name = value;
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
        
        public static List<VSM.Data.Objects.M_KioskGroup_KioskID> Select(System.Guid? kioskGroup_ID, string kioskGroup_KioskGroup_Name, System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_KioskGroup_KioskIDFactory().Select(kioskGroup_ID, kioskGroup_KioskGroup_Name, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_KioskGroup_KioskID> Select(VSM.Data.Objects.M_KioskGroup_KioskID qbe)
        {
            return new M_KioskGroup_KioskIDFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_KioskGroup_KioskID> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_KioskGroup_KioskIDFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_KioskGroup_KioskID> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_KioskGroup_KioskIDFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_KioskGroup_KioskID> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_KioskGroup_KioskIDFactory().Select(filter, sort, M_KioskGroup_KioskIDFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_KioskGroup_KioskID> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_KioskGroup_KioskIDFactory().Select(filter, sort, M_KioskGroup_KioskIDFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_KioskGroup_KioskID> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_KioskGroup_KioskIDFactory().Select(filter, null, M_KioskGroup_KioskIDFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_KioskGroup_KioskID> Select(string filter, params FieldValue[] parameters)
        {
            return new M_KioskGroup_KioskIDFactory().Select(filter, null, M_KioskGroup_KioskIDFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_KioskGroup_KioskID SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_KioskGroup_KioskIDFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_KioskGroup_KioskID SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_KioskGroup_KioskIDFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_KioskGroup_KioskID SelectSingle(System.Guid? kioskGroup_ID, System.Guid? kiosk_ID)
        {
            return new M_KioskGroup_KioskIDFactory().SelectSingle(kioskGroup_ID, kiosk_ID);
        }
        
        public int Insert()
        {
            return new M_KioskGroup_KioskIDFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_KioskGroup_KioskIDFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_KioskGroup_KioskIDFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("KioskGroup_ID: {0}; Kiosk_ID: {1}", this.KioskGroup_ID, this.Kiosk_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_KioskGroup_KioskIDFactory
    {
        
        public M_KioskGroup_KioskIDFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_KioskGroup_KioskID");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_KioskGroup_KioskID");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_KioskGroup_KioskID");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_KioskGroup_KioskID");
            }
        }
        
        public static M_KioskGroup_KioskIDFactory Create()
        {
            return new M_KioskGroup_KioskIDFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? kioskGroup_ID, string kioskGroup_KioskGroup_Name, System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (kioskGroup_ID.HasValue)
            	filter.Add(("KioskGroup_ID:=" + kioskGroup_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskGroup_KioskGroup_Name)))
            	filter.Add(("KioskGroup_KioskGroup_Name:*" + kioskGroup_KioskGroup_Name));
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
        public List<VSM.Data.Objects.M_KioskGroup_KioskID> Select(System.Guid? kioskGroup_ID, string kioskGroup_KioskGroup_Name, System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kioskGroup_ID, kioskGroup_KioskGroup_Name, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_KioskGroup_KioskID", dataView, request);
            return page.ToList<VSM.Data.Objects.M_KioskGroup_KioskID>();
        }
        
        public List<VSM.Data.Objects.M_KioskGroup_KioskID> Select(VSM.Data.Objects.M_KioskGroup_KioskID qbe)
        {
            return Select(qbe.KioskGroup_ID, qbe.KioskGroup_KioskGroup_Name, qbe.Kiosk_ID, qbe.Kiosk_Kiosk_Code, qbe.Kiosk_KioskType_KioskType_Name, qbe.Kiosk_Location_Location_Address, qbe.Kiosk_Location_KioskOwner_KioskOwner_Code, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(System.Guid? kioskGroup_ID, string kioskGroup_KioskGroup_Name, System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kioskGroup_ID, kioskGroup_KioskGroup_Name, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_KioskGroup_KioskID", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_KioskGroup_KioskID> Select(System.Guid? kioskGroup_ID, string kioskGroup_KioskGroup_Name, System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(kioskGroup_ID, kioskGroup_KioskGroup_Name, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_KioskGroup_KioskID SelectSingle(System.Guid? kioskGroup_ID, System.Guid? kiosk_ID)
        {
            List<VSM.Data.Objects.M_KioskGroup_KioskID> list = Select(kioskGroup_ID, null, kiosk_ID, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_KioskGroup_KioskID> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_KioskGroup_KioskID", dataView, request);
            return page.ToList<VSM.Data.Objects.M_KioskGroup_KioskID>();
        }
        
        public List<VSM.Data.Objects.M_KioskGroup_KioskID> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_KioskGroup_KioskID> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_KioskGroup_KioskID SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_KioskGroup_KioskID> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_KioskGroup_KioskID theM_KioskGroup_KioskID, VSM.Data.Objects.M_KioskGroup_KioskID original_M_KioskGroup_KioskID)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("KioskGroup_ID", original_M_KioskGroup_KioskID.KioskGroup_ID, theM_KioskGroup_KioskID.KioskGroup_ID));
            values.Add(new FieldValue("KioskGroup_KioskGroup_Name", original_M_KioskGroup_KioskID.KioskGroup_KioskGroup_Name, theM_KioskGroup_KioskID.KioskGroup_KioskGroup_Name, true));
            values.Add(new FieldValue("Kiosk_ID", original_M_KioskGroup_KioskID.Kiosk_ID, theM_KioskGroup_KioskID.Kiosk_ID));
            values.Add(new FieldValue("Kiosk_Kiosk_Code", original_M_KioskGroup_KioskID.Kiosk_Kiosk_Code, theM_KioskGroup_KioskID.Kiosk_Kiosk_Code, true));
            values.Add(new FieldValue("Kiosk_KioskType_KioskType_Name", original_M_KioskGroup_KioskID.Kiosk_KioskType_KioskType_Name, theM_KioskGroup_KioskID.Kiosk_KioskType_KioskType_Name, true));
            values.Add(new FieldValue("Kiosk_Location_Location_Address", original_M_KioskGroup_KioskID.Kiosk_Location_Location_Address, theM_KioskGroup_KioskID.Kiosk_Location_Location_Address, true));
            values.Add(new FieldValue("Kiosk_Location_KioskOwner_KioskOwner_Code", original_M_KioskGroup_KioskID.Kiosk_Location_KioskOwner_KioskOwner_Code, theM_KioskGroup_KioskID.Kiosk_Location_KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("CreatedBy", original_M_KioskGroup_KioskID.CreatedBy, theM_KioskGroup_KioskID.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_KioskGroup_KioskID.CreatedOn, theM_KioskGroup_KioskID.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_KioskGroup_KioskID.ModifiedBy, theM_KioskGroup_KioskID.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_KioskGroup_KioskID.ModifiedOn, theM_KioskGroup_KioskID.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_KioskGroup_KioskID theM_KioskGroup_KioskID, VSM.Data.Objects.M_KioskGroup_KioskID original_M_KioskGroup_KioskID, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_KioskGroup_KioskID";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_KioskGroup_KioskID, original_M_KioskGroup_KioskID);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_KioskGroup_KioskID", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_KioskGroup_KioskID);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_KioskGroup_KioskID theM_KioskGroup_KioskID, VSM.Data.Objects.M_KioskGroup_KioskID original_M_KioskGroup_KioskID)
        {
            return ExecuteAction(theM_KioskGroup_KioskID, original_M_KioskGroup_KioskID, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_KioskGroup_KioskID theM_KioskGroup_KioskID)
        {
            return Update(theM_KioskGroup_KioskID, SelectSingle(theM_KioskGroup_KioskID.KioskGroup_ID, theM_KioskGroup_KioskID.Kiosk_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_KioskGroup_KioskID theM_KioskGroup_KioskID)
        {
            return ExecuteAction(theM_KioskGroup_KioskID, new M_KioskGroup_KioskID(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_KioskGroup_KioskID theM_KioskGroup_KioskID)
        {
            return ExecuteAction(theM_KioskGroup_KioskID, theM_KioskGroup_KioskID, "Select", "Delete", DeleteView);
        }
    }
}

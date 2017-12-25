using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_Usage_Status
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _usageStatus_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locale_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locale_Locale_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _usageStatus_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _usageStatus_Name;
        
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
        
        public M_Usage_Status()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? UsageStatus_ID
        {
            get
            {
                return _usageStatus_ID;
            }
            set
            {
                _usageStatus_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Locale_Code
        {
            get
            {
                return _locale_Code;
            }
            set
            {
                _locale_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Locale_Locale_Name
        {
            get
            {
                return _locale_Locale_Name;
            }
            set
            {
                _locale_Locale_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string UsageStatus_Code
        {
            get
            {
                return _usageStatus_Code;
            }
            set
            {
                _usageStatus_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        public static List<VSM.Data.Objects.M_Usage_Status> Select(int? usageStatus_ID, string locale_Code, string locale_Locale_Name, string usageStatus_Code, string usageStatus_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_Usage_StatusFactory().Select(usageStatus_ID, locale_Code, locale_Locale_Name, usageStatus_Code, usageStatus_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_Usage_Status> Select(VSM.Data.Objects.M_Usage_Status qbe)
        {
            return new M_Usage_StatusFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_Usage_Status> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_Usage_StatusFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Usage_Status> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_Usage_StatusFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Usage_Status> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_Usage_StatusFactory().Select(filter, sort, M_Usage_StatusFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Usage_Status> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_Usage_StatusFactory().Select(filter, sort, M_Usage_StatusFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Usage_Status> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_Usage_StatusFactory().Select(filter, null, M_Usage_StatusFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Usage_Status> Select(string filter, params FieldValue[] parameters)
        {
            return new M_Usage_StatusFactory().Select(filter, null, M_Usage_StatusFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Usage_Status SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_Usage_StatusFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_Usage_Status SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_Usage_StatusFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Usage_Status SelectSingle(int? usageStatus_ID)
        {
            return new M_Usage_StatusFactory().SelectSingle(usageStatus_ID);
        }
        
        public int Insert()
        {
            return new M_Usage_StatusFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_Usage_StatusFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_Usage_StatusFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("UsageStatus_ID: {0}", this.UsageStatus_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_Usage_StatusFactory
    {
        
        public M_Usage_StatusFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_Usage_Status");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_Usage_Status");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_Usage_Status");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_Usage_Status");
            }
        }
        
        public static M_Usage_StatusFactory Create()
        {
            return new M_Usage_StatusFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? usageStatus_ID, string locale_Code, string locale_Locale_Name, string usageStatus_Code, string usageStatus_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (usageStatus_ID.HasValue)
            	filter.Add(("UsageStatus_ID:=" + usageStatus_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(locale_Code)))
            	filter.Add(("Locale_Code:*" + locale_Code));
            if (!(String.IsNullOrEmpty(locale_Locale_Name)))
            	filter.Add(("Locale_Locale_Name:*" + locale_Locale_Name));
            if (!(String.IsNullOrEmpty(usageStatus_Code)))
            	filter.Add(("UsageStatus_Code:*" + usageStatus_Code));
            if (!(String.IsNullOrEmpty(usageStatus_Name)))
            	filter.Add(("UsageStatus_Name:*" + usageStatus_Name));
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
        public List<VSM.Data.Objects.M_Usage_Status> Select(int? usageStatus_ID, string locale_Code, string locale_Locale_Name, string usageStatus_Code, string usageStatus_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(usageStatus_ID, locale_Code, locale_Locale_Name, usageStatus_Code, usageStatus_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Usage_Status", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Usage_Status>();
        }
        
        public List<VSM.Data.Objects.M_Usage_Status> Select(VSM.Data.Objects.M_Usage_Status qbe)
        {
            return Select(qbe.UsageStatus_ID, qbe.Locale_Code, qbe.Locale_Locale_Name, qbe.UsageStatus_Code, qbe.UsageStatus_Name, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(int? usageStatus_ID, string locale_Code, string locale_Locale_Name, string usageStatus_Code, string usageStatus_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(usageStatus_ID, locale_Code, locale_Locale_Name, usageStatus_Code, usageStatus_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Usage_Status", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_Usage_Status> Select(int? usageStatus_ID, string locale_Code, string locale_Locale_Name, string usageStatus_Code, string usageStatus_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(usageStatus_ID, locale_Code, locale_Locale_Name, usageStatus_Code, usageStatus_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_Usage_Status SelectSingle(int? usageStatus_ID)
        {
            List<VSM.Data.Objects.M_Usage_Status> list = Select(usageStatus_ID, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_Usage_Status> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_Usage_Status", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Usage_Status>();
        }
        
        public List<VSM.Data.Objects.M_Usage_Status> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_Usage_Status> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_Usage_Status SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_Usage_Status> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_Usage_Status theM_Usage_Status, VSM.Data.Objects.M_Usage_Status original_M_Usage_Status)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("UsageStatus_ID", original_M_Usage_Status.UsageStatus_ID, theM_Usage_Status.UsageStatus_ID, true));
            values.Add(new FieldValue("Locale_Code", original_M_Usage_Status.Locale_Code, theM_Usage_Status.Locale_Code));
            values.Add(new FieldValue("Locale_Locale_Name", original_M_Usage_Status.Locale_Locale_Name, theM_Usage_Status.Locale_Locale_Name, true));
            values.Add(new FieldValue("UsageStatus_Code", original_M_Usage_Status.UsageStatus_Code, theM_Usage_Status.UsageStatus_Code));
            values.Add(new FieldValue("UsageStatus_Name", original_M_Usage_Status.UsageStatus_Name, theM_Usage_Status.UsageStatus_Name));
            values.Add(new FieldValue("Item_Flag", original_M_Usage_Status.Item_Flag, theM_Usage_Status.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_Usage_Status.CreatedBy, theM_Usage_Status.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_Usage_Status.CreatedOn, theM_Usage_Status.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_Usage_Status.ModifiedBy, theM_Usage_Status.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_Usage_Status.ModifiedOn, theM_Usage_Status.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_Usage_Status theM_Usage_Status, VSM.Data.Objects.M_Usage_Status original_M_Usage_Status, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_Usage_Status";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_Usage_Status, original_M_Usage_Status);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_Usage_Status", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_Usage_Status);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_Usage_Status theM_Usage_Status, VSM.Data.Objects.M_Usage_Status original_M_Usage_Status)
        {
            return ExecuteAction(theM_Usage_Status, original_M_Usage_Status, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_Usage_Status theM_Usage_Status)
        {
            return Update(theM_Usage_Status, SelectSingle(theM_Usage_Status.UsageStatus_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_Usage_Status theM_Usage_Status)
        {
            return ExecuteAction(theM_Usage_Status, new M_Usage_Status(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_Usage_Status theM_Usage_Status)
        {
            return ExecuteAction(theM_Usage_Status, theM_Usage_Status, "Select", "Delete", DeleteView);
        }
    }
}

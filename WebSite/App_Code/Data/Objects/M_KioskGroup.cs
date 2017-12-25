using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_KioskGroup
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskGroup_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskGroup_Name;
        
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
        
        public M_KioskGroup()
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string KioskGroup_Name
        {
            get
            {
                return _kioskGroup_Name;
            }
            set
            {
                _kioskGroup_Name = value;
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
        
        public static List<VSM.Data.Objects.M_KioskGroup> Select(System.Guid? kioskGroup_ID, string kioskGroup_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_KioskGroupFactory().Select(kioskGroup_ID, kioskGroup_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_KioskGroup> Select(VSM.Data.Objects.M_KioskGroup qbe)
        {
            return new M_KioskGroupFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_KioskGroup> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_KioskGroupFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_KioskGroup> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_KioskGroupFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_KioskGroup> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_KioskGroupFactory().Select(filter, sort, M_KioskGroupFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_KioskGroup> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_KioskGroupFactory().Select(filter, sort, M_KioskGroupFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_KioskGroup> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_KioskGroupFactory().Select(filter, null, M_KioskGroupFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_KioskGroup> Select(string filter, params FieldValue[] parameters)
        {
            return new M_KioskGroupFactory().Select(filter, null, M_KioskGroupFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_KioskGroup SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_KioskGroupFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_KioskGroup SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_KioskGroupFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_KioskGroup SelectSingle(System.Guid? kioskGroup_ID)
        {
            return new M_KioskGroupFactory().SelectSingle(kioskGroup_ID);
        }
        
        public int Insert()
        {
            return new M_KioskGroupFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_KioskGroupFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_KioskGroupFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("KioskGroup_ID: {0}", this.KioskGroup_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_KioskGroupFactory
    {
        
        public M_KioskGroupFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_KioskGroup");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_KioskGroup");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_KioskGroup");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_KioskGroup");
            }
        }
        
        public static M_KioskGroupFactory Create()
        {
            return new M_KioskGroupFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? kioskGroup_ID, string kioskGroup_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (kioskGroup_ID.HasValue)
            	filter.Add(("KioskGroup_ID:=" + kioskGroup_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskGroup_Name)))
            	filter.Add(("KioskGroup_Name:*" + kioskGroup_Name));
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
        public List<VSM.Data.Objects.M_KioskGroup> Select(System.Guid? kioskGroup_ID, string kioskGroup_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kioskGroup_ID, kioskGroup_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_KioskGroup", dataView, request);
            return page.ToList<VSM.Data.Objects.M_KioskGroup>();
        }
        
        public List<VSM.Data.Objects.M_KioskGroup> Select(VSM.Data.Objects.M_KioskGroup qbe)
        {
            return Select(qbe.KioskGroup_ID, qbe.KioskGroup_Name, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(System.Guid? kioskGroup_ID, string kioskGroup_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kioskGroup_ID, kioskGroup_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_KioskGroup", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_KioskGroup> Select(System.Guid? kioskGroup_ID, string kioskGroup_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(kioskGroup_ID, kioskGroup_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_KioskGroup SelectSingle(System.Guid? kioskGroup_ID)
        {
            List<VSM.Data.Objects.M_KioskGroup> list = Select(kioskGroup_ID, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_KioskGroup> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_KioskGroup", dataView, request);
            return page.ToList<VSM.Data.Objects.M_KioskGroup>();
        }
        
        public List<VSM.Data.Objects.M_KioskGroup> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_KioskGroup> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_KioskGroup SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_KioskGroup> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_KioskGroup theM_KioskGroup, VSM.Data.Objects.M_KioskGroup original_M_KioskGroup)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("KioskGroup_ID", original_M_KioskGroup.KioskGroup_ID, theM_KioskGroup.KioskGroup_ID));
            values.Add(new FieldValue("KioskGroup_Name", original_M_KioskGroup.KioskGroup_Name, theM_KioskGroup.KioskGroup_Name));
            values.Add(new FieldValue("Item_Flag", original_M_KioskGroup.Item_Flag, theM_KioskGroup.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_KioskGroup.CreatedBy, theM_KioskGroup.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_KioskGroup.CreatedOn, theM_KioskGroup.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_KioskGroup.ModifiedBy, theM_KioskGroup.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_KioskGroup.ModifiedOn, theM_KioskGroup.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_KioskGroup theM_KioskGroup, VSM.Data.Objects.M_KioskGroup original_M_KioskGroup, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_KioskGroup";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_KioskGroup, original_M_KioskGroup);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_KioskGroup", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_KioskGroup);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_KioskGroup theM_KioskGroup, VSM.Data.Objects.M_KioskGroup original_M_KioskGroup)
        {
            return ExecuteAction(theM_KioskGroup, original_M_KioskGroup, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_KioskGroup theM_KioskGroup)
        {
            return Update(theM_KioskGroup, SelectSingle(theM_KioskGroup.KioskGroup_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_KioskGroup theM_KioskGroup)
        {
            return ExecuteAction(theM_KioskGroup, new M_KioskGroup(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_KioskGroup theM_KioskGroup)
        {
            return ExecuteAction(theM_KioskGroup, theM_KioskGroup, "Select", "Delete", DeleteView);
        }
    }
}

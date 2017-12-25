using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class T_Advertise_KioskGroup
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _advertise_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advertise_Advertise_Desc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advertise_KioskOwner_KioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskGroup_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskGroup_KioskGroup_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        public T_Advertise_KioskGroup()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? Advertise_ID
        {
            get
            {
                return _advertise_ID;
            }
            set
            {
                _advertise_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Advertise_Advertise_Desc
        {
            get
            {
                return _advertise_Advertise_Desc;
            }
            set
            {
                _advertise_Advertise_Desc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Advertise_KioskOwner_KioskOwner_Code
        {
            get
            {
                return _advertise_KioskOwner_KioskOwner_Code;
            }
            set
            {
                _advertise_KioskOwner_KioskOwner_Code = value;
            }
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
        
        public static List<VSM.Data.Objects.T_Advertise_KioskGroup> Select(System.Guid? advertise_ID, string advertise_Advertise_Desc, string advertise_KioskOwner_KioskOwner_Code, System.Guid? kioskGroup_ID, string kioskGroup_KioskGroup_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new T_Advertise_KioskGroupFactory().Select(advertise_ID, advertise_Advertise_Desc, advertise_KioskOwner_KioskOwner_Code, kioskGroup_ID, kioskGroup_KioskGroup_Name, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.T_Advertise_KioskGroup> Select(VSM.Data.Objects.T_Advertise_KioskGroup qbe)
        {
            return new T_Advertise_KioskGroupFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.T_Advertise_KioskGroup> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new T_Advertise_KioskGroupFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Advertise_KioskGroup> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new T_Advertise_KioskGroupFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Advertise_KioskGroup> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new T_Advertise_KioskGroupFactory().Select(filter, sort, T_Advertise_KioskGroupFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Advertise_KioskGroup> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new T_Advertise_KioskGroupFactory().Select(filter, sort, T_Advertise_KioskGroupFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Advertise_KioskGroup> Select(string filter, BusinessObjectParameters parameters)
        {
            return new T_Advertise_KioskGroupFactory().Select(filter, null, T_Advertise_KioskGroupFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Advertise_KioskGroup> Select(string filter, params FieldValue[] parameters)
        {
            return new T_Advertise_KioskGroupFactory().Select(filter, null, T_Advertise_KioskGroupFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Advertise_KioskGroup SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new T_Advertise_KioskGroupFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.T_Advertise_KioskGroup SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new T_Advertise_KioskGroupFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Advertise_KioskGroup SelectSingle(System.Guid? advertise_ID, System.Guid? kioskGroup_ID)
        {
            return new T_Advertise_KioskGroupFactory().SelectSingle(advertise_ID, kioskGroup_ID);
        }
        
        public int Insert()
        {
            return new T_Advertise_KioskGroupFactory().Insert(this);
        }
        
        public int Update()
        {
            return new T_Advertise_KioskGroupFactory().Update(this);
        }
        
        public int Delete()
        {
            return new T_Advertise_KioskGroupFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Advertise_ID: {0}; KioskGroup_ID: {1}", this.Advertise_ID, this.KioskGroup_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class T_Advertise_KioskGroupFactory
    {
        
        public T_Advertise_KioskGroupFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("T_Advertise_KioskGroup");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("T_Advertise_KioskGroup");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("T_Advertise_KioskGroup");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("T_Advertise_KioskGroup");
            }
        }
        
        public static T_Advertise_KioskGroupFactory Create()
        {
            return new T_Advertise_KioskGroupFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? advertise_ID, string advertise_Advertise_Desc, string advertise_KioskOwner_KioskOwner_Code, System.Guid? kioskGroup_ID, string kioskGroup_KioskGroup_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (advertise_ID.HasValue)
            	filter.Add(("Advertise_ID:=" + advertise_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(advertise_Advertise_Desc)))
            	filter.Add(("Advertise_Advertise_Desc:*" + advertise_Advertise_Desc));
            if (!(String.IsNullOrEmpty(advertise_KioskOwner_KioskOwner_Code)))
            	filter.Add(("Advertise_KioskOwner_KioskOwner_Code:*" + advertise_KioskOwner_KioskOwner_Code));
            if (kioskGroup_ID.HasValue)
            	filter.Add(("KioskGroup_ID:=" + kioskGroup_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskGroup_KioskGroup_Name)))
            	filter.Add(("KioskGroup_KioskGroup_Name:*" + kioskGroup_KioskGroup_Name));
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
        public List<VSM.Data.Objects.T_Advertise_KioskGroup> Select(System.Guid? advertise_ID, string advertise_Advertise_Desc, string advertise_KioskOwner_KioskOwner_Code, System.Guid? kioskGroup_ID, string kioskGroup_KioskGroup_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(advertise_ID, advertise_Advertise_Desc, advertise_KioskOwner_KioskOwner_Code, kioskGroup_ID, kioskGroup_KioskGroup_Name, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Advertise_KioskGroup", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Advertise_KioskGroup>();
        }
        
        public List<VSM.Data.Objects.T_Advertise_KioskGroup> Select(VSM.Data.Objects.T_Advertise_KioskGroup qbe)
        {
            return Select(qbe.Advertise_ID, qbe.Advertise_Advertise_Desc, qbe.Advertise_KioskOwner_KioskOwner_Code, qbe.KioskGroup_ID, qbe.KioskGroup_KioskGroup_Name, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(System.Guid? advertise_ID, string advertise_Advertise_Desc, string advertise_KioskOwner_KioskOwner_Code, System.Guid? kioskGroup_ID, string kioskGroup_KioskGroup_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(advertise_ID, advertise_Advertise_Desc, advertise_KioskOwner_KioskOwner_Code, kioskGroup_ID, kioskGroup_KioskGroup_Name, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Advertise_KioskGroup", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.T_Advertise_KioskGroup> Select(System.Guid? advertise_ID, string advertise_Advertise_Desc, string advertise_KioskOwner_KioskOwner_Code, System.Guid? kioskGroup_ID, string kioskGroup_KioskGroup_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(advertise_ID, advertise_Advertise_Desc, advertise_KioskOwner_KioskOwner_Code, kioskGroup_ID, kioskGroup_KioskGroup_Name, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.T_Advertise_KioskGroup SelectSingle(System.Guid? advertise_ID, System.Guid? kioskGroup_ID)
        {
            List<VSM.Data.Objects.T_Advertise_KioskGroup> list = Select(advertise_ID, null, null, kioskGroup_ID, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.T_Advertise_KioskGroup> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("T_Advertise_KioskGroup", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Advertise_KioskGroup>();
        }
        
        public List<VSM.Data.Objects.T_Advertise_KioskGroup> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.T_Advertise_KioskGroup> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.T_Advertise_KioskGroup SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.T_Advertise_KioskGroup> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.T_Advertise_KioskGroup theT_Advertise_KioskGroup, VSM.Data.Objects.T_Advertise_KioskGroup original_T_Advertise_KioskGroup)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Advertise_ID", original_T_Advertise_KioskGroup.Advertise_ID, theT_Advertise_KioskGroup.Advertise_ID));
            values.Add(new FieldValue("Advertise_Advertise_Desc", original_T_Advertise_KioskGroup.Advertise_Advertise_Desc, theT_Advertise_KioskGroup.Advertise_Advertise_Desc, true));
            values.Add(new FieldValue("Advertise_KioskOwner_KioskOwner_Code", original_T_Advertise_KioskGroup.Advertise_KioskOwner_KioskOwner_Code, theT_Advertise_KioskGroup.Advertise_KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("KioskGroup_ID", original_T_Advertise_KioskGroup.KioskGroup_ID, theT_Advertise_KioskGroup.KioskGroup_ID));
            values.Add(new FieldValue("KioskGroup_KioskGroup_Name", original_T_Advertise_KioskGroup.KioskGroup_KioskGroup_Name, theT_Advertise_KioskGroup.KioskGroup_KioskGroup_Name, true));
            values.Add(new FieldValue("CreatedBy", original_T_Advertise_KioskGroup.CreatedBy, theT_Advertise_KioskGroup.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_T_Advertise_KioskGroup.CreatedOn, theT_Advertise_KioskGroup.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_T_Advertise_KioskGroup.ModifiedBy, theT_Advertise_KioskGroup.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_T_Advertise_KioskGroup.ModifiedOn, theT_Advertise_KioskGroup.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.T_Advertise_KioskGroup theT_Advertise_KioskGroup, VSM.Data.Objects.T_Advertise_KioskGroup original_T_Advertise_KioskGroup, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "T_Advertise_KioskGroup";
            args.View = dataView;
            args.Values = CreateFieldValues(theT_Advertise_KioskGroup, original_T_Advertise_KioskGroup);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("T_Advertise_KioskGroup", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theT_Advertise_KioskGroup);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.T_Advertise_KioskGroup theT_Advertise_KioskGroup, VSM.Data.Objects.T_Advertise_KioskGroup original_T_Advertise_KioskGroup)
        {
            return ExecuteAction(theT_Advertise_KioskGroup, original_T_Advertise_KioskGroup, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.T_Advertise_KioskGroup theT_Advertise_KioskGroup)
        {
            return Update(theT_Advertise_KioskGroup, SelectSingle(theT_Advertise_KioskGroup.Advertise_ID, theT_Advertise_KioskGroup.KioskGroup_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.T_Advertise_KioskGroup theT_Advertise_KioskGroup)
        {
            return ExecuteAction(theT_Advertise_KioskGroup, new T_Advertise_KioskGroup(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.T_Advertise_KioskGroup theT_Advertise_KioskGroup)
        {
            return ExecuteAction(theT_Advertise_KioskGroup, theT_Advertise_KioskGroup, "Select", "Delete", DeleteView);
        }
    }
}

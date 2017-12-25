using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class T_Contents_KioskGroup
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _content_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _content_Content_Desc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _content_KioskOwner_KioskOwner_Code;
        
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
        
        public T_Contents_KioskGroup()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? Content_ID
        {
            get
            {
                return _content_ID;
            }
            set
            {
                _content_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Content_Content_Desc
        {
            get
            {
                return _content_Content_Desc;
            }
            set
            {
                _content_Content_Desc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Content_KioskOwner_KioskOwner_Code
        {
            get
            {
                return _content_KioskOwner_KioskOwner_Code;
            }
            set
            {
                _content_KioskOwner_KioskOwner_Code = value;
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
        
        public static List<VSM.Data.Objects.T_Contents_KioskGroup> Select(System.Guid? content_ID, string content_Content_Desc, string content_KioskOwner_KioskOwner_Code, System.Guid? kioskGroup_ID, string kioskGroup_KioskGroup_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new T_Contents_KioskGroupFactory().Select(content_ID, content_Content_Desc, content_KioskOwner_KioskOwner_Code, kioskGroup_ID, kioskGroup_KioskGroup_Name, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.T_Contents_KioskGroup> Select(VSM.Data.Objects.T_Contents_KioskGroup qbe)
        {
            return new T_Contents_KioskGroupFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.T_Contents_KioskGroup> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new T_Contents_KioskGroupFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Contents_KioskGroup> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new T_Contents_KioskGroupFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Contents_KioskGroup> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new T_Contents_KioskGroupFactory().Select(filter, sort, T_Contents_KioskGroupFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Contents_KioskGroup> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new T_Contents_KioskGroupFactory().Select(filter, sort, T_Contents_KioskGroupFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Contents_KioskGroup> Select(string filter, BusinessObjectParameters parameters)
        {
            return new T_Contents_KioskGroupFactory().Select(filter, null, T_Contents_KioskGroupFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Contents_KioskGroup> Select(string filter, params FieldValue[] parameters)
        {
            return new T_Contents_KioskGroupFactory().Select(filter, null, T_Contents_KioskGroupFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Contents_KioskGroup SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new T_Contents_KioskGroupFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.T_Contents_KioskGroup SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new T_Contents_KioskGroupFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Contents_KioskGroup SelectSingle(System.Guid? content_ID, System.Guid? kioskGroup_ID)
        {
            return new T_Contents_KioskGroupFactory().SelectSingle(content_ID, kioskGroup_ID);
        }
        
        public int Insert()
        {
            return new T_Contents_KioskGroupFactory().Insert(this);
        }
        
        public int Update()
        {
            return new T_Contents_KioskGroupFactory().Update(this);
        }
        
        public int Delete()
        {
            return new T_Contents_KioskGroupFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Content_ID: {0}; KioskGroup_ID: {1}", this.Content_ID, this.KioskGroup_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class T_Contents_KioskGroupFactory
    {
        
        public T_Contents_KioskGroupFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("T_Contents_KioskGroup");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("T_Contents_KioskGroup");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("T_Contents_KioskGroup");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("T_Contents_KioskGroup");
            }
        }
        
        public static T_Contents_KioskGroupFactory Create()
        {
            return new T_Contents_KioskGroupFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? content_ID, string content_Content_Desc, string content_KioskOwner_KioskOwner_Code, System.Guid? kioskGroup_ID, string kioskGroup_KioskGroup_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (content_ID.HasValue)
            	filter.Add(("Content_ID:=" + content_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(content_Content_Desc)))
            	filter.Add(("Content_Content_Desc:*" + content_Content_Desc));
            if (!(String.IsNullOrEmpty(content_KioskOwner_KioskOwner_Code)))
            	filter.Add(("Content_KioskOwner_KioskOwner_Code:*" + content_KioskOwner_KioskOwner_Code));
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
        public List<VSM.Data.Objects.T_Contents_KioskGroup> Select(System.Guid? content_ID, string content_Content_Desc, string content_KioskOwner_KioskOwner_Code, System.Guid? kioskGroup_ID, string kioskGroup_KioskGroup_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(content_ID, content_Content_Desc, content_KioskOwner_KioskOwner_Code, kioskGroup_ID, kioskGroup_KioskGroup_Name, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Contents_KioskGroup", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Contents_KioskGroup>();
        }
        
        public List<VSM.Data.Objects.T_Contents_KioskGroup> Select(VSM.Data.Objects.T_Contents_KioskGroup qbe)
        {
            return Select(qbe.Content_ID, qbe.Content_Content_Desc, qbe.Content_KioskOwner_KioskOwner_Code, qbe.KioskGroup_ID, qbe.KioskGroup_KioskGroup_Name, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(System.Guid? content_ID, string content_Content_Desc, string content_KioskOwner_KioskOwner_Code, System.Guid? kioskGroup_ID, string kioskGroup_KioskGroup_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(content_ID, content_Content_Desc, content_KioskOwner_KioskOwner_Code, kioskGroup_ID, kioskGroup_KioskGroup_Name, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Contents_KioskGroup", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.T_Contents_KioskGroup> Select(System.Guid? content_ID, string content_Content_Desc, string content_KioskOwner_KioskOwner_Code, System.Guid? kioskGroup_ID, string kioskGroup_KioskGroup_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(content_ID, content_Content_Desc, content_KioskOwner_KioskOwner_Code, kioskGroup_ID, kioskGroup_KioskGroup_Name, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.T_Contents_KioskGroup SelectSingle(System.Guid? content_ID, System.Guid? kioskGroup_ID)
        {
            List<VSM.Data.Objects.T_Contents_KioskGroup> list = Select(content_ID, null, null, kioskGroup_ID, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.T_Contents_KioskGroup> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("T_Contents_KioskGroup", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Contents_KioskGroup>();
        }
        
        public List<VSM.Data.Objects.T_Contents_KioskGroup> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.T_Contents_KioskGroup> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.T_Contents_KioskGroup SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.T_Contents_KioskGroup> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.T_Contents_KioskGroup theT_Contents_KioskGroup, VSM.Data.Objects.T_Contents_KioskGroup original_T_Contents_KioskGroup)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Content_ID", original_T_Contents_KioskGroup.Content_ID, theT_Contents_KioskGroup.Content_ID));
            values.Add(new FieldValue("Content_Content_Desc", original_T_Contents_KioskGroup.Content_Content_Desc, theT_Contents_KioskGroup.Content_Content_Desc, true));
            values.Add(new FieldValue("Content_KioskOwner_KioskOwner_Code", original_T_Contents_KioskGroup.Content_KioskOwner_KioskOwner_Code, theT_Contents_KioskGroup.Content_KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("KioskGroup_ID", original_T_Contents_KioskGroup.KioskGroup_ID, theT_Contents_KioskGroup.KioskGroup_ID));
            values.Add(new FieldValue("KioskGroup_KioskGroup_Name", original_T_Contents_KioskGroup.KioskGroup_KioskGroup_Name, theT_Contents_KioskGroup.KioskGroup_KioskGroup_Name, true));
            values.Add(new FieldValue("CreatedBy", original_T_Contents_KioskGroup.CreatedBy, theT_Contents_KioskGroup.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_T_Contents_KioskGroup.CreatedOn, theT_Contents_KioskGroup.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_T_Contents_KioskGroup.ModifiedBy, theT_Contents_KioskGroup.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_T_Contents_KioskGroup.ModifiedOn, theT_Contents_KioskGroup.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.T_Contents_KioskGroup theT_Contents_KioskGroup, VSM.Data.Objects.T_Contents_KioskGroup original_T_Contents_KioskGroup, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "T_Contents_KioskGroup";
            args.View = dataView;
            args.Values = CreateFieldValues(theT_Contents_KioskGroup, original_T_Contents_KioskGroup);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("T_Contents_KioskGroup", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theT_Contents_KioskGroup);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.T_Contents_KioskGroup theT_Contents_KioskGroup, VSM.Data.Objects.T_Contents_KioskGroup original_T_Contents_KioskGroup)
        {
            return ExecuteAction(theT_Contents_KioskGroup, original_T_Contents_KioskGroup, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.T_Contents_KioskGroup theT_Contents_KioskGroup)
        {
            return Update(theT_Contents_KioskGroup, SelectSingle(theT_Contents_KioskGroup.Content_ID, theT_Contents_KioskGroup.KioskGroup_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.T_Contents_KioskGroup theT_Contents_KioskGroup)
        {
            return ExecuteAction(theT_Contents_KioskGroup, new T_Contents_KioskGroup(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.T_Contents_KioskGroup theT_Contents_KioskGroup)
        {
            return ExecuteAction(theT_Contents_KioskGroup, theT_Contents_KioskGroup, "Select", "Delete", DeleteView);
        }
    }
}

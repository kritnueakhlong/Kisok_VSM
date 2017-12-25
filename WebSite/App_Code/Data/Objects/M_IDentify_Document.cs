using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_IDentify_Document
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _idenDoc_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _idenDoc_Name;
        
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
        
        public M_IDentify_Document()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public string IdenDoc_Code
        {
            get
            {
                return _idenDoc_Code;
            }
            set
            {
                _idenDoc_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string IdenDoc_Name
        {
            get
            {
                return _idenDoc_Name;
            }
            set
            {
                _idenDoc_Name = value;
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
        
        public static List<VSM.Data.Objects.M_IDentify_Document> Select(string idenDoc_Code, string idenDoc_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_IDentify_DocumentFactory().Select(idenDoc_Code, idenDoc_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_IDentify_Document> Select(VSM.Data.Objects.M_IDentify_Document qbe)
        {
            return new M_IDentify_DocumentFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_IDentify_Document> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_IDentify_DocumentFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_IDentify_Document> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_IDentify_DocumentFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_IDentify_Document> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_IDentify_DocumentFactory().Select(filter, sort, M_IDentify_DocumentFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_IDentify_Document> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_IDentify_DocumentFactory().Select(filter, sort, M_IDentify_DocumentFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_IDentify_Document> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_IDentify_DocumentFactory().Select(filter, null, M_IDentify_DocumentFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_IDentify_Document> Select(string filter, params FieldValue[] parameters)
        {
            return new M_IDentify_DocumentFactory().Select(filter, null, M_IDentify_DocumentFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_IDentify_Document SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_IDentify_DocumentFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_IDentify_Document SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_IDentify_DocumentFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_IDentify_Document SelectSingle(string idenDoc_Code)
        {
            return new M_IDentify_DocumentFactory().SelectSingle(idenDoc_Code);
        }
        
        public int Insert()
        {
            return new M_IDentify_DocumentFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_IDentify_DocumentFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_IDentify_DocumentFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IdenDoc_Code: {0}", this.IdenDoc_Code);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_IDentify_DocumentFactory
    {
        
        public M_IDentify_DocumentFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_IDentify_Document");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_IDentify_Document");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_IDentify_Document");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_IDentify_Document");
            }
        }
        
        public static M_IDentify_DocumentFactory Create()
        {
            return new M_IDentify_DocumentFactory();
        }
        
        protected virtual PageRequest CreateRequest(string idenDoc_Code, string idenDoc_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (idenDoc_Code != null)
            	filter.Add(("IdenDoc_Code:=" + idenDoc_Code));
            if (!(String.IsNullOrEmpty(idenDoc_Name)))
            	filter.Add(("IdenDoc_Name:*" + idenDoc_Name));
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
        public List<VSM.Data.Objects.M_IDentify_Document> Select(string idenDoc_Code, string idenDoc_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(idenDoc_Code, idenDoc_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_IDentify_Document", dataView, request);
            return page.ToList<VSM.Data.Objects.M_IDentify_Document>();
        }
        
        public List<VSM.Data.Objects.M_IDentify_Document> Select(VSM.Data.Objects.M_IDentify_Document qbe)
        {
            return Select(qbe.IdenDoc_Code, qbe.IdenDoc_Name, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(string idenDoc_Code, string idenDoc_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(idenDoc_Code, idenDoc_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_IDentify_Document", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_IDentify_Document> Select(string idenDoc_Code, string idenDoc_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(idenDoc_Code, idenDoc_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_IDentify_Document SelectSingle(string idenDoc_Code)
        {
            List<VSM.Data.Objects.M_IDentify_Document> list = Select(idenDoc_Code, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_IDentify_Document> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_IDentify_Document", dataView, request);
            return page.ToList<VSM.Data.Objects.M_IDentify_Document>();
        }
        
        public List<VSM.Data.Objects.M_IDentify_Document> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_IDentify_Document> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_IDentify_Document SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_IDentify_Document> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_IDentify_Document theM_IDentify_Document, VSM.Data.Objects.M_IDentify_Document original_M_IDentify_Document)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IdenDoc_Code", original_M_IDentify_Document.IdenDoc_Code, theM_IDentify_Document.IdenDoc_Code));
            values.Add(new FieldValue("IdenDoc_Name", original_M_IDentify_Document.IdenDoc_Name, theM_IDentify_Document.IdenDoc_Name));
            values.Add(new FieldValue("Item_Flag", original_M_IDentify_Document.Item_Flag, theM_IDentify_Document.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_IDentify_Document.CreatedBy, theM_IDentify_Document.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_IDentify_Document.CreatedOn, theM_IDentify_Document.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_IDentify_Document.ModifiedBy, theM_IDentify_Document.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_IDentify_Document.ModifiedOn, theM_IDentify_Document.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_IDentify_Document theM_IDentify_Document, VSM.Data.Objects.M_IDentify_Document original_M_IDentify_Document, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_IDentify_Document";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_IDentify_Document, original_M_IDentify_Document);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_IDentify_Document", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_IDentify_Document);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_IDentify_Document theM_IDentify_Document, VSM.Data.Objects.M_IDentify_Document original_M_IDentify_Document)
        {
            return ExecuteAction(theM_IDentify_Document, original_M_IDentify_Document, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_IDentify_Document theM_IDentify_Document)
        {
            return Update(theM_IDentify_Document, SelectSingle(theM_IDentify_Document.IdenDoc_Code));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_IDentify_Document theM_IDentify_Document)
        {
            return ExecuteAction(theM_IDentify_Document, new M_IDentify_Document(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_IDentify_Document theM_IDentify_Document)
        {
            return ExecuteAction(theM_IDentify_Document, theM_IDentify_Document, "Select", "Delete", DeleteView);
        }
    }
}

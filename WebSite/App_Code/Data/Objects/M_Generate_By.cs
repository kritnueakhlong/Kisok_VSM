using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_Generate_By
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _genBy_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _genBy_Name;
        
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
        
        public M_Generate_By()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public string GenBy_Code
        {
            get
            {
                return _genBy_Code;
            }
            set
            {
                _genBy_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string GenBy_Name
        {
            get
            {
                return _genBy_Name;
            }
            set
            {
                _genBy_Name = value;
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
        
        public static List<VSM.Data.Objects.M_Generate_By> Select(string genBy_Code, string genBy_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_Generate_ByFactory().Select(genBy_Code, genBy_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_Generate_By> Select(VSM.Data.Objects.M_Generate_By qbe)
        {
            return new M_Generate_ByFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_Generate_By> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_Generate_ByFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Generate_By> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_Generate_ByFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Generate_By> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_Generate_ByFactory().Select(filter, sort, M_Generate_ByFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Generate_By> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_Generate_ByFactory().Select(filter, sort, M_Generate_ByFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Generate_By> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_Generate_ByFactory().Select(filter, null, M_Generate_ByFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Generate_By> Select(string filter, params FieldValue[] parameters)
        {
            return new M_Generate_ByFactory().Select(filter, null, M_Generate_ByFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Generate_By SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_Generate_ByFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_Generate_By SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_Generate_ByFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Generate_By SelectSingle(string genBy_Code)
        {
            return new M_Generate_ByFactory().SelectSingle(genBy_Code);
        }
        
        public int Insert()
        {
            return new M_Generate_ByFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_Generate_ByFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_Generate_ByFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("GenBy_Code: {0}", this.GenBy_Code);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_Generate_ByFactory
    {
        
        public M_Generate_ByFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_Generate_By");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_Generate_By");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_Generate_By");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_Generate_By");
            }
        }
        
        public static M_Generate_ByFactory Create()
        {
            return new M_Generate_ByFactory();
        }
        
        protected virtual PageRequest CreateRequest(string genBy_Code, string genBy_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (genBy_Code != null)
            	filter.Add(("GenBy_Code:=" + genBy_Code));
            if (!(String.IsNullOrEmpty(genBy_Name)))
            	filter.Add(("GenBy_Name:*" + genBy_Name));
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
        public List<VSM.Data.Objects.M_Generate_By> Select(string genBy_Code, string genBy_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(genBy_Code, genBy_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Generate_By", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Generate_By>();
        }
        
        public List<VSM.Data.Objects.M_Generate_By> Select(VSM.Data.Objects.M_Generate_By qbe)
        {
            return Select(qbe.GenBy_Code, qbe.GenBy_Name, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(string genBy_Code, string genBy_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(genBy_Code, genBy_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Generate_By", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_Generate_By> Select(string genBy_Code, string genBy_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(genBy_Code, genBy_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_Generate_By SelectSingle(string genBy_Code)
        {
            List<VSM.Data.Objects.M_Generate_By> list = Select(genBy_Code, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_Generate_By> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_Generate_By", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Generate_By>();
        }
        
        public List<VSM.Data.Objects.M_Generate_By> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_Generate_By> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_Generate_By SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_Generate_By> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_Generate_By theM_Generate_By, VSM.Data.Objects.M_Generate_By original_M_Generate_By)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("GenBy_Code", original_M_Generate_By.GenBy_Code, theM_Generate_By.GenBy_Code));
            values.Add(new FieldValue("GenBy_Name", original_M_Generate_By.GenBy_Name, theM_Generate_By.GenBy_Name));
            values.Add(new FieldValue("Item_Flag", original_M_Generate_By.Item_Flag, theM_Generate_By.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_Generate_By.CreatedBy, theM_Generate_By.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_Generate_By.CreatedOn, theM_Generate_By.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_Generate_By.ModifiedBy, theM_Generate_By.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_Generate_By.ModifiedOn, theM_Generate_By.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_Generate_By theM_Generate_By, VSM.Data.Objects.M_Generate_By original_M_Generate_By, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_Generate_By";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_Generate_By, original_M_Generate_By);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_Generate_By", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_Generate_By);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_Generate_By theM_Generate_By, VSM.Data.Objects.M_Generate_By original_M_Generate_By)
        {
            return ExecuteAction(theM_Generate_By, original_M_Generate_By, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_Generate_By theM_Generate_By)
        {
            return Update(theM_Generate_By, SelectSingle(theM_Generate_By.GenBy_Code));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_Generate_By theM_Generate_By)
        {
            return ExecuteAction(theM_Generate_By, new M_Generate_By(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_Generate_By theM_Generate_By)
        {
            return ExecuteAction(theM_Generate_By, theM_Generate_By, "Select", "Delete", DeleteView);
        }
    }
}

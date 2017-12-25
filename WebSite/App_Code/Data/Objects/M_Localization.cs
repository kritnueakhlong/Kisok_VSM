using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_Localization
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locale_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locale_Name;
        
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
        
        public M_Localization()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Locale_Name
        {
            get
            {
                return _locale_Name;
            }
            set
            {
                _locale_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        public static List<VSM.Data.Objects.M_Localization> Select(string locale_Code, string locale_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_LocalizationFactory().Select(locale_Code, locale_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_Localization> Select(VSM.Data.Objects.M_Localization qbe)
        {
            return new M_LocalizationFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_Localization> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_LocalizationFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Localization> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_LocalizationFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Localization> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_LocalizationFactory().Select(filter, sort, M_LocalizationFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Localization> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_LocalizationFactory().Select(filter, sort, M_LocalizationFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Localization> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_LocalizationFactory().Select(filter, null, M_LocalizationFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Localization> Select(string filter, params FieldValue[] parameters)
        {
            return new M_LocalizationFactory().Select(filter, null, M_LocalizationFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Localization SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_LocalizationFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_Localization SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_LocalizationFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Localization SelectSingle(string locale_Code)
        {
            return new M_LocalizationFactory().SelectSingle(locale_Code);
        }
        
        public int Insert()
        {
            return new M_LocalizationFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_LocalizationFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_LocalizationFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Locale_Code: {0}", this.Locale_Code);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_LocalizationFactory
    {
        
        public M_LocalizationFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_Localization");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_Localization");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_Localization");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_Localization");
            }
        }
        
        public static M_LocalizationFactory Create()
        {
            return new M_LocalizationFactory();
        }
        
        protected virtual PageRequest CreateRequest(string locale_Code, string locale_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (locale_Code != null)
            	filter.Add(("Locale_Code:=" + locale_Code));
            if (!(String.IsNullOrEmpty(locale_Name)))
            	filter.Add(("Locale_Name:*" + locale_Name));
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
        public List<VSM.Data.Objects.M_Localization> Select(string locale_Code, string locale_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(locale_Code, locale_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Localization", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Localization>();
        }
        
        public List<VSM.Data.Objects.M_Localization> Select(VSM.Data.Objects.M_Localization qbe)
        {
            return Select(qbe.Locale_Code, qbe.Locale_Name, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(string locale_Code, string locale_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(locale_Code, locale_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Localization", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_Localization> Select(string locale_Code, string locale_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(locale_Code, locale_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_Localization SelectSingle(string locale_Code)
        {
            List<VSM.Data.Objects.M_Localization> list = Select(locale_Code, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_Localization> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_Localization", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Localization>();
        }
        
        public List<VSM.Data.Objects.M_Localization> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_Localization> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_Localization SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_Localization> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_Localization theM_Localization, VSM.Data.Objects.M_Localization original_M_Localization)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Locale_Code", original_M_Localization.Locale_Code, theM_Localization.Locale_Code));
            values.Add(new FieldValue("Locale_Name", original_M_Localization.Locale_Name, theM_Localization.Locale_Name));
            values.Add(new FieldValue("Item_Flag", original_M_Localization.Item_Flag, theM_Localization.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_Localization.CreatedBy, theM_Localization.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_Localization.CreatedOn, theM_Localization.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_Localization.ModifiedBy, theM_Localization.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_Localization.ModifiedOn, theM_Localization.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_Localization theM_Localization, VSM.Data.Objects.M_Localization original_M_Localization, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_Localization";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_Localization, original_M_Localization);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_Localization", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_Localization);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_Localization theM_Localization, VSM.Data.Objects.M_Localization original_M_Localization)
        {
            return ExecuteAction(theM_Localization, original_M_Localization, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_Localization theM_Localization)
        {
            return Update(theM_Localization, SelectSingle(theM_Localization.Locale_Code));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_Localization theM_Localization)
        {
            return ExecuteAction(theM_Localization, new M_Localization(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_Localization theM_Localization)
        {
            return ExecuteAction(theM_Localization, theM_Localization, "Select", "Delete", DeleteView);
        }
    }
}

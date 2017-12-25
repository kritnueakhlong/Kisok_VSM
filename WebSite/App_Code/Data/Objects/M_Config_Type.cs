using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_Config_Type
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _configType_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _configType_Name;
        
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
        
        public M_Config_Type()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public string ConfigType_Code
        {
            get
            {
                return _configType_Code;
            }
            set
            {
                _configType_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string ConfigType_Name
        {
            get
            {
                return _configType_Name;
            }
            set
            {
                _configType_Name = value;
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
        
        public static List<VSM.Data.Objects.M_Config_Type> Select(string configType_Code, string configType_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_Config_TypeFactory().Select(configType_Code, configType_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_Config_Type> Select(VSM.Data.Objects.M_Config_Type qbe)
        {
            return new M_Config_TypeFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_Config_Type> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_Config_TypeFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Config_Type> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_Config_TypeFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Config_Type> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_Config_TypeFactory().Select(filter, sort, M_Config_TypeFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Config_Type> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_Config_TypeFactory().Select(filter, sort, M_Config_TypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Config_Type> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_Config_TypeFactory().Select(filter, null, M_Config_TypeFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Config_Type> Select(string filter, params FieldValue[] parameters)
        {
            return new M_Config_TypeFactory().Select(filter, null, M_Config_TypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Config_Type SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_Config_TypeFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_Config_Type SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_Config_TypeFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Config_Type SelectSingle(string configType_Code)
        {
            return new M_Config_TypeFactory().SelectSingle(configType_Code);
        }
        
        public int Insert()
        {
            return new M_Config_TypeFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_Config_TypeFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_Config_TypeFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("ConfigType_Code: {0}", this.ConfigType_Code);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_Config_TypeFactory
    {
        
        public M_Config_TypeFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_Config_Type");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_Config_Type");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_Config_Type");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_Config_Type");
            }
        }
        
        public static M_Config_TypeFactory Create()
        {
            return new M_Config_TypeFactory();
        }
        
        protected virtual PageRequest CreateRequest(string configType_Code, string configType_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (configType_Code != null)
            	filter.Add(("ConfigType_Code:=" + configType_Code));
            if (!(String.IsNullOrEmpty(configType_Name)))
            	filter.Add(("ConfigType_Name:*" + configType_Name));
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
        public List<VSM.Data.Objects.M_Config_Type> Select(string configType_Code, string configType_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(configType_Code, configType_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Config_Type", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Config_Type>();
        }
        
        public List<VSM.Data.Objects.M_Config_Type> Select(VSM.Data.Objects.M_Config_Type qbe)
        {
            return Select(qbe.ConfigType_Code, qbe.ConfigType_Name, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(string configType_Code, string configType_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(configType_Code, configType_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Config_Type", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_Config_Type> Select(string configType_Code, string configType_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(configType_Code, configType_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_Config_Type SelectSingle(string configType_Code)
        {
            List<VSM.Data.Objects.M_Config_Type> list = Select(configType_Code, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_Config_Type> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_Config_Type", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Config_Type>();
        }
        
        public List<VSM.Data.Objects.M_Config_Type> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_Config_Type> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_Config_Type SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_Config_Type> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_Config_Type theM_Config_Type, VSM.Data.Objects.M_Config_Type original_M_Config_Type)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("ConfigType_Code", original_M_Config_Type.ConfigType_Code, theM_Config_Type.ConfigType_Code));
            values.Add(new FieldValue("ConfigType_Name", original_M_Config_Type.ConfigType_Name, theM_Config_Type.ConfigType_Name));
            values.Add(new FieldValue("Item_Flag", original_M_Config_Type.Item_Flag, theM_Config_Type.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_Config_Type.CreatedBy, theM_Config_Type.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_Config_Type.CreatedOn, theM_Config_Type.CreatedOn, true));
            values.Add(new FieldValue("ModifiedBy", original_M_Config_Type.ModifiedBy, theM_Config_Type.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_Config_Type.ModifiedOn, theM_Config_Type.ModifiedOn, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_Config_Type theM_Config_Type, VSM.Data.Objects.M_Config_Type original_M_Config_Type, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_Config_Type";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_Config_Type, original_M_Config_Type);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_Config_Type", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_Config_Type);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_Config_Type theM_Config_Type, VSM.Data.Objects.M_Config_Type original_M_Config_Type)
        {
            return ExecuteAction(theM_Config_Type, original_M_Config_Type, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_Config_Type theM_Config_Type)
        {
            return Update(theM_Config_Type, SelectSingle(theM_Config_Type.ConfigType_Code));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_Config_Type theM_Config_Type)
        {
            return ExecuteAction(theM_Config_Type, new M_Config_Type(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_Config_Type theM_Config_Type)
        {
            return ExecuteAction(theM_Config_Type, theM_Config_Type, "Select", "Delete", DeleteView);
        }
    }
}

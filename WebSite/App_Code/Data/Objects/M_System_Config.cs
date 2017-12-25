using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_System_Config
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _config_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _configType_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _configType_ConfigType_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _config_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _config_Desc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _config_Value;
        
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
        
        public M_System_Config()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? Config_ID
        {
            get
            {
                return _config_ID;
            }
            set
            {
                _config_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ConfigType_ConfigType_Name
        {
            get
            {
                return _configType_ConfigType_Name;
            }
            set
            {
                _configType_ConfigType_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Config_Name
        {
            get
            {
                return _config_Name;
            }
            set
            {
                _config_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Config_Desc
        {
            get
            {
                return _config_Desc;
            }
            set
            {
                _config_Desc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Config_Value
        {
            get
            {
                return _config_Value;
            }
            set
            {
                _config_Value = value;
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
        
        public static List<VSM.Data.Objects.M_System_Config> Select(System.Guid? config_ID, string configType_Code, string configType_ConfigType_Name, string config_Name, string config_Desc, string config_Value, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_System_ConfigFactory().Select(config_ID, configType_Code, configType_ConfigType_Name, config_Name, config_Desc, config_Value, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_System_Config> Select(VSM.Data.Objects.M_System_Config qbe)
        {
            return new M_System_ConfigFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_System_Config> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_System_ConfigFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_System_Config> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_System_ConfigFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_System_Config> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_System_ConfigFactory().Select(filter, sort, M_System_ConfigFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_System_Config> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_System_ConfigFactory().Select(filter, sort, M_System_ConfigFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_System_Config> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_System_ConfigFactory().Select(filter, null, M_System_ConfigFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_System_Config> Select(string filter, params FieldValue[] parameters)
        {
            return new M_System_ConfigFactory().Select(filter, null, M_System_ConfigFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_System_Config SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_System_ConfigFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_System_Config SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_System_ConfigFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_System_Config SelectSingle(System.Guid? config_ID)
        {
            return new M_System_ConfigFactory().SelectSingle(config_ID);
        }
        
        public int Insert()
        {
            return new M_System_ConfigFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_System_ConfigFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_System_ConfigFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Config_ID: {0}", this.Config_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_System_ConfigFactory
    {
        
        public M_System_ConfigFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_System_Config");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_System_Config");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_System_Config");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_System_Config");
            }
        }
        
        public static M_System_ConfigFactory Create()
        {
            return new M_System_ConfigFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? config_ID, string configType_Code, string configType_ConfigType_Name, string config_Name, string config_Desc, string config_Value, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (config_ID.HasValue)
            	filter.Add(("Config_ID:=" + config_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(configType_Code)))
            	filter.Add(("ConfigType_Code:*" + configType_Code));
            if (!(String.IsNullOrEmpty(configType_ConfigType_Name)))
            	filter.Add(("ConfigType_ConfigType_Name:*" + configType_ConfigType_Name));
            if (!(String.IsNullOrEmpty(config_Name)))
            	filter.Add(("Config_Name:*" + config_Name));
            if (!(String.IsNullOrEmpty(config_Desc)))
            	filter.Add(("Config_Desc:*" + config_Desc));
            if (!(String.IsNullOrEmpty(config_Value)))
            	filter.Add(("Config_Value:*" + config_Value));
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
        public List<VSM.Data.Objects.M_System_Config> Select(System.Guid? config_ID, string configType_Code, string configType_ConfigType_Name, string config_Name, string config_Desc, string config_Value, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(config_ID, configType_Code, configType_ConfigType_Name, config_Name, config_Desc, config_Value, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_System_Config", dataView, request);
            return page.ToList<VSM.Data.Objects.M_System_Config>();
        }
        
        public List<VSM.Data.Objects.M_System_Config> Select(VSM.Data.Objects.M_System_Config qbe)
        {
            return Select(qbe.Config_ID, qbe.ConfigType_Code, qbe.ConfigType_ConfigType_Name, qbe.Config_Name, qbe.Config_Desc, qbe.Config_Value, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(System.Guid? config_ID, string configType_Code, string configType_ConfigType_Name, string config_Name, string config_Desc, string config_Value, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(config_ID, configType_Code, configType_ConfigType_Name, config_Name, config_Desc, config_Value, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_System_Config", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_System_Config> Select(System.Guid? config_ID, string configType_Code, string configType_ConfigType_Name, string config_Name, string config_Desc, string config_Value, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(config_ID, configType_Code, configType_ConfigType_Name, config_Name, config_Desc, config_Value, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_System_Config SelectSingle(System.Guid? config_ID)
        {
            List<VSM.Data.Objects.M_System_Config> list = Select(config_ID, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_System_Config> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_System_Config", dataView, request);
            return page.ToList<VSM.Data.Objects.M_System_Config>();
        }
        
        public List<VSM.Data.Objects.M_System_Config> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_System_Config> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_System_Config SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_System_Config> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_System_Config theM_System_Config, VSM.Data.Objects.M_System_Config original_M_System_Config)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Config_ID", original_M_System_Config.Config_ID, theM_System_Config.Config_ID));
            values.Add(new FieldValue("ConfigType_Code", original_M_System_Config.ConfigType_Code, theM_System_Config.ConfigType_Code, true));
            values.Add(new FieldValue("ConfigType_ConfigType_Name", original_M_System_Config.ConfigType_ConfigType_Name, theM_System_Config.ConfigType_ConfigType_Name, true));
            values.Add(new FieldValue("Config_Name", original_M_System_Config.Config_Name, theM_System_Config.Config_Name));
            values.Add(new FieldValue("Config_Desc", original_M_System_Config.Config_Desc, theM_System_Config.Config_Desc));
            values.Add(new FieldValue("Config_Value", original_M_System_Config.Config_Value, theM_System_Config.Config_Value));
            values.Add(new FieldValue("Item_Flag", original_M_System_Config.Item_Flag, theM_System_Config.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_System_Config.CreatedBy, theM_System_Config.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_System_Config.CreatedOn, theM_System_Config.CreatedOn, true));
            values.Add(new FieldValue("ModifiedBy", original_M_System_Config.ModifiedBy, theM_System_Config.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_System_Config.ModifiedOn, theM_System_Config.ModifiedOn, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_System_Config theM_System_Config, VSM.Data.Objects.M_System_Config original_M_System_Config, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_System_Config";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_System_Config, original_M_System_Config);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_System_Config", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_System_Config);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_System_Config theM_System_Config, VSM.Data.Objects.M_System_Config original_M_System_Config)
        {
            return ExecuteAction(theM_System_Config, original_M_System_Config, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_System_Config theM_System_Config)
        {
            return Update(theM_System_Config, SelectSingle(theM_System_Config.Config_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_System_Config theM_System_Config)
        {
            return ExecuteAction(theM_System_Config, new M_System_Config(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_System_Config theM_System_Config)
        {
            return ExecuteAction(theM_System_Config, theM_System_Config, "Select", "Delete", DeleteView);
        }
    }
}

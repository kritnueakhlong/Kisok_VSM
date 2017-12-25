using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_KioskOwner_Config
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_Branch_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Branch_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _config_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _configType_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _configType_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _config_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _config_Desc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _config_Value;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        public M_KioskOwner_Config()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? KioskOwner_Branch_ID
        {
            get
            {
                return _kioskOwner_Branch_ID;
            }
            set
            {
                _kioskOwner_Branch_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string KioskOwner_Branch_Code
        {
            get
            {
                return _kioskOwner_Branch_Code;
            }
            set
            {
                _kioskOwner_Branch_Code = value;
            }
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        public static List<VSM.Data.Objects.M_KioskOwner_Config> Select(System.Guid? kioskOwner_Branch_ID, string kioskOwner_Branch_Code, System.Guid? config_ID, string configType_Code, string configType_Name, string config_Value, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_KioskOwner_ConfigFactory().Select(kioskOwner_Branch_ID, kioskOwner_Branch_Code, config_ID, configType_Code, configType_Name, config_Value, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Config> Select(VSM.Data.Objects.M_KioskOwner_Config qbe)
        {
            return new M_KioskOwner_ConfigFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Config> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_KioskOwner_ConfigFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Config> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_KioskOwner_ConfigFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Config> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_KioskOwner_ConfigFactory().Select(filter, sort, M_KioskOwner_ConfigFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Config> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_KioskOwner_ConfigFactory().Select(filter, sort, M_KioskOwner_ConfigFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Config> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_KioskOwner_ConfigFactory().Select(filter, null, M_KioskOwner_ConfigFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Config> Select(string filter, params FieldValue[] parameters)
        {
            return new M_KioskOwner_ConfigFactory().Select(filter, null, M_KioskOwner_ConfigFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_KioskOwner_Config SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_KioskOwner_ConfigFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_KioskOwner_Config SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_KioskOwner_ConfigFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_KioskOwner_Config SelectSingle(System.Guid? kioskOwner_Branch_ID, System.Guid? config_ID)
        {
            return new M_KioskOwner_ConfigFactory().SelectSingle(kioskOwner_Branch_ID, config_ID);
        }
        
        public int Insert()
        {
            return new M_KioskOwner_ConfigFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_KioskOwner_ConfigFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_KioskOwner_ConfigFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("KioskOwner_Branch_ID: {0}; Config_ID: {1}", this.KioskOwner_Branch_ID, this.Config_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_KioskOwner_ConfigFactory
    {
        
        public M_KioskOwner_ConfigFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_KioskOwner_Config");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_KioskOwner_Config");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_KioskOwner_Config");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_KioskOwner_Config");
            }
        }
        
        public static M_KioskOwner_ConfigFactory Create()
        {
            return new M_KioskOwner_ConfigFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? kioskOwner_Branch_ID, string kioskOwner_Branch_Code, System.Guid? config_ID, string configType_Code, string configType_Name, string config_Value, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (kioskOwner_Branch_ID.HasValue)
            	filter.Add(("KioskOwner_Branch_ID:=" + kioskOwner_Branch_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_Branch_Code)))
            	filter.Add(("KioskOwner_Branch_Code:*" + kioskOwner_Branch_Code));
            if (config_ID.HasValue)
            	filter.Add(("Config_ID:=" + config_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(configType_Code)))
            	filter.Add(("ConfigType_Code:*" + configType_Code));
            if (!(String.IsNullOrEmpty(configType_Name)))
            	filter.Add(("ConfigType_Name:*" + configType_Name));
            if (!(String.IsNullOrEmpty(config_Value)))
            	filter.Add(("Config_Value:*" + config_Value));
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
        public List<VSM.Data.Objects.M_KioskOwner_Config> Select(System.Guid? kioskOwner_Branch_ID, string kioskOwner_Branch_Code, System.Guid? config_ID, string configType_Code, string configType_Name, string config_Value, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kioskOwner_Branch_ID, kioskOwner_Branch_Code, config_ID, configType_Code, configType_Name, config_Value, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_KioskOwner_Config", dataView, request);
            return page.ToList<VSM.Data.Objects.M_KioskOwner_Config>();
        }
        
        public List<VSM.Data.Objects.M_KioskOwner_Config> Select(VSM.Data.Objects.M_KioskOwner_Config qbe)
        {
            return Select(qbe.KioskOwner_Branch_ID, qbe.KioskOwner_Branch_Code, qbe.Config_ID, qbe.ConfigType_Code, qbe.ConfigType_Name, qbe.Config_Value, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(System.Guid? kioskOwner_Branch_ID, string kioskOwner_Branch_Code, System.Guid? config_ID, string configType_Code, string configType_Name, string config_Value, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kioskOwner_Branch_ID, kioskOwner_Branch_Code, config_ID, configType_Code, configType_Name, config_Value, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_KioskOwner_Config", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_KioskOwner_Config> Select(System.Guid? kioskOwner_Branch_ID, string kioskOwner_Branch_Code, System.Guid? config_ID, string configType_Code, string configType_Name, string config_Value, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(kioskOwner_Branch_ID, kioskOwner_Branch_Code, config_ID, configType_Code, configType_Name, config_Value, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_KioskOwner_Config SelectSingle(System.Guid? kioskOwner_Branch_ID, System.Guid? config_ID)
        {
            List<VSM.Data.Objects.M_KioskOwner_Config> list = Select(kioskOwner_Branch_ID, null, config_ID, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_KioskOwner_Config> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_KioskOwner_Config", dataView, request);
            return page.ToList<VSM.Data.Objects.M_KioskOwner_Config>();
        }
        
        public List<VSM.Data.Objects.M_KioskOwner_Config> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_KioskOwner_Config> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_KioskOwner_Config SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_KioskOwner_Config> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_KioskOwner_Config theM_KioskOwner_Config, VSM.Data.Objects.M_KioskOwner_Config original_M_KioskOwner_Config)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("KioskOwner_Branch_ID", original_M_KioskOwner_Config.KioskOwner_Branch_ID, theM_KioskOwner_Config.KioskOwner_Branch_ID));
            values.Add(new FieldValue("KioskOwner_Branch_Code", original_M_KioskOwner_Config.KioskOwner_Branch_Code, theM_KioskOwner_Config.KioskOwner_Branch_Code, true));
            values.Add(new FieldValue("Config_ID", original_M_KioskOwner_Config.Config_ID, theM_KioskOwner_Config.Config_ID));
            values.Add(new FieldValue("ConfigType_Code", original_M_KioskOwner_Config.ConfigType_Code, theM_KioskOwner_Config.ConfigType_Code, true));
            values.Add(new FieldValue("ConfigType_Name", original_M_KioskOwner_Config.ConfigType_Name, theM_KioskOwner_Config.ConfigType_Name, true));
            values.Add(new FieldValue("Config_Name", original_M_KioskOwner_Config.Config_Name, theM_KioskOwner_Config.Config_Name));
            values.Add(new FieldValue("Config_Desc", original_M_KioskOwner_Config.Config_Desc, theM_KioskOwner_Config.Config_Desc));
            values.Add(new FieldValue("Config_Value", original_M_KioskOwner_Config.Config_Value, theM_KioskOwner_Config.Config_Value));
            values.Add(new FieldValue("CreatedBy", original_M_KioskOwner_Config.CreatedBy, theM_KioskOwner_Config.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_KioskOwner_Config.CreatedOn, theM_KioskOwner_Config.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_KioskOwner_Config.ModifiedBy, theM_KioskOwner_Config.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_KioskOwner_Config.ModifiedOn, theM_KioskOwner_Config.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_KioskOwner_Config theM_KioskOwner_Config, VSM.Data.Objects.M_KioskOwner_Config original_M_KioskOwner_Config, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_KioskOwner_Config";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_KioskOwner_Config, original_M_KioskOwner_Config);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_KioskOwner_Config", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_KioskOwner_Config);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_KioskOwner_Config theM_KioskOwner_Config, VSM.Data.Objects.M_KioskOwner_Config original_M_KioskOwner_Config)
        {
            return ExecuteAction(theM_KioskOwner_Config, original_M_KioskOwner_Config, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_KioskOwner_Config theM_KioskOwner_Config)
        {
            return Update(theM_KioskOwner_Config, SelectSingle(theM_KioskOwner_Config.KioskOwner_Branch_ID, theM_KioskOwner_Config.Config_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_KioskOwner_Config theM_KioskOwner_Config)
        {
            return ExecuteAction(theM_KioskOwner_Config, new M_KioskOwner_Config(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_KioskOwner_Config theM_KioskOwner_Config)
        {
            return ExecuteAction(theM_KioskOwner_Config, theM_KioskOwner_Config, "Select", "Delete", DeleteView);
        }
    }
}

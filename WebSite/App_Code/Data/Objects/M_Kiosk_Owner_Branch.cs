using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_Kiosk_Owner_Branch
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_Branch_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Branch_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Branch_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Branch_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _kioskOwner_Branch_LAT;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _kioskOwner_Branch_LONG;
        
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
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _configs;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _configValue;
        
        public M_Kiosk_Owner_Branch()
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public System.Guid? KioskOwner_ID
        {
            get
            {
                return _kioskOwner_ID;
            }
            set
            {
                _kioskOwner_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string KioskOwner_Branch_Name
        {
            get
            {
                return _kioskOwner_Branch_Name;
            }
            set
            {
                _kioskOwner_Branch_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string KioskOwner_Branch_Address
        {
            get
            {
                return _kioskOwner_Branch_Address;
            }
            set
            {
                _kioskOwner_Branch_Address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? KioskOwner_Branch_LAT
        {
            get
            {
                return _kioskOwner_Branch_LAT;
            }
            set
            {
                _kioskOwner_Branch_LAT = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? KioskOwner_Branch_LONG
        {
            get
            {
                return _kioskOwner_Branch_LONG;
            }
            set
            {
                _kioskOwner_Branch_LONG = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Configs
        {
            get
            {
                return _configs;
            }
            set
            {
                _configs = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string KioskOwner_Code
        {
            get
            {
                return _kioskOwner_Code;
            }
            set
            {
                _kioskOwner_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string ConfigValue
        {
            get
            {
                return _configValue;
            }
            set
            {
                _configValue = value;
            }
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner_Branch> Select(System.Guid? kioskOwner_Branch_ID, string kioskOwner_Branch_Code, string kioskOwner_Branch_Name, string kioskOwner_Branch_Address, decimal? kioskOwner_Branch_LAT, decimal? kioskOwner_Branch_LONG, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_Kiosk_Owner_BranchFactory().Select(kioskOwner_Branch_ID, kioskOwner_Branch_Code, kioskOwner_Branch_Name, kioskOwner_Branch_Address, kioskOwner_Branch_LAT, kioskOwner_Branch_LONG, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner_Branch> Select(VSM.Data.Objects.M_Kiosk_Owner_Branch qbe)
        {
            return new M_Kiosk_Owner_BranchFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner_Branch> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_Owner_BranchFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner_Branch> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_Kiosk_Owner_BranchFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner_Branch> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_Owner_BranchFactory().Select(filter, sort, M_Kiosk_Owner_BranchFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner_Branch> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_Kiosk_Owner_BranchFactory().Select(filter, sort, M_Kiosk_Owner_BranchFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner_Branch> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_Owner_BranchFactory().Select(filter, null, M_Kiosk_Owner_BranchFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner_Branch> Select(string filter, params FieldValue[] parameters)
        {
            return new M_Kiosk_Owner_BranchFactory().Select(filter, null, M_Kiosk_Owner_BranchFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Kiosk_Owner_Branch SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_Owner_BranchFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_Kiosk_Owner_Branch SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_Kiosk_Owner_BranchFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Kiosk_Owner_Branch SelectSingle(System.Guid? kioskOwner_Branch_ID)
        {
            return new M_Kiosk_Owner_BranchFactory().SelectSingle(kioskOwner_Branch_ID);
        }
        
        public int Insert()
        {
            return new M_Kiosk_Owner_BranchFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_Kiosk_Owner_BranchFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_Kiosk_Owner_BranchFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("KioskOwner_Branch_ID: {0}", this.KioskOwner_Branch_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_Kiosk_Owner_BranchFactory
    {
        
        public M_Kiosk_Owner_BranchFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_Kiosk_Owner_Branch");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_Kiosk_Owner_Branch");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_Kiosk_Owner_Branch");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_Kiosk_Owner_Branch");
            }
        }
        
        public static M_Kiosk_Owner_BranchFactory Create()
        {
            return new M_Kiosk_Owner_BranchFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? kioskOwner_Branch_ID, string kioskOwner_Branch_Code, string kioskOwner_Branch_Name, string kioskOwner_Branch_Address, decimal? kioskOwner_Branch_LAT, decimal? kioskOwner_Branch_LONG, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (kioskOwner_Branch_ID.HasValue)
            	filter.Add(("KioskOwner_Branch_ID:=" + kioskOwner_Branch_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_Branch_Code)))
            	filter.Add(("KioskOwner_Branch_Code:*" + kioskOwner_Branch_Code));
            if (!(String.IsNullOrEmpty(kioskOwner_Branch_Name)))
            	filter.Add(("KioskOwner_Branch_Name:*" + kioskOwner_Branch_Name));
            if (!(String.IsNullOrEmpty(kioskOwner_Branch_Address)))
            	filter.Add(("KioskOwner_Branch_Address:*" + kioskOwner_Branch_Address));
            if (kioskOwner_Branch_LAT.HasValue)
            	filter.Add(("KioskOwner_Branch_LAT:=" + kioskOwner_Branch_LAT.Value.ToString()));
            if (kioskOwner_Branch_LONG.HasValue)
            	filter.Add(("KioskOwner_Branch_LONG:=" + kioskOwner_Branch_LONG.Value.ToString()));
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
        public List<VSM.Data.Objects.M_Kiosk_Owner_Branch> Select(System.Guid? kioskOwner_Branch_ID, string kioskOwner_Branch_Code, string kioskOwner_Branch_Name, string kioskOwner_Branch_Address, decimal? kioskOwner_Branch_LAT, decimal? kioskOwner_Branch_LONG, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kioskOwner_Branch_ID, kioskOwner_Branch_Code, kioskOwner_Branch_Name, kioskOwner_Branch_Address, kioskOwner_Branch_LAT, kioskOwner_Branch_LONG, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Kiosk_Owner_Branch", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Kiosk_Owner_Branch>();
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Owner_Branch> Select(VSM.Data.Objects.M_Kiosk_Owner_Branch qbe)
        {
            return Select(qbe.KioskOwner_Branch_ID, qbe.KioskOwner_Branch_Code, qbe.KioskOwner_Branch_Name, qbe.KioskOwner_Branch_Address, qbe.KioskOwner_Branch_LAT, qbe.KioskOwner_Branch_LONG, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(System.Guid? kioskOwner_Branch_ID, string kioskOwner_Branch_Code, string kioskOwner_Branch_Name, string kioskOwner_Branch_Address, decimal? kioskOwner_Branch_LAT, decimal? kioskOwner_Branch_LONG, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kioskOwner_Branch_ID, kioskOwner_Branch_Code, kioskOwner_Branch_Name, kioskOwner_Branch_Address, kioskOwner_Branch_LAT, kioskOwner_Branch_LONG, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Kiosk_Owner_Branch", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_Kiosk_Owner_Branch> Select(System.Guid? kioskOwner_Branch_ID, string kioskOwner_Branch_Code, string kioskOwner_Branch_Name, string kioskOwner_Branch_Address, decimal? kioskOwner_Branch_LAT, decimal? kioskOwner_Branch_LONG, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(kioskOwner_Branch_ID, kioskOwner_Branch_Code, kioskOwner_Branch_Name, kioskOwner_Branch_Address, kioskOwner_Branch_LAT, kioskOwner_Branch_LONG, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_Kiosk_Owner_Branch SelectSingle(System.Guid? kioskOwner_Branch_ID)
        {
            List<VSM.Data.Objects.M_Kiosk_Owner_Branch> list = Select(kioskOwner_Branch_ID, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Owner_Branch> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_Kiosk_Owner_Branch", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Kiosk_Owner_Branch>();
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Owner_Branch> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Owner_Branch> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_Kiosk_Owner_Branch SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_Kiosk_Owner_Branch> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_Kiosk_Owner_Branch theM_Kiosk_Owner_Branch, VSM.Data.Objects.M_Kiosk_Owner_Branch original_M_Kiosk_Owner_Branch)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("KioskOwner_Branch_ID", original_M_Kiosk_Owner_Branch.KioskOwner_Branch_ID, theM_Kiosk_Owner_Branch.KioskOwner_Branch_ID));
            values.Add(new FieldValue("KioskOwner_ID", original_M_Kiosk_Owner_Branch.KioskOwner_ID, theM_Kiosk_Owner_Branch.KioskOwner_ID));
            values.Add(new FieldValue("KioskOwner_Branch_Code", original_M_Kiosk_Owner_Branch.KioskOwner_Branch_Code, theM_Kiosk_Owner_Branch.KioskOwner_Branch_Code));
            values.Add(new FieldValue("KioskOwner_Branch_Name", original_M_Kiosk_Owner_Branch.KioskOwner_Branch_Name, theM_Kiosk_Owner_Branch.KioskOwner_Branch_Name));
            values.Add(new FieldValue("KioskOwner_Branch_Address", original_M_Kiosk_Owner_Branch.KioskOwner_Branch_Address, theM_Kiosk_Owner_Branch.KioskOwner_Branch_Address));
            values.Add(new FieldValue("KioskOwner_Branch_LAT", original_M_Kiosk_Owner_Branch.KioskOwner_Branch_LAT, theM_Kiosk_Owner_Branch.KioskOwner_Branch_LAT));
            values.Add(new FieldValue("KioskOwner_Branch_LONG", original_M_Kiosk_Owner_Branch.KioskOwner_Branch_LONG, theM_Kiosk_Owner_Branch.KioskOwner_Branch_LONG));
            values.Add(new FieldValue("Item_Flag", original_M_Kiosk_Owner_Branch.Item_Flag, theM_Kiosk_Owner_Branch.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_Kiosk_Owner_Branch.CreatedBy, theM_Kiosk_Owner_Branch.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_Kiosk_Owner_Branch.CreatedOn, theM_Kiosk_Owner_Branch.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_Kiosk_Owner_Branch.ModifiedBy, theM_Kiosk_Owner_Branch.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_Kiosk_Owner_Branch.ModifiedOn, theM_Kiosk_Owner_Branch.ModifiedOn));
            values.Add(new FieldValue("Configs", original_M_Kiosk_Owner_Branch.Configs, theM_Kiosk_Owner_Branch.Configs));
            values.Add(new FieldValue("KioskOwner_Code", original_M_Kiosk_Owner_Branch.KioskOwner_Code, theM_Kiosk_Owner_Branch.KioskOwner_Code));
            values.Add(new FieldValue("ConfigValue", original_M_Kiosk_Owner_Branch.ConfigValue, theM_Kiosk_Owner_Branch.ConfigValue));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_Kiosk_Owner_Branch theM_Kiosk_Owner_Branch, VSM.Data.Objects.M_Kiosk_Owner_Branch original_M_Kiosk_Owner_Branch, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_Kiosk_Owner_Branch";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_Kiosk_Owner_Branch, original_M_Kiosk_Owner_Branch);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_Kiosk_Owner_Branch", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_Kiosk_Owner_Branch);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_Kiosk_Owner_Branch theM_Kiosk_Owner_Branch, VSM.Data.Objects.M_Kiosk_Owner_Branch original_M_Kiosk_Owner_Branch)
        {
            return ExecuteAction(theM_Kiosk_Owner_Branch, original_M_Kiosk_Owner_Branch, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_Kiosk_Owner_Branch theM_Kiosk_Owner_Branch)
        {
            return Update(theM_Kiosk_Owner_Branch, SelectSingle(theM_Kiosk_Owner_Branch.KioskOwner_Branch_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_Kiosk_Owner_Branch theM_Kiosk_Owner_Branch)
        {
            return ExecuteAction(theM_Kiosk_Owner_Branch, new M_Kiosk_Owner_Branch(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_Kiosk_Owner_Branch theM_Kiosk_Owner_Branch)
        {
            return ExecuteAction(theM_Kiosk_Owner_Branch, theM_Kiosk_Owner_Branch, "Select", "Delete", DeleteView);
        }
    }
}

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_Kiosk_Owner
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _kioskOwner_LAT;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _kioskOwner_LONG;
        
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
        
        public M_Kiosk_Owner()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string KioskOwner_Name
        {
            get
            {
                return _kioskOwner_Name;
            }
            set
            {
                _kioskOwner_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string KioskOwner_Address
        {
            get
            {
                return _kioskOwner_Address;
            }
            set
            {
                _kioskOwner_Address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? KioskOwner_LAT
        {
            get
            {
                return _kioskOwner_LAT;
            }
            set
            {
                _kioskOwner_LAT = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? KioskOwner_LONG
        {
            get
            {
                return _kioskOwner_LONG;
            }
            set
            {
                _kioskOwner_LONG = value;
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
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner> Select(System.Guid? kioskOwner_ID, string kioskOwner_Code, string kioskOwner_Name, string kioskOwner_Address, decimal? kioskOwner_LAT, decimal? kioskOwner_LONG, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_Kiosk_OwnerFactory().Select(kioskOwner_ID, kioskOwner_Code, kioskOwner_Name, kioskOwner_Address, kioskOwner_LAT, kioskOwner_LONG, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner> Select(VSM.Data.Objects.M_Kiosk_Owner qbe)
        {
            return new M_Kiosk_OwnerFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_OwnerFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_Kiosk_OwnerFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_OwnerFactory().Select(filter, sort, M_Kiosk_OwnerFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_Kiosk_OwnerFactory().Select(filter, sort, M_Kiosk_OwnerFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_OwnerFactory().Select(filter, null, M_Kiosk_OwnerFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Owner> Select(string filter, params FieldValue[] parameters)
        {
            return new M_Kiosk_OwnerFactory().Select(filter, null, M_Kiosk_OwnerFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Kiosk_Owner SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_OwnerFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_Kiosk_Owner SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_Kiosk_OwnerFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Kiosk_Owner SelectSingle(System.Guid? kioskOwner_ID)
        {
            return new M_Kiosk_OwnerFactory().SelectSingle(kioskOwner_ID);
        }
        
        public int Insert()
        {
            return new M_Kiosk_OwnerFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_Kiosk_OwnerFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_Kiosk_OwnerFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("KioskOwner_ID: {0}", this.KioskOwner_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_Kiosk_OwnerFactory
    {
        
        public M_Kiosk_OwnerFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_Kiosk_Owner");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_Kiosk_Owner");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_Kiosk_Owner");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_Kiosk_Owner");
            }
        }
        
        public static M_Kiosk_OwnerFactory Create()
        {
            return new M_Kiosk_OwnerFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? kioskOwner_ID, string kioskOwner_Code, string kioskOwner_Name, string kioskOwner_Address, decimal? kioskOwner_LAT, decimal? kioskOwner_LONG, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (kioskOwner_ID.HasValue)
            	filter.Add(("KioskOwner_ID:=" + kioskOwner_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_Code)))
            	filter.Add(("KioskOwner_Code:*" + kioskOwner_Code));
            if (!(String.IsNullOrEmpty(kioskOwner_Name)))
            	filter.Add(("KioskOwner_Name:*" + kioskOwner_Name));
            if (!(String.IsNullOrEmpty(kioskOwner_Address)))
            	filter.Add(("KioskOwner_Address:*" + kioskOwner_Address));
            if (kioskOwner_LAT.HasValue)
            	filter.Add(("KioskOwner_LAT:=" + kioskOwner_LAT.Value.ToString()));
            if (kioskOwner_LONG.HasValue)
            	filter.Add(("KioskOwner_LONG:=" + kioskOwner_LONG.Value.ToString()));
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
        public List<VSM.Data.Objects.M_Kiosk_Owner> Select(System.Guid? kioskOwner_ID, string kioskOwner_Code, string kioskOwner_Name, string kioskOwner_Address, decimal? kioskOwner_LAT, decimal? kioskOwner_LONG, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kioskOwner_ID, kioskOwner_Code, kioskOwner_Name, kioskOwner_Address, kioskOwner_LAT, kioskOwner_LONG, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Kiosk_Owner", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Kiosk_Owner>();
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Owner> Select(VSM.Data.Objects.M_Kiosk_Owner qbe)
        {
            return Select(qbe.KioskOwner_ID, qbe.KioskOwner_Code, qbe.KioskOwner_Name, qbe.KioskOwner_Address, qbe.KioskOwner_LAT, qbe.KioskOwner_LONG, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(System.Guid? kioskOwner_ID, string kioskOwner_Code, string kioskOwner_Name, string kioskOwner_Address, decimal? kioskOwner_LAT, decimal? kioskOwner_LONG, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kioskOwner_ID, kioskOwner_Code, kioskOwner_Name, kioskOwner_Address, kioskOwner_LAT, kioskOwner_LONG, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Kiosk_Owner", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_Kiosk_Owner> Select(System.Guid? kioskOwner_ID, string kioskOwner_Code, string kioskOwner_Name, string kioskOwner_Address, decimal? kioskOwner_LAT, decimal? kioskOwner_LONG, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(kioskOwner_ID, kioskOwner_Code, kioskOwner_Name, kioskOwner_Address, kioskOwner_LAT, kioskOwner_LONG, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_Kiosk_Owner SelectSingle(System.Guid? kioskOwner_ID)
        {
            List<VSM.Data.Objects.M_Kiosk_Owner> list = Select(kioskOwner_ID, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Owner> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_Kiosk_Owner", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Kiosk_Owner>();
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Owner> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Owner> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_Kiosk_Owner SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_Kiosk_Owner> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_Kiosk_Owner theM_Kiosk_Owner, VSM.Data.Objects.M_Kiosk_Owner original_M_Kiosk_Owner)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("KioskOwner_ID", original_M_Kiosk_Owner.KioskOwner_ID, theM_Kiosk_Owner.KioskOwner_ID));
            values.Add(new FieldValue("KioskOwner_Code", original_M_Kiosk_Owner.KioskOwner_Code, theM_Kiosk_Owner.KioskOwner_Code));
            values.Add(new FieldValue("KioskOwner_Name", original_M_Kiosk_Owner.KioskOwner_Name, theM_Kiosk_Owner.KioskOwner_Name));
            values.Add(new FieldValue("KioskOwner_Address", original_M_Kiosk_Owner.KioskOwner_Address, theM_Kiosk_Owner.KioskOwner_Address));
            values.Add(new FieldValue("KioskOwner_LAT", original_M_Kiosk_Owner.KioskOwner_LAT, theM_Kiosk_Owner.KioskOwner_LAT));
            values.Add(new FieldValue("KioskOwner_LONG", original_M_Kiosk_Owner.KioskOwner_LONG, theM_Kiosk_Owner.KioskOwner_LONG));
            values.Add(new FieldValue("Item_Flag", original_M_Kiosk_Owner.Item_Flag, theM_Kiosk_Owner.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_Kiosk_Owner.CreatedBy, theM_Kiosk_Owner.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_Kiosk_Owner.CreatedOn, theM_Kiosk_Owner.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_Kiosk_Owner.ModifiedBy, theM_Kiosk_Owner.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_Kiosk_Owner.ModifiedOn, theM_Kiosk_Owner.ModifiedOn));
            values.Add(new FieldValue("Configs", original_M_Kiosk_Owner.Configs, theM_Kiosk_Owner.Configs));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_Kiosk_Owner theM_Kiosk_Owner, VSM.Data.Objects.M_Kiosk_Owner original_M_Kiosk_Owner, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_Kiosk_Owner";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_Kiosk_Owner, original_M_Kiosk_Owner);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_Kiosk_Owner", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_Kiosk_Owner);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_Kiosk_Owner theM_Kiosk_Owner, VSM.Data.Objects.M_Kiosk_Owner original_M_Kiosk_Owner)
        {
            return ExecuteAction(theM_Kiosk_Owner, original_M_Kiosk_Owner, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_Kiosk_Owner theM_Kiosk_Owner)
        {
            return Update(theM_Kiosk_Owner, SelectSingle(theM_Kiosk_Owner.KioskOwner_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_Kiosk_Owner theM_Kiosk_Owner)
        {
            return ExecuteAction(theM_Kiosk_Owner, new M_Kiosk_Owner(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_Kiosk_Owner theM_Kiosk_Owner)
        {
            return ExecuteAction(theM_Kiosk_Owner, theM_Kiosk_Owner, "Select", "Delete", DeleteView);
        }
    }
}

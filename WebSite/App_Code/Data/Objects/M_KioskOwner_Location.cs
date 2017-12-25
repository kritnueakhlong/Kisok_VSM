using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_KioskOwner_Location
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _location_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _location_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _location_LAT;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _location_LONG;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_KioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_Branch_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Branch_KioskOwner_Branch_Code;
        
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
        
        public M_KioskOwner_Location()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? Location_ID
        {
            get
            {
                return _location_ID;
            }
            set
            {
                _location_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Location_Address
        {
            get
            {
                return _location_Address;
            }
            set
            {
                _location_Address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? Location_LAT
        {
            get
            {
                return _location_LAT;
            }
            set
            {
                _location_LAT = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? Location_LONG
        {
            get
            {
                return _location_LONG;
            }
            set
            {
                _location_LONG = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string KioskOwner_KioskOwner_Code
        {
            get
            {
                return _kioskOwner_KioskOwner_Code;
            }
            set
            {
                _kioskOwner_KioskOwner_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        public string KioskOwner_Branch_KioskOwner_Branch_Code
        {
            get
            {
                return _kioskOwner_Branch_KioskOwner_Branch_Code;
            }
            set
            {
                _kioskOwner_Branch_KioskOwner_Branch_Code = value;
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
        
        public static List<VSM.Data.Objects.M_KioskOwner_Location> Select(System.Guid? location_ID, string location_Address, decimal? location_LAT, decimal? location_LONG, System.Guid? kioskOwner_ID, string kioskOwner_KioskOwner_Code, System.Guid? kioskOwner_Branch_ID, string kioskOwner_Branch_KioskOwner_Branch_Code, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_KioskOwner_LocationFactory().Select(location_ID, location_Address, location_LAT, location_LONG, kioskOwner_ID, kioskOwner_KioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_KioskOwner_Branch_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Location> Select(VSM.Data.Objects.M_KioskOwner_Location qbe)
        {
            return new M_KioskOwner_LocationFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Location> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_KioskOwner_LocationFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Location> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_KioskOwner_LocationFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Location> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_KioskOwner_LocationFactory().Select(filter, sort, M_KioskOwner_LocationFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Location> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_KioskOwner_LocationFactory().Select(filter, sort, M_KioskOwner_LocationFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Location> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_KioskOwner_LocationFactory().Select(filter, null, M_KioskOwner_LocationFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Location> Select(string filter, params FieldValue[] parameters)
        {
            return new M_KioskOwner_LocationFactory().Select(filter, null, M_KioskOwner_LocationFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_KioskOwner_Location SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_KioskOwner_LocationFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_KioskOwner_Location SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_KioskOwner_LocationFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_KioskOwner_Location SelectSingle(System.Guid? location_ID)
        {
            return new M_KioskOwner_LocationFactory().SelectSingle(location_ID);
        }
        
        public int Insert()
        {
            return new M_KioskOwner_LocationFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_KioskOwner_LocationFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_KioskOwner_LocationFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Location_ID: {0}", this.Location_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_KioskOwner_LocationFactory
    {
        
        public M_KioskOwner_LocationFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_KioskOwner_Location");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_KioskOwner_Location");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_KioskOwner_Location");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_KioskOwner_Location");
            }
        }
        
        public static M_KioskOwner_LocationFactory Create()
        {
            return new M_KioskOwner_LocationFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    System.Guid? location_ID, 
                    string location_Address, 
                    decimal? location_LAT, 
                    decimal? location_LONG, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kioskOwner_Branch_KioskOwner_Branch_Code, 
                    bool? item_Flag, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (location_ID.HasValue)
            	filter.Add(("Location_ID:=" + location_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(location_Address)))
            	filter.Add(("Location_Address:*" + location_Address));
            if (location_LAT.HasValue)
            	filter.Add(("Location_LAT:=" + location_LAT.Value.ToString()));
            if (location_LONG.HasValue)
            	filter.Add(("Location_LONG:=" + location_LONG.Value.ToString()));
            if (kioskOwner_ID.HasValue)
            	filter.Add(("KioskOwner_ID:=" + kioskOwner_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_KioskOwner_Code)))
            	filter.Add(("KioskOwner_KioskOwner_Code:*" + kioskOwner_KioskOwner_Code));
            if (kioskOwner_Branch_ID.HasValue)
            	filter.Add(("KioskOwner_Branch_ID:=" + kioskOwner_Branch_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_Branch_KioskOwner_Branch_Code)))
            	filter.Add(("KioskOwner_Branch_KioskOwner_Branch_Code:*" + kioskOwner_Branch_KioskOwner_Branch_Code));
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
        public List<VSM.Data.Objects.M_KioskOwner_Location> Select(
                    System.Guid? location_ID, 
                    string location_Address, 
                    decimal? location_LAT, 
                    decimal? location_LONG, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kioskOwner_Branch_KioskOwner_Branch_Code, 
                    bool? item_Flag, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(location_ID, location_Address, location_LAT, location_LONG, kioskOwner_ID, kioskOwner_KioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_KioskOwner_Branch_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_KioskOwner_Location", dataView, request);
            return page.ToList<VSM.Data.Objects.M_KioskOwner_Location>();
        }
        
        public List<VSM.Data.Objects.M_KioskOwner_Location> Select(VSM.Data.Objects.M_KioskOwner_Location qbe)
        {
            return Select(qbe.Location_ID, qbe.Location_Address, qbe.Location_LAT, qbe.Location_LONG, qbe.KioskOwner_ID, qbe.KioskOwner_KioskOwner_Code, qbe.KioskOwner_Branch_ID, qbe.KioskOwner_Branch_KioskOwner_Branch_Code, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? location_ID, 
                    string location_Address, 
                    decimal? location_LAT, 
                    decimal? location_LONG, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kioskOwner_Branch_KioskOwner_Branch_Code, 
                    bool? item_Flag, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(location_ID, location_Address, location_LAT, location_LONG, kioskOwner_ID, kioskOwner_KioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_KioskOwner_Branch_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_KioskOwner_Location", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_KioskOwner_Location> Select(System.Guid? location_ID, string location_Address, decimal? location_LAT, decimal? location_LONG, System.Guid? kioskOwner_ID, string kioskOwner_KioskOwner_Code, System.Guid? kioskOwner_Branch_ID, string kioskOwner_Branch_KioskOwner_Branch_Code, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(location_ID, location_Address, location_LAT, location_LONG, kioskOwner_ID, kioskOwner_KioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_KioskOwner_Branch_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_KioskOwner_Location SelectSingle(System.Guid? location_ID)
        {
            List<VSM.Data.Objects.M_KioskOwner_Location> list = Select(location_ID, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_KioskOwner_Location> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_KioskOwner_Location", dataView, request);
            return page.ToList<VSM.Data.Objects.M_KioskOwner_Location>();
        }
        
        public List<VSM.Data.Objects.M_KioskOwner_Location> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_KioskOwner_Location> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_KioskOwner_Location SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_KioskOwner_Location> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_KioskOwner_Location theM_KioskOwner_Location, VSM.Data.Objects.M_KioskOwner_Location original_M_KioskOwner_Location)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Location_ID", original_M_KioskOwner_Location.Location_ID, theM_KioskOwner_Location.Location_ID));
            values.Add(new FieldValue("Location_Address", original_M_KioskOwner_Location.Location_Address, theM_KioskOwner_Location.Location_Address));
            values.Add(new FieldValue("Location_LAT", original_M_KioskOwner_Location.Location_LAT, theM_KioskOwner_Location.Location_LAT));
            values.Add(new FieldValue("Location_LONG", original_M_KioskOwner_Location.Location_LONG, theM_KioskOwner_Location.Location_LONG));
            values.Add(new FieldValue("KioskOwner_ID", original_M_KioskOwner_Location.KioskOwner_ID, theM_KioskOwner_Location.KioskOwner_ID));
            values.Add(new FieldValue("KioskOwner_KioskOwner_Code", original_M_KioskOwner_Location.KioskOwner_KioskOwner_Code, theM_KioskOwner_Location.KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("KioskOwner_Branch_ID", original_M_KioskOwner_Location.KioskOwner_Branch_ID, theM_KioskOwner_Location.KioskOwner_Branch_ID));
            values.Add(new FieldValue("KioskOwner_Branch_KioskOwner_Branch_Code", original_M_KioskOwner_Location.KioskOwner_Branch_KioskOwner_Branch_Code, theM_KioskOwner_Location.KioskOwner_Branch_KioskOwner_Branch_Code, true));
            values.Add(new FieldValue("Item_Flag", original_M_KioskOwner_Location.Item_Flag, theM_KioskOwner_Location.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_KioskOwner_Location.CreatedBy, theM_KioskOwner_Location.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_KioskOwner_Location.CreatedOn, theM_KioskOwner_Location.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_KioskOwner_Location.ModifiedBy, theM_KioskOwner_Location.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_KioskOwner_Location.ModifiedOn, theM_KioskOwner_Location.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_KioskOwner_Location theM_KioskOwner_Location, VSM.Data.Objects.M_KioskOwner_Location original_M_KioskOwner_Location, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_KioskOwner_Location";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_KioskOwner_Location, original_M_KioskOwner_Location);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_KioskOwner_Location", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_KioskOwner_Location);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_KioskOwner_Location theM_KioskOwner_Location, VSM.Data.Objects.M_KioskOwner_Location original_M_KioskOwner_Location)
        {
            return ExecuteAction(theM_KioskOwner_Location, original_M_KioskOwner_Location, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_KioskOwner_Location theM_KioskOwner_Location)
        {
            return Update(theM_KioskOwner_Location, SelectSingle(theM_KioskOwner_Location.Location_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_KioskOwner_Location theM_KioskOwner_Location)
        {
            return ExecuteAction(theM_KioskOwner_Location, new M_KioskOwner_Location(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_KioskOwner_Location theM_KioskOwner_Location)
        {
            return ExecuteAction(theM_KioskOwner_Location, theM_KioskOwner_Location, "Select", "Delete", DeleteView);
        }
    }
}

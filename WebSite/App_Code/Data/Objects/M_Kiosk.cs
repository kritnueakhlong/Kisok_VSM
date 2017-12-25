using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_Kiosk
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kiosk_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Serial;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mac_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _hD_Serial;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iP_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskType_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskType_KioskType_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_Branch_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Branch_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _location_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _location_Location_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        public M_Kiosk()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? Kiosk_ID
        {
            get
            {
                return _kiosk_ID;
            }
            set
            {
                _kiosk_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Kiosk_Code
        {
            get
            {
                return _kiosk_Code;
            }
            set
            {
                _kiosk_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Kiosk_Name
        {
            get
            {
                return _kiosk_Name;
            }
            set
            {
                _kiosk_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Kiosk_Serial
        {
            get
            {
                return _kiosk_Serial;
            }
            set
            {
                _kiosk_Serial = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Mac_Address
        {
            get
            {
                return _mac_Address;
            }
            set
            {
                _mac_Address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HD_Serial
        {
            get
            {
                return _hD_Serial;
            }
            set
            {
                _hD_Serial = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IP_Address
        {
            get
            {
                return _iP_Address;
            }
            set
            {
                _iP_Address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string KioskType_Code
        {
            get
            {
                return _kioskType_Code;
            }
            set
            {
                _kioskType_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string KioskType_KioskType_Name
        {
            get
            {
                return _kioskType_KioskType_Name;
            }
            set
            {
                _kioskType_KioskType_Name = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Location_Location_Address
        {
            get
            {
                return _location_Location_Address;
            }
            set
            {
                _location_Location_Address = value;
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
        
        public static List<VSM.Data.Objects.M_Kiosk> Select(
                    System.Guid? kiosk_ID, 
                    string kiosk_Code, 
                    string kiosk_Name, 
                    string kiosk_Serial, 
                    string mac_Address, 
                    string hD_Serial, 
                    string iP_Address, 
                    string kioskType_Code, 
                    string kioskType_KioskType_Name, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    System.Guid? location_ID, 
                    string location_Location_Address, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn)
        {
            return new M_KioskFactory().Select(kiosk_ID, kiosk_Code, kiosk_Name, kiosk_Serial, mac_Address, hD_Serial, iP_Address, kioskType_Code, kioskType_KioskType_Name, kioskOwner_ID, kioskOwner_Code, kioskOwner_Branch_ID, location_ID, location_Location_Address, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk> Select(VSM.Data.Objects.M_Kiosk qbe)
        {
            return new M_KioskFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_KioskFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_KioskFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Kiosk> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_KioskFactory().Select(filter, sort, M_KioskFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_KioskFactory().Select(filter, sort, M_KioskFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Kiosk> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_KioskFactory().Select(filter, null, M_KioskFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk> Select(string filter, params FieldValue[] parameters)
        {
            return new M_KioskFactory().Select(filter, null, M_KioskFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Kiosk SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_KioskFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_Kiosk SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_KioskFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Kiosk SelectSingle(System.Guid? kiosk_ID)
        {
            return new M_KioskFactory().SelectSingle(kiosk_ID);
        }
        
        public int Insert()
        {
            return new M_KioskFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_KioskFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_KioskFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Kiosk_ID: {0}", this.Kiosk_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_KioskFactory
    {
        
        public M_KioskFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_Kiosk");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_Kiosk");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_Kiosk");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_Kiosk");
            }
        }
        
        public static M_KioskFactory Create()
        {
            return new M_KioskFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    System.Guid? kiosk_ID, 
                    string kiosk_Code, 
                    string kiosk_Name, 
                    string kiosk_Serial, 
                    string mac_Address, 
                    string hD_Serial, 
                    string iP_Address, 
                    string kioskType_Code, 
                    string kioskType_KioskType_Name, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    System.Guid? location_ID, 
                    string location_Location_Address, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (kiosk_ID.HasValue)
            	filter.Add(("Kiosk_ID:=" + kiosk_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kiosk_Code)))
            	filter.Add(("Kiosk_Code:*" + kiosk_Code));
            if (!(String.IsNullOrEmpty(kiosk_Name)))
            	filter.Add(("Kiosk_Name:*" + kiosk_Name));
            if (!(String.IsNullOrEmpty(kiosk_Serial)))
            	filter.Add(("Kiosk_Serial:*" + kiosk_Serial));
            if (!(String.IsNullOrEmpty(mac_Address)))
            	filter.Add(("Mac_Address:*" + mac_Address));
            if (!(String.IsNullOrEmpty(hD_Serial)))
            	filter.Add(("HD_Serial:*" + hD_Serial));
            if (!(String.IsNullOrEmpty(iP_Address)))
            	filter.Add(("IP_Address:*" + iP_Address));
            if (!(String.IsNullOrEmpty(kioskType_Code)))
            	filter.Add(("KioskType_Code:*" + kioskType_Code));
            if (!(String.IsNullOrEmpty(kioskType_KioskType_Name)))
            	filter.Add(("KioskType_KioskType_Name:*" + kioskType_KioskType_Name));
            if (kioskOwner_ID.HasValue)
            	filter.Add(("KioskOwner_ID:=" + kioskOwner_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_Code)))
            	filter.Add(("KioskOwner_Code:*" + kioskOwner_Code));
            if (kioskOwner_Branch_ID.HasValue)
            	filter.Add(("KioskOwner_Branch_ID:=" + kioskOwner_Branch_ID.Value.ToString()));
            if (location_ID.HasValue)
            	filter.Add(("Location_ID:=" + location_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(location_Location_Address)))
            	filter.Add(("Location_Location_Address:*" + location_Location_Address));
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
        public List<VSM.Data.Objects.M_Kiosk> Select(
                    System.Guid? kiosk_ID, 
                    string kiosk_Code, 
                    string kiosk_Name, 
                    string kiosk_Serial, 
                    string mac_Address, 
                    string hD_Serial, 
                    string iP_Address, 
                    string kioskType_Code, 
                    string kioskType_KioskType_Name, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    System.Guid? location_ID, 
                    string location_Location_Address, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(kiosk_ID, kiosk_Code, kiosk_Name, kiosk_Serial, mac_Address, hD_Serial, iP_Address, kioskType_Code, kioskType_KioskType_Name, kioskOwner_ID, kioskOwner_Code, kioskOwner_Branch_ID, location_ID, location_Location_Address, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Kiosk", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Kiosk>();
        }
        
        public List<VSM.Data.Objects.M_Kiosk> Select(VSM.Data.Objects.M_Kiosk qbe)
        {
            return Select(qbe.Kiosk_ID, qbe.Kiosk_Code, qbe.Kiosk_Name, qbe.Kiosk_Serial, qbe.Mac_Address, qbe.HD_Serial, qbe.IP_Address, qbe.KioskType_Code, qbe.KioskType_KioskType_Name, qbe.KioskOwner_ID, qbe.KioskOwner_Code, qbe.KioskOwner_Branch_ID, qbe.Location_ID, qbe.Location_Location_Address, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? kiosk_ID, 
                    string kiosk_Code, 
                    string kiosk_Name, 
                    string kiosk_Serial, 
                    string mac_Address, 
                    string hD_Serial, 
                    string iP_Address, 
                    string kioskType_Code, 
                    string kioskType_KioskType_Name, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    System.Guid? location_ID, 
                    string location_Location_Address, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(kiosk_ID, kiosk_Code, kiosk_Name, kiosk_Serial, mac_Address, hD_Serial, iP_Address, kioskType_Code, kioskType_KioskType_Name, kioskOwner_ID, kioskOwner_Code, kioskOwner_Branch_ID, location_ID, location_Location_Address, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Kiosk", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_Kiosk> Select(
                    System.Guid? kiosk_ID, 
                    string kiosk_Code, 
                    string kiosk_Name, 
                    string kiosk_Serial, 
                    string mac_Address, 
                    string hD_Serial, 
                    string iP_Address, 
                    string kioskType_Code, 
                    string kioskType_KioskType_Name, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    System.Guid? location_ID, 
                    string location_Location_Address, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn)
        {
            return Select(kiosk_ID, kiosk_Code, kiosk_Name, kiosk_Serial, mac_Address, hD_Serial, iP_Address, kioskType_Code, kioskType_KioskType_Name, kioskOwner_ID, kioskOwner_Code, kioskOwner_Branch_ID, location_ID, location_Location_Address, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_Kiosk SelectSingle(System.Guid? kiosk_ID)
        {
            List<VSM.Data.Objects.M_Kiosk> list = Select(kiosk_ID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_Kiosk> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_Kiosk", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Kiosk>();
        }
        
        public List<VSM.Data.Objects.M_Kiosk> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_Kiosk> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_Kiosk SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_Kiosk> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_Kiosk theM_Kiosk, VSM.Data.Objects.M_Kiosk original_M_Kiosk)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Kiosk_ID", original_M_Kiosk.Kiosk_ID, theM_Kiosk.Kiosk_ID));
            values.Add(new FieldValue("Kiosk_Code", original_M_Kiosk.Kiosk_Code, theM_Kiosk.Kiosk_Code));
            values.Add(new FieldValue("Kiosk_Name", original_M_Kiosk.Kiosk_Name, theM_Kiosk.Kiosk_Name));
            values.Add(new FieldValue("Kiosk_Serial", original_M_Kiosk.Kiosk_Serial, theM_Kiosk.Kiosk_Serial));
            values.Add(new FieldValue("Mac_Address", original_M_Kiosk.Mac_Address, theM_Kiosk.Mac_Address));
            values.Add(new FieldValue("HD_Serial", original_M_Kiosk.HD_Serial, theM_Kiosk.HD_Serial));
            values.Add(new FieldValue("IP_Address", original_M_Kiosk.IP_Address, theM_Kiosk.IP_Address));
            values.Add(new FieldValue("KioskType_Code", original_M_Kiosk.KioskType_Code, theM_Kiosk.KioskType_Code));
            values.Add(new FieldValue("KioskType_KioskType_Name", original_M_Kiosk.KioskType_KioskType_Name, theM_Kiosk.KioskType_KioskType_Name, true));
            values.Add(new FieldValue("KioskOwner_ID", original_M_Kiosk.KioskOwner_ID, theM_Kiosk.KioskOwner_ID));
            values.Add(new FieldValue("KioskOwner_Code", original_M_Kiosk.KioskOwner_Code, theM_Kiosk.KioskOwner_Code, true));
            values.Add(new FieldValue("KioskOwner_Branch_ID", original_M_Kiosk.KioskOwner_Branch_ID, theM_Kiosk.KioskOwner_Branch_ID));
            values.Add(new FieldValue("KioskOwner_Branch_Code", original_M_Kiosk.KioskOwner_Branch_Code, theM_Kiosk.KioskOwner_Branch_Code, true));
            values.Add(new FieldValue("Location_ID", original_M_Kiosk.Location_ID, theM_Kiosk.Location_ID));
            values.Add(new FieldValue("Location_Location_Address", original_M_Kiosk.Location_Location_Address, theM_Kiosk.Location_Location_Address, true));
            values.Add(new FieldValue("CreatedBy", original_M_Kiosk.CreatedBy, theM_Kiosk.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_Kiosk.CreatedOn, theM_Kiosk.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_Kiosk.ModifiedBy, theM_Kiosk.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_Kiosk.ModifiedOn, theM_Kiosk.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_Kiosk theM_Kiosk, VSM.Data.Objects.M_Kiosk original_M_Kiosk, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_Kiosk";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_Kiosk, original_M_Kiosk);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_Kiosk", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_Kiosk);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_Kiosk theM_Kiosk, VSM.Data.Objects.M_Kiosk original_M_Kiosk)
        {
            return ExecuteAction(theM_Kiosk, original_M_Kiosk, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_Kiosk theM_Kiosk)
        {
            return Update(theM_Kiosk, SelectSingle(theM_Kiosk.Kiosk_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_Kiosk theM_Kiosk)
        {
            return ExecuteAction(theM_Kiosk, new M_Kiosk(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_Kiosk theM_Kiosk)
        {
            return ExecuteAction(theM_Kiosk, theM_Kiosk, "Select", "Delete", DeleteView);
        }
    }
}

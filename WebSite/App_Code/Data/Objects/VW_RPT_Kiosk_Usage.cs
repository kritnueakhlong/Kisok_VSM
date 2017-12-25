using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class VW_RPT_Kiosk_Usage
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kiosk_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mac_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _hD_Serial;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iP_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskType_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _location_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_Branch_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _amount;
        
        public VW_RPT_Kiosk_Usage()
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
        public int? Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> Select(System.Guid? kiosk_ID, string kiosk_Code, string kiosk_Name, string mac_Address, string hD_Serial, string iP_Address, string kioskType_Code, string location_Address, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, int? amount)
        {
            return new VW_RPT_Kiosk_UsageFactory().Select(kiosk_ID, kiosk_Code, kiosk_Name, mac_Address, hD_Serial, iP_Address, kioskType_Code, location_Address, kioskOwner_ID, kioskOwner_Branch_ID, amount);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> Select(VSM.Data.Objects.VW_RPT_Kiosk_Usage qbe)
        {
            return new VW_RPT_Kiosk_UsageFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new VW_RPT_Kiosk_UsageFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new VW_RPT_Kiosk_UsageFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new VW_RPT_Kiosk_UsageFactory().Select(filter, sort, VW_RPT_Kiosk_UsageFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new VW_RPT_Kiosk_UsageFactory().Select(filter, sort, VW_RPT_Kiosk_UsageFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> Select(string filter, BusinessObjectParameters parameters)
        {
            return new VW_RPT_Kiosk_UsageFactory().Select(filter, null, VW_RPT_Kiosk_UsageFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> Select(string filter, params FieldValue[] parameters)
        {
            return new VW_RPT_Kiosk_UsageFactory().Select(filter, null, VW_RPT_Kiosk_UsageFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.VW_RPT_Kiosk_Usage SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new VW_RPT_Kiosk_UsageFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.VW_RPT_Kiosk_Usage SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new VW_RPT_Kiosk_UsageFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.VW_RPT_Kiosk_Usage SelectSingle(System.Guid? kiosk_ID)
        {
            return new VW_RPT_Kiosk_UsageFactory().SelectSingle(kiosk_ID);
        }
        
        public int Insert()
        {
            return new VW_RPT_Kiosk_UsageFactory().Insert(this);
        }
        
        public int Update()
        {
            return new VW_RPT_Kiosk_UsageFactory().Update(this);
        }
        
        public int Delete()
        {
            return new VW_RPT_Kiosk_UsageFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Kiosk_ID: {0}", this.Kiosk_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class VW_RPT_Kiosk_UsageFactory
    {
        
        public VW_RPT_Kiosk_UsageFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("VW_RPT_Kiosk_Usage");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("VW_RPT_Kiosk_Usage");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("VW_RPT_Kiosk_Usage");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("VW_RPT_Kiosk_Usage");
            }
        }
        
        public static VW_RPT_Kiosk_UsageFactory Create()
        {
            return new VW_RPT_Kiosk_UsageFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? kiosk_ID, string kiosk_Code, string kiosk_Name, string mac_Address, string hD_Serial, string iP_Address, string kioskType_Code, string location_Address, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, int? amount, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (kiosk_ID.HasValue)
            	filter.Add(("Kiosk_ID:=" + kiosk_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kiosk_Code)))
            	filter.Add(("Kiosk_Code:*" + kiosk_Code));
            if (!(String.IsNullOrEmpty(kiosk_Name)))
            	filter.Add(("Kiosk_Name:*" + kiosk_Name));
            if (!(String.IsNullOrEmpty(mac_Address)))
            	filter.Add(("Mac_Address:*" + mac_Address));
            if (!(String.IsNullOrEmpty(hD_Serial)))
            	filter.Add(("HD_Serial:*" + hD_Serial));
            if (!(String.IsNullOrEmpty(iP_Address)))
            	filter.Add(("IP_Address:*" + iP_Address));
            if (!(String.IsNullOrEmpty(kioskType_Code)))
            	filter.Add(("KioskType_Code:*" + kioskType_Code));
            if (!(String.IsNullOrEmpty(location_Address)))
            	filter.Add(("Location_Address:*" + location_Address));
            if (kioskOwner_ID.HasValue)
            	filter.Add(("KioskOwner_ID:=" + kioskOwner_ID.Value.ToString()));
            if (kioskOwner_Branch_ID.HasValue)
            	filter.Add(("KioskOwner_Branch_ID:=" + kioskOwner_Branch_ID.Value.ToString()));
            if (amount.HasValue)
            	filter.Add(("Amount:=" + amount.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> Select(System.Guid? kiosk_ID, string kiosk_Code, string kiosk_Name, string mac_Address, string hD_Serial, string iP_Address, string kioskType_Code, string location_Address, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, int? amount, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kiosk_ID, kiosk_Code, kiosk_Name, mac_Address, hD_Serial, iP_Address, kioskType_Code, location_Address, kioskOwner_ID, kioskOwner_Branch_ID, amount, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VW_RPT_Kiosk_Usage", dataView, request);
            return page.ToList<VSM.Data.Objects.VW_RPT_Kiosk_Usage>();
        }
        
        public List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> Select(VSM.Data.Objects.VW_RPT_Kiosk_Usage qbe)
        {
            return Select(qbe.Kiosk_ID, qbe.Kiosk_Code, qbe.Kiosk_Name, qbe.Mac_Address, qbe.HD_Serial, qbe.IP_Address, qbe.KioskType_Code, qbe.Location_Address, qbe.KioskOwner_ID, qbe.KioskOwner_Branch_ID, qbe.Amount);
        }
        
        public int SelectCount(System.Guid? kiosk_ID, string kiosk_Code, string kiosk_Name, string mac_Address, string hD_Serial, string iP_Address, string kioskType_Code, string location_Address, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, int? amount, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kiosk_ID, kiosk_Code, kiosk_Name, mac_Address, hD_Serial, iP_Address, kioskType_Code, location_Address, kioskOwner_ID, kioskOwner_Branch_ID, amount, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VW_RPT_Kiosk_Usage", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> Select(System.Guid? kiosk_ID, string kiosk_Code, string kiosk_Name, string mac_Address, string hD_Serial, string iP_Address, string kioskType_Code, string location_Address, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, int? amount)
        {
            return Select(kiosk_ID, kiosk_Code, kiosk_Name, mac_Address, hD_Serial, iP_Address, kioskType_Code, location_Address, kioskOwner_ID, kioskOwner_Branch_ID, amount, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.VW_RPT_Kiosk_Usage SelectSingle(System.Guid? kiosk_ID)
        {
            List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> list = Select(kiosk_ID, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("VW_RPT_Kiosk_Usage", dataView, request);
            return page.ToList<VSM.Data.Objects.VW_RPT_Kiosk_Usage>();
        }
        
        public List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.VW_RPT_Kiosk_Usage SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.VW_RPT_Kiosk_Usage> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.VW_RPT_Kiosk_Usage theVW_RPT_Kiosk_Usage, VSM.Data.Objects.VW_RPT_Kiosk_Usage original_VW_RPT_Kiosk_Usage)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Kiosk_ID", original_VW_RPT_Kiosk_Usage.Kiosk_ID, theVW_RPT_Kiosk_Usage.Kiosk_ID));
            values.Add(new FieldValue("Kiosk_Code", original_VW_RPT_Kiosk_Usage.Kiosk_Code, theVW_RPT_Kiosk_Usage.Kiosk_Code));
            values.Add(new FieldValue("Kiosk_Name", original_VW_RPT_Kiosk_Usage.Kiosk_Name, theVW_RPT_Kiosk_Usage.Kiosk_Name));
            values.Add(new FieldValue("Mac_Address", original_VW_RPT_Kiosk_Usage.Mac_Address, theVW_RPT_Kiosk_Usage.Mac_Address));
            values.Add(new FieldValue("HD_Serial", original_VW_RPT_Kiosk_Usage.HD_Serial, theVW_RPT_Kiosk_Usage.HD_Serial));
            values.Add(new FieldValue("IP_Address", original_VW_RPT_Kiosk_Usage.IP_Address, theVW_RPT_Kiosk_Usage.IP_Address));
            values.Add(new FieldValue("KioskType_Code", original_VW_RPT_Kiosk_Usage.KioskType_Code, theVW_RPT_Kiosk_Usage.KioskType_Code));
            values.Add(new FieldValue("Location_Address", original_VW_RPT_Kiosk_Usage.Location_Address, theVW_RPT_Kiosk_Usage.Location_Address));
            values.Add(new FieldValue("KioskOwner_ID", original_VW_RPT_Kiosk_Usage.KioskOwner_ID, theVW_RPT_Kiosk_Usage.KioskOwner_ID));
            values.Add(new FieldValue("KioskOwner_Branch_ID", original_VW_RPT_Kiosk_Usage.KioskOwner_Branch_ID, theVW_RPT_Kiosk_Usage.KioskOwner_Branch_ID));
            values.Add(new FieldValue("Amount", original_VW_RPT_Kiosk_Usage.Amount, theVW_RPT_Kiosk_Usage.Amount));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.VW_RPT_Kiosk_Usage theVW_RPT_Kiosk_Usage, VSM.Data.Objects.VW_RPT_Kiosk_Usage original_VW_RPT_Kiosk_Usage, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "VW_RPT_Kiosk_Usage";
            args.View = dataView;
            args.Values = CreateFieldValues(theVW_RPT_Kiosk_Usage, original_VW_RPT_Kiosk_Usage);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("VW_RPT_Kiosk_Usage", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theVW_RPT_Kiosk_Usage);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.VW_RPT_Kiosk_Usage theVW_RPT_Kiosk_Usage, VSM.Data.Objects.VW_RPT_Kiosk_Usage original_VW_RPT_Kiosk_Usage)
        {
            return ExecuteAction(theVW_RPT_Kiosk_Usage, original_VW_RPT_Kiosk_Usage, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.VW_RPT_Kiosk_Usage theVW_RPT_Kiosk_Usage)
        {
            return Update(theVW_RPT_Kiosk_Usage, SelectSingle(theVW_RPT_Kiosk_Usage.Kiosk_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.VW_RPT_Kiosk_Usage theVW_RPT_Kiosk_Usage)
        {
            return ExecuteAction(theVW_RPT_Kiosk_Usage, new VW_RPT_Kiosk_Usage(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.VW_RPT_Kiosk_Usage theVW_RPT_Kiosk_Usage)
        {
            return ExecuteAction(theVW_RPT_Kiosk_Usage, theVW_RPT_Kiosk_Usage, "Select", "Delete", DeleteView);
        }
    }
}

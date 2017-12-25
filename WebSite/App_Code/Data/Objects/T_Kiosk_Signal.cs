using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class T_Kiosk_Signal
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kiosk_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Kiosk_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_KioskType_KioskType_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Location_Location_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Location_KioskOwner_KioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        public T_Kiosk_Signal()
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Kiosk_Kiosk_Code
        {
            get
            {
                return _kiosk_Kiosk_Code;
            }
            set
            {
                _kiosk_Kiosk_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Kiosk_KioskType_KioskType_Name
        {
            get
            {
                return _kiosk_KioskType_KioskType_Name;
            }
            set
            {
                _kiosk_KioskType_KioskType_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Kiosk_Location_Location_Address
        {
            get
            {
                return _kiosk_Location_Location_Address;
            }
            set
            {
                _kiosk_Location_Location_Address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Kiosk_Location_KioskOwner_KioskOwner_Code
        {
            get
            {
                return _kiosk_Location_KioskOwner_KioskOwner_Code;
            }
            set
            {
                _kiosk_Location_KioskOwner_KioskOwner_Code = value;
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
        
        public static List<VSM.Data.Objects.T_Kiosk_Signal> Select(System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new T_Kiosk_SignalFactory().Select(kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.T_Kiosk_Signal> Select(VSM.Data.Objects.T_Kiosk_Signal qbe)
        {
            return new T_Kiosk_SignalFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.T_Kiosk_Signal> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new T_Kiosk_SignalFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Kiosk_Signal> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new T_Kiosk_SignalFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Kiosk_Signal> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new T_Kiosk_SignalFactory().Select(filter, sort, T_Kiosk_SignalFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Kiosk_Signal> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new T_Kiosk_SignalFactory().Select(filter, sort, T_Kiosk_SignalFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Kiosk_Signal> Select(string filter, BusinessObjectParameters parameters)
        {
            return new T_Kiosk_SignalFactory().Select(filter, null, T_Kiosk_SignalFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Kiosk_Signal> Select(string filter, params FieldValue[] parameters)
        {
            return new T_Kiosk_SignalFactory().Select(filter, null, T_Kiosk_SignalFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Kiosk_Signal SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new T_Kiosk_SignalFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.T_Kiosk_Signal SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new T_Kiosk_SignalFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Kiosk_Signal SelectSingle(System.Guid? kiosk_ID)
        {
            return new T_Kiosk_SignalFactory().SelectSingle(kiosk_ID);
        }
        
        public int Insert()
        {
            return new T_Kiosk_SignalFactory().Insert(this);
        }
        
        public int Update()
        {
            return new T_Kiosk_SignalFactory().Update(this);
        }
        
        public int Delete()
        {
            return new T_Kiosk_SignalFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Kiosk_ID: {0}", this.Kiosk_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class T_Kiosk_SignalFactory
    {
        
        public T_Kiosk_SignalFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("T_Kiosk_Signal");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("T_Kiosk_Signal");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("T_Kiosk_Signal");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("T_Kiosk_Signal");
            }
        }
        
        public static T_Kiosk_SignalFactory Create()
        {
            return new T_Kiosk_SignalFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (kiosk_ID.HasValue)
            	filter.Add(("Kiosk_ID:=" + kiosk_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kiosk_Kiosk_Code)))
            	filter.Add(("Kiosk_Kiosk_Code:*" + kiosk_Kiosk_Code));
            if (!(String.IsNullOrEmpty(kiosk_KioskType_KioskType_Name)))
            	filter.Add(("Kiosk_KioskType_KioskType_Name:*" + kiosk_KioskType_KioskType_Name));
            if (!(String.IsNullOrEmpty(kiosk_Location_Location_Address)))
            	filter.Add(("Kiosk_Location_Location_Address:*" + kiosk_Location_Location_Address));
            if (!(String.IsNullOrEmpty(kiosk_Location_KioskOwner_KioskOwner_Code)))
            	filter.Add(("Kiosk_Location_KioskOwner_KioskOwner_Code:*" + kiosk_Location_KioskOwner_KioskOwner_Code));
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
        public List<VSM.Data.Objects.T_Kiosk_Signal> Select(System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Kiosk_Signal", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Kiosk_Signal>();
        }
        
        public List<VSM.Data.Objects.T_Kiosk_Signal> Select(VSM.Data.Objects.T_Kiosk_Signal qbe)
        {
            return Select(qbe.Kiosk_ID, qbe.Kiosk_Kiosk_Code, qbe.Kiosk_KioskType_KioskType_Name, qbe.Kiosk_Location_Location_Address, qbe.Kiosk_Location_KioskOwner_KioskOwner_Code, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Kiosk_Signal", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.T_Kiosk_Signal> Select(System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.T_Kiosk_Signal SelectSingle(System.Guid? kiosk_ID)
        {
            List<VSM.Data.Objects.T_Kiosk_Signal> list = Select(kiosk_ID, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.T_Kiosk_Signal> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("T_Kiosk_Signal", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Kiosk_Signal>();
        }
        
        public List<VSM.Data.Objects.T_Kiosk_Signal> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.T_Kiosk_Signal> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.T_Kiosk_Signal SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.T_Kiosk_Signal> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.T_Kiosk_Signal theT_Kiosk_Signal, VSM.Data.Objects.T_Kiosk_Signal original_T_Kiosk_Signal)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Kiosk_ID", original_T_Kiosk_Signal.Kiosk_ID, theT_Kiosk_Signal.Kiosk_ID));
            values.Add(new FieldValue("Kiosk_Kiosk_Code", original_T_Kiosk_Signal.Kiosk_Kiosk_Code, theT_Kiosk_Signal.Kiosk_Kiosk_Code, true));
            values.Add(new FieldValue("Kiosk_KioskType_KioskType_Name", original_T_Kiosk_Signal.Kiosk_KioskType_KioskType_Name, theT_Kiosk_Signal.Kiosk_KioskType_KioskType_Name, true));
            values.Add(new FieldValue("Kiosk_Location_Location_Address", original_T_Kiosk_Signal.Kiosk_Location_Location_Address, theT_Kiosk_Signal.Kiosk_Location_Location_Address, true));
            values.Add(new FieldValue("Kiosk_Location_KioskOwner_KioskOwner_Code", original_T_Kiosk_Signal.Kiosk_Location_KioskOwner_KioskOwner_Code, theT_Kiosk_Signal.Kiosk_Location_KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("CreatedBy", original_T_Kiosk_Signal.CreatedBy, theT_Kiosk_Signal.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_T_Kiosk_Signal.CreatedOn, theT_Kiosk_Signal.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_T_Kiosk_Signal.ModifiedBy, theT_Kiosk_Signal.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_T_Kiosk_Signal.ModifiedOn, theT_Kiosk_Signal.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.T_Kiosk_Signal theT_Kiosk_Signal, VSM.Data.Objects.T_Kiosk_Signal original_T_Kiosk_Signal, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "T_Kiosk_Signal";
            args.View = dataView;
            args.Values = CreateFieldValues(theT_Kiosk_Signal, original_T_Kiosk_Signal);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("T_Kiosk_Signal", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theT_Kiosk_Signal);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.T_Kiosk_Signal theT_Kiosk_Signal, VSM.Data.Objects.T_Kiosk_Signal original_T_Kiosk_Signal)
        {
            return ExecuteAction(theT_Kiosk_Signal, original_T_Kiosk_Signal, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.T_Kiosk_Signal theT_Kiosk_Signal)
        {
            return Update(theT_Kiosk_Signal, SelectSingle(theT_Kiosk_Signal.Kiosk_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.T_Kiosk_Signal theT_Kiosk_Signal)
        {
            return ExecuteAction(theT_Kiosk_Signal, new T_Kiosk_Signal(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.T_Kiosk_Signal theT_Kiosk_Signal)
        {
            return ExecuteAction(theT_Kiosk_Signal, theT_Kiosk_Signal, "Select", "Delete", DeleteView);
        }
    }
}

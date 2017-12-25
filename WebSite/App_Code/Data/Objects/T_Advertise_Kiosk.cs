using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class T_Advertise_Kiosk
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _advertise_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advertise_Advertise_Desc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advertise_KioskOwner_KioskOwner_Code;
        
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
        
        public T_Advertise_Kiosk()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? Advertise_ID
        {
            get
            {
                return _advertise_ID;
            }
            set
            {
                _advertise_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Advertise_Advertise_Desc
        {
            get
            {
                return _advertise_Advertise_Desc;
            }
            set
            {
                _advertise_Advertise_Desc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Advertise_KioskOwner_KioskOwner_Code
        {
            get
            {
                return _advertise_KioskOwner_KioskOwner_Code;
            }
            set
            {
                _advertise_KioskOwner_KioskOwner_Code = value;
            }
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
        
        public static List<VSM.Data.Objects.T_Advertise_Kiosk> Select(System.Guid? advertise_ID, string advertise_Advertise_Desc, string advertise_KioskOwner_KioskOwner_Code, System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new T_Advertise_KioskFactory().Select(advertise_ID, advertise_Advertise_Desc, advertise_KioskOwner_KioskOwner_Code, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.T_Advertise_Kiosk> Select(VSM.Data.Objects.T_Advertise_Kiosk qbe)
        {
            return new T_Advertise_KioskFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.T_Advertise_Kiosk> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new T_Advertise_KioskFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Advertise_Kiosk> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new T_Advertise_KioskFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Advertise_Kiosk> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new T_Advertise_KioskFactory().Select(filter, sort, T_Advertise_KioskFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Advertise_Kiosk> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new T_Advertise_KioskFactory().Select(filter, sort, T_Advertise_KioskFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Advertise_Kiosk> Select(string filter, BusinessObjectParameters parameters)
        {
            return new T_Advertise_KioskFactory().Select(filter, null, T_Advertise_KioskFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Advertise_Kiosk> Select(string filter, params FieldValue[] parameters)
        {
            return new T_Advertise_KioskFactory().Select(filter, null, T_Advertise_KioskFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Advertise_Kiosk SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new T_Advertise_KioskFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.T_Advertise_Kiosk SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new T_Advertise_KioskFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Advertise_Kiosk SelectSingle(System.Guid? advertise_ID, System.Guid? kiosk_ID)
        {
            return new T_Advertise_KioskFactory().SelectSingle(advertise_ID, kiosk_ID);
        }
        
        public int Insert()
        {
            return new T_Advertise_KioskFactory().Insert(this);
        }
        
        public int Update()
        {
            return new T_Advertise_KioskFactory().Update(this);
        }
        
        public int Delete()
        {
            return new T_Advertise_KioskFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Advertise_ID: {0}; Kiosk_ID: {1}", this.Advertise_ID, this.Kiosk_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class T_Advertise_KioskFactory
    {
        
        public T_Advertise_KioskFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("T_Advertise_Kiosk");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("T_Advertise_Kiosk");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("T_Advertise_Kiosk");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("T_Advertise_Kiosk");
            }
        }
        
        public static T_Advertise_KioskFactory Create()
        {
            return new T_Advertise_KioskFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? advertise_ID, string advertise_Advertise_Desc, string advertise_KioskOwner_KioskOwner_Code, System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (advertise_ID.HasValue)
            	filter.Add(("Advertise_ID:=" + advertise_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(advertise_Advertise_Desc)))
            	filter.Add(("Advertise_Advertise_Desc:*" + advertise_Advertise_Desc));
            if (!(String.IsNullOrEmpty(advertise_KioskOwner_KioskOwner_Code)))
            	filter.Add(("Advertise_KioskOwner_KioskOwner_Code:*" + advertise_KioskOwner_KioskOwner_Code));
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
        public List<VSM.Data.Objects.T_Advertise_Kiosk> Select(
                    System.Guid? advertise_ID, 
                    string advertise_Advertise_Desc, 
                    string advertise_KioskOwner_KioskOwner_Code, 
                    System.Guid? kiosk_ID, 
                    string kiosk_Kiosk_Code, 
                    string kiosk_KioskType_KioskType_Name, 
                    string kiosk_Location_Location_Address, 
                    string kiosk_Location_KioskOwner_KioskOwner_Code, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(advertise_ID, advertise_Advertise_Desc, advertise_KioskOwner_KioskOwner_Code, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Advertise_Kiosk", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Advertise_Kiosk>();
        }
        
        public List<VSM.Data.Objects.T_Advertise_Kiosk> Select(VSM.Data.Objects.T_Advertise_Kiosk qbe)
        {
            return Select(qbe.Advertise_ID, qbe.Advertise_Advertise_Desc, qbe.Advertise_KioskOwner_KioskOwner_Code, qbe.Kiosk_ID, qbe.Kiosk_Kiosk_Code, qbe.Kiosk_KioskType_KioskType_Name, qbe.Kiosk_Location_Location_Address, qbe.Kiosk_Location_KioskOwner_KioskOwner_Code, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? advertise_ID, 
                    string advertise_Advertise_Desc, 
                    string advertise_KioskOwner_KioskOwner_Code, 
                    System.Guid? kiosk_ID, 
                    string kiosk_Kiosk_Code, 
                    string kiosk_KioskType_KioskType_Name, 
                    string kiosk_Location_Location_Address, 
                    string kiosk_Location_KioskOwner_KioskOwner_Code, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(advertise_ID, advertise_Advertise_Desc, advertise_KioskOwner_KioskOwner_Code, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Advertise_Kiosk", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.T_Advertise_Kiosk> Select(System.Guid? advertise_ID, string advertise_Advertise_Desc, string advertise_KioskOwner_KioskOwner_Code, System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(advertise_ID, advertise_Advertise_Desc, advertise_KioskOwner_KioskOwner_Code, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.T_Advertise_Kiosk SelectSingle(System.Guid? advertise_ID, System.Guid? kiosk_ID)
        {
            List<VSM.Data.Objects.T_Advertise_Kiosk> list = Select(advertise_ID, null, null, kiosk_ID, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.T_Advertise_Kiosk> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("T_Advertise_Kiosk", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Advertise_Kiosk>();
        }
        
        public List<VSM.Data.Objects.T_Advertise_Kiosk> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.T_Advertise_Kiosk> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.T_Advertise_Kiosk SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.T_Advertise_Kiosk> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.T_Advertise_Kiosk theT_Advertise_Kiosk, VSM.Data.Objects.T_Advertise_Kiosk original_T_Advertise_Kiosk)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Advertise_ID", original_T_Advertise_Kiosk.Advertise_ID, theT_Advertise_Kiosk.Advertise_ID));
            values.Add(new FieldValue("Advertise_Advertise_Desc", original_T_Advertise_Kiosk.Advertise_Advertise_Desc, theT_Advertise_Kiosk.Advertise_Advertise_Desc, true));
            values.Add(new FieldValue("Advertise_KioskOwner_KioskOwner_Code", original_T_Advertise_Kiosk.Advertise_KioskOwner_KioskOwner_Code, theT_Advertise_Kiosk.Advertise_KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("Kiosk_ID", original_T_Advertise_Kiosk.Kiosk_ID, theT_Advertise_Kiosk.Kiosk_ID));
            values.Add(new FieldValue("Kiosk_Kiosk_Code", original_T_Advertise_Kiosk.Kiosk_Kiosk_Code, theT_Advertise_Kiosk.Kiosk_Kiosk_Code, true));
            values.Add(new FieldValue("Kiosk_KioskType_KioskType_Name", original_T_Advertise_Kiosk.Kiosk_KioskType_KioskType_Name, theT_Advertise_Kiosk.Kiosk_KioskType_KioskType_Name, true));
            values.Add(new FieldValue("Kiosk_Location_Location_Address", original_T_Advertise_Kiosk.Kiosk_Location_Location_Address, theT_Advertise_Kiosk.Kiosk_Location_Location_Address, true));
            values.Add(new FieldValue("Kiosk_Location_KioskOwner_KioskOwner_Code", original_T_Advertise_Kiosk.Kiosk_Location_KioskOwner_KioskOwner_Code, theT_Advertise_Kiosk.Kiosk_Location_KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("CreatedBy", original_T_Advertise_Kiosk.CreatedBy, theT_Advertise_Kiosk.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_T_Advertise_Kiosk.CreatedOn, theT_Advertise_Kiosk.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_T_Advertise_Kiosk.ModifiedBy, theT_Advertise_Kiosk.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_T_Advertise_Kiosk.ModifiedOn, theT_Advertise_Kiosk.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.T_Advertise_Kiosk theT_Advertise_Kiosk, VSM.Data.Objects.T_Advertise_Kiosk original_T_Advertise_Kiosk, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "T_Advertise_Kiosk";
            args.View = dataView;
            args.Values = CreateFieldValues(theT_Advertise_Kiosk, original_T_Advertise_Kiosk);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("T_Advertise_Kiosk", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theT_Advertise_Kiosk);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.T_Advertise_Kiosk theT_Advertise_Kiosk, VSM.Data.Objects.T_Advertise_Kiosk original_T_Advertise_Kiosk)
        {
            return ExecuteAction(theT_Advertise_Kiosk, original_T_Advertise_Kiosk, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.T_Advertise_Kiosk theT_Advertise_Kiosk)
        {
            return Update(theT_Advertise_Kiosk, SelectSingle(theT_Advertise_Kiosk.Advertise_ID, theT_Advertise_Kiosk.Kiosk_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.T_Advertise_Kiosk theT_Advertise_Kiosk)
        {
            return ExecuteAction(theT_Advertise_Kiosk, new T_Advertise_Kiosk(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.T_Advertise_Kiosk theT_Advertise_Kiosk)
        {
            return ExecuteAction(theT_Advertise_Kiosk, theT_Advertise_Kiosk, "Select", "Delete", DeleteView);
        }
    }
}

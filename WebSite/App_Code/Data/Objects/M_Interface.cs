using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_Interface
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _interface_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _interface_Name;
        
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
        
        public M_Interface()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public string Interface_Code
        {
            get
            {
                return _interface_Code;
            }
            set
            {
                _interface_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Interface_Name
        {
            get
            {
                return _interface_Name;
            }
            set
            {
                _interface_Name = value;
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
        
        public static List<VSM.Data.Objects.M_Interface> Select(string interface_Code, string interface_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_InterfaceFactory().Select(interface_Code, interface_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_Interface> Select(VSM.Data.Objects.M_Interface qbe)
        {
            return new M_InterfaceFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_Interface> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_InterfaceFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Interface> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_InterfaceFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Interface> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_InterfaceFactory().Select(filter, sort, M_InterfaceFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Interface> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_InterfaceFactory().Select(filter, sort, M_InterfaceFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Interface> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_InterfaceFactory().Select(filter, null, M_InterfaceFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Interface> Select(string filter, params FieldValue[] parameters)
        {
            return new M_InterfaceFactory().Select(filter, null, M_InterfaceFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Interface SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_InterfaceFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_Interface SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_InterfaceFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Interface SelectSingle(string interface_Code)
        {
            return new M_InterfaceFactory().SelectSingle(interface_Code);
        }
        
        public int Insert()
        {
            return new M_InterfaceFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_InterfaceFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_InterfaceFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Interface_Code: {0}", this.Interface_Code);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_InterfaceFactory
    {
        
        public M_InterfaceFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_Interface");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_Interface");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_Interface");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_Interface");
            }
        }
        
        public static M_InterfaceFactory Create()
        {
            return new M_InterfaceFactory();
        }
        
        protected virtual PageRequest CreateRequest(string interface_Code, string interface_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (interface_Code != null)
            	filter.Add(("Interface_Code:=" + interface_Code));
            if (!(String.IsNullOrEmpty(interface_Name)))
            	filter.Add(("Interface_Name:*" + interface_Name));
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
        public List<VSM.Data.Objects.M_Interface> Select(string interface_Code, string interface_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(interface_Code, interface_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Interface", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Interface>();
        }
        
        public List<VSM.Data.Objects.M_Interface> Select(VSM.Data.Objects.M_Interface qbe)
        {
            return Select(qbe.Interface_Code, qbe.Interface_Name, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(string interface_Code, string interface_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(interface_Code, interface_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Interface", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_Interface> Select(string interface_Code, string interface_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(interface_Code, interface_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_Interface SelectSingle(string interface_Code)
        {
            List<VSM.Data.Objects.M_Interface> list = Select(interface_Code, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_Interface> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_Interface", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Interface>();
        }
        
        public List<VSM.Data.Objects.M_Interface> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_Interface> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_Interface SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_Interface> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_Interface theM_Interface, VSM.Data.Objects.M_Interface original_M_Interface)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Interface_Code", original_M_Interface.Interface_Code, theM_Interface.Interface_Code));
            values.Add(new FieldValue("Interface_Name", original_M_Interface.Interface_Name, theM_Interface.Interface_Name));
            values.Add(new FieldValue("Item_Flag", original_M_Interface.Item_Flag, theM_Interface.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_Interface.CreatedBy, theM_Interface.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_Interface.CreatedOn, theM_Interface.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_Interface.ModifiedBy, theM_Interface.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_Interface.ModifiedOn, theM_Interface.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_Interface theM_Interface, VSM.Data.Objects.M_Interface original_M_Interface, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_Interface";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_Interface, original_M_Interface);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_Interface", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_Interface);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_Interface theM_Interface, VSM.Data.Objects.M_Interface original_M_Interface)
        {
            return ExecuteAction(theM_Interface, original_M_Interface, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_Interface theM_Interface)
        {
            return Update(theM_Interface, SelectSingle(theM_Interface.Interface_Code));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_Interface theM_Interface)
        {
            return ExecuteAction(theM_Interface, new M_Interface(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_Interface theM_Interface)
        {
            return ExecuteAction(theM_Interface, theM_Interface, "Select", "Delete", DeleteView);
        }
    }
}

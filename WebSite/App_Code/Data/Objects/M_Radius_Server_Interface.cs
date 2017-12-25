using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_Radius_Server_Interface
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _radiusServer_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _radiusServer_RadiusServer_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _interface_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _interface_Interface_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        public M_Radius_Server_Interface()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public string RadiusServer_Code
        {
            get
            {
                return _radiusServer_Code;
            }
            set
            {
                _radiusServer_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RadiusServer_RadiusServer_Name
        {
            get
            {
                return _radiusServer_RadiusServer_Name;
            }
            set
            {
                _radiusServer_RadiusServer_Name = value;
            }
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
        public string Interface_Interface_Name
        {
            get
            {
                return _interface_Interface_Name;
            }
            set
            {
                _interface_Interface_Name = value;
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
        
        public static List<VSM.Data.Objects.M_Radius_Server_Interface> Select(string radiusServer_Code, string radiusServer_RadiusServer_Name, string interface_Code, string interface_Interface_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_Radius_Server_InterfaceFactory().Select(radiusServer_Code, radiusServer_RadiusServer_Name, interface_Code, interface_Interface_Name, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_Radius_Server_Interface> Select(VSM.Data.Objects.M_Radius_Server_Interface qbe)
        {
            return new M_Radius_Server_InterfaceFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_Radius_Server_Interface> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_Radius_Server_InterfaceFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Radius_Server_Interface> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_Radius_Server_InterfaceFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Radius_Server_Interface> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_Radius_Server_InterfaceFactory().Select(filter, sort, M_Radius_Server_InterfaceFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Radius_Server_Interface> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_Radius_Server_InterfaceFactory().Select(filter, sort, M_Radius_Server_InterfaceFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Radius_Server_Interface> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_Radius_Server_InterfaceFactory().Select(filter, null, M_Radius_Server_InterfaceFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Radius_Server_Interface> Select(string filter, params FieldValue[] parameters)
        {
            return new M_Radius_Server_InterfaceFactory().Select(filter, null, M_Radius_Server_InterfaceFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Radius_Server_Interface SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_Radius_Server_InterfaceFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_Radius_Server_Interface SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_Radius_Server_InterfaceFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Radius_Server_Interface SelectSingle(string radiusServer_Code, string interface_Code)
        {
            return new M_Radius_Server_InterfaceFactory().SelectSingle(radiusServer_Code, interface_Code);
        }
        
        public int Insert()
        {
            return new M_Radius_Server_InterfaceFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_Radius_Server_InterfaceFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_Radius_Server_InterfaceFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("RadiusServer_Code: {0}; Interface_Code: {1}", this.RadiusServer_Code, this.Interface_Code);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_Radius_Server_InterfaceFactory
    {
        
        public M_Radius_Server_InterfaceFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_Radius_Server_Interface");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_Radius_Server_Interface");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_Radius_Server_Interface");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_Radius_Server_Interface");
            }
        }
        
        public static M_Radius_Server_InterfaceFactory Create()
        {
            return new M_Radius_Server_InterfaceFactory();
        }
        
        protected virtual PageRequest CreateRequest(string radiusServer_Code, string radiusServer_RadiusServer_Name, string interface_Code, string interface_Interface_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (radiusServer_Code != null)
            	filter.Add(("RadiusServer_Code:=" + radiusServer_Code));
            if (!(String.IsNullOrEmpty(radiusServer_RadiusServer_Name)))
            	filter.Add(("RadiusServer_RadiusServer_Name:*" + radiusServer_RadiusServer_Name));
            if (interface_Code != null)
            	filter.Add(("Interface_Code:=" + interface_Code));
            if (!(String.IsNullOrEmpty(interface_Interface_Name)))
            	filter.Add(("Interface_Interface_Name:*" + interface_Interface_Name));
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
        public List<VSM.Data.Objects.M_Radius_Server_Interface> Select(string radiusServer_Code, string radiusServer_RadiusServer_Name, string interface_Code, string interface_Interface_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(radiusServer_Code, radiusServer_RadiusServer_Name, interface_Code, interface_Interface_Name, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Radius_Server_Interface", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Radius_Server_Interface>();
        }
        
        public List<VSM.Data.Objects.M_Radius_Server_Interface> Select(VSM.Data.Objects.M_Radius_Server_Interface qbe)
        {
            return Select(qbe.RadiusServer_Code, qbe.RadiusServer_RadiusServer_Name, qbe.Interface_Code, qbe.Interface_Interface_Name, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(string radiusServer_Code, string radiusServer_RadiusServer_Name, string interface_Code, string interface_Interface_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(radiusServer_Code, radiusServer_RadiusServer_Name, interface_Code, interface_Interface_Name, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Radius_Server_Interface", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_Radius_Server_Interface> Select(string radiusServer_Code, string radiusServer_RadiusServer_Name, string interface_Code, string interface_Interface_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(radiusServer_Code, radiusServer_RadiusServer_Name, interface_Code, interface_Interface_Name, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_Radius_Server_Interface SelectSingle(string radiusServer_Code, string interface_Code)
        {
            List<VSM.Data.Objects.M_Radius_Server_Interface> list = Select(radiusServer_Code, null, interface_Code, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_Radius_Server_Interface> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_Radius_Server_Interface", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Radius_Server_Interface>();
        }
        
        public List<VSM.Data.Objects.M_Radius_Server_Interface> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_Radius_Server_Interface> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_Radius_Server_Interface SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_Radius_Server_Interface> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_Radius_Server_Interface theM_Radius_Server_Interface, VSM.Data.Objects.M_Radius_Server_Interface original_M_Radius_Server_Interface)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("RadiusServer_Code", original_M_Radius_Server_Interface.RadiusServer_Code, theM_Radius_Server_Interface.RadiusServer_Code));
            values.Add(new FieldValue("RadiusServer_RadiusServer_Name", original_M_Radius_Server_Interface.RadiusServer_RadiusServer_Name, theM_Radius_Server_Interface.RadiusServer_RadiusServer_Name, true));
            values.Add(new FieldValue("Interface_Code", original_M_Radius_Server_Interface.Interface_Code, theM_Radius_Server_Interface.Interface_Code));
            values.Add(new FieldValue("Interface_Interface_Name", original_M_Radius_Server_Interface.Interface_Interface_Name, theM_Radius_Server_Interface.Interface_Interface_Name, true));
            values.Add(new FieldValue("CreatedBy", original_M_Radius_Server_Interface.CreatedBy, theM_Radius_Server_Interface.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_Radius_Server_Interface.CreatedOn, theM_Radius_Server_Interface.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_Radius_Server_Interface.ModifiedBy, theM_Radius_Server_Interface.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_Radius_Server_Interface.ModifiedOn, theM_Radius_Server_Interface.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_Radius_Server_Interface theM_Radius_Server_Interface, VSM.Data.Objects.M_Radius_Server_Interface original_M_Radius_Server_Interface, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_Radius_Server_Interface";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_Radius_Server_Interface, original_M_Radius_Server_Interface);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_Radius_Server_Interface", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_Radius_Server_Interface);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_Radius_Server_Interface theM_Radius_Server_Interface, VSM.Data.Objects.M_Radius_Server_Interface original_M_Radius_Server_Interface)
        {
            return ExecuteAction(theM_Radius_Server_Interface, original_M_Radius_Server_Interface, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_Radius_Server_Interface theM_Radius_Server_Interface)
        {
            return Update(theM_Radius_Server_Interface, SelectSingle(theM_Radius_Server_Interface.RadiusServer_Code, theM_Radius_Server_Interface.Interface_Code));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_Radius_Server_Interface theM_Radius_Server_Interface)
        {
            return ExecuteAction(theM_Radius_Server_Interface, new M_Radius_Server_Interface(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_Radius_Server_Interface theM_Radius_Server_Interface)
        {
            return ExecuteAction(theM_Radius_Server_Interface, theM_Radius_Server_Interface, "Select", "Delete", DeleteView);
        }
    }
}

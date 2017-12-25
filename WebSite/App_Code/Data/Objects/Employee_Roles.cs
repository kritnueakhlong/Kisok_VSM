using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Employee_Roles
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _emp_id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _emp_password;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _roles_id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _roles_roles_name;
        
        public Employee_Roles()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? emp_id
        {
            get
            {
                return _emp_id;
            }
            set
            {
                _emp_id = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string emp_password
        {
            get
            {
                return _emp_password;
            }
            set
            {
                _emp_password = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? roles_id
        {
            get
            {
                return _roles_id;
            }
            set
            {
                _roles_id = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string roles_roles_name
        {
            get
            {
                return _roles_roles_name;
            }
            set
            {
                _roles_roles_name = value;
            }
        }
        
        public static List<VSM.Data.Objects.Employee_Roles> Select(System.Guid? emp_id, string emp_password, System.Guid? roles_id, string roles_roles_name)
        {
            return new Employee_RolesFactory().Select(emp_id, emp_password, roles_id, roles_roles_name);
        }
        
        public static List<VSM.Data.Objects.Employee_Roles> Select(VSM.Data.Objects.Employee_Roles qbe)
        {
            return new Employee_RolesFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.Employee_Roles> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new Employee_RolesFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.Employee_Roles> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new Employee_RolesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.Employee_Roles> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new Employee_RolesFactory().Select(filter, sort, Employee_RolesFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.Employee_Roles> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new Employee_RolesFactory().Select(filter, sort, Employee_RolesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.Employee_Roles> Select(string filter, BusinessObjectParameters parameters)
        {
            return new Employee_RolesFactory().Select(filter, null, Employee_RolesFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.Employee_Roles> Select(string filter, params FieldValue[] parameters)
        {
            return new Employee_RolesFactory().Select(filter, null, Employee_RolesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.Employee_Roles SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new Employee_RolesFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.Employee_Roles SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new Employee_RolesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.Employee_Roles SelectSingle(System.Guid? emp_id, System.Guid? roles_id)
        {
            return new Employee_RolesFactory().SelectSingle(emp_id, roles_id);
        }
        
        public int Insert()
        {
            return new Employee_RolesFactory().Insert(this);
        }
        
        public int Update()
        {
            return new Employee_RolesFactory().Update(this);
        }
        
        public int Delete()
        {
            return new Employee_RolesFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("emp_id: {0}; roles_id: {1}", this.emp_id, this.roles_id);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class Employee_RolesFactory
    {
        
        public Employee_RolesFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Employee_Roles");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Employee_Roles");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Employee_Roles");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Employee_Roles");
            }
        }
        
        public static Employee_RolesFactory Create()
        {
            return new Employee_RolesFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? emp_id, string emp_password, System.Guid? roles_id, string roles_roles_name, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (emp_id.HasValue)
            	filter.Add(("emp_id:=" + emp_id.Value.ToString()));
            if (!(String.IsNullOrEmpty(emp_password)))
            	filter.Add(("emp_password:*" + emp_password));
            if (roles_id.HasValue)
            	filter.Add(("roles_id:=" + roles_id.Value.ToString()));
            if (!(String.IsNullOrEmpty(roles_roles_name)))
            	filter.Add(("roles_roles_name:*" + roles_roles_name));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<VSM.Data.Objects.Employee_Roles> Select(System.Guid? emp_id, string emp_password, System.Guid? roles_id, string roles_roles_name, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(emp_id, emp_password, roles_id, roles_roles_name, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Employee_Roles", dataView, request);
            return page.ToList<VSM.Data.Objects.Employee_Roles>();
        }
        
        public List<VSM.Data.Objects.Employee_Roles> Select(VSM.Data.Objects.Employee_Roles qbe)
        {
            return Select(qbe.emp_id, qbe.emp_password, qbe.roles_id, qbe.roles_roles_name);
        }
        
        public int SelectCount(System.Guid? emp_id, string emp_password, System.Guid? roles_id, string roles_roles_name, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(emp_id, emp_password, roles_id, roles_roles_name, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Employee_Roles", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.Employee_Roles> Select(System.Guid? emp_id, string emp_password, System.Guid? roles_id, string roles_roles_name)
        {
            return Select(emp_id, emp_password, roles_id, roles_roles_name, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.Employee_Roles SelectSingle(System.Guid? emp_id, System.Guid? roles_id)
        {
            string emptyemp_password = null;
            string emptyroles_roles_name = null;
            List<VSM.Data.Objects.Employee_Roles> list = Select(emp_id, emptyemp_password, roles_id, emptyroles_roles_name);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.Employee_Roles> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Employee_Roles", dataView, request);
            return page.ToList<VSM.Data.Objects.Employee_Roles>();
        }
        
        public List<VSM.Data.Objects.Employee_Roles> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.Employee_Roles> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.Employee_Roles SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.Employee_Roles> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.Employee_Roles theEmployee_Roles, VSM.Data.Objects.Employee_Roles original_Employee_Roles)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("emp_id", original_Employee_Roles.emp_id, theEmployee_Roles.emp_id));
            values.Add(new FieldValue("emp_password", original_Employee_Roles.emp_password, theEmployee_Roles.emp_password, true));
            values.Add(new FieldValue("roles_id", original_Employee_Roles.roles_id, theEmployee_Roles.roles_id));
            values.Add(new FieldValue("roles_roles_name", original_Employee_Roles.roles_roles_name, theEmployee_Roles.roles_roles_name, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.Employee_Roles theEmployee_Roles, VSM.Data.Objects.Employee_Roles original_Employee_Roles, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Employee_Roles";
            args.View = dataView;
            args.Values = CreateFieldValues(theEmployee_Roles, original_Employee_Roles);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Employee_Roles", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theEmployee_Roles);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.Employee_Roles theEmployee_Roles, VSM.Data.Objects.Employee_Roles original_Employee_Roles)
        {
            return ExecuteAction(theEmployee_Roles, original_Employee_Roles, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.Employee_Roles theEmployee_Roles)
        {
            return Update(theEmployee_Roles, SelectSingle(theEmployee_Roles.emp_id, theEmployee_Roles.roles_id));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.Employee_Roles theEmployee_Roles)
        {
            return ExecuteAction(theEmployee_Roles, new Employee_Roles(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.Employee_Roles theEmployee_Roles)
        {
            return ExecuteAction(theEmployee_Roles, theEmployee_Roles, "Select", "Delete", DeleteView);
        }
    }
}

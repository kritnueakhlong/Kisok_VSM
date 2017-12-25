using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Employee
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _emp_id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _emp_code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _password;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _emp_fname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _emp_lname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _emp_email;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _team_id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _telephone;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_Branch_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Branch_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _updatename;
        
        public Employee()
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string emp_code
        {
            get
            {
                return _emp_code;
            }
            set
            {
                _emp_code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string emp_fname
        {
            get
            {
                return _emp_fname;
            }
            set
            {
                _emp_fname = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string emp_lname
        {
            get
            {
                return _emp_lname;
            }
            set
            {
                _emp_lname = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string emp_email
        {
            get
            {
                return _emp_email;
            }
            set
            {
                _emp_email = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? team_id
        {
            get
            {
                return _team_id;
            }
            set
            {
                _team_id = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string telephone
        {
            get
            {
                return _telephone;
            }
            set
            {
                _telephone = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string createname
        {
            get
            {
                return _createname;
            }
            set
            {
                _createname = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string updatename
        {
            get
            {
                return _updatename;
            }
            set
            {
                _updatename = value;
            }
        }
        
        public static List<VSM.Data.Objects.Employee> Select(
                    System.Guid? emp_id, 
                    string emp_code, 
                    string password, 
                    string emp_fname, 
                    string emp_lname, 
                    string emp_email, 
                    int? team_id, 
                    string telephone, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kioskOwner_Branch_Code, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn)
        {
            return new EmployeeFactory().Select(emp_id, emp_code, password, emp_fname, emp_lname, emp_email, team_id, telephone, kioskOwner_ID, kioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_Code, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.Employee> Select(VSM.Data.Objects.Employee qbe)
        {
            return new EmployeeFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.Employee> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new EmployeeFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.Employee> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new EmployeeFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.Employee> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new EmployeeFactory().Select(filter, sort, EmployeeFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.Employee> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new EmployeeFactory().Select(filter, sort, EmployeeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.Employee> Select(string filter, BusinessObjectParameters parameters)
        {
            return new EmployeeFactory().Select(filter, null, EmployeeFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.Employee> Select(string filter, params FieldValue[] parameters)
        {
            return new EmployeeFactory().Select(filter, null, EmployeeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.Employee SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new EmployeeFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.Employee SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new EmployeeFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.Employee SelectSingle(System.Guid? emp_id)
        {
            return new EmployeeFactory().SelectSingle(emp_id);
        }
        
        public int Insert()
        {
            return new EmployeeFactory().Insert(this);
        }
        
        public int Update()
        {
            return new EmployeeFactory().Update(this);
        }
        
        public int Delete()
        {
            return new EmployeeFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("emp_id: {0}", this.emp_id);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class EmployeeFactory
    {
        
        public EmployeeFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Employee");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Employee");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Employee");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Employee");
            }
        }
        
        public static EmployeeFactory Create()
        {
            return new EmployeeFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    System.Guid? emp_id, 
                    string emp_code, 
                    string password, 
                    string emp_fname, 
                    string emp_lname, 
                    string emp_email, 
                    int? team_id, 
                    string telephone, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kioskOwner_Branch_Code, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (emp_id.HasValue)
            	filter.Add(("emp_id:=" + emp_id.Value.ToString()));
            if (!(String.IsNullOrEmpty(emp_code)))
            	filter.Add(("emp_code:*" + emp_code));
            if (!(String.IsNullOrEmpty(password)))
            	filter.Add(("password:*" + password));
            if (!(String.IsNullOrEmpty(emp_fname)))
            	filter.Add(("emp_fname:*" + emp_fname));
            if (!(String.IsNullOrEmpty(emp_lname)))
            	filter.Add(("emp_lname:*" + emp_lname));
            if (!(String.IsNullOrEmpty(emp_email)))
            	filter.Add(("emp_email:*" + emp_email));
            if (team_id.HasValue)
            	filter.Add(("team_id:=" + team_id.Value.ToString()));
            if (!(String.IsNullOrEmpty(telephone)))
            	filter.Add(("telephone:*" + telephone));
            if (kioskOwner_ID.HasValue)
            	filter.Add(("KioskOwner_ID:=" + kioskOwner_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_Code)))
            	filter.Add(("KioskOwner_Code:*" + kioskOwner_Code));
            if (kioskOwner_Branch_ID.HasValue)
            	filter.Add(("KioskOwner_Branch_ID:=" + kioskOwner_Branch_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_Branch_Code)))
            	filter.Add(("KioskOwner_Branch_Code:*" + kioskOwner_Branch_Code));
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
        public List<VSM.Data.Objects.Employee> Select(
                    System.Guid? emp_id, 
                    string emp_code, 
                    string password, 
                    string emp_fname, 
                    string emp_lname, 
                    string emp_email, 
                    int? team_id, 
                    string telephone, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kioskOwner_Branch_Code, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(emp_id, emp_code, password, emp_fname, emp_lname, emp_email, team_id, telephone, kioskOwner_ID, kioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_Code, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Employee", dataView, request);
            return page.ToList<VSM.Data.Objects.Employee>();
        }
        
        public List<VSM.Data.Objects.Employee> Select(VSM.Data.Objects.Employee qbe)
        {
            return Select(qbe.emp_id, qbe.emp_code, qbe.password, qbe.emp_fname, qbe.emp_lname, qbe.emp_email, qbe.team_id, qbe.telephone, qbe.KioskOwner_ID, qbe.KioskOwner_Code, qbe.KioskOwner_Branch_ID, qbe.KioskOwner_Branch_Code, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? emp_id, 
                    string emp_code, 
                    string password, 
                    string emp_fname, 
                    string emp_lname, 
                    string emp_email, 
                    int? team_id, 
                    string telephone, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kioskOwner_Branch_Code, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(emp_id, emp_code, password, emp_fname, emp_lname, emp_email, team_id, telephone, kioskOwner_ID, kioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_Code, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Employee", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.Employee> Select(
                    System.Guid? emp_id, 
                    string emp_code, 
                    string password, 
                    string emp_fname, 
                    string emp_lname, 
                    string emp_email, 
                    int? team_id, 
                    string telephone, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kioskOwner_Branch_Code, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn)
        {
            return Select(emp_id, emp_code, password, emp_fname, emp_lname, emp_email, team_id, telephone, kioskOwner_ID, kioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_Code, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.Employee SelectSingle(System.Guid? emp_id)
        {
            List<VSM.Data.Objects.Employee> list = Select(emp_id, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.Employee> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Employee", dataView, request);
            return page.ToList<VSM.Data.Objects.Employee>();
        }
        
        public List<VSM.Data.Objects.Employee> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.Employee> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.Employee SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.Employee> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.Employee theEmployee, VSM.Data.Objects.Employee original_Employee)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("emp_id", original_Employee.emp_id, theEmployee.emp_id));
            values.Add(new FieldValue("emp_code", original_Employee.emp_code, theEmployee.emp_code));
            values.Add(new FieldValue("password", original_Employee.password, theEmployee.password));
            values.Add(new FieldValue("emp_fname", original_Employee.emp_fname, theEmployee.emp_fname));
            values.Add(new FieldValue("emp_lname", original_Employee.emp_lname, theEmployee.emp_lname));
            values.Add(new FieldValue("emp_email", original_Employee.emp_email, theEmployee.emp_email));
            values.Add(new FieldValue("team_id", original_Employee.team_id, theEmployee.team_id));
            values.Add(new FieldValue("telephone", original_Employee.telephone, theEmployee.telephone));
            values.Add(new FieldValue("KioskOwner_ID", original_Employee.KioskOwner_ID, theEmployee.KioskOwner_ID));
            values.Add(new FieldValue("KioskOwner_Code", original_Employee.KioskOwner_Code, theEmployee.KioskOwner_Code, true));
            values.Add(new FieldValue("KioskOwner_Branch_ID", original_Employee.KioskOwner_Branch_ID, theEmployee.KioskOwner_Branch_ID));
            values.Add(new FieldValue("KioskOwner_Branch_Code", original_Employee.KioskOwner_Branch_Code, theEmployee.KioskOwner_Branch_Code, true));
            values.Add(new FieldValue("CreatedBy", original_Employee.CreatedBy, theEmployee.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_Employee.CreatedOn, theEmployee.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_Employee.ModifiedBy, theEmployee.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_Employee.ModifiedOn, theEmployee.ModifiedOn));
            values.Add(new FieldValue("createname", original_Employee.createname, theEmployee.createname));
            values.Add(new FieldValue("updatename", original_Employee.updatename, theEmployee.updatename));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.Employee theEmployee, VSM.Data.Objects.Employee original_Employee, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Employee";
            args.View = dataView;
            args.Values = CreateFieldValues(theEmployee, original_Employee);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Employee", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theEmployee);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.Employee theEmployee, VSM.Data.Objects.Employee original_Employee)
        {
            return ExecuteAction(theEmployee, original_Employee, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.Employee theEmployee)
        {
            return Update(theEmployee, SelectSingle(theEmployee.emp_id));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.Employee theEmployee)
        {
            return ExecuteAction(theEmployee, new Employee(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.Employee theEmployee)
        {
            return ExecuteAction(theEmployee, theEmployee, "Select", "Delete", DeleteView);
        }
    }
}

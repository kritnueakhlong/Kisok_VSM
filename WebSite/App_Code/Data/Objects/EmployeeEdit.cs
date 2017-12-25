using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class EmployeeEdit
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
        private string _kioskOwner_KioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_Branch_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Branch_KioskOwner_Branch_Code;
        
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
        
        public EmployeeEdit()
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
        
        public static List<VSM.Data.Objects.EmployeeEdit> Select(
                    System.Guid? emp_id, 
                    string emp_code, 
                    string password, 
                    string emp_fname, 
                    string emp_lname, 
                    string emp_email, 
                    int? team_id, 
                    string telephone, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kioskOwner_Branch_KioskOwner_Branch_Code, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn)
        {
            return new EmployeeEditFactory().Select(emp_id, emp_code, password, emp_fname, emp_lname, emp_email, team_id, telephone, kioskOwner_ID, kioskOwner_KioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_KioskOwner_Branch_Code, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.EmployeeEdit> Select(VSM.Data.Objects.EmployeeEdit qbe)
        {
            return new EmployeeEditFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.EmployeeEdit> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new EmployeeEditFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.EmployeeEdit> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new EmployeeEditFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.EmployeeEdit> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new EmployeeEditFactory().Select(filter, sort, EmployeeEditFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.EmployeeEdit> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new EmployeeEditFactory().Select(filter, sort, EmployeeEditFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.EmployeeEdit> Select(string filter, BusinessObjectParameters parameters)
        {
            return new EmployeeEditFactory().Select(filter, null, EmployeeEditFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.EmployeeEdit> Select(string filter, params FieldValue[] parameters)
        {
            return new EmployeeEditFactory().Select(filter, null, EmployeeEditFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.EmployeeEdit SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new EmployeeEditFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.EmployeeEdit SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new EmployeeEditFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.EmployeeEdit SelectSingle(System.Guid? emp_id)
        {
            return new EmployeeEditFactory().SelectSingle(emp_id);
        }
        
        public int Insert()
        {
            return new EmployeeEditFactory().Insert(this);
        }
        
        public int Update()
        {
            return new EmployeeEditFactory().Update(this);
        }
        
        public int Delete()
        {
            return new EmployeeEditFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("emp_id: {0}", this.emp_id);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class EmployeeEditFactory
    {
        
        public EmployeeEditFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("EmployeeEdit");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("EmployeeEdit");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("EmployeeEdit");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("EmployeeEdit");
            }
        }
        
        public static EmployeeEditFactory Create()
        {
            return new EmployeeEditFactory();
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
                    string kioskOwner_KioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kioskOwner_Branch_KioskOwner_Branch_Code, 
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
            if (!(String.IsNullOrEmpty(kioskOwner_KioskOwner_Code)))
            	filter.Add(("KioskOwner_KioskOwner_Code:*" + kioskOwner_KioskOwner_Code));
            if (kioskOwner_Branch_ID.HasValue)
            	filter.Add(("KioskOwner_Branch_ID:=" + kioskOwner_Branch_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_Branch_KioskOwner_Branch_Code)))
            	filter.Add(("KioskOwner_Branch_KioskOwner_Branch_Code:*" + kioskOwner_Branch_KioskOwner_Branch_Code));
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
        public List<VSM.Data.Objects.EmployeeEdit> Select(
                    System.Guid? emp_id, 
                    string emp_code, 
                    string password, 
                    string emp_fname, 
                    string emp_lname, 
                    string emp_email, 
                    int? team_id, 
                    string telephone, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kioskOwner_Branch_KioskOwner_Branch_Code, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(emp_id, emp_code, password, emp_fname, emp_lname, emp_email, team_id, telephone, kioskOwner_ID, kioskOwner_KioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_KioskOwner_Branch_Code, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("EmployeeEdit", dataView, request);
            return page.ToList<VSM.Data.Objects.EmployeeEdit>();
        }
        
        public List<VSM.Data.Objects.EmployeeEdit> Select(VSM.Data.Objects.EmployeeEdit qbe)
        {
            return Select(qbe.emp_id, qbe.emp_code, qbe.password, qbe.emp_fname, qbe.emp_lname, qbe.emp_email, qbe.team_id, qbe.telephone, qbe.KioskOwner_ID, qbe.KioskOwner_KioskOwner_Code, qbe.KioskOwner_Branch_ID, qbe.KioskOwner_Branch_KioskOwner_Branch_Code, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
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
                    string kioskOwner_KioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kioskOwner_Branch_KioskOwner_Branch_Code, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(emp_id, emp_code, password, emp_fname, emp_lname, emp_email, team_id, telephone, kioskOwner_ID, kioskOwner_KioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_KioskOwner_Branch_Code, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("EmployeeEdit", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.EmployeeEdit> Select(
                    System.Guid? emp_id, 
                    string emp_code, 
                    string password, 
                    string emp_fname, 
                    string emp_lname, 
                    string emp_email, 
                    int? team_id, 
                    string telephone, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kioskOwner_Branch_KioskOwner_Branch_Code, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn)
        {
            return Select(emp_id, emp_code, password, emp_fname, emp_lname, emp_email, team_id, telephone, kioskOwner_ID, kioskOwner_KioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_KioskOwner_Branch_Code, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.EmployeeEdit SelectSingle(System.Guid? emp_id)
        {
            List<VSM.Data.Objects.EmployeeEdit> list = Select(emp_id, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.EmployeeEdit> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("EmployeeEdit", dataView, request);
            return page.ToList<VSM.Data.Objects.EmployeeEdit>();
        }
        
        public List<VSM.Data.Objects.EmployeeEdit> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.EmployeeEdit> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.EmployeeEdit SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.EmployeeEdit> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.EmployeeEdit theEmployeeEdit, VSM.Data.Objects.EmployeeEdit original_EmployeeEdit)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("emp_id", original_EmployeeEdit.emp_id, theEmployeeEdit.emp_id));
            values.Add(new FieldValue("emp_code", original_EmployeeEdit.emp_code, theEmployeeEdit.emp_code, true));
            values.Add(new FieldValue("password", original_EmployeeEdit.password, theEmployeeEdit.password));
            values.Add(new FieldValue("emp_fname", original_EmployeeEdit.emp_fname, theEmployeeEdit.emp_fname));
            values.Add(new FieldValue("emp_lname", original_EmployeeEdit.emp_lname, theEmployeeEdit.emp_lname));
            values.Add(new FieldValue("emp_email", original_EmployeeEdit.emp_email, theEmployeeEdit.emp_email));
            values.Add(new FieldValue("team_id", original_EmployeeEdit.team_id, theEmployeeEdit.team_id));
            values.Add(new FieldValue("telephone", original_EmployeeEdit.telephone, theEmployeeEdit.telephone));
            values.Add(new FieldValue("KioskOwner_ID", original_EmployeeEdit.KioskOwner_ID, theEmployeeEdit.KioskOwner_ID));
            values.Add(new FieldValue("KioskOwner_KioskOwner_Code", original_EmployeeEdit.KioskOwner_KioskOwner_Code, theEmployeeEdit.KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("KioskOwner_Branch_ID", original_EmployeeEdit.KioskOwner_Branch_ID, theEmployeeEdit.KioskOwner_Branch_ID));
            values.Add(new FieldValue("KioskOwner_Branch_KioskOwner_Branch_Code", original_EmployeeEdit.KioskOwner_Branch_KioskOwner_Branch_Code, theEmployeeEdit.KioskOwner_Branch_KioskOwner_Branch_Code, true));
            values.Add(new FieldValue("CreatedBy", original_EmployeeEdit.CreatedBy, theEmployeeEdit.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_EmployeeEdit.CreatedOn, theEmployeeEdit.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_EmployeeEdit.ModifiedBy, theEmployeeEdit.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_EmployeeEdit.ModifiedOn, theEmployeeEdit.ModifiedOn));
            values.Add(new FieldValue("createname", original_EmployeeEdit.createname, theEmployeeEdit.createname));
            values.Add(new FieldValue("updatename", original_EmployeeEdit.updatename, theEmployeeEdit.updatename));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.EmployeeEdit theEmployeeEdit, VSM.Data.Objects.EmployeeEdit original_EmployeeEdit, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "EmployeeEdit";
            args.View = dataView;
            args.Values = CreateFieldValues(theEmployeeEdit, original_EmployeeEdit);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("EmployeeEdit", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theEmployeeEdit);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.EmployeeEdit theEmployeeEdit, VSM.Data.Objects.EmployeeEdit original_EmployeeEdit)
        {
            return ExecuteAction(theEmployeeEdit, original_EmployeeEdit, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.EmployeeEdit theEmployeeEdit)
        {
            return Update(theEmployeeEdit, SelectSingle(theEmployeeEdit.emp_id));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.EmployeeEdit theEmployeeEdit)
        {
            return ExecuteAction(theEmployeeEdit, new EmployeeEdit(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.EmployeeEdit theEmployeeEdit)
        {
            return ExecuteAction(theEmployeeEdit, theEmployeeEdit, "Select", "Delete", DeleteView);
        }
    }
}

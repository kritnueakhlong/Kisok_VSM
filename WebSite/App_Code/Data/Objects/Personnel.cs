using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Personnel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _personnel_id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personnel_no;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personnel_rfid_no;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personnel_prefix;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personnel_card_no;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personnel_firstname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personnel_lastname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personnel_status;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personnel_type;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personnel_description;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _create_by;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _create_on;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _modified_by;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modified_on;
        
        public Personnel()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? Personnel_id
        {
            get
            {
                return _personnel_id;
            }
            set
            {
                _personnel_id = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Personnel_no
        {
            get
            {
                return _personnel_no;
            }
            set
            {
                _personnel_no = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Personnel_rfid_no
        {
            get
            {
                return _personnel_rfid_no;
            }
            set
            {
                _personnel_rfid_no = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Personnel_prefix
        {
            get
            {
                return _personnel_prefix;
            }
            set
            {
                _personnel_prefix = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Personnel_card_no
        {
            get
            {
                return _personnel_card_no;
            }
            set
            {
                _personnel_card_no = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Personnel_firstname
        {
            get
            {
                return _personnel_firstname;
            }
            set
            {
                _personnel_firstname = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Personnel_lastname
        {
            get
            {
                return _personnel_lastname;
            }
            set
            {
                _personnel_lastname = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Personnel_status
        {
            get
            {
                return _personnel_status;
            }
            set
            {
                _personnel_status = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Personnel_type
        {
            get
            {
                return _personnel_type;
            }
            set
            {
                _personnel_type = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Personnel_description
        {
            get
            {
                return _personnel_description;
            }
            set
            {
                _personnel_description = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public long? create_by
        {
            get
            {
                return _create_by;
            }
            set
            {
                _create_by = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? create_on
        {
            get
            {
                return _create_on;
            }
            set
            {
                _create_on = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public long? modified_by
        {
            get
            {
                return _modified_by;
            }
            set
            {
                _modified_by = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? modified_on
        {
            get
            {
                return _modified_on;
            }
            set
            {
                _modified_on = value;
            }
        }
        
        public static List<VSM.Data.Objects.Personnel> Select(System.Guid? personnel_id, string personnel_no, string personnel_rfid_no, string personnel_prefix, string personnel_card_no, string personnel_firstname, string personnel_lastname, string personnel_status, string personnel_type, long? create_by, DateTime? create_on, long? modified_by, DateTime? modified_on)
        {
            return new PersonnelFactory().Select(personnel_id, personnel_no, personnel_rfid_no, personnel_prefix, personnel_card_no, personnel_firstname, personnel_lastname, personnel_status, personnel_type, create_by, create_on, modified_by, modified_on);
        }
        
        public static List<VSM.Data.Objects.Personnel> Select(VSM.Data.Objects.Personnel qbe)
        {
            return new PersonnelFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.Personnel> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new PersonnelFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.Personnel> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new PersonnelFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.Personnel> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new PersonnelFactory().Select(filter, sort, PersonnelFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.Personnel> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new PersonnelFactory().Select(filter, sort, PersonnelFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.Personnel> Select(string filter, BusinessObjectParameters parameters)
        {
            return new PersonnelFactory().Select(filter, null, PersonnelFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.Personnel> Select(string filter, params FieldValue[] parameters)
        {
            return new PersonnelFactory().Select(filter, null, PersonnelFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.Personnel SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new PersonnelFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.Personnel SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new PersonnelFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.Personnel SelectSingle(System.Guid? personnel_id)
        {
            return new PersonnelFactory().SelectSingle(personnel_id);
        }
        
        public int Insert()
        {
            return new PersonnelFactory().Insert(this);
        }
        
        public int Update()
        {
            return new PersonnelFactory().Update(this);
        }
        
        public int Delete()
        {
            return new PersonnelFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Personnel_id: {0}", this.Personnel_id);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class PersonnelFactory
    {
        
        public PersonnelFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Personnel");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Personnel");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Personnel");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Personnel");
            }
        }
        
        public static PersonnelFactory Create()
        {
            return new PersonnelFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    System.Guid? personnel_id, 
                    string personnel_no, 
                    string personnel_rfid_no, 
                    string personnel_prefix, 
                    string personnel_card_no, 
                    string personnel_firstname, 
                    string personnel_lastname, 
                    string personnel_status, 
                    string personnel_type, 
                    long? create_by, 
                    DateTime? create_on, 
                    long? modified_by, 
                    DateTime? modified_on, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (personnel_id.HasValue)
            	filter.Add(("Personnel_id:=" + personnel_id.Value.ToString()));
            if (!(String.IsNullOrEmpty(personnel_no)))
            	filter.Add(("Personnel_no:*" + personnel_no));
            if (!(String.IsNullOrEmpty(personnel_rfid_no)))
            	filter.Add(("Personnel_rfid_no:*" + personnel_rfid_no));
            if (!(String.IsNullOrEmpty(personnel_prefix)))
            	filter.Add(("Personnel_prefix:*" + personnel_prefix));
            if (!(String.IsNullOrEmpty(personnel_card_no)))
            	filter.Add(("Personnel_card_no:*" + personnel_card_no));
            if (!(String.IsNullOrEmpty(personnel_firstname)))
            	filter.Add(("Personnel_firstname:*" + personnel_firstname));
            if (!(String.IsNullOrEmpty(personnel_lastname)))
            	filter.Add(("Personnel_lastname:*" + personnel_lastname));
            if (!(String.IsNullOrEmpty(personnel_status)))
            	filter.Add(("Personnel_status:*" + personnel_status));
            if (!(String.IsNullOrEmpty(personnel_type)))
            	filter.Add(("Personnel_type:*" + personnel_type));
            if (create_by.HasValue)
            	filter.Add(("create_by:=" + create_by.Value.ToString()));
            if (create_on.HasValue)
            	filter.Add(("create_on:=" + create_on.Value.ToString()));
            if (modified_by.HasValue)
            	filter.Add(("modified_by:=" + modified_by.Value.ToString()));
            if (modified_on.HasValue)
            	filter.Add(("modified_on:=" + modified_on.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<VSM.Data.Objects.Personnel> Select(
                    System.Guid? personnel_id, 
                    string personnel_no, 
                    string personnel_rfid_no, 
                    string personnel_prefix, 
                    string personnel_card_no, 
                    string personnel_firstname, 
                    string personnel_lastname, 
                    string personnel_status, 
                    string personnel_type, 
                    long? create_by, 
                    DateTime? create_on, 
                    long? modified_by, 
                    DateTime? modified_on, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(personnel_id, personnel_no, personnel_rfid_no, personnel_prefix, personnel_card_no, personnel_firstname, personnel_lastname, personnel_status, personnel_type, create_by, create_on, modified_by, modified_on, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Personnel", dataView, request);
            return page.ToList<VSM.Data.Objects.Personnel>();
        }
        
        public List<VSM.Data.Objects.Personnel> Select(VSM.Data.Objects.Personnel qbe)
        {
            return Select(qbe.Personnel_id, qbe.Personnel_no, qbe.Personnel_rfid_no, qbe.Personnel_prefix, qbe.Personnel_card_no, qbe.Personnel_firstname, qbe.Personnel_lastname, qbe.Personnel_status, qbe.Personnel_type, qbe.create_by, qbe.create_on, qbe.modified_by, qbe.modified_on);
        }
        
        public int SelectCount(
                    System.Guid? personnel_id, 
                    string personnel_no, 
                    string personnel_rfid_no, 
                    string personnel_prefix, 
                    string personnel_card_no, 
                    string personnel_firstname, 
                    string personnel_lastname, 
                    string personnel_status, 
                    string personnel_type, 
                    long? create_by, 
                    DateTime? create_on, 
                    long? modified_by, 
                    DateTime? modified_on, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(personnel_id, personnel_no, personnel_rfid_no, personnel_prefix, personnel_card_no, personnel_firstname, personnel_lastname, personnel_status, personnel_type, create_by, create_on, modified_by, modified_on, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Personnel", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.Personnel> Select(System.Guid? personnel_id, string personnel_no, string personnel_rfid_no, string personnel_prefix, string personnel_card_no, string personnel_firstname, string personnel_lastname, string personnel_status, string personnel_type, long? create_by, DateTime? create_on, long? modified_by, DateTime? modified_on)
        {
            return Select(personnel_id, personnel_no, personnel_rfid_no, personnel_prefix, personnel_card_no, personnel_firstname, personnel_lastname, personnel_status, personnel_type, create_by, create_on, modified_by, modified_on, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.Personnel SelectSingle(System.Guid? personnel_id)
        {
            List<VSM.Data.Objects.Personnel> list = Select(personnel_id, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.Personnel> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Personnel", dataView, request);
            return page.ToList<VSM.Data.Objects.Personnel>();
        }
        
        public List<VSM.Data.Objects.Personnel> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.Personnel> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.Personnel SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.Personnel> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.Personnel thePersonnel, VSM.Data.Objects.Personnel original_Personnel)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Personnel_id", original_Personnel.Personnel_id, thePersonnel.Personnel_id));
            values.Add(new FieldValue("Personnel_no", original_Personnel.Personnel_no, thePersonnel.Personnel_no));
            values.Add(new FieldValue("Personnel_rfid_no", original_Personnel.Personnel_rfid_no, thePersonnel.Personnel_rfid_no));
            values.Add(new FieldValue("Personnel_prefix", original_Personnel.Personnel_prefix, thePersonnel.Personnel_prefix));
            values.Add(new FieldValue("Personnel_card_no", original_Personnel.Personnel_card_no, thePersonnel.Personnel_card_no));
            values.Add(new FieldValue("Personnel_firstname", original_Personnel.Personnel_firstname, thePersonnel.Personnel_firstname));
            values.Add(new FieldValue("Personnel_lastname", original_Personnel.Personnel_lastname, thePersonnel.Personnel_lastname));
            values.Add(new FieldValue("Personnel_status", original_Personnel.Personnel_status, thePersonnel.Personnel_status));
            values.Add(new FieldValue("Personnel_type", original_Personnel.Personnel_type, thePersonnel.Personnel_type));
            values.Add(new FieldValue("Personnel_description", original_Personnel.Personnel_description, thePersonnel.Personnel_description));
            values.Add(new FieldValue("create_by", original_Personnel.create_by, thePersonnel.create_by));
            values.Add(new FieldValue("create_on", original_Personnel.create_on, thePersonnel.create_on));
            values.Add(new FieldValue("modified_by", original_Personnel.modified_by, thePersonnel.modified_by));
            values.Add(new FieldValue("modified_on", original_Personnel.modified_on, thePersonnel.modified_on));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.Personnel thePersonnel, VSM.Data.Objects.Personnel original_Personnel, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Personnel";
            args.View = dataView;
            args.Values = CreateFieldValues(thePersonnel, original_Personnel);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Personnel", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(thePersonnel);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.Personnel thePersonnel, VSM.Data.Objects.Personnel original_Personnel)
        {
            return ExecuteAction(thePersonnel, original_Personnel, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.Personnel thePersonnel)
        {
            return Update(thePersonnel, SelectSingle(thePersonnel.Personnel_id));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.Personnel thePersonnel)
        {
            return ExecuteAction(thePersonnel, new Personnel(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.Personnel thePersonnel)
        {
            return ExecuteAction(thePersonnel, thePersonnel, "Select", "Delete", DeleteView);
        }
    }
}

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class HelpDesk
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _helpDesk_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _personnel_no;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _helpDesk_FirstName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _helpDesk_LastName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _helpDesk_AuthenPassword;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        public HelpDesk()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? HelpDesk_ID
        {
            get
            {
                return _helpDesk_ID;
            }
            set
            {
                _helpDesk_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string HelpDesk_FirstName
        {
            get
            {
                return _helpDesk_FirstName;
            }
            set
            {
                _helpDesk_FirstName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HelpDesk_LastName
        {
            get
            {
                return _helpDesk_LastName;
            }
            set
            {
                _helpDesk_LastName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string HelpDesk_AuthenPassword
        {
            get
            {
                return _helpDesk_AuthenPassword;
            }
            set
            {
                _helpDesk_AuthenPassword = value;
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
        
        public static List<VSM.Data.Objects.HelpDesk> Select(System.Guid? helpDesk_ID, string personnel_no, string helpDesk_FirstName, string helpDesk_LastName, string helpDesk_AuthenPassword, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new HelpDeskFactory().Select(helpDesk_ID, personnel_no, helpDesk_FirstName, helpDesk_LastName, helpDesk_AuthenPassword, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.HelpDesk> Select(VSM.Data.Objects.HelpDesk qbe)
        {
            return new HelpDeskFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.HelpDesk> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new HelpDeskFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.HelpDesk> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new HelpDeskFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.HelpDesk> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new HelpDeskFactory().Select(filter, sort, HelpDeskFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.HelpDesk> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new HelpDeskFactory().Select(filter, sort, HelpDeskFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.HelpDesk> Select(string filter, BusinessObjectParameters parameters)
        {
            return new HelpDeskFactory().Select(filter, null, HelpDeskFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.HelpDesk> Select(string filter, params FieldValue[] parameters)
        {
            return new HelpDeskFactory().Select(filter, null, HelpDeskFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.HelpDesk SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new HelpDeskFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.HelpDesk SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new HelpDeskFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.HelpDesk SelectSingle(System.Guid? helpDesk_ID)
        {
            return new HelpDeskFactory().SelectSingle(helpDesk_ID);
        }
        
        public int Insert()
        {
            return new HelpDeskFactory().Insert(this);
        }
        
        public int Update()
        {
            return new HelpDeskFactory().Update(this);
        }
        
        public int Delete()
        {
            return new HelpDeskFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("HelpDesk_ID: {0}", this.HelpDesk_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class HelpDeskFactory
    {
        
        public HelpDeskFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("HelpDesk");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("HelpDesk");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("HelpDesk");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("HelpDesk");
            }
        }
        
        public static HelpDeskFactory Create()
        {
            return new HelpDeskFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? helpDesk_ID, string personnel_no, string helpDesk_FirstName, string helpDesk_LastName, string helpDesk_AuthenPassword, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (helpDesk_ID.HasValue)
            	filter.Add(("HelpDesk_ID:=" + helpDesk_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(personnel_no)))
            	filter.Add(("Personnel_no:*" + personnel_no));
            if (!(String.IsNullOrEmpty(helpDesk_FirstName)))
            	filter.Add(("HelpDesk_FirstName:*" + helpDesk_FirstName));
            if (!(String.IsNullOrEmpty(helpDesk_LastName)))
            	filter.Add(("HelpDesk_LastName:*" + helpDesk_LastName));
            if (!(String.IsNullOrEmpty(helpDesk_AuthenPassword)))
            	filter.Add(("HelpDesk_AuthenPassword:*" + helpDesk_AuthenPassword));
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
        public List<VSM.Data.Objects.HelpDesk> Select(System.Guid? helpDesk_ID, string personnel_no, string helpDesk_FirstName, string helpDesk_LastName, string helpDesk_AuthenPassword, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(helpDesk_ID, personnel_no, helpDesk_FirstName, helpDesk_LastName, helpDesk_AuthenPassword, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("HelpDesk", dataView, request);
            return page.ToList<VSM.Data.Objects.HelpDesk>();
        }
        
        public List<VSM.Data.Objects.HelpDesk> Select(VSM.Data.Objects.HelpDesk qbe)
        {
            return Select(qbe.HelpDesk_ID, qbe.Personnel_no, qbe.HelpDesk_FirstName, qbe.HelpDesk_LastName, qbe.HelpDesk_AuthenPassword, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(System.Guid? helpDesk_ID, string personnel_no, string helpDesk_FirstName, string helpDesk_LastName, string helpDesk_AuthenPassword, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(helpDesk_ID, personnel_no, helpDesk_FirstName, helpDesk_LastName, helpDesk_AuthenPassword, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("HelpDesk", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.HelpDesk> Select(System.Guid? helpDesk_ID, string personnel_no, string helpDesk_FirstName, string helpDesk_LastName, string helpDesk_AuthenPassword, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(helpDesk_ID, personnel_no, helpDesk_FirstName, helpDesk_LastName, helpDesk_AuthenPassword, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.HelpDesk SelectSingle(System.Guid? helpDesk_ID)
        {
            List<VSM.Data.Objects.HelpDesk> list = Select(helpDesk_ID, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.HelpDesk> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("HelpDesk", dataView, request);
            return page.ToList<VSM.Data.Objects.HelpDesk>();
        }
        
        public List<VSM.Data.Objects.HelpDesk> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.HelpDesk> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.HelpDesk SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.HelpDesk> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.HelpDesk theHelpDesk, VSM.Data.Objects.HelpDesk original_HelpDesk)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("HelpDesk_ID", original_HelpDesk.HelpDesk_ID, theHelpDesk.HelpDesk_ID));
            values.Add(new FieldValue("Personnel_no", original_HelpDesk.Personnel_no, theHelpDesk.Personnel_no));
            values.Add(new FieldValue("HelpDesk_FirstName", original_HelpDesk.HelpDesk_FirstName, theHelpDesk.HelpDesk_FirstName));
            values.Add(new FieldValue("HelpDesk_LastName", original_HelpDesk.HelpDesk_LastName, theHelpDesk.HelpDesk_LastName));
            values.Add(new FieldValue("HelpDesk_AuthenPassword", original_HelpDesk.HelpDesk_AuthenPassword, theHelpDesk.HelpDesk_AuthenPassword));
            values.Add(new FieldValue("CreatedBy", original_HelpDesk.CreatedBy, theHelpDesk.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_HelpDesk.CreatedOn, theHelpDesk.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_HelpDesk.ModifiedBy, theHelpDesk.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_HelpDesk.ModifiedOn, theHelpDesk.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.HelpDesk theHelpDesk, VSM.Data.Objects.HelpDesk original_HelpDesk, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "HelpDesk";
            args.View = dataView;
            args.Values = CreateFieldValues(theHelpDesk, original_HelpDesk);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("HelpDesk", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theHelpDesk);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.HelpDesk theHelpDesk, VSM.Data.Objects.HelpDesk original_HelpDesk)
        {
            return ExecuteAction(theHelpDesk, original_HelpDesk, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.HelpDesk theHelpDesk)
        {
            return Update(theHelpDesk, SelectSingle(theHelpDesk.HelpDesk_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.HelpDesk theHelpDesk)
        {
            return ExecuteAction(theHelpDesk, new HelpDesk(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.HelpDesk theHelpDesk)
        {
            return ExecuteAction(theHelpDesk, theHelpDesk, "Select", "Delete", DeleteView);
        }
    }
}

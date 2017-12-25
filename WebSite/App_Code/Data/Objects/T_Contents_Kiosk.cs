using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class T_Contents_Kiosk
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _content_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _content_Content_Desc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _content_KioskOwner_KioskOwner_Code;
        
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
        
        public T_Contents_Kiosk()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? Content_ID
        {
            get
            {
                return _content_ID;
            }
            set
            {
                _content_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Content_Content_Desc
        {
            get
            {
                return _content_Content_Desc;
            }
            set
            {
                _content_Content_Desc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Content_KioskOwner_KioskOwner_Code
        {
            get
            {
                return _content_KioskOwner_KioskOwner_Code;
            }
            set
            {
                _content_KioskOwner_KioskOwner_Code = value;
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
        
        public static List<VSM.Data.Objects.T_Contents_Kiosk> Select(System.Guid? content_ID, string content_Content_Desc, string content_KioskOwner_KioskOwner_Code, System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new T_Contents_KioskFactory().Select(content_ID, content_Content_Desc, content_KioskOwner_KioskOwner_Code, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.T_Contents_Kiosk> Select(VSM.Data.Objects.T_Contents_Kiosk qbe)
        {
            return new T_Contents_KioskFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.T_Contents_Kiosk> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new T_Contents_KioskFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Contents_Kiosk> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new T_Contents_KioskFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Contents_Kiosk> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new T_Contents_KioskFactory().Select(filter, sort, T_Contents_KioskFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Contents_Kiosk> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new T_Contents_KioskFactory().Select(filter, sort, T_Contents_KioskFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Contents_Kiosk> Select(string filter, BusinessObjectParameters parameters)
        {
            return new T_Contents_KioskFactory().Select(filter, null, T_Contents_KioskFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Contents_Kiosk> Select(string filter, params FieldValue[] parameters)
        {
            return new T_Contents_KioskFactory().Select(filter, null, T_Contents_KioskFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Contents_Kiosk SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new T_Contents_KioskFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.T_Contents_Kiosk SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new T_Contents_KioskFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Contents_Kiosk SelectSingle(System.Guid? content_ID, System.Guid? kiosk_ID)
        {
            return new T_Contents_KioskFactory().SelectSingle(content_ID, kiosk_ID);
        }
        
        public int Insert()
        {
            return new T_Contents_KioskFactory().Insert(this);
        }
        
        public int Update()
        {
            return new T_Contents_KioskFactory().Update(this);
        }
        
        public int Delete()
        {
            return new T_Contents_KioskFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Content_ID: {0}; Kiosk_ID: {1}", this.Content_ID, this.Kiosk_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class T_Contents_KioskFactory
    {
        
        public T_Contents_KioskFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("T_Contents_Kiosk");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("T_Contents_Kiosk");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("T_Contents_Kiosk");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("T_Contents_Kiosk");
            }
        }
        
        public static T_Contents_KioskFactory Create()
        {
            return new T_Contents_KioskFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? content_ID, string content_Content_Desc, string content_KioskOwner_KioskOwner_Code, System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (content_ID.HasValue)
            	filter.Add(("Content_ID:=" + content_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(content_Content_Desc)))
            	filter.Add(("Content_Content_Desc:*" + content_Content_Desc));
            if (!(String.IsNullOrEmpty(content_KioskOwner_KioskOwner_Code)))
            	filter.Add(("Content_KioskOwner_KioskOwner_Code:*" + content_KioskOwner_KioskOwner_Code));
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
        public List<VSM.Data.Objects.T_Contents_Kiosk> Select(
                    System.Guid? content_ID, 
                    string content_Content_Desc, 
                    string content_KioskOwner_KioskOwner_Code, 
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
            PageRequest request = CreateRequest(content_ID, content_Content_Desc, content_KioskOwner_KioskOwner_Code, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Contents_Kiosk", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Contents_Kiosk>();
        }
        
        public List<VSM.Data.Objects.T_Contents_Kiosk> Select(VSM.Data.Objects.T_Contents_Kiosk qbe)
        {
            return Select(qbe.Content_ID, qbe.Content_Content_Desc, qbe.Content_KioskOwner_KioskOwner_Code, qbe.Kiosk_ID, qbe.Kiosk_Kiosk_Code, qbe.Kiosk_KioskType_KioskType_Name, qbe.Kiosk_Location_Location_Address, qbe.Kiosk_Location_KioskOwner_KioskOwner_Code, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? content_ID, 
                    string content_Content_Desc, 
                    string content_KioskOwner_KioskOwner_Code, 
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
            PageRequest request = CreateRequest(content_ID, content_Content_Desc, content_KioskOwner_KioskOwner_Code, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Contents_Kiosk", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.T_Contents_Kiosk> Select(System.Guid? content_ID, string content_Content_Desc, string content_KioskOwner_KioskOwner_Code, System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(content_ID, content_Content_Desc, content_KioskOwner_KioskOwner_Code, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.T_Contents_Kiosk SelectSingle(System.Guid? content_ID, System.Guid? kiosk_ID)
        {
            List<VSM.Data.Objects.T_Contents_Kiosk> list = Select(content_ID, null, null, kiosk_ID, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.T_Contents_Kiosk> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("T_Contents_Kiosk", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Contents_Kiosk>();
        }
        
        public List<VSM.Data.Objects.T_Contents_Kiosk> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.T_Contents_Kiosk> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.T_Contents_Kiosk SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.T_Contents_Kiosk> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.T_Contents_Kiosk theT_Contents_Kiosk, VSM.Data.Objects.T_Contents_Kiosk original_T_Contents_Kiosk)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Content_ID", original_T_Contents_Kiosk.Content_ID, theT_Contents_Kiosk.Content_ID));
            values.Add(new FieldValue("Content_Content_Desc", original_T_Contents_Kiosk.Content_Content_Desc, theT_Contents_Kiosk.Content_Content_Desc, true));
            values.Add(new FieldValue("Content_KioskOwner_KioskOwner_Code", original_T_Contents_Kiosk.Content_KioskOwner_KioskOwner_Code, theT_Contents_Kiosk.Content_KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("Kiosk_ID", original_T_Contents_Kiosk.Kiosk_ID, theT_Contents_Kiosk.Kiosk_ID));
            values.Add(new FieldValue("Kiosk_Kiosk_Code", original_T_Contents_Kiosk.Kiosk_Kiosk_Code, theT_Contents_Kiosk.Kiosk_Kiosk_Code, true));
            values.Add(new FieldValue("Kiosk_KioskType_KioskType_Name", original_T_Contents_Kiosk.Kiosk_KioskType_KioskType_Name, theT_Contents_Kiosk.Kiosk_KioskType_KioskType_Name, true));
            values.Add(new FieldValue("Kiosk_Location_Location_Address", original_T_Contents_Kiosk.Kiosk_Location_Location_Address, theT_Contents_Kiosk.Kiosk_Location_Location_Address, true));
            values.Add(new FieldValue("Kiosk_Location_KioskOwner_KioskOwner_Code", original_T_Contents_Kiosk.Kiosk_Location_KioskOwner_KioskOwner_Code, theT_Contents_Kiosk.Kiosk_Location_KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("CreatedBy", original_T_Contents_Kiosk.CreatedBy, theT_Contents_Kiosk.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_T_Contents_Kiosk.CreatedOn, theT_Contents_Kiosk.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_T_Contents_Kiosk.ModifiedBy, theT_Contents_Kiosk.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_T_Contents_Kiosk.ModifiedOn, theT_Contents_Kiosk.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.T_Contents_Kiosk theT_Contents_Kiosk, VSM.Data.Objects.T_Contents_Kiosk original_T_Contents_Kiosk, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "T_Contents_Kiosk";
            args.View = dataView;
            args.Values = CreateFieldValues(theT_Contents_Kiosk, original_T_Contents_Kiosk);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("T_Contents_Kiosk", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theT_Contents_Kiosk);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.T_Contents_Kiosk theT_Contents_Kiosk, VSM.Data.Objects.T_Contents_Kiosk original_T_Contents_Kiosk)
        {
            return ExecuteAction(theT_Contents_Kiosk, original_T_Contents_Kiosk, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.T_Contents_Kiosk theT_Contents_Kiosk)
        {
            return Update(theT_Contents_Kiosk, SelectSingle(theT_Contents_Kiosk.Content_ID, theT_Contents_Kiosk.Kiosk_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.T_Contents_Kiosk theT_Contents_Kiosk)
        {
            return ExecuteAction(theT_Contents_Kiosk, new T_Contents_Kiosk(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.T_Contents_Kiosk theT_Contents_Kiosk)
        {
            return ExecuteAction(theT_Contents_Kiosk, theT_Contents_Kiosk, "Select", "Delete", DeleteView);
        }
    }
}

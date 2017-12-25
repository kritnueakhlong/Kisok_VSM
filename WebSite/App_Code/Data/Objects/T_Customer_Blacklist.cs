using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class T_Customer_Blacklist
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _blacklist_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_KioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_Branch_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Branch_KioskOwner_Branch_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _identity_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _blacklist_Description;
        
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
        
        public T_Customer_Blacklist()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? Blacklist_ID
        {
            get
            {
                return _blacklist_ID;
            }
            set
            {
                _blacklist_ID = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Identity_ID
        {
            get
            {
                return _identity_ID;
            }
            set
            {
                _identity_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Blacklist_Description
        {
            get
            {
                return _blacklist_Description;
            }
            set
            {
                _blacklist_Description = value;
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
        
        public static List<VSM.Data.Objects.T_Customer_Blacklist> Select(System.Guid? blacklist_ID, System.Guid? kioskOwner_ID, string kioskOwner_KioskOwner_Code, System.Guid? kioskOwner_Branch_ID, string kioskOwner_Branch_KioskOwner_Branch_Code, string identity_ID, string blacklist_Description, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new T_Customer_BlacklistFactory().Select(blacklist_ID, kioskOwner_ID, kioskOwner_KioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_KioskOwner_Branch_Code, identity_ID, blacklist_Description, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.T_Customer_Blacklist> Select(VSM.Data.Objects.T_Customer_Blacklist qbe)
        {
            return new T_Customer_BlacklistFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.T_Customer_Blacklist> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new T_Customer_BlacklistFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Customer_Blacklist> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new T_Customer_BlacklistFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Customer_Blacklist> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new T_Customer_BlacklistFactory().Select(filter, sort, T_Customer_BlacklistFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Customer_Blacklist> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new T_Customer_BlacklistFactory().Select(filter, sort, T_Customer_BlacklistFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Customer_Blacklist> Select(string filter, BusinessObjectParameters parameters)
        {
            return new T_Customer_BlacklistFactory().Select(filter, null, T_Customer_BlacklistFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Customer_Blacklist> Select(string filter, params FieldValue[] parameters)
        {
            return new T_Customer_BlacklistFactory().Select(filter, null, T_Customer_BlacklistFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Customer_Blacklist SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new T_Customer_BlacklistFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.T_Customer_Blacklist SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new T_Customer_BlacklistFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Customer_Blacklist SelectSingle(System.Guid? blacklist_ID)
        {
            return new T_Customer_BlacklistFactory().SelectSingle(blacklist_ID);
        }
        
        public int Insert()
        {
            return new T_Customer_BlacklistFactory().Insert(this);
        }
        
        public int Update()
        {
            return new T_Customer_BlacklistFactory().Update(this);
        }
        
        public int Delete()
        {
            return new T_Customer_BlacklistFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Blacklist_ID: {0}", this.Blacklist_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class T_Customer_BlacklistFactory
    {
        
        public T_Customer_BlacklistFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("T_Customer_Blacklist");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("T_Customer_Blacklist");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("T_Customer_Blacklist");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("T_Customer_Blacklist");
            }
        }
        
        public static T_Customer_BlacklistFactory Create()
        {
            return new T_Customer_BlacklistFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? blacklist_ID, System.Guid? kioskOwner_ID, string kioskOwner_KioskOwner_Code, System.Guid? kioskOwner_Branch_ID, string kioskOwner_Branch_KioskOwner_Branch_Code, string identity_ID, string blacklist_Description, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (blacklist_ID.HasValue)
            	filter.Add(("Blacklist_ID:=" + blacklist_ID.Value.ToString()));
            if (kioskOwner_ID.HasValue)
            	filter.Add(("KioskOwner_ID:=" + kioskOwner_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_KioskOwner_Code)))
            	filter.Add(("KioskOwner_KioskOwner_Code:*" + kioskOwner_KioskOwner_Code));
            if (kioskOwner_Branch_ID.HasValue)
            	filter.Add(("KioskOwner_Branch_ID:=" + kioskOwner_Branch_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_Branch_KioskOwner_Branch_Code)))
            	filter.Add(("KioskOwner_Branch_KioskOwner_Branch_Code:*" + kioskOwner_Branch_KioskOwner_Branch_Code));
            if (!(String.IsNullOrEmpty(identity_ID)))
            	filter.Add(("Identity_ID:*" + identity_ID));
            if (!(String.IsNullOrEmpty(blacklist_Description)))
            	filter.Add(("Blacklist_Description:*" + blacklist_Description));
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
        public List<VSM.Data.Objects.T_Customer_Blacklist> Select(
                    System.Guid? blacklist_ID, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kioskOwner_Branch_KioskOwner_Branch_Code, 
                    string identity_ID, 
                    string blacklist_Description, 
                    bool? item_Flag, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(blacklist_ID, kioskOwner_ID, kioskOwner_KioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_KioskOwner_Branch_Code, identity_ID, blacklist_Description, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Customer_Blacklist", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Customer_Blacklist>();
        }
        
        public List<VSM.Data.Objects.T_Customer_Blacklist> Select(VSM.Data.Objects.T_Customer_Blacklist qbe)
        {
            return Select(qbe.Blacklist_ID, qbe.KioskOwner_ID, qbe.KioskOwner_KioskOwner_Code, qbe.KioskOwner_Branch_ID, qbe.KioskOwner_Branch_KioskOwner_Branch_Code, qbe.Identity_ID, qbe.Blacklist_Description, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? blacklist_ID, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    System.Guid? kioskOwner_Branch_ID, 
                    string kioskOwner_Branch_KioskOwner_Branch_Code, 
                    string identity_ID, 
                    string blacklist_Description, 
                    bool? item_Flag, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(blacklist_ID, kioskOwner_ID, kioskOwner_KioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_KioskOwner_Branch_Code, identity_ID, blacklist_Description, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Customer_Blacklist", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.T_Customer_Blacklist> Select(System.Guid? blacklist_ID, System.Guid? kioskOwner_ID, string kioskOwner_KioskOwner_Code, System.Guid? kioskOwner_Branch_ID, string kioskOwner_Branch_KioskOwner_Branch_Code, string identity_ID, string blacklist_Description, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(blacklist_ID, kioskOwner_ID, kioskOwner_KioskOwner_Code, kioskOwner_Branch_ID, kioskOwner_Branch_KioskOwner_Branch_Code, identity_ID, blacklist_Description, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.T_Customer_Blacklist SelectSingle(System.Guid? blacklist_ID)
        {
            List<VSM.Data.Objects.T_Customer_Blacklist> list = Select(blacklist_ID, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.T_Customer_Blacklist> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("T_Customer_Blacklist", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Customer_Blacklist>();
        }
        
        public List<VSM.Data.Objects.T_Customer_Blacklist> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.T_Customer_Blacklist> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.T_Customer_Blacklist SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.T_Customer_Blacklist> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.T_Customer_Blacklist theT_Customer_Blacklist, VSM.Data.Objects.T_Customer_Blacklist original_T_Customer_Blacklist)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Blacklist_ID", original_T_Customer_Blacklist.Blacklist_ID, theT_Customer_Blacklist.Blacklist_ID));
            values.Add(new FieldValue("KioskOwner_ID", original_T_Customer_Blacklist.KioskOwner_ID, theT_Customer_Blacklist.KioskOwner_ID));
            values.Add(new FieldValue("KioskOwner_KioskOwner_Code", original_T_Customer_Blacklist.KioskOwner_KioskOwner_Code, theT_Customer_Blacklist.KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("KioskOwner_Branch_ID", original_T_Customer_Blacklist.KioskOwner_Branch_ID, theT_Customer_Blacklist.KioskOwner_Branch_ID));
            values.Add(new FieldValue("KioskOwner_Branch_KioskOwner_Branch_Code", original_T_Customer_Blacklist.KioskOwner_Branch_KioskOwner_Branch_Code, theT_Customer_Blacklist.KioskOwner_Branch_KioskOwner_Branch_Code, true));
            values.Add(new FieldValue("Identity_ID", original_T_Customer_Blacklist.Identity_ID, theT_Customer_Blacklist.Identity_ID));
            values.Add(new FieldValue("Blacklist_Description", original_T_Customer_Blacklist.Blacklist_Description, theT_Customer_Blacklist.Blacklist_Description));
            values.Add(new FieldValue("Item_Flag", original_T_Customer_Blacklist.Item_Flag, theT_Customer_Blacklist.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_T_Customer_Blacklist.CreatedBy, theT_Customer_Blacklist.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_T_Customer_Blacklist.CreatedOn, theT_Customer_Blacklist.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_T_Customer_Blacklist.ModifiedBy, theT_Customer_Blacklist.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_T_Customer_Blacklist.ModifiedOn, theT_Customer_Blacklist.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.T_Customer_Blacklist theT_Customer_Blacklist, VSM.Data.Objects.T_Customer_Blacklist original_T_Customer_Blacklist, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "T_Customer_Blacklist";
            args.View = dataView;
            args.Values = CreateFieldValues(theT_Customer_Blacklist, original_T_Customer_Blacklist);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("T_Customer_Blacklist", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theT_Customer_Blacklist);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.T_Customer_Blacklist theT_Customer_Blacklist, VSM.Data.Objects.T_Customer_Blacklist original_T_Customer_Blacklist)
        {
            return ExecuteAction(theT_Customer_Blacklist, original_T_Customer_Blacklist, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.T_Customer_Blacklist theT_Customer_Blacklist)
        {
            return Update(theT_Customer_Blacklist, SelectSingle(theT_Customer_Blacklist.Blacklist_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.T_Customer_Blacklist theT_Customer_Blacklist)
        {
            return ExecuteAction(theT_Customer_Blacklist, new T_Customer_Blacklist(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.T_Customer_Blacklist theT_Customer_Blacklist)
        {
            return ExecuteAction(theT_Customer_Blacklist, theT_Customer_Blacklist, "Select", "Delete", DeleteView);
        }
    }
}

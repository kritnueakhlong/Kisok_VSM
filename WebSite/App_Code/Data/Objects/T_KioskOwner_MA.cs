using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class T_KioskOwner_MA
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwnerMA_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_KioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mA_DocumentNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _mA_Startdate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _mA_Enddate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _mA_Cost;
        
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
        
        public T_KioskOwner_MA()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? KioskOwnerMA_ID
        {
            get
            {
                return _kioskOwnerMA_ID;
            }
            set
            {
                _kioskOwnerMA_ID = value;
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
        public string MA_DocumentNo
        {
            get
            {
                return _mA_DocumentNo;
            }
            set
            {
                _mA_DocumentNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? MA_Startdate
        {
            get
            {
                return _mA_Startdate;
            }
            set
            {
                _mA_Startdate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? MA_Enddate
        {
            get
            {
                return _mA_Enddate;
            }
            set
            {
                _mA_Enddate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? MA_Cost
        {
            get
            {
                return _mA_Cost;
            }
            set
            {
                _mA_Cost = value;
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
        
        public static List<VSM.Data.Objects.T_KioskOwner_MA> Select(System.Guid? kioskOwnerMA_ID, System.Guid? kioskOwner_ID, string kioskOwner_KioskOwner_Code, string mA_DocumentNo, DateTime? mA_Startdate, DateTime? mA_Enddate, decimal? mA_Cost, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new T_KioskOwner_MAFactory().Select(kioskOwnerMA_ID, kioskOwner_ID, kioskOwner_KioskOwner_Code, mA_DocumentNo, mA_Startdate, mA_Enddate, mA_Cost, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.T_KioskOwner_MA> Select(VSM.Data.Objects.T_KioskOwner_MA qbe)
        {
            return new T_KioskOwner_MAFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.T_KioskOwner_MA> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new T_KioskOwner_MAFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_KioskOwner_MA> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new T_KioskOwner_MAFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_KioskOwner_MA> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new T_KioskOwner_MAFactory().Select(filter, sort, T_KioskOwner_MAFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_KioskOwner_MA> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new T_KioskOwner_MAFactory().Select(filter, sort, T_KioskOwner_MAFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_KioskOwner_MA> Select(string filter, BusinessObjectParameters parameters)
        {
            return new T_KioskOwner_MAFactory().Select(filter, null, T_KioskOwner_MAFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_KioskOwner_MA> Select(string filter, params FieldValue[] parameters)
        {
            return new T_KioskOwner_MAFactory().Select(filter, null, T_KioskOwner_MAFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_KioskOwner_MA SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new T_KioskOwner_MAFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.T_KioskOwner_MA SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new T_KioskOwner_MAFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_KioskOwner_MA SelectSingle(System.Guid? kioskOwnerMA_ID)
        {
            return new T_KioskOwner_MAFactory().SelectSingle(kioskOwnerMA_ID);
        }
        
        public int Insert()
        {
            return new T_KioskOwner_MAFactory().Insert(this);
        }
        
        public int Update()
        {
            return new T_KioskOwner_MAFactory().Update(this);
        }
        
        public int Delete()
        {
            return new T_KioskOwner_MAFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("KioskOwnerMA_ID: {0}", this.KioskOwnerMA_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class T_KioskOwner_MAFactory
    {
        
        public T_KioskOwner_MAFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("T_KioskOwner_MA");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("T_KioskOwner_MA");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("T_KioskOwner_MA");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("T_KioskOwner_MA");
            }
        }
        
        public static T_KioskOwner_MAFactory Create()
        {
            return new T_KioskOwner_MAFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? kioskOwnerMA_ID, System.Guid? kioskOwner_ID, string kioskOwner_KioskOwner_Code, string mA_DocumentNo, DateTime? mA_Startdate, DateTime? mA_Enddate, decimal? mA_Cost, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (kioskOwnerMA_ID.HasValue)
            	filter.Add(("KioskOwnerMA_ID:=" + kioskOwnerMA_ID.Value.ToString()));
            if (kioskOwner_ID.HasValue)
            	filter.Add(("KioskOwner_ID:=" + kioskOwner_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_KioskOwner_Code)))
            	filter.Add(("KioskOwner_KioskOwner_Code:*" + kioskOwner_KioskOwner_Code));
            if (!(String.IsNullOrEmpty(mA_DocumentNo)))
            	filter.Add(("MA_DocumentNo:*" + mA_DocumentNo));
            if (mA_Startdate.HasValue)
            	filter.Add(("MA_Startdate:=" + mA_Startdate.Value.ToString()));
            if (mA_Enddate.HasValue)
            	filter.Add(("MA_Enddate:=" + mA_Enddate.Value.ToString()));
            if (mA_Cost.HasValue)
            	filter.Add(("MA_Cost:=" + mA_Cost.Value.ToString()));
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
        public List<VSM.Data.Objects.T_KioskOwner_MA> Select(
                    System.Guid? kioskOwnerMA_ID, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    string mA_DocumentNo, 
                    DateTime? mA_Startdate, 
                    DateTime? mA_Enddate, 
                    decimal? mA_Cost, 
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
            PageRequest request = CreateRequest(kioskOwnerMA_ID, kioskOwner_ID, kioskOwner_KioskOwner_Code, mA_DocumentNo, mA_Startdate, mA_Enddate, mA_Cost, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_KioskOwner_MA", dataView, request);
            return page.ToList<VSM.Data.Objects.T_KioskOwner_MA>();
        }
        
        public List<VSM.Data.Objects.T_KioskOwner_MA> Select(VSM.Data.Objects.T_KioskOwner_MA qbe)
        {
            return Select(qbe.KioskOwnerMA_ID, qbe.KioskOwner_ID, qbe.KioskOwner_KioskOwner_Code, qbe.MA_DocumentNo, qbe.MA_Startdate, qbe.MA_Enddate, qbe.MA_Cost, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? kioskOwnerMA_ID, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    string mA_DocumentNo, 
                    DateTime? mA_Startdate, 
                    DateTime? mA_Enddate, 
                    decimal? mA_Cost, 
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
            PageRequest request = CreateRequest(kioskOwnerMA_ID, kioskOwner_ID, kioskOwner_KioskOwner_Code, mA_DocumentNo, mA_Startdate, mA_Enddate, mA_Cost, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_KioskOwner_MA", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.T_KioskOwner_MA> Select(System.Guid? kioskOwnerMA_ID, System.Guid? kioskOwner_ID, string kioskOwner_KioskOwner_Code, string mA_DocumentNo, DateTime? mA_Startdate, DateTime? mA_Enddate, decimal? mA_Cost, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(kioskOwnerMA_ID, kioskOwner_ID, kioskOwner_KioskOwner_Code, mA_DocumentNo, mA_Startdate, mA_Enddate, mA_Cost, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.T_KioskOwner_MA SelectSingle(System.Guid? kioskOwnerMA_ID)
        {
            List<VSM.Data.Objects.T_KioskOwner_MA> list = Select(kioskOwnerMA_ID, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.T_KioskOwner_MA> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("T_KioskOwner_MA", dataView, request);
            return page.ToList<VSM.Data.Objects.T_KioskOwner_MA>();
        }
        
        public List<VSM.Data.Objects.T_KioskOwner_MA> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.T_KioskOwner_MA> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.T_KioskOwner_MA SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.T_KioskOwner_MA> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.T_KioskOwner_MA theT_KioskOwner_MA, VSM.Data.Objects.T_KioskOwner_MA original_T_KioskOwner_MA)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("KioskOwnerMA_ID", original_T_KioskOwner_MA.KioskOwnerMA_ID, theT_KioskOwner_MA.KioskOwnerMA_ID));
            values.Add(new FieldValue("KioskOwner_ID", original_T_KioskOwner_MA.KioskOwner_ID, theT_KioskOwner_MA.KioskOwner_ID));
            values.Add(new FieldValue("KioskOwner_KioskOwner_Code", original_T_KioskOwner_MA.KioskOwner_KioskOwner_Code, theT_KioskOwner_MA.KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("MA_DocumentNo", original_T_KioskOwner_MA.MA_DocumentNo, theT_KioskOwner_MA.MA_DocumentNo));
            values.Add(new FieldValue("MA_Startdate", original_T_KioskOwner_MA.MA_Startdate, theT_KioskOwner_MA.MA_Startdate));
            values.Add(new FieldValue("MA_Enddate", original_T_KioskOwner_MA.MA_Enddate, theT_KioskOwner_MA.MA_Enddate));
            values.Add(new FieldValue("MA_Cost", original_T_KioskOwner_MA.MA_Cost, theT_KioskOwner_MA.MA_Cost));
            values.Add(new FieldValue("Item_Flag", original_T_KioskOwner_MA.Item_Flag, theT_KioskOwner_MA.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_T_KioskOwner_MA.CreatedBy, theT_KioskOwner_MA.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_T_KioskOwner_MA.CreatedOn, theT_KioskOwner_MA.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_T_KioskOwner_MA.ModifiedBy, theT_KioskOwner_MA.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_T_KioskOwner_MA.ModifiedOn, theT_KioskOwner_MA.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.T_KioskOwner_MA theT_KioskOwner_MA, VSM.Data.Objects.T_KioskOwner_MA original_T_KioskOwner_MA, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "T_KioskOwner_MA";
            args.View = dataView;
            args.Values = CreateFieldValues(theT_KioskOwner_MA, original_T_KioskOwner_MA);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("T_KioskOwner_MA", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theT_KioskOwner_MA);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.T_KioskOwner_MA theT_KioskOwner_MA, VSM.Data.Objects.T_KioskOwner_MA original_T_KioskOwner_MA)
        {
            return ExecuteAction(theT_KioskOwner_MA, original_T_KioskOwner_MA, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.T_KioskOwner_MA theT_KioskOwner_MA)
        {
            return Update(theT_KioskOwner_MA, SelectSingle(theT_KioskOwner_MA.KioskOwnerMA_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.T_KioskOwner_MA theT_KioskOwner_MA)
        {
            return ExecuteAction(theT_KioskOwner_MA, new T_KioskOwner_MA(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.T_KioskOwner_MA theT_KioskOwner_MA)
        {
            return ExecuteAction(theT_KioskOwner_MA, theT_KioskOwner_MA, "Select", "Delete", DeleteView);
        }
    }
}

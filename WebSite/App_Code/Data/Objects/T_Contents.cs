using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class T_Contents
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _content_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _content_Desc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contentFileName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contentContentType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _contentLength;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _effect_Type;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _effective_Date;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _end_Date;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_KioskOwner_Code;
        
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
        
        public T_Contents()
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Content_Desc
        {
            get
            {
                return _content_Desc;
            }
            set
            {
                _content_Desc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ContentFileName
        {
            get
            {
                return _contentFileName;
            }
            set
            {
                _contentFileName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ContentContentType
        {
            get
            {
                return _contentContentType;
            }
            set
            {
                _contentContentType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ContentLength
        {
            get
            {
                return _contentLength;
            }
            set
            {
                _contentLength = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Effect_Type
        {
            get
            {
                return _effect_Type;
            }
            set
            {
                _effect_Type = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? Effective_Date
        {
            get
            {
                return _effective_Date;
            }
            set
            {
                _effective_Date = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? End_Date
        {
            get
            {
                return _end_Date;
            }
            set
            {
                _end_Date = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        public static List<VSM.Data.Objects.T_Contents> Select(System.Guid? content_ID, string content_Desc, string contentFileName, string contentContentType, int? contentLength, string effect_Type, DateTime? effective_Date, DateTime? end_Date, System.Guid? kioskOwner_ID, string kioskOwner_KioskOwner_Code, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new T_ContentsFactory().Select(content_ID, content_Desc, contentFileName, contentContentType, contentLength, effect_Type, effective_Date, end_Date, kioskOwner_ID, kioskOwner_KioskOwner_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.T_Contents> Select(VSM.Data.Objects.T_Contents qbe)
        {
            return new T_ContentsFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.T_Contents> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new T_ContentsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Contents> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new T_ContentsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Contents> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new T_ContentsFactory().Select(filter, sort, T_ContentsFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Contents> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new T_ContentsFactory().Select(filter, sort, T_ContentsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Contents> Select(string filter, BusinessObjectParameters parameters)
        {
            return new T_ContentsFactory().Select(filter, null, T_ContentsFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Contents> Select(string filter, params FieldValue[] parameters)
        {
            return new T_ContentsFactory().Select(filter, null, T_ContentsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Contents SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new T_ContentsFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.T_Contents SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new T_ContentsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Contents SelectSingle(System.Guid? content_ID)
        {
            return new T_ContentsFactory().SelectSingle(content_ID);
        }
        
        public int Insert()
        {
            return new T_ContentsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new T_ContentsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new T_ContentsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Content_ID: {0}", this.Content_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class T_ContentsFactory
    {
        
        public T_ContentsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("T_Contents");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("T_Contents");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("T_Contents");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("T_Contents");
            }
        }
        
        public static T_ContentsFactory Create()
        {
            return new T_ContentsFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    System.Guid? content_ID, 
                    string content_Desc, 
                    string contentFileName, 
                    string contentContentType, 
                    int? contentLength, 
                    string effect_Type, 
                    DateTime? effective_Date, 
                    DateTime? end_Date, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    bool? item_Flag, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (content_ID.HasValue)
            	filter.Add(("Content_ID:=" + content_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(content_Desc)))
            	filter.Add(("Content_Desc:*" + content_Desc));
            if (!(String.IsNullOrEmpty(contentFileName)))
            	filter.Add(("ContentFileName:*" + contentFileName));
            if (!(String.IsNullOrEmpty(contentContentType)))
            	filter.Add(("ContentContentType:*" + contentContentType));
            if (contentLength.HasValue)
            	filter.Add(("ContentLength:=" + contentLength.Value.ToString()));
            if (!(String.IsNullOrEmpty(effect_Type)))
            	filter.Add(("Effect_Type:*" + effect_Type));
            if (effective_Date.HasValue)
            	filter.Add(("Effective_Date:=" + effective_Date.Value.ToString()));
            if (end_Date.HasValue)
            	filter.Add(("End_Date:=" + end_Date.Value.ToString()));
            if (kioskOwner_ID.HasValue)
            	filter.Add(("KioskOwner_ID:=" + kioskOwner_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_KioskOwner_Code)))
            	filter.Add(("KioskOwner_KioskOwner_Code:*" + kioskOwner_KioskOwner_Code));
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
        public List<VSM.Data.Objects.T_Contents> Select(
                    System.Guid? content_ID, 
                    string content_Desc, 
                    string contentFileName, 
                    string contentContentType, 
                    int? contentLength, 
                    string effect_Type, 
                    DateTime? effective_Date, 
                    DateTime? end_Date, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
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
            PageRequest request = CreateRequest(content_ID, content_Desc, contentFileName, contentContentType, contentLength, effect_Type, effective_Date, end_Date, kioskOwner_ID, kioskOwner_KioskOwner_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Contents", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Contents>();
        }
        
        public List<VSM.Data.Objects.T_Contents> Select(VSM.Data.Objects.T_Contents qbe)
        {
            return Select(qbe.Content_ID, qbe.Content_Desc, qbe.ContentFileName, qbe.ContentContentType, qbe.ContentLength, qbe.Effect_Type, qbe.Effective_Date, qbe.End_Date, qbe.KioskOwner_ID, qbe.KioskOwner_KioskOwner_Code, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? content_ID, 
                    string content_Desc, 
                    string contentFileName, 
                    string contentContentType, 
                    int? contentLength, 
                    string effect_Type, 
                    DateTime? effective_Date, 
                    DateTime? end_Date, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
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
            PageRequest request = CreateRequest(content_ID, content_Desc, contentFileName, contentContentType, contentLength, effect_Type, effective_Date, end_Date, kioskOwner_ID, kioskOwner_KioskOwner_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Contents", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.T_Contents> Select(System.Guid? content_ID, string content_Desc, string contentFileName, string contentContentType, int? contentLength, string effect_Type, DateTime? effective_Date, DateTime? end_Date, System.Guid? kioskOwner_ID, string kioskOwner_KioskOwner_Code, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(content_ID, content_Desc, contentFileName, contentContentType, contentLength, effect_Type, effective_Date, end_Date, kioskOwner_ID, kioskOwner_KioskOwner_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.T_Contents SelectSingle(System.Guid? content_ID)
        {
            List<VSM.Data.Objects.T_Contents> list = Select(content_ID, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.T_Contents> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("T_Contents", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Contents>();
        }
        
        public List<VSM.Data.Objects.T_Contents> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.T_Contents> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.T_Contents SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.T_Contents> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.T_Contents theT_Contents, VSM.Data.Objects.T_Contents original_T_Contents)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Content_ID", original_T_Contents.Content_ID, theT_Contents.Content_ID));
            values.Add(new FieldValue("Content_Desc", original_T_Contents.Content_Desc, theT_Contents.Content_Desc));
            values.Add(new FieldValue("ContentFileName", original_T_Contents.ContentFileName, theT_Contents.ContentFileName));
            values.Add(new FieldValue("ContentContentType", original_T_Contents.ContentContentType, theT_Contents.ContentContentType));
            values.Add(new FieldValue("ContentLength", original_T_Contents.ContentLength, theT_Contents.ContentLength));
            values.Add(new FieldValue("Effect_Type", original_T_Contents.Effect_Type, theT_Contents.Effect_Type));
            values.Add(new FieldValue("Effective_Date", original_T_Contents.Effective_Date, theT_Contents.Effective_Date));
            values.Add(new FieldValue("End_Date", original_T_Contents.End_Date, theT_Contents.End_Date));
            values.Add(new FieldValue("KioskOwner_ID", original_T_Contents.KioskOwner_ID, theT_Contents.KioskOwner_ID));
            values.Add(new FieldValue("KioskOwner_KioskOwner_Code", original_T_Contents.KioskOwner_KioskOwner_Code, theT_Contents.KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("Item_Flag", original_T_Contents.Item_Flag, theT_Contents.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_T_Contents.CreatedBy, theT_Contents.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_T_Contents.CreatedOn, theT_Contents.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_T_Contents.ModifiedBy, theT_Contents.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_T_Contents.ModifiedOn, theT_Contents.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.T_Contents theT_Contents, VSM.Data.Objects.T_Contents original_T_Contents, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "T_Contents";
            args.View = dataView;
            args.Values = CreateFieldValues(theT_Contents, original_T_Contents);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("T_Contents", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theT_Contents);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.T_Contents theT_Contents, VSM.Data.Objects.T_Contents original_T_Contents)
        {
            return ExecuteAction(theT_Contents, original_T_Contents, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.T_Contents theT_Contents)
        {
            return Update(theT_Contents, SelectSingle(theT_Contents.Content_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.T_Contents theT_Contents)
        {
            return ExecuteAction(theT_Contents, new T_Contents(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.T_Contents theT_Contents)
        {
            return ExecuteAction(theT_Contents, theT_Contents, "Select", "Delete", DeleteView);
        }
    }
}

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class T_Advertise
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _advertise_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _advertise_Date;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advertise_Desc;
        
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
        
        public T_Advertise()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? Advertise_ID
        {
            get
            {
                return _advertise_ID;
            }
            set
            {
                _advertise_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? Advertise_Date
        {
            get
            {
                return _advertise_Date;
            }
            set
            {
                _advertise_Date = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Advertise_Desc
        {
            get
            {
                return _advertise_Desc;
            }
            set
            {
                _advertise_Desc = value;
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
        
        public static List<VSM.Data.Objects.T_Advertise> Select(System.Guid? advertise_ID, DateTime? advertise_Date, string advertise_Desc, string effect_Type, DateTime? effective_Date, DateTime? end_Date, System.Guid? kioskOwner_ID, string kioskOwner_KioskOwner_Code, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new T_AdvertiseFactory().Select(advertise_ID, advertise_Date, advertise_Desc, effect_Type, effective_Date, end_Date, kioskOwner_ID, kioskOwner_KioskOwner_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.T_Advertise> Select(VSM.Data.Objects.T_Advertise qbe)
        {
            return new T_AdvertiseFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.T_Advertise> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new T_AdvertiseFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Advertise> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new T_AdvertiseFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Advertise> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new T_AdvertiseFactory().Select(filter, sort, T_AdvertiseFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Advertise> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new T_AdvertiseFactory().Select(filter, sort, T_AdvertiseFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Advertise> Select(string filter, BusinessObjectParameters parameters)
        {
            return new T_AdvertiseFactory().Select(filter, null, T_AdvertiseFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Advertise> Select(string filter, params FieldValue[] parameters)
        {
            return new T_AdvertiseFactory().Select(filter, null, T_AdvertiseFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Advertise SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new T_AdvertiseFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.T_Advertise SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new T_AdvertiseFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Advertise SelectSingle(System.Guid? advertise_ID)
        {
            return new T_AdvertiseFactory().SelectSingle(advertise_ID);
        }
        
        public int Insert()
        {
            return new T_AdvertiseFactory().Insert(this);
        }
        
        public int Update()
        {
            return new T_AdvertiseFactory().Update(this);
        }
        
        public int Delete()
        {
            return new T_AdvertiseFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Advertise_ID: {0}", this.Advertise_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class T_AdvertiseFactory
    {
        
        public T_AdvertiseFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("T_Advertise");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("T_Advertise");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("T_Advertise");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("T_Advertise");
            }
        }
        
        public static T_AdvertiseFactory Create()
        {
            return new T_AdvertiseFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    System.Guid? advertise_ID, 
                    DateTime? advertise_Date, 
                    string advertise_Desc, 
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
            if (advertise_ID.HasValue)
            	filter.Add(("Advertise_ID:=" + advertise_ID.Value.ToString()));
            if (advertise_Date.HasValue)
            	filter.Add(("Advertise_Date:=" + advertise_Date.Value.ToString()));
            if (!(String.IsNullOrEmpty(advertise_Desc)))
            	filter.Add(("Advertise_Desc:*" + advertise_Desc));
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
        public List<VSM.Data.Objects.T_Advertise> Select(
                    System.Guid? advertise_ID, 
                    DateTime? advertise_Date, 
                    string advertise_Desc, 
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
            PageRequest request = CreateRequest(advertise_ID, advertise_Date, advertise_Desc, effect_Type, effective_Date, end_Date, kioskOwner_ID, kioskOwner_KioskOwner_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Advertise", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Advertise>();
        }
        
        public List<VSM.Data.Objects.T_Advertise> Select(VSM.Data.Objects.T_Advertise qbe)
        {
            return Select(qbe.Advertise_ID, qbe.Advertise_Date, qbe.Advertise_Desc, qbe.Effect_Type, qbe.Effective_Date, qbe.End_Date, qbe.KioskOwner_ID, qbe.KioskOwner_KioskOwner_Code, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? advertise_ID, 
                    DateTime? advertise_Date, 
                    string advertise_Desc, 
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
            PageRequest request = CreateRequest(advertise_ID, advertise_Date, advertise_Desc, effect_Type, effective_Date, end_Date, kioskOwner_ID, kioskOwner_KioskOwner_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Advertise", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.T_Advertise> Select(System.Guid? advertise_ID, DateTime? advertise_Date, string advertise_Desc, string effect_Type, DateTime? effective_Date, DateTime? end_Date, System.Guid? kioskOwner_ID, string kioskOwner_KioskOwner_Code, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(advertise_ID, advertise_Date, advertise_Desc, effect_Type, effective_Date, end_Date, kioskOwner_ID, kioskOwner_KioskOwner_Code, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.T_Advertise SelectSingle(System.Guid? advertise_ID)
        {
            List<VSM.Data.Objects.T_Advertise> list = Select(advertise_ID, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.T_Advertise> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("T_Advertise", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Advertise>();
        }
        
        public List<VSM.Data.Objects.T_Advertise> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.T_Advertise> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.T_Advertise SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.T_Advertise> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.T_Advertise theT_Advertise, VSM.Data.Objects.T_Advertise original_T_Advertise)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Advertise_ID", original_T_Advertise.Advertise_ID, theT_Advertise.Advertise_ID));
            values.Add(new FieldValue("Advertise_Date", original_T_Advertise.Advertise_Date, theT_Advertise.Advertise_Date));
            values.Add(new FieldValue("Advertise_Desc", original_T_Advertise.Advertise_Desc, theT_Advertise.Advertise_Desc));
            values.Add(new FieldValue("Effect_Type", original_T_Advertise.Effect_Type, theT_Advertise.Effect_Type));
            values.Add(new FieldValue("Effective_Date", original_T_Advertise.Effective_Date, theT_Advertise.Effective_Date));
            values.Add(new FieldValue("End_Date", original_T_Advertise.End_Date, theT_Advertise.End_Date));
            values.Add(new FieldValue("KioskOwner_ID", original_T_Advertise.KioskOwner_ID, theT_Advertise.KioskOwner_ID));
            values.Add(new FieldValue("KioskOwner_KioskOwner_Code", original_T_Advertise.KioskOwner_KioskOwner_Code, theT_Advertise.KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("Item_Flag", original_T_Advertise.Item_Flag, theT_Advertise.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_T_Advertise.CreatedBy, theT_Advertise.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_T_Advertise.CreatedOn, theT_Advertise.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_T_Advertise.ModifiedBy, theT_Advertise.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_T_Advertise.ModifiedOn, theT_Advertise.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.T_Advertise theT_Advertise, VSM.Data.Objects.T_Advertise original_T_Advertise, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "T_Advertise";
            args.View = dataView;
            args.Values = CreateFieldValues(theT_Advertise, original_T_Advertise);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("T_Advertise", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theT_Advertise);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.T_Advertise theT_Advertise, VSM.Data.Objects.T_Advertise original_T_Advertise)
        {
            return ExecuteAction(theT_Advertise, original_T_Advertise, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.T_Advertise theT_Advertise)
        {
            return Update(theT_Advertise, SelectSingle(theT_Advertise.Advertise_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.T_Advertise theT_Advertise)
        {
            return ExecuteAction(theT_Advertise, new T_Advertise(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.T_Advertise theT_Advertise)
        {
            return ExecuteAction(theT_Advertise, theT_Advertise, "Select", "Delete", DeleteView);
        }
    }
}

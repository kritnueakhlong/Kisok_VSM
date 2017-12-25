using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_Kiosk_Type
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskType_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskType_Name;
        
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
        
        public M_Kiosk_Type()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public string KioskType_Code
        {
            get
            {
                return _kioskType_Code;
            }
            set
            {
                _kioskType_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string KioskType_Name
        {
            get
            {
                return _kioskType_Name;
            }
            set
            {
                _kioskType_Name = value;
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
        
        public static List<VSM.Data.Objects.M_Kiosk_Type> Select(string kioskType_Code, string kioskType_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_Kiosk_TypeFactory().Select(kioskType_Code, kioskType_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Type> Select(VSM.Data.Objects.M_Kiosk_Type qbe)
        {
            return new M_Kiosk_TypeFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Type> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_TypeFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Type> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_Kiosk_TypeFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Type> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_TypeFactory().Select(filter, sort, M_Kiosk_TypeFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Type> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_Kiosk_TypeFactory().Select(filter, sort, M_Kiosk_TypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Type> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_TypeFactory().Select(filter, null, M_Kiosk_TypeFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Type> Select(string filter, params FieldValue[] parameters)
        {
            return new M_Kiosk_TypeFactory().Select(filter, null, M_Kiosk_TypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Kiosk_Type SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_TypeFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_Kiosk_Type SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_Kiosk_TypeFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Kiosk_Type SelectSingle(string kioskType_Code)
        {
            return new M_Kiosk_TypeFactory().SelectSingle(kioskType_Code);
        }
        
        public int Insert()
        {
            return new M_Kiosk_TypeFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_Kiosk_TypeFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_Kiosk_TypeFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("KioskType_Code: {0}", this.KioskType_Code);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_Kiosk_TypeFactory
    {
        
        public M_Kiosk_TypeFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_Kiosk_Type");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_Kiosk_Type");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_Kiosk_Type");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_Kiosk_Type");
            }
        }
        
        public static M_Kiosk_TypeFactory Create()
        {
            return new M_Kiosk_TypeFactory();
        }
        
        protected virtual PageRequest CreateRequest(string kioskType_Code, string kioskType_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (kioskType_Code != null)
            	filter.Add(("KioskType_Code:=" + kioskType_Code));
            if (!(String.IsNullOrEmpty(kioskType_Name)))
            	filter.Add(("KioskType_Name:*" + kioskType_Name));
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
        public List<VSM.Data.Objects.M_Kiosk_Type> Select(string kioskType_Code, string kioskType_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kioskType_Code, kioskType_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Kiosk_Type", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Kiosk_Type>();
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Type> Select(VSM.Data.Objects.M_Kiosk_Type qbe)
        {
            return Select(qbe.KioskType_Code, qbe.KioskType_Name, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(string kioskType_Code, string kioskType_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(kioskType_Code, kioskType_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Kiosk_Type", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_Kiosk_Type> Select(string kioskType_Code, string kioskType_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(kioskType_Code, kioskType_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_Kiosk_Type SelectSingle(string kioskType_Code)
        {
            List<VSM.Data.Objects.M_Kiosk_Type> list = Select(kioskType_Code, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Type> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_Kiosk_Type", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Kiosk_Type>();
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Type> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Type> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_Kiosk_Type SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_Kiosk_Type> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_Kiosk_Type theM_Kiosk_Type, VSM.Data.Objects.M_Kiosk_Type original_M_Kiosk_Type)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("KioskType_Code", original_M_Kiosk_Type.KioskType_Code, theM_Kiosk_Type.KioskType_Code));
            values.Add(new FieldValue("KioskType_Name", original_M_Kiosk_Type.KioskType_Name, theM_Kiosk_Type.KioskType_Name));
            values.Add(new FieldValue("Item_Flag", original_M_Kiosk_Type.Item_Flag, theM_Kiosk_Type.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_Kiosk_Type.CreatedBy, theM_Kiosk_Type.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_Kiosk_Type.CreatedOn, theM_Kiosk_Type.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_Kiosk_Type.ModifiedBy, theM_Kiosk_Type.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_Kiosk_Type.ModifiedOn, theM_Kiosk_Type.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_Kiosk_Type theM_Kiosk_Type, VSM.Data.Objects.M_Kiosk_Type original_M_Kiosk_Type, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_Kiosk_Type";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_Kiosk_Type, original_M_Kiosk_Type);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_Kiosk_Type", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_Kiosk_Type);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_Kiosk_Type theM_Kiosk_Type, VSM.Data.Objects.M_Kiosk_Type original_M_Kiosk_Type)
        {
            return ExecuteAction(theM_Kiosk_Type, original_M_Kiosk_Type, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_Kiosk_Type theM_Kiosk_Type)
        {
            return Update(theM_Kiosk_Type, SelectSingle(theM_Kiosk_Type.KioskType_Code));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_Kiosk_Type theM_Kiosk_Type)
        {
            return ExecuteAction(theM_Kiosk_Type, new M_Kiosk_Type(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_Kiosk_Type theM_Kiosk_Type)
        {
            return ExecuteAction(theM_Kiosk_Type, theM_Kiosk_Type, "Select", "Delete", DeleteView);
        }
    }
}

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_Kiosk_Material
    {
        
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
        private System.Guid? _mater_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mater_MaterType_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mater_MaterType_MaterType_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        public M_Kiosk_Material()
        {
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
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? Mater_ID
        {
            get
            {
                return _mater_ID;
            }
            set
            {
                _mater_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Mater_MaterType_Code
        {
            get
            {
                return _mater_MaterType_Code;
            }
            set
            {
                _mater_MaterType_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Mater_MaterType_MaterType_Name
        {
            get
            {
                return _mater_MaterType_MaterType_Name;
            }
            set
            {
                _mater_MaterType_MaterType_Name = value;
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
        
        public static List<VSM.Data.Objects.M_Kiosk_Material> Select(System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, System.Guid? mater_ID, string mater_MaterType_Code, string mater_MaterType_MaterType_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_Kiosk_MaterialFactory().Select(kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, mater_ID, mater_MaterType_Code, mater_MaterType_MaterType_Name, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Material> Select(VSM.Data.Objects.M_Kiosk_Material qbe)
        {
            return new M_Kiosk_MaterialFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Material> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_MaterialFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Material> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_Kiosk_MaterialFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Material> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_MaterialFactory().Select(filter, sort, M_Kiosk_MaterialFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Material> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_Kiosk_MaterialFactory().Select(filter, sort, M_Kiosk_MaterialFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Material> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_MaterialFactory().Select(filter, null, M_Kiosk_MaterialFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Kiosk_Material> Select(string filter, params FieldValue[] parameters)
        {
            return new M_Kiosk_MaterialFactory().Select(filter, null, M_Kiosk_MaterialFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Kiosk_Material SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_Kiosk_MaterialFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_Kiosk_Material SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_Kiosk_MaterialFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Kiosk_Material SelectSingle(System.Guid? kiosk_ID, System.Guid? mater_ID)
        {
            return new M_Kiosk_MaterialFactory().SelectSingle(kiosk_ID, mater_ID);
        }
        
        public int Insert()
        {
            return new M_Kiosk_MaterialFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_Kiosk_MaterialFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_Kiosk_MaterialFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Kiosk_ID: {0}; Mater_ID: {1}", this.Kiosk_ID, this.Mater_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_Kiosk_MaterialFactory
    {
        
        public M_Kiosk_MaterialFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_Kiosk_Material");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_Kiosk_Material");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_Kiosk_Material");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_Kiosk_Material");
            }
        }
        
        public static M_Kiosk_MaterialFactory Create()
        {
            return new M_Kiosk_MaterialFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, System.Guid? mater_ID, string mater_MaterType_Code, string mater_MaterType_MaterType_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
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
            if (mater_ID.HasValue)
            	filter.Add(("Mater_ID:=" + mater_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(mater_MaterType_Code)))
            	filter.Add(("Mater_MaterType_Code:*" + mater_MaterType_Code));
            if (!(String.IsNullOrEmpty(mater_MaterType_MaterType_Name)))
            	filter.Add(("Mater_MaterType_MaterType_Name:*" + mater_MaterType_MaterType_Name));
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
        public List<VSM.Data.Objects.M_Kiosk_Material> Select(
                    System.Guid? kiosk_ID, 
                    string kiosk_Kiosk_Code, 
                    string kiosk_KioskType_KioskType_Name, 
                    string kiosk_Location_Location_Address, 
                    string kiosk_Location_KioskOwner_KioskOwner_Code, 
                    System.Guid? mater_ID, 
                    string mater_MaterType_Code, 
                    string mater_MaterType_MaterType_Name, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, mater_ID, mater_MaterType_Code, mater_MaterType_MaterType_Name, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Kiosk_Material", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Kiosk_Material>();
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Material> Select(VSM.Data.Objects.M_Kiosk_Material qbe)
        {
            return Select(qbe.Kiosk_ID, qbe.Kiosk_Kiosk_Code, qbe.Kiosk_KioskType_KioskType_Name, qbe.Kiosk_Location_Location_Address, qbe.Kiosk_Location_KioskOwner_KioskOwner_Code, qbe.Mater_ID, qbe.Mater_MaterType_Code, qbe.Mater_MaterType_MaterType_Name, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? kiosk_ID, 
                    string kiosk_Kiosk_Code, 
                    string kiosk_KioskType_KioskType_Name, 
                    string kiosk_Location_Location_Address, 
                    string kiosk_Location_KioskOwner_KioskOwner_Code, 
                    System.Guid? mater_ID, 
                    string mater_MaterType_Code, 
                    string mater_MaterType_MaterType_Name, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, mater_ID, mater_MaterType_Code, mater_MaterType_MaterType_Name, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Kiosk_Material", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_Kiosk_Material> Select(System.Guid? kiosk_ID, string kiosk_Kiosk_Code, string kiosk_KioskType_KioskType_Name, string kiosk_Location_Location_Address, string kiosk_Location_KioskOwner_KioskOwner_Code, System.Guid? mater_ID, string mater_MaterType_Code, string mater_MaterType_MaterType_Name, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, mater_ID, mater_MaterType_Code, mater_MaterType_MaterType_Name, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_Kiosk_Material SelectSingle(System.Guid? kiosk_ID, System.Guid? mater_ID)
        {
            List<VSM.Data.Objects.M_Kiosk_Material> list = Select(kiosk_ID, null, null, null, null, mater_ID, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Material> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_Kiosk_Material", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Kiosk_Material>();
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Material> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_Kiosk_Material> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_Kiosk_Material SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_Kiosk_Material> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_Kiosk_Material theM_Kiosk_Material, VSM.Data.Objects.M_Kiosk_Material original_M_Kiosk_Material)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Kiosk_ID", original_M_Kiosk_Material.Kiosk_ID, theM_Kiosk_Material.Kiosk_ID));
            values.Add(new FieldValue("Kiosk_Kiosk_Code", original_M_Kiosk_Material.Kiosk_Kiosk_Code, theM_Kiosk_Material.Kiosk_Kiosk_Code, true));
            values.Add(new FieldValue("Kiosk_KioskType_KioskType_Name", original_M_Kiosk_Material.Kiosk_KioskType_KioskType_Name, theM_Kiosk_Material.Kiosk_KioskType_KioskType_Name, true));
            values.Add(new FieldValue("Kiosk_Location_Location_Address", original_M_Kiosk_Material.Kiosk_Location_Location_Address, theM_Kiosk_Material.Kiosk_Location_Location_Address, true));
            values.Add(new FieldValue("Kiosk_Location_KioskOwner_KioskOwner_Code", original_M_Kiosk_Material.Kiosk_Location_KioskOwner_KioskOwner_Code, theM_Kiosk_Material.Kiosk_Location_KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("Mater_ID", original_M_Kiosk_Material.Mater_ID, theM_Kiosk_Material.Mater_ID));
            values.Add(new FieldValue("Mater_MaterType_Code", original_M_Kiosk_Material.Mater_MaterType_Code, theM_Kiosk_Material.Mater_MaterType_Code, true));
            values.Add(new FieldValue("Mater_MaterType_MaterType_Name", original_M_Kiosk_Material.Mater_MaterType_MaterType_Name, theM_Kiosk_Material.Mater_MaterType_MaterType_Name, true));
            values.Add(new FieldValue("CreatedBy", original_M_Kiosk_Material.CreatedBy, theM_Kiosk_Material.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_Kiosk_Material.CreatedOn, theM_Kiosk_Material.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_Kiosk_Material.ModifiedBy, theM_Kiosk_Material.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_Kiosk_Material.ModifiedOn, theM_Kiosk_Material.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_Kiosk_Material theM_Kiosk_Material, VSM.Data.Objects.M_Kiosk_Material original_M_Kiosk_Material, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_Kiosk_Material";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_Kiosk_Material, original_M_Kiosk_Material);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_Kiosk_Material", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_Kiosk_Material);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_Kiosk_Material theM_Kiosk_Material, VSM.Data.Objects.M_Kiosk_Material original_M_Kiosk_Material)
        {
            return ExecuteAction(theM_Kiosk_Material, original_M_Kiosk_Material, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_Kiosk_Material theM_Kiosk_Material)
        {
            return Update(theM_Kiosk_Material, SelectSingle(theM_Kiosk_Material.Kiosk_ID, theM_Kiosk_Material.Mater_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_Kiosk_Material theM_Kiosk_Material)
        {
            return ExecuteAction(theM_Kiosk_Material, new M_Kiosk_Material(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_Kiosk_Material theM_Kiosk_Material)
        {
            return ExecuteAction(theM_Kiosk_Material, theM_Kiosk_Material, "Select", "Delete", DeleteView);
        }
    }
}

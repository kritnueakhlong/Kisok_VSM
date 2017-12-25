using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_Material
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _mater_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mater_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mater_Model;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mater_Desc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _materType_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _materType_MaterType_Name;
        
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
        
        public M_Material()
        {
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
        public string Mater_Name
        {
            get
            {
                return _mater_Name;
            }
            set
            {
                _mater_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Mater_Model
        {
            get
            {
                return _mater_Model;
            }
            set
            {
                _mater_Model = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Mater_Desc
        {
            get
            {
                return _mater_Desc;
            }
            set
            {
                _mater_Desc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string MaterType_Code
        {
            get
            {
                return _materType_Code;
            }
            set
            {
                _materType_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string MaterType_MaterType_Name
        {
            get
            {
                return _materType_MaterType_Name;
            }
            set
            {
                _materType_MaterType_Name = value;
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
        
        public static List<VSM.Data.Objects.M_Material> Select(System.Guid? mater_ID, string mater_Name, string mater_Model, string mater_Desc, string materType_Code, string materType_MaterType_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_MaterialFactory().Select(mater_ID, mater_Name, mater_Model, mater_Desc, materType_Code, materType_MaterType_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_Material> Select(VSM.Data.Objects.M_Material qbe)
        {
            return new M_MaterialFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_Material> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_MaterialFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Material> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_MaterialFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Material> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_MaterialFactory().Select(filter, sort, M_MaterialFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Material> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_MaterialFactory().Select(filter, sort, M_MaterialFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Material> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_MaterialFactory().Select(filter, null, M_MaterialFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Material> Select(string filter, params FieldValue[] parameters)
        {
            return new M_MaterialFactory().Select(filter, null, M_MaterialFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Material SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_MaterialFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_Material SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_MaterialFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Material SelectSingle(System.Guid? mater_ID)
        {
            return new M_MaterialFactory().SelectSingle(mater_ID);
        }
        
        public int Insert()
        {
            return new M_MaterialFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_MaterialFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_MaterialFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Mater_ID: {0}", this.Mater_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_MaterialFactory
    {
        
        public M_MaterialFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_Material");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_Material");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_Material");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_Material");
            }
        }
        
        public static M_MaterialFactory Create()
        {
            return new M_MaterialFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? mater_ID, string mater_Name, string mater_Model, string mater_Desc, string materType_Code, string materType_MaterType_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (mater_ID.HasValue)
            	filter.Add(("Mater_ID:=" + mater_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(mater_Name)))
            	filter.Add(("Mater_Name:*" + mater_Name));
            if (!(String.IsNullOrEmpty(mater_Model)))
            	filter.Add(("Mater_Model:*" + mater_Model));
            if (!(String.IsNullOrEmpty(mater_Desc)))
            	filter.Add(("Mater_Desc:*" + mater_Desc));
            if (!(String.IsNullOrEmpty(materType_Code)))
            	filter.Add(("MaterType_Code:*" + materType_Code));
            if (!(String.IsNullOrEmpty(materType_MaterType_Name)))
            	filter.Add(("MaterType_MaterType_Name:*" + materType_MaterType_Name));
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
        public List<VSM.Data.Objects.M_Material> Select(System.Guid? mater_ID, string mater_Name, string mater_Model, string mater_Desc, string materType_Code, string materType_MaterType_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(mater_ID, mater_Name, mater_Model, mater_Desc, materType_Code, materType_MaterType_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Material", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Material>();
        }
        
        public List<VSM.Data.Objects.M_Material> Select(VSM.Data.Objects.M_Material qbe)
        {
            return Select(qbe.Mater_ID, qbe.Mater_Name, qbe.Mater_Model, qbe.Mater_Desc, qbe.MaterType_Code, qbe.MaterType_MaterType_Name, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(System.Guid? mater_ID, string mater_Name, string mater_Model, string mater_Desc, string materType_Code, string materType_MaterType_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(mater_ID, mater_Name, mater_Model, mater_Desc, materType_Code, materType_MaterType_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Material", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_Material> Select(System.Guid? mater_ID, string mater_Name, string mater_Model, string mater_Desc, string materType_Code, string materType_MaterType_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(mater_ID, mater_Name, mater_Model, mater_Desc, materType_Code, materType_MaterType_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_Material SelectSingle(System.Guid? mater_ID)
        {
            List<VSM.Data.Objects.M_Material> list = Select(mater_ID, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_Material> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_Material", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Material>();
        }
        
        public List<VSM.Data.Objects.M_Material> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_Material> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_Material SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_Material> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_Material theM_Material, VSM.Data.Objects.M_Material original_M_Material)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Mater_ID", original_M_Material.Mater_ID, theM_Material.Mater_ID));
            values.Add(new FieldValue("Mater_Name", original_M_Material.Mater_Name, theM_Material.Mater_Name));
            values.Add(new FieldValue("Mater_Model", original_M_Material.Mater_Model, theM_Material.Mater_Model));
            values.Add(new FieldValue("Mater_Desc", original_M_Material.Mater_Desc, theM_Material.Mater_Desc));
            values.Add(new FieldValue("MaterType_Code", original_M_Material.MaterType_Code, theM_Material.MaterType_Code));
            values.Add(new FieldValue("MaterType_MaterType_Name", original_M_Material.MaterType_MaterType_Name, theM_Material.MaterType_MaterType_Name, true));
            values.Add(new FieldValue("Item_Flag", original_M_Material.Item_Flag, theM_Material.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_Material.CreatedBy, theM_Material.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_Material.CreatedOn, theM_Material.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_Material.ModifiedBy, theM_Material.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_Material.ModifiedOn, theM_Material.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_Material theM_Material, VSM.Data.Objects.M_Material original_M_Material, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_Material";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_Material, original_M_Material);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_Material", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_Material);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_Material theM_Material, VSM.Data.Objects.M_Material original_M_Material)
        {
            return ExecuteAction(theM_Material, original_M_Material, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_Material theM_Material)
        {
            return Update(theM_Material, SelectSingle(theM_Material.Mater_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_Material theM_Material)
        {
            return ExecuteAction(theM_Material, new M_Material(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_Material theM_Material)
        {
            return ExecuteAction(theM_Material, theM_Material, "Select", "Delete", DeleteView);
        }
    }
}

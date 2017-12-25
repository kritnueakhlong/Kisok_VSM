using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_Radius_Server
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _radiusServer_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _radiusServer_Name;
        
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
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _interfaces;
        
        public M_Radius_Server()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public string RadiusServer_Code
        {
            get
            {
                return _radiusServer_Code;
            }
            set
            {
                _radiusServer_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RadiusServer_Name
        {
            get
            {
                return _radiusServer_Name;
            }
            set
            {
                _radiusServer_Name = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Interfaces
        {
            get
            {
                return _interfaces;
            }
            set
            {
                _interfaces = value;
            }
        }
        
        public static List<VSM.Data.Objects.M_Radius_Server> Select(string radiusServer_Code, string radiusServer_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_Radius_ServerFactory().Select(radiusServer_Code, radiusServer_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_Radius_Server> Select(VSM.Data.Objects.M_Radius_Server qbe)
        {
            return new M_Radius_ServerFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_Radius_Server> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_Radius_ServerFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Radius_Server> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_Radius_ServerFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Radius_Server> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_Radius_ServerFactory().Select(filter, sort, M_Radius_ServerFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Radius_Server> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_Radius_ServerFactory().Select(filter, sort, M_Radius_ServerFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Radius_Server> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_Radius_ServerFactory().Select(filter, null, M_Radius_ServerFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Radius_Server> Select(string filter, params FieldValue[] parameters)
        {
            return new M_Radius_ServerFactory().Select(filter, null, M_Radius_ServerFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Radius_Server SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_Radius_ServerFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_Radius_Server SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_Radius_ServerFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Radius_Server SelectSingle(string radiusServer_Code)
        {
            return new M_Radius_ServerFactory().SelectSingle(radiusServer_Code);
        }
        
        public int Insert()
        {
            return new M_Radius_ServerFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_Radius_ServerFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_Radius_ServerFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("RadiusServer_Code: {0}", this.RadiusServer_Code);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_Radius_ServerFactory
    {
        
        public M_Radius_ServerFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_Radius_Server");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_Radius_Server");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_Radius_Server");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_Radius_Server");
            }
        }
        
        public static M_Radius_ServerFactory Create()
        {
            return new M_Radius_ServerFactory();
        }
        
        protected virtual PageRequest CreateRequest(string radiusServer_Code, string radiusServer_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (radiusServer_Code != null)
            	filter.Add(("RadiusServer_Code:=" + radiusServer_Code));
            if (!(String.IsNullOrEmpty(radiusServer_Name)))
            	filter.Add(("RadiusServer_Name:*" + radiusServer_Name));
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
        public List<VSM.Data.Objects.M_Radius_Server> Select(string radiusServer_Code, string radiusServer_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(radiusServer_Code, radiusServer_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Radius_Server", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Radius_Server>();
        }
        
        public List<VSM.Data.Objects.M_Radius_Server> Select(VSM.Data.Objects.M_Radius_Server qbe)
        {
            return Select(qbe.RadiusServer_Code, qbe.RadiusServer_Name, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(string radiusServer_Code, string radiusServer_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(radiusServer_Code, radiusServer_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Radius_Server", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_Radius_Server> Select(string radiusServer_Code, string radiusServer_Name, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(radiusServer_Code, radiusServer_Name, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_Radius_Server SelectSingle(string radiusServer_Code)
        {
            List<VSM.Data.Objects.M_Radius_Server> list = Select(radiusServer_Code, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_Radius_Server> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_Radius_Server", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Radius_Server>();
        }
        
        public List<VSM.Data.Objects.M_Radius_Server> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_Radius_Server> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_Radius_Server SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_Radius_Server> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_Radius_Server theM_Radius_Server, VSM.Data.Objects.M_Radius_Server original_M_Radius_Server)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("RadiusServer_Code", original_M_Radius_Server.RadiusServer_Code, theM_Radius_Server.RadiusServer_Code));
            values.Add(new FieldValue("RadiusServer_Name", original_M_Radius_Server.RadiusServer_Name, theM_Radius_Server.RadiusServer_Name));
            values.Add(new FieldValue("Item_Flag", original_M_Radius_Server.Item_Flag, theM_Radius_Server.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_Radius_Server.CreatedBy, theM_Radius_Server.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_Radius_Server.CreatedOn, theM_Radius_Server.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_Radius_Server.ModifiedBy, theM_Radius_Server.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_Radius_Server.ModifiedOn, theM_Radius_Server.ModifiedOn));
            values.Add(new FieldValue("Interfaces", original_M_Radius_Server.Interfaces, theM_Radius_Server.Interfaces));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_Radius_Server theM_Radius_Server, VSM.Data.Objects.M_Radius_Server original_M_Radius_Server, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_Radius_Server";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_Radius_Server, original_M_Radius_Server);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_Radius_Server", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_Radius_Server);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_Radius_Server theM_Radius_Server, VSM.Data.Objects.M_Radius_Server original_M_Radius_Server)
        {
            return ExecuteAction(theM_Radius_Server, original_M_Radius_Server, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_Radius_Server theM_Radius_Server)
        {
            return Update(theM_Radius_Server, SelectSingle(theM_Radius_Server.RadiusServer_Code));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_Radius_Server theM_Radius_Server)
        {
            return ExecuteAction(theM_Radius_Server, new M_Radius_Server(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_Radius_Server theM_Radius_Server)
        {
            return ExecuteAction(theM_Radius_Server, theM_Radius_Server, "Select", "Delete", DeleteView);
        }
    }
}

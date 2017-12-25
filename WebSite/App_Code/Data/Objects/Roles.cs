using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Roles
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _roles_id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _roles_name;
        
        public Roles()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? roles_id
        {
            get
            {
                return _roles_id;
            }
            set
            {
                _roles_id = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string roles_name
        {
            get
            {
                return _roles_name;
            }
            set
            {
                _roles_name = value;
            }
        }
        
        public static List<VSM.Data.Objects.Roles> Select(System.Guid? roles_id, string roles_name)
        {
            return new RolesFactory().Select(roles_id, roles_name);
        }
        
        public static List<VSM.Data.Objects.Roles> Select(VSM.Data.Objects.Roles qbe)
        {
            return new RolesFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.Roles> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new RolesFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.Roles> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new RolesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.Roles> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new RolesFactory().Select(filter, sort, RolesFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.Roles> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new RolesFactory().Select(filter, sort, RolesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.Roles> Select(string filter, BusinessObjectParameters parameters)
        {
            return new RolesFactory().Select(filter, null, RolesFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.Roles> Select(string filter, params FieldValue[] parameters)
        {
            return new RolesFactory().Select(filter, null, RolesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.Roles SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new RolesFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.Roles SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new RolesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.Roles SelectSingle(System.Guid? roles_id)
        {
            return new RolesFactory().SelectSingle(roles_id);
        }
        
        public int Insert()
        {
            return new RolesFactory().Insert(this);
        }
        
        public int Update()
        {
            return new RolesFactory().Update(this);
        }
        
        public int Delete()
        {
            return new RolesFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("roles_id: {0}", this.roles_id);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class RolesFactory
    {
        
        public RolesFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Roles");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Roles");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Roles");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Roles");
            }
        }
        
        public static RolesFactory Create()
        {
            return new RolesFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? roles_id, string roles_name, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (roles_id.HasValue)
            	filter.Add(("roles_id:=" + roles_id.Value.ToString()));
            if (!(String.IsNullOrEmpty(roles_name)))
            	filter.Add(("roles_name:*" + roles_name));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<VSM.Data.Objects.Roles> Select(System.Guid? roles_id, string roles_name, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(roles_id, roles_name, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Roles", dataView, request);
            return page.ToList<VSM.Data.Objects.Roles>();
        }
        
        public List<VSM.Data.Objects.Roles> Select(VSM.Data.Objects.Roles qbe)
        {
            return Select(qbe.roles_id, qbe.roles_name);
        }
        
        public int SelectCount(System.Guid? roles_id, string roles_name, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(roles_id, roles_name, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Roles", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.Roles> Select(System.Guid? roles_id, string roles_name)
        {
            return Select(roles_id, roles_name, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.Roles SelectSingle(System.Guid? roles_id)
        {
            string emptyroles_name = null;
            List<VSM.Data.Objects.Roles> list = Select(roles_id, emptyroles_name);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.Roles> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Roles", dataView, request);
            return page.ToList<VSM.Data.Objects.Roles>();
        }
        
        public List<VSM.Data.Objects.Roles> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.Roles> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.Roles SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.Roles> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.Roles theRoles, VSM.Data.Objects.Roles original_Roles)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("roles_id", original_Roles.roles_id, theRoles.roles_id));
            values.Add(new FieldValue("roles_name", original_Roles.roles_name, theRoles.roles_name));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.Roles theRoles, VSM.Data.Objects.Roles original_Roles, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Roles";
            args.View = dataView;
            args.Values = CreateFieldValues(theRoles, original_Roles);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Roles", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theRoles);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.Roles theRoles, VSM.Data.Objects.Roles original_Roles)
        {
            return ExecuteAction(theRoles, original_Roles, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.Roles theRoles)
        {
            return Update(theRoles, SelectSingle(theRoles.roles_id));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.Roles theRoles)
        {
            return ExecuteAction(theRoles, new Roles(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.Roles theRoles)
        {
            return ExecuteAction(theRoles, theRoles, "Select", "Delete", DeleteView);
        }
    }
}

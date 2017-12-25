using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class VW_RPT_OldCustomer
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _idenDoc_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _identity_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _name_th;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sex;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _authen_User;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_Branch_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _amount;
        
        public VW_RPT_OldCustomer()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string IdenDoc_Code
        {
            get
            {
                return _idenDoc_Code;
            }
            set
            {
                _idenDoc_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(true, true, true)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Name_th
        {
            get
            {
                return _name_th;
            }
            set
            {
                _name_th = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Authen_User
        {
            get
            {
                return _authen_User;
            }
            set
            {
                _authen_User = value;
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
        public int? Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
        
        public static List<VSM.Data.Objects.VW_RPT_OldCustomer> Select(string idenDoc_Code, string identity_ID, string name_th, string sex, string authen_User, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, int? amount)
        {
            return new VW_RPT_OldCustomerFactory().Select(idenDoc_Code, identity_ID, name_th, sex, authen_User, kioskOwner_ID, kioskOwner_Branch_ID, amount);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_OldCustomer> Select(VSM.Data.Objects.VW_RPT_OldCustomer qbe)
        {
            return new VW_RPT_OldCustomerFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_OldCustomer> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new VW_RPT_OldCustomerFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_OldCustomer> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new VW_RPT_OldCustomerFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.VW_RPT_OldCustomer> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new VW_RPT_OldCustomerFactory().Select(filter, sort, VW_RPT_OldCustomerFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_OldCustomer> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new VW_RPT_OldCustomerFactory().Select(filter, sort, VW_RPT_OldCustomerFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.VW_RPT_OldCustomer> Select(string filter, BusinessObjectParameters parameters)
        {
            return new VW_RPT_OldCustomerFactory().Select(filter, null, VW_RPT_OldCustomerFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_OldCustomer> Select(string filter, params FieldValue[] parameters)
        {
            return new VW_RPT_OldCustomerFactory().Select(filter, null, VW_RPT_OldCustomerFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.VW_RPT_OldCustomer SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new VW_RPT_OldCustomerFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.VW_RPT_OldCustomer SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new VW_RPT_OldCustomerFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.VW_RPT_OldCustomer SelectSingle(string identity_ID)
        {
            return new VW_RPT_OldCustomerFactory().SelectSingle(identity_ID);
        }
        
        public int Insert()
        {
            return new VW_RPT_OldCustomerFactory().Insert(this);
        }
        
        public int Update()
        {
            return new VW_RPT_OldCustomerFactory().Update(this);
        }
        
        public int Delete()
        {
            return new VW_RPT_OldCustomerFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Identity_ID: {0}", this.Identity_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class VW_RPT_OldCustomerFactory
    {
        
        public VW_RPT_OldCustomerFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("VW_RPT_OldCustomer");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("VW_RPT_OldCustomer");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("VW_RPT_OldCustomer");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("VW_RPT_OldCustomer");
            }
        }
        
        public static VW_RPT_OldCustomerFactory Create()
        {
            return new VW_RPT_OldCustomerFactory();
        }
        
        protected virtual PageRequest CreateRequest(string idenDoc_Code, string identity_ID, string name_th, string sex, string authen_User, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, int? amount, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (!(String.IsNullOrEmpty(idenDoc_Code)))
            	filter.Add(("IdenDoc_Code:*" + idenDoc_Code));
            if (identity_ID != null)
            	filter.Add(("Identity_ID:=" + identity_ID));
            if (!(String.IsNullOrEmpty(name_th)))
            	filter.Add(("Name_th:*" + name_th));
            if (!(String.IsNullOrEmpty(sex)))
            	filter.Add(("Sex:*" + sex));
            if (!(String.IsNullOrEmpty(authen_User)))
            	filter.Add(("Authen_User:*" + authen_User));
            if (kioskOwner_ID.HasValue)
            	filter.Add(("KioskOwner_ID:=" + kioskOwner_ID.Value.ToString()));
            if (kioskOwner_Branch_ID.HasValue)
            	filter.Add(("KioskOwner_Branch_ID:=" + kioskOwner_Branch_ID.Value.ToString()));
            if (amount.HasValue)
            	filter.Add(("Amount:=" + amount.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<VSM.Data.Objects.VW_RPT_OldCustomer> Select(string idenDoc_Code, string identity_ID, string name_th, string sex, string authen_User, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, int? amount, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(idenDoc_Code, identity_ID, name_th, sex, authen_User, kioskOwner_ID, kioskOwner_Branch_ID, amount, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VW_RPT_OldCustomer", dataView, request);
            return page.ToList<VSM.Data.Objects.VW_RPT_OldCustomer>();
        }
        
        public List<VSM.Data.Objects.VW_RPT_OldCustomer> Select(VSM.Data.Objects.VW_RPT_OldCustomer qbe)
        {
            return Select(qbe.IdenDoc_Code, qbe.Identity_ID, qbe.Name_th, qbe.Sex, qbe.Authen_User, qbe.KioskOwner_ID, qbe.KioskOwner_Branch_ID, qbe.Amount);
        }
        
        public int SelectCount(string idenDoc_Code, string identity_ID, string name_th, string sex, string authen_User, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, int? amount, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(idenDoc_Code, identity_ID, name_th, sex, authen_User, kioskOwner_ID, kioskOwner_Branch_ID, amount, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VW_RPT_OldCustomer", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.VW_RPT_OldCustomer> Select(string idenDoc_Code, string identity_ID, string name_th, string sex, string authen_User, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, int? amount)
        {
            return Select(idenDoc_Code, identity_ID, name_th, sex, authen_User, kioskOwner_ID, kioskOwner_Branch_ID, amount, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.VW_RPT_OldCustomer SelectSingle(string identity_ID)
        {
            List<VSM.Data.Objects.VW_RPT_OldCustomer> list = Select(null, identity_ID, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.VW_RPT_OldCustomer> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("VW_RPT_OldCustomer", dataView, request);
            return page.ToList<VSM.Data.Objects.VW_RPT_OldCustomer>();
        }
        
        public List<VSM.Data.Objects.VW_RPT_OldCustomer> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.VW_RPT_OldCustomer> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.VW_RPT_OldCustomer SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.VW_RPT_OldCustomer> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.VW_RPT_OldCustomer theVW_RPT_OldCustomer, VSM.Data.Objects.VW_RPT_OldCustomer original_VW_RPT_OldCustomer)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IdenDoc_Code", original_VW_RPT_OldCustomer.IdenDoc_Code, theVW_RPT_OldCustomer.IdenDoc_Code, true));
            values.Add(new FieldValue("Identity_ID", original_VW_RPT_OldCustomer.Identity_ID, theVW_RPT_OldCustomer.Identity_ID, true));
            values.Add(new FieldValue("Name_th", original_VW_RPT_OldCustomer.Name_th, theVW_RPT_OldCustomer.Name_th, true));
            values.Add(new FieldValue("Sex", original_VW_RPT_OldCustomer.Sex, theVW_RPT_OldCustomer.Sex));
            values.Add(new FieldValue("Authen_User", original_VW_RPT_OldCustomer.Authen_User, theVW_RPT_OldCustomer.Authen_User));
            values.Add(new FieldValue("KioskOwner_ID", original_VW_RPT_OldCustomer.KioskOwner_ID, theVW_RPT_OldCustomer.KioskOwner_ID));
            values.Add(new FieldValue("KioskOwner_Branch_ID", original_VW_RPT_OldCustomer.KioskOwner_Branch_ID, theVW_RPT_OldCustomer.KioskOwner_Branch_ID));
            values.Add(new FieldValue("Amount", original_VW_RPT_OldCustomer.Amount, theVW_RPT_OldCustomer.Amount));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.VW_RPT_OldCustomer theVW_RPT_OldCustomer, VSM.Data.Objects.VW_RPT_OldCustomer original_VW_RPT_OldCustomer, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "VW_RPT_OldCustomer";
            args.View = dataView;
            args.Values = CreateFieldValues(theVW_RPT_OldCustomer, original_VW_RPT_OldCustomer);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("VW_RPT_OldCustomer", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theVW_RPT_OldCustomer);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.VW_RPT_OldCustomer theVW_RPT_OldCustomer, VSM.Data.Objects.VW_RPT_OldCustomer original_VW_RPT_OldCustomer)
        {
            return ExecuteAction(theVW_RPT_OldCustomer, original_VW_RPT_OldCustomer, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.VW_RPT_OldCustomer theVW_RPT_OldCustomer)
        {
            return Update(theVW_RPT_OldCustomer, SelectSingle(theVW_RPT_OldCustomer.Identity_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.VW_RPT_OldCustomer theVW_RPT_OldCustomer)
        {
            return ExecuteAction(theVW_RPT_OldCustomer, new VW_RPT_OldCustomer(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.VW_RPT_OldCustomer theVW_RPT_OldCustomer)
        {
            return ExecuteAction(theVW_RPT_OldCustomer, theVW_RPT_OldCustomer, "Select", "Delete", DeleteView);
        }
    }
}

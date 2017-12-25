using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Base_Customer_Authentication
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _customer_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _customer_IdenDoc_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _customer_Country_Country_Name_Locale;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _customer_GenBy_GenBy_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _customer_IdenDoc_IdenDoc_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _authen_User;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _authen_Password;
        
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
        
        public Base_Customer_Authentication()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? Customer_ID
        {
            get
            {
                return _customer_ID;
            }
            set
            {
                _customer_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Customer_IdenDoc_Code
        {
            get
            {
                return _customer_IdenDoc_Code;
            }
            set
            {
                _customer_IdenDoc_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Customer_Country_Country_Name_Locale
        {
            get
            {
                return _customer_Country_Country_Name_Locale;
            }
            set
            {
                _customer_Country_Country_Name_Locale = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Customer_GenBy_GenBy_Name
        {
            get
            {
                return _customer_GenBy_GenBy_Name;
            }
            set
            {
                _customer_GenBy_GenBy_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Customer_IdenDoc_IdenDoc_Name
        {
            get
            {
                return _customer_IdenDoc_IdenDoc_Name;
            }
            set
            {
                _customer_IdenDoc_IdenDoc_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
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
        public string Authen_Password
        {
            get
            {
                return _authen_Password;
            }
            set
            {
                _authen_Password = value;
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
        
        public static List<VSM.Data.Objects.Base_Customer_Authentication> Select(System.Guid? customer_ID, string customer_IdenDoc_Code, string customer_Country_Country_Name_Locale, string customer_GenBy_GenBy_Name, string customer_IdenDoc_IdenDoc_Name, string authen_User, string authen_Password, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new Base_Customer_AuthenticationFactory().Select(customer_ID, customer_IdenDoc_Code, customer_Country_Country_Name_Locale, customer_GenBy_GenBy_Name, customer_IdenDoc_IdenDoc_Name, authen_User, authen_Password, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.Base_Customer_Authentication> Select(VSM.Data.Objects.Base_Customer_Authentication qbe)
        {
            return new Base_Customer_AuthenticationFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.Base_Customer_Authentication> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new Base_Customer_AuthenticationFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.Base_Customer_Authentication> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new Base_Customer_AuthenticationFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.Base_Customer_Authentication> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new Base_Customer_AuthenticationFactory().Select(filter, sort, Base_Customer_AuthenticationFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.Base_Customer_Authentication> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new Base_Customer_AuthenticationFactory().Select(filter, sort, Base_Customer_AuthenticationFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.Base_Customer_Authentication> Select(string filter, BusinessObjectParameters parameters)
        {
            return new Base_Customer_AuthenticationFactory().Select(filter, null, Base_Customer_AuthenticationFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.Base_Customer_Authentication> Select(string filter, params FieldValue[] parameters)
        {
            return new Base_Customer_AuthenticationFactory().Select(filter, null, Base_Customer_AuthenticationFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.Base_Customer_Authentication SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new Base_Customer_AuthenticationFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.Base_Customer_Authentication SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new Base_Customer_AuthenticationFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.Base_Customer_Authentication SelectSingle(System.Guid? customer_ID, string authen_User)
        {
            return new Base_Customer_AuthenticationFactory().SelectSingle(customer_ID, authen_User);
        }
        
        public int Insert()
        {
            return new Base_Customer_AuthenticationFactory().Insert(this);
        }
        
        public int Update()
        {
            return new Base_Customer_AuthenticationFactory().Update(this);
        }
        
        public int Delete()
        {
            return new Base_Customer_AuthenticationFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Customer_ID: {0}; Authen_User: {1}", this.Customer_ID, this.Authen_User);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class Base_Customer_AuthenticationFactory
    {
        
        public Base_Customer_AuthenticationFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Base_Customer_Authentication");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Base_Customer_Authentication");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Base_Customer_Authentication");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Base_Customer_Authentication");
            }
        }
        
        public static Base_Customer_AuthenticationFactory Create()
        {
            return new Base_Customer_AuthenticationFactory();
        }
        
        protected virtual PageRequest CreateRequest(System.Guid? customer_ID, string customer_IdenDoc_Code, string customer_Country_Country_Name_Locale, string customer_GenBy_GenBy_Name, string customer_IdenDoc_IdenDoc_Name, string authen_User, string authen_Password, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (customer_ID.HasValue)
            	filter.Add(("Customer_ID:=" + customer_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(customer_IdenDoc_Code)))
            	filter.Add(("Customer_IdenDoc_Code:*" + customer_IdenDoc_Code));
            if (!(String.IsNullOrEmpty(customer_Country_Country_Name_Locale)))
            	filter.Add(("Customer_Country_Country_Name_Locale:*" + customer_Country_Country_Name_Locale));
            if (!(String.IsNullOrEmpty(customer_GenBy_GenBy_Name)))
            	filter.Add(("Customer_GenBy_GenBy_Name:*" + customer_GenBy_GenBy_Name));
            if (!(String.IsNullOrEmpty(customer_IdenDoc_IdenDoc_Name)))
            	filter.Add(("Customer_IdenDoc_IdenDoc_Name:*" + customer_IdenDoc_IdenDoc_Name));
            if (authen_User != null)
            	filter.Add(("Authen_User:=" + authen_User));
            if (!(String.IsNullOrEmpty(authen_Password)))
            	filter.Add(("Authen_Password:*" + authen_Password));
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
        public List<VSM.Data.Objects.Base_Customer_Authentication> Select(
                    System.Guid? customer_ID, 
                    string customer_IdenDoc_Code, 
                    string customer_Country_Country_Name_Locale, 
                    string customer_GenBy_GenBy_Name, 
                    string customer_IdenDoc_IdenDoc_Name, 
                    string authen_User, 
                    string authen_Password, 
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
            PageRequest request = CreateRequest(customer_ID, customer_IdenDoc_Code, customer_Country_Country_Name_Locale, customer_GenBy_GenBy_Name, customer_IdenDoc_IdenDoc_Name, authen_User, authen_Password, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Base_Customer_Authentication", dataView, request);
            return page.ToList<VSM.Data.Objects.Base_Customer_Authentication>();
        }
        
        public List<VSM.Data.Objects.Base_Customer_Authentication> Select(VSM.Data.Objects.Base_Customer_Authentication qbe)
        {
            return Select(qbe.Customer_ID, qbe.Customer_IdenDoc_Code, qbe.Customer_Country_Country_Name_Locale, qbe.Customer_GenBy_GenBy_Name, qbe.Customer_IdenDoc_IdenDoc_Name, qbe.Authen_User, qbe.Authen_Password, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? customer_ID, 
                    string customer_IdenDoc_Code, 
                    string customer_Country_Country_Name_Locale, 
                    string customer_GenBy_GenBy_Name, 
                    string customer_IdenDoc_IdenDoc_Name, 
                    string authen_User, 
                    string authen_Password, 
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
            PageRequest request = CreateRequest(customer_ID, customer_IdenDoc_Code, customer_Country_Country_Name_Locale, customer_GenBy_GenBy_Name, customer_IdenDoc_IdenDoc_Name, authen_User, authen_Password, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Base_Customer_Authentication", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.Base_Customer_Authentication> Select(System.Guid? customer_ID, string customer_IdenDoc_Code, string customer_Country_Country_Name_Locale, string customer_GenBy_GenBy_Name, string customer_IdenDoc_IdenDoc_Name, string authen_User, string authen_Password, bool? item_Flag, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(customer_ID, customer_IdenDoc_Code, customer_Country_Country_Name_Locale, customer_GenBy_GenBy_Name, customer_IdenDoc_IdenDoc_Name, authen_User, authen_Password, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.Base_Customer_Authentication SelectSingle(System.Guid? customer_ID, string authen_User)
        {
            List<VSM.Data.Objects.Base_Customer_Authentication> list = Select(customer_ID, null, null, null, null, authen_User, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.Base_Customer_Authentication> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Base_Customer_Authentication", dataView, request);
            return page.ToList<VSM.Data.Objects.Base_Customer_Authentication>();
        }
        
        public List<VSM.Data.Objects.Base_Customer_Authentication> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.Base_Customer_Authentication> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.Base_Customer_Authentication SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.Base_Customer_Authentication> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.Base_Customer_Authentication theBase_Customer_Authentication, VSM.Data.Objects.Base_Customer_Authentication original_Base_Customer_Authentication)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Customer_ID", original_Base_Customer_Authentication.Customer_ID, theBase_Customer_Authentication.Customer_ID));
            values.Add(new FieldValue("Customer_IdenDoc_Code", original_Base_Customer_Authentication.Customer_IdenDoc_Code, theBase_Customer_Authentication.Customer_IdenDoc_Code, true));
            values.Add(new FieldValue("Customer_Country_Country_Name_Locale", original_Base_Customer_Authentication.Customer_Country_Country_Name_Locale, theBase_Customer_Authentication.Customer_Country_Country_Name_Locale, true));
            values.Add(new FieldValue("Customer_GenBy_GenBy_Name", original_Base_Customer_Authentication.Customer_GenBy_GenBy_Name, theBase_Customer_Authentication.Customer_GenBy_GenBy_Name, true));
            values.Add(new FieldValue("Customer_IdenDoc_IdenDoc_Name", original_Base_Customer_Authentication.Customer_IdenDoc_IdenDoc_Name, theBase_Customer_Authentication.Customer_IdenDoc_IdenDoc_Name, true));
            values.Add(new FieldValue("Authen_User", original_Base_Customer_Authentication.Authen_User, theBase_Customer_Authentication.Authen_User));
            values.Add(new FieldValue("Authen_Password", original_Base_Customer_Authentication.Authen_Password, theBase_Customer_Authentication.Authen_Password));
            values.Add(new FieldValue("Item_Flag", original_Base_Customer_Authentication.Item_Flag, theBase_Customer_Authentication.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_Base_Customer_Authentication.CreatedBy, theBase_Customer_Authentication.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_Base_Customer_Authentication.CreatedOn, theBase_Customer_Authentication.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_Base_Customer_Authentication.ModifiedBy, theBase_Customer_Authentication.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_Base_Customer_Authentication.ModifiedOn, theBase_Customer_Authentication.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.Base_Customer_Authentication theBase_Customer_Authentication, VSM.Data.Objects.Base_Customer_Authentication original_Base_Customer_Authentication, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Base_Customer_Authentication";
            args.View = dataView;
            args.Values = CreateFieldValues(theBase_Customer_Authentication, original_Base_Customer_Authentication);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Base_Customer_Authentication", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theBase_Customer_Authentication);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.Base_Customer_Authentication theBase_Customer_Authentication, VSM.Data.Objects.Base_Customer_Authentication original_Base_Customer_Authentication)
        {
            return ExecuteAction(theBase_Customer_Authentication, original_Base_Customer_Authentication, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.Base_Customer_Authentication theBase_Customer_Authentication)
        {
            return Update(theBase_Customer_Authentication, SelectSingle(theBase_Customer_Authentication.Customer_ID, theBase_Customer_Authentication.Authen_User));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.Base_Customer_Authentication theBase_Customer_Authentication)
        {
            return ExecuteAction(theBase_Customer_Authentication, new Base_Customer_Authentication(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.Base_Customer_Authentication theBase_Customer_Authentication)
        {
            return ExecuteAction(theBase_Customer_Authentication, theBase_Customer_Authentication, "Select", "Delete", DeleteView);
        }
    }
}

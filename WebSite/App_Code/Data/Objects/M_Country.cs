using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_Country
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _country_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _country_Name_Locale;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _country_Name_En;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        public M_Country()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public string Country_Code
        {
            get
            {
                return _country_Code;
            }
            set
            {
                _country_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Country_Name_Locale
        {
            get
            {
                return _country_Name_Locale;
            }
            set
            {
                _country_Name_Locale = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Country_Name_En
        {
            get
            {
                return _country_Name_En;
            }
            set
            {
                _country_Name_En = value;
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
        
        public static List<VSM.Data.Objects.M_Country> Select(string country_Code, string country_Name_Locale, string country_Name_En, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_CountryFactory().Select(country_Code, country_Name_Locale, country_Name_En, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_Country> Select(VSM.Data.Objects.M_Country qbe)
        {
            return new M_CountryFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_Country> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_CountryFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Country> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_CountryFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Country> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_CountryFactory().Select(filter, sort, M_CountryFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Country> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_CountryFactory().Select(filter, sort, M_CountryFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Country> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_CountryFactory().Select(filter, null, M_CountryFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Country> Select(string filter, params FieldValue[] parameters)
        {
            return new M_CountryFactory().Select(filter, null, M_CountryFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Country SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_CountryFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_Country SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_CountryFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Country SelectSingle(string country_Code)
        {
            return new M_CountryFactory().SelectSingle(country_Code);
        }
        
        public int Insert()
        {
            return new M_CountryFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_CountryFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_CountryFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Country_Code: {0}", this.Country_Code);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_CountryFactory
    {
        
        public M_CountryFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_Country");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_Country");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_Country");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_Country");
            }
        }
        
        public static M_CountryFactory Create()
        {
            return new M_CountryFactory();
        }
        
        protected virtual PageRequest CreateRequest(string country_Code, string country_Name_Locale, string country_Name_En, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (country_Code != null)
            	filter.Add(("Country_Code:=" + country_Code));
            if (!(String.IsNullOrEmpty(country_Name_Locale)))
            	filter.Add(("Country_Name_Locale:*" + country_Name_Locale));
            if (!(String.IsNullOrEmpty(country_Name_En)))
            	filter.Add(("Country_Name_En:*" + country_Name_En));
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
        public List<VSM.Data.Objects.M_Country> Select(string country_Code, string country_Name_Locale, string country_Name_En, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(country_Code, country_Name_Locale, country_Name_En, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Country", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Country>();
        }
        
        public List<VSM.Data.Objects.M_Country> Select(VSM.Data.Objects.M_Country qbe)
        {
            return Select(qbe.Country_Code, qbe.Country_Name_Locale, qbe.Country_Name_En, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(string country_Code, string country_Name_Locale, string country_Name_En, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(country_Code, country_Name_Locale, country_Name_En, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Country", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_Country> Select(string country_Code, string country_Name_Locale, string country_Name_En, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(country_Code, country_Name_Locale, country_Name_En, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_Country SelectSingle(string country_Code)
        {
            List<VSM.Data.Objects.M_Country> list = Select(country_Code, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_Country> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_Country", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Country>();
        }
        
        public List<VSM.Data.Objects.M_Country> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_Country> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_Country SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_Country> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_Country theM_Country, VSM.Data.Objects.M_Country original_M_Country)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Country_Code", original_M_Country.Country_Code, theM_Country.Country_Code));
            values.Add(new FieldValue("Country_Name_Locale", original_M_Country.Country_Name_Locale, theM_Country.Country_Name_Locale));
            values.Add(new FieldValue("Country_Name_En", original_M_Country.Country_Name_En, theM_Country.Country_Name_En));
            values.Add(new FieldValue("CreatedBy", original_M_Country.CreatedBy, theM_Country.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_Country.CreatedOn, theM_Country.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_Country.ModifiedBy, theM_Country.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_Country.ModifiedOn, theM_Country.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_Country theM_Country, VSM.Data.Objects.M_Country original_M_Country, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_Country";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_Country, original_M_Country);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_Country", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_Country);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_Country theM_Country, VSM.Data.Objects.M_Country original_M_Country)
        {
            return ExecuteAction(theM_Country, original_M_Country, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_Country theM_Country)
        {
            return Update(theM_Country, SelectSingle(theM_Country.Country_Code));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_Country theM_Country)
        {
            return ExecuteAction(theM_Country, new M_Country(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_Country theM_Country)
        {
            return ExecuteAction(theM_Country, theM_Country, "Select", "Delete", DeleteView);
        }
    }
}

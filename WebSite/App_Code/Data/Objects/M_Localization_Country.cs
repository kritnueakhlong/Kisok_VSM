using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_Localization_Country
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locale_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locale_Locale_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _country_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _country_Country_Name_Locale;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        public M_Localization_Country()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public string Locale_Code
        {
            get
            {
                return _locale_Code;
            }
            set
            {
                _locale_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Locale_Locale_Name
        {
            get
            {
                return _locale_Locale_Name;
            }
            set
            {
                _locale_Locale_Name = value;
            }
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
        public string Country_Country_Name_Locale
        {
            get
            {
                return _country_Country_Name_Locale;
            }
            set
            {
                _country_Country_Name_Locale = value;
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
        
        public static List<VSM.Data.Objects.M_Localization_Country> Select(string locale_Code, string locale_Locale_Name, string country_Code, string country_Country_Name_Locale, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return new M_Localization_CountryFactory().Select(locale_Code, locale_Locale_Name, country_Code, country_Country_Name_Locale, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_Localization_Country> Select(VSM.Data.Objects.M_Localization_Country qbe)
        {
            return new M_Localization_CountryFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_Localization_Country> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_Localization_CountryFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Localization_Country> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_Localization_CountryFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Localization_Country> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_Localization_CountryFactory().Select(filter, sort, M_Localization_CountryFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Localization_Country> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_Localization_CountryFactory().Select(filter, sort, M_Localization_CountryFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_Localization_Country> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_Localization_CountryFactory().Select(filter, null, M_Localization_CountryFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_Localization_Country> Select(string filter, params FieldValue[] parameters)
        {
            return new M_Localization_CountryFactory().Select(filter, null, M_Localization_CountryFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Localization_Country SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_Localization_CountryFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_Localization_Country SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_Localization_CountryFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_Localization_Country SelectSingle(string locale_Code, string country_Code)
        {
            return new M_Localization_CountryFactory().SelectSingle(locale_Code, country_Code);
        }
        
        public int Insert()
        {
            return new M_Localization_CountryFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_Localization_CountryFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_Localization_CountryFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Locale_Code: {0}; Country_Code: {1}", this.Locale_Code, this.Country_Code);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_Localization_CountryFactory
    {
        
        public M_Localization_CountryFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_Localization_Country");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_Localization_Country");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_Localization_Country");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_Localization_Country");
            }
        }
        
        public static M_Localization_CountryFactory Create()
        {
            return new M_Localization_CountryFactory();
        }
        
        protected virtual PageRequest CreateRequest(string locale_Code, string locale_Locale_Name, string country_Code, string country_Country_Name_Locale, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (locale_Code != null)
            	filter.Add(("Locale_Code:=" + locale_Code));
            if (!(String.IsNullOrEmpty(locale_Locale_Name)))
            	filter.Add(("Locale_Locale_Name:*" + locale_Locale_Name));
            if (country_Code != null)
            	filter.Add(("Country_Code:=" + country_Code));
            if (!(String.IsNullOrEmpty(country_Country_Name_Locale)))
            	filter.Add(("Country_Country_Name_Locale:*" + country_Country_Name_Locale));
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
        public List<VSM.Data.Objects.M_Localization_Country> Select(string locale_Code, string locale_Locale_Name, string country_Code, string country_Country_Name_Locale, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(locale_Code, locale_Locale_Name, country_Code, country_Country_Name_Locale, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Localization_Country", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Localization_Country>();
        }
        
        public List<VSM.Data.Objects.M_Localization_Country> Select(VSM.Data.Objects.M_Localization_Country qbe)
        {
            return Select(qbe.Locale_Code, qbe.Locale_Locale_Name, qbe.Country_Code, qbe.Country_Country_Name_Locale, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(string locale_Code, string locale_Locale_Name, string country_Code, string country_Country_Name_Locale, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(locale_Code, locale_Locale_Name, country_Code, country_Country_Name_Locale, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_Localization_Country", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_Localization_Country> Select(string locale_Code, string locale_Locale_Name, string country_Code, string country_Country_Name_Locale, string createdBy, DateTime? createdOn, string modifiedBy, DateTime? modifiedOn)
        {
            return Select(locale_Code, locale_Locale_Name, country_Code, country_Country_Name_Locale, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_Localization_Country SelectSingle(string locale_Code, string country_Code)
        {
            List<VSM.Data.Objects.M_Localization_Country> list = Select(locale_Code, null, country_Code, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_Localization_Country> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_Localization_Country", dataView, request);
            return page.ToList<VSM.Data.Objects.M_Localization_Country>();
        }
        
        public List<VSM.Data.Objects.M_Localization_Country> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_Localization_Country> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_Localization_Country SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_Localization_Country> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_Localization_Country theM_Localization_Country, VSM.Data.Objects.M_Localization_Country original_M_Localization_Country)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Locale_Code", original_M_Localization_Country.Locale_Code, theM_Localization_Country.Locale_Code));
            values.Add(new FieldValue("Locale_Locale_Name", original_M_Localization_Country.Locale_Locale_Name, theM_Localization_Country.Locale_Locale_Name, true));
            values.Add(new FieldValue("Country_Code", original_M_Localization_Country.Country_Code, theM_Localization_Country.Country_Code));
            values.Add(new FieldValue("Country_Country_Name_Locale", original_M_Localization_Country.Country_Country_Name_Locale, theM_Localization_Country.Country_Country_Name_Locale, true));
            values.Add(new FieldValue("CreatedBy", original_M_Localization_Country.CreatedBy, theM_Localization_Country.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_Localization_Country.CreatedOn, theM_Localization_Country.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_Localization_Country.ModifiedBy, theM_Localization_Country.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_Localization_Country.ModifiedOn, theM_Localization_Country.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_Localization_Country theM_Localization_Country, VSM.Data.Objects.M_Localization_Country original_M_Localization_Country, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_Localization_Country";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_Localization_Country, original_M_Localization_Country);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_Localization_Country", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_Localization_Country);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_Localization_Country theM_Localization_Country, VSM.Data.Objects.M_Localization_Country original_M_Localization_Country)
        {
            return ExecuteAction(theM_Localization_Country, original_M_Localization_Country, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_Localization_Country theM_Localization_Country)
        {
            return Update(theM_Localization_Country, SelectSingle(theM_Localization_Country.Locale_Code, theM_Localization_Country.Country_Code));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_Localization_Country theM_Localization_Country)
        {
            return ExecuteAction(theM_Localization_Country, new M_Localization_Country(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_Localization_Country theM_Localization_Country)
        {
            return ExecuteAction(theM_Localization_Country, theM_Localization_Country, "Select", "Delete", DeleteView);
        }
    }
}

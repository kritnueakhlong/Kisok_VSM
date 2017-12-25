using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Base_Customer
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _customer_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _idenDoc_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _idenDoc_IdenDoc_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _identity_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tName_Locale;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fName_Locale;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lName_Locale;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mName_Locale;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tName_EN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fName_EN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lName_EN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mName_EN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _birthDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _idenIssuedDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _idenExpireDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addr_Home;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addr_Moo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addr_Trok;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addr_SubDistrict;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addr_District;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addr_Province;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sex;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nationality;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _country_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _country_Country_Name_Locale;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _email;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _phone_No;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _genBy_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _genBy_GenBy_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _refer_ID;
        
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
        
        public Base_Customer()
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IdenDoc_IdenDoc_Name
        {
            get
            {
                return _idenDoc_IdenDoc_Name;
            }
            set
            {
                _idenDoc_IdenDoc_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        public string tName_Locale
        {
            get
            {
                return _tName_Locale;
            }
            set
            {
                _tName_Locale = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string fName_Locale
        {
            get
            {
                return _fName_Locale;
            }
            set
            {
                _fName_Locale = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string lName_Locale
        {
            get
            {
                return _lName_Locale;
            }
            set
            {
                _lName_Locale = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string mName_Locale
        {
            get
            {
                return _mName_Locale;
            }
            set
            {
                _mName_Locale = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string tName_EN
        {
            get
            {
                return _tName_EN;
            }
            set
            {
                _tName_EN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string fName_EN
        {
            get
            {
                return _fName_EN;
            }
            set
            {
                _fName_EN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string lName_EN
        {
            get
            {
                return _lName_EN;
            }
            set
            {
                _lName_EN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string mName_EN
        {
            get
            {
                return _mName_EN;
            }
            set
            {
                _mName_EN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? IdenIssuedDate
        {
            get
            {
                return _idenIssuedDate;
            }
            set
            {
                _idenIssuedDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? IdenExpireDate
        {
            get
            {
                return _idenExpireDate;
            }
            set
            {
                _idenExpireDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Addr_Home
        {
            get
            {
                return _addr_Home;
            }
            set
            {
                _addr_Home = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Addr_Moo
        {
            get
            {
                return _addr_Moo;
            }
            set
            {
                _addr_Moo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Addr_Trok
        {
            get
            {
                return _addr_Trok;
            }
            set
            {
                _addr_Trok = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Addr_SubDistrict
        {
            get
            {
                return _addr_SubDistrict;
            }
            set
            {
                _addr_SubDistrict = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Addr_District
        {
            get
            {
                return _addr_District;
            }
            set
            {
                _addr_District = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Addr_Province
        {
            get
            {
                return _addr_Province;
            }
            set
            {
                _addr_Province = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
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
        public string Nationality
        {
            get
            {
                return _nationality;
            }
            set
            {
                _nationality = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Phone_No
        {
            get
            {
                return _phone_No;
            }
            set
            {
                _phone_No = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string GenBy_Code
        {
            get
            {
                return _genBy_Code;
            }
            set
            {
                _genBy_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string GenBy_GenBy_Name
        {
            get
            {
                return _genBy_GenBy_Name;
            }
            set
            {
                _genBy_GenBy_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public System.Guid? Refer_ID
        {
            get
            {
                return _refer_ID;
            }
            set
            {
                _refer_ID = value;
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
        
        public static List<VSM.Data.Objects.Base_Customer> Select(
                    System.Guid? customer_ID, 
                    string idenDoc_Code, 
                    string idenDoc_IdenDoc_Name, 
                    string identity_ID, 
                    string tName_Locale, 
                    string fName_Locale, 
                    string lName_Locale, 
                    string mName_Locale, 
                    string tName_EN, 
                    string fName_EN, 
                    string lName_EN, 
                    string mName_EN, 
                    int? birthDate, 
                    int? idenIssuedDate, 
                    int? idenExpireDate, 
                    string addr_Home, 
                    string addr_Moo, 
                    string addr_Trok, 
                    string addr_SubDistrict, 
                    string addr_District, 
                    string addr_Province, 
                    string address, 
                    string sex, 
                    string nationality, 
                    string country_Code, 
                    string country_Country_Name_Locale, 
                    string email, 
                    string phone_No, 
                    string genBy_Code, 
                    string genBy_GenBy_Name, 
                    System.Guid? refer_ID, 
                    bool? item_Flag, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn)
        {
            return new Base_CustomerFactory().Select(customer_ID, idenDoc_Code, idenDoc_IdenDoc_Name, identity_ID, tName_Locale, fName_Locale, lName_Locale, mName_Locale, tName_EN, fName_EN, lName_EN, mName_EN, birthDate, idenIssuedDate, idenExpireDate, addr_Home, addr_Moo, addr_Trok, addr_SubDistrict, addr_District, addr_Province, address, sex, nationality, country_Code, country_Country_Name_Locale, email, phone_No, genBy_Code, genBy_GenBy_Name, refer_ID, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.Base_Customer> Select(VSM.Data.Objects.Base_Customer qbe)
        {
            return new Base_CustomerFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.Base_Customer> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new Base_CustomerFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.Base_Customer> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new Base_CustomerFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.Base_Customer> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new Base_CustomerFactory().Select(filter, sort, Base_CustomerFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.Base_Customer> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new Base_CustomerFactory().Select(filter, sort, Base_CustomerFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.Base_Customer> Select(string filter, BusinessObjectParameters parameters)
        {
            return new Base_CustomerFactory().Select(filter, null, Base_CustomerFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.Base_Customer> Select(string filter, params FieldValue[] parameters)
        {
            return new Base_CustomerFactory().Select(filter, null, Base_CustomerFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.Base_Customer SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new Base_CustomerFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.Base_Customer SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new Base_CustomerFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.Base_Customer SelectSingle(System.Guid? customer_ID)
        {
            return new Base_CustomerFactory().SelectSingle(customer_ID);
        }
        
        public int Insert()
        {
            return new Base_CustomerFactory().Insert(this);
        }
        
        public int Update()
        {
            return new Base_CustomerFactory().Update(this);
        }
        
        public int Delete()
        {
            return new Base_CustomerFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Customer_ID: {0}", this.Customer_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class Base_CustomerFactory
    {
        
        public Base_CustomerFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Base_Customer");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Base_Customer");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Base_Customer");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Base_Customer");
            }
        }
        
        public static Base_CustomerFactory Create()
        {
            return new Base_CustomerFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    System.Guid? customer_ID, 
                    string idenDoc_Code, 
                    string idenDoc_IdenDoc_Name, 
                    string identity_ID, 
                    string tName_Locale, 
                    string fName_Locale, 
                    string lName_Locale, 
                    string mName_Locale, 
                    string tName_EN, 
                    string fName_EN, 
                    string lName_EN, 
                    string mName_EN, 
                    int? birthDate, 
                    int? idenIssuedDate, 
                    int? idenExpireDate, 
                    string addr_Home, 
                    string addr_Moo, 
                    string addr_Trok, 
                    string addr_SubDistrict, 
                    string addr_District, 
                    string addr_Province, 
                    string address, 
                    string sex, 
                    string nationality, 
                    string country_Code, 
                    string country_Country_Name_Locale, 
                    string email, 
                    string phone_No, 
                    string genBy_Code, 
                    string genBy_GenBy_Name, 
                    System.Guid? refer_ID, 
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
            if (customer_ID.HasValue)
            	filter.Add(("Customer_ID:=" + customer_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(idenDoc_Code)))
            	filter.Add(("IdenDoc_Code:*" + idenDoc_Code));
            if (!(String.IsNullOrEmpty(idenDoc_IdenDoc_Name)))
            	filter.Add(("IdenDoc_IdenDoc_Name:*" + idenDoc_IdenDoc_Name));
            if (!(String.IsNullOrEmpty(identity_ID)))
            	filter.Add(("Identity_ID:*" + identity_ID));
            if (!(String.IsNullOrEmpty(tName_Locale)))
            	filter.Add(("tName_Locale:*" + tName_Locale));
            if (!(String.IsNullOrEmpty(fName_Locale)))
            	filter.Add(("fName_Locale:*" + fName_Locale));
            if (!(String.IsNullOrEmpty(lName_Locale)))
            	filter.Add(("lName_Locale:*" + lName_Locale));
            if (!(String.IsNullOrEmpty(mName_Locale)))
            	filter.Add(("mName_Locale:*" + mName_Locale));
            if (!(String.IsNullOrEmpty(tName_EN)))
            	filter.Add(("tName_EN:*" + tName_EN));
            if (!(String.IsNullOrEmpty(fName_EN)))
            	filter.Add(("fName_EN:*" + fName_EN));
            if (!(String.IsNullOrEmpty(lName_EN)))
            	filter.Add(("lName_EN:*" + lName_EN));
            if (!(String.IsNullOrEmpty(mName_EN)))
            	filter.Add(("mName_EN:*" + mName_EN));
            if (birthDate.HasValue)
            	filter.Add(("BirthDate:=" + birthDate.Value.ToString()));
            if (idenIssuedDate.HasValue)
            	filter.Add(("IdenIssuedDate:=" + idenIssuedDate.Value.ToString()));
            if (idenExpireDate.HasValue)
            	filter.Add(("IdenExpireDate:=" + idenExpireDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(addr_Home)))
            	filter.Add(("Addr_Home:*" + addr_Home));
            if (!(String.IsNullOrEmpty(addr_Moo)))
            	filter.Add(("Addr_Moo:*" + addr_Moo));
            if (!(String.IsNullOrEmpty(addr_Trok)))
            	filter.Add(("Addr_Trok:*" + addr_Trok));
            if (!(String.IsNullOrEmpty(addr_SubDistrict)))
            	filter.Add(("Addr_SubDistrict:*" + addr_SubDistrict));
            if (!(String.IsNullOrEmpty(addr_District)))
            	filter.Add(("Addr_District:*" + addr_District));
            if (!(String.IsNullOrEmpty(addr_Province)))
            	filter.Add(("Addr_Province:*" + addr_Province));
            if (!(String.IsNullOrEmpty(address)))
            	filter.Add(("Address:*" + address));
            if (!(String.IsNullOrEmpty(sex)))
            	filter.Add(("Sex:*" + sex));
            if (!(String.IsNullOrEmpty(nationality)))
            	filter.Add(("Nationality:*" + nationality));
            if (!(String.IsNullOrEmpty(country_Code)))
            	filter.Add(("Country_Code:*" + country_Code));
            if (!(String.IsNullOrEmpty(country_Country_Name_Locale)))
            	filter.Add(("Country_Country_Name_Locale:*" + country_Country_Name_Locale));
            if (!(String.IsNullOrEmpty(email)))
            	filter.Add(("Email:*" + email));
            if (!(String.IsNullOrEmpty(phone_No)))
            	filter.Add(("Phone_No:*" + phone_No));
            if (!(String.IsNullOrEmpty(genBy_Code)))
            	filter.Add(("GenBy_Code:*" + genBy_Code));
            if (!(String.IsNullOrEmpty(genBy_GenBy_Name)))
            	filter.Add(("GenBy_GenBy_Name:*" + genBy_GenBy_Name));
            if (refer_ID.HasValue)
            	filter.Add(("Refer_ID:=" + refer_ID.Value.ToString()));
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
        public List<VSM.Data.Objects.Base_Customer> Select(
                    System.Guid? customer_ID, 
                    string idenDoc_Code, 
                    string idenDoc_IdenDoc_Name, 
                    string identity_ID, 
                    string tName_Locale, 
                    string fName_Locale, 
                    string lName_Locale, 
                    string mName_Locale, 
                    string tName_EN, 
                    string fName_EN, 
                    string lName_EN, 
                    string mName_EN, 
                    int? birthDate, 
                    int? idenIssuedDate, 
                    int? idenExpireDate, 
                    string addr_Home, 
                    string addr_Moo, 
                    string addr_Trok, 
                    string addr_SubDistrict, 
                    string addr_District, 
                    string addr_Province, 
                    string address, 
                    string sex, 
                    string nationality, 
                    string country_Code, 
                    string country_Country_Name_Locale, 
                    string email, 
                    string phone_No, 
                    string genBy_Code, 
                    string genBy_GenBy_Name, 
                    System.Guid? refer_ID, 
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
            PageRequest request = CreateRequest(customer_ID, idenDoc_Code, idenDoc_IdenDoc_Name, identity_ID, tName_Locale, fName_Locale, lName_Locale, mName_Locale, tName_EN, fName_EN, lName_EN, mName_EN, birthDate, idenIssuedDate, idenExpireDate, addr_Home, addr_Moo, addr_Trok, addr_SubDistrict, addr_District, addr_Province, address, sex, nationality, country_Code, country_Country_Name_Locale, email, phone_No, genBy_Code, genBy_GenBy_Name, refer_ID, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Base_Customer", dataView, request);
            return page.ToList<VSM.Data.Objects.Base_Customer>();
        }
        
        public List<VSM.Data.Objects.Base_Customer> Select(VSM.Data.Objects.Base_Customer qbe)
        {
            return Select(qbe.Customer_ID, qbe.IdenDoc_Code, qbe.IdenDoc_IdenDoc_Name, qbe.Identity_ID, qbe.tName_Locale, qbe.fName_Locale, qbe.lName_Locale, qbe.mName_Locale, qbe.tName_EN, qbe.fName_EN, qbe.lName_EN, qbe.mName_EN, qbe.BirthDate, qbe.IdenIssuedDate, qbe.IdenExpireDate, qbe.Addr_Home, qbe.Addr_Moo, qbe.Addr_Trok, qbe.Addr_SubDistrict, qbe.Addr_District, qbe.Addr_Province, qbe.Address, qbe.Sex, qbe.Nationality, qbe.Country_Code, qbe.Country_Country_Name_Locale, qbe.Email, qbe.Phone_No, qbe.GenBy_Code, qbe.GenBy_GenBy_Name, qbe.Refer_ID, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? customer_ID, 
                    string idenDoc_Code, 
                    string idenDoc_IdenDoc_Name, 
                    string identity_ID, 
                    string tName_Locale, 
                    string fName_Locale, 
                    string lName_Locale, 
                    string mName_Locale, 
                    string tName_EN, 
                    string fName_EN, 
                    string lName_EN, 
                    string mName_EN, 
                    int? birthDate, 
                    int? idenIssuedDate, 
                    int? idenExpireDate, 
                    string addr_Home, 
                    string addr_Moo, 
                    string addr_Trok, 
                    string addr_SubDistrict, 
                    string addr_District, 
                    string addr_Province, 
                    string address, 
                    string sex, 
                    string nationality, 
                    string country_Code, 
                    string country_Country_Name_Locale, 
                    string email, 
                    string phone_No, 
                    string genBy_Code, 
                    string genBy_GenBy_Name, 
                    System.Guid? refer_ID, 
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
            PageRequest request = CreateRequest(customer_ID, idenDoc_Code, idenDoc_IdenDoc_Name, identity_ID, tName_Locale, fName_Locale, lName_Locale, mName_Locale, tName_EN, fName_EN, lName_EN, mName_EN, birthDate, idenIssuedDate, idenExpireDate, addr_Home, addr_Moo, addr_Trok, addr_SubDistrict, addr_District, addr_Province, address, sex, nationality, country_Code, country_Country_Name_Locale, email, phone_No, genBy_Code, genBy_GenBy_Name, refer_ID, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Base_Customer", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.Base_Customer> Select(
                    System.Guid? customer_ID, 
                    string idenDoc_Code, 
                    string idenDoc_IdenDoc_Name, 
                    string identity_ID, 
                    string tName_Locale, 
                    string fName_Locale, 
                    string lName_Locale, 
                    string mName_Locale, 
                    string tName_EN, 
                    string fName_EN, 
                    string lName_EN, 
                    string mName_EN, 
                    int? birthDate, 
                    int? idenIssuedDate, 
                    int? idenExpireDate, 
                    string addr_Home, 
                    string addr_Moo, 
                    string addr_Trok, 
                    string addr_SubDistrict, 
                    string addr_District, 
                    string addr_Province, 
                    string address, 
                    string sex, 
                    string nationality, 
                    string country_Code, 
                    string country_Country_Name_Locale, 
                    string email, 
                    string phone_No, 
                    string genBy_Code, 
                    string genBy_GenBy_Name, 
                    System.Guid? refer_ID, 
                    bool? item_Flag, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn)
        {
            return Select(customer_ID, idenDoc_Code, idenDoc_IdenDoc_Name, identity_ID, tName_Locale, fName_Locale, lName_Locale, mName_Locale, tName_EN, fName_EN, lName_EN, mName_EN, birthDate, idenIssuedDate, idenExpireDate, addr_Home, addr_Moo, addr_Trok, addr_SubDistrict, addr_District, addr_Province, address, sex, nationality, country_Code, country_Country_Name_Locale, email, phone_No, genBy_Code, genBy_GenBy_Name, refer_ID, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.Base_Customer SelectSingle(System.Guid? customer_ID)
        {
            List<VSM.Data.Objects.Base_Customer> list = Select(customer_ID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.Base_Customer> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Base_Customer", dataView, request);
            return page.ToList<VSM.Data.Objects.Base_Customer>();
        }
        
        public List<VSM.Data.Objects.Base_Customer> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.Base_Customer> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.Base_Customer SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.Base_Customer> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.Base_Customer theBase_Customer, VSM.Data.Objects.Base_Customer original_Base_Customer)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Customer_ID", original_Base_Customer.Customer_ID, theBase_Customer.Customer_ID));
            values.Add(new FieldValue("IdenDoc_Code", original_Base_Customer.IdenDoc_Code, theBase_Customer.IdenDoc_Code));
            values.Add(new FieldValue("IdenDoc_IdenDoc_Name", original_Base_Customer.IdenDoc_IdenDoc_Name, theBase_Customer.IdenDoc_IdenDoc_Name, true));
            values.Add(new FieldValue("Identity_ID", original_Base_Customer.Identity_ID, theBase_Customer.Identity_ID));
            values.Add(new FieldValue("tName_Locale", original_Base_Customer.tName_Locale, theBase_Customer.tName_Locale));
            values.Add(new FieldValue("fName_Locale", original_Base_Customer.fName_Locale, theBase_Customer.fName_Locale));
            values.Add(new FieldValue("lName_Locale", original_Base_Customer.lName_Locale, theBase_Customer.lName_Locale));
            values.Add(new FieldValue("mName_Locale", original_Base_Customer.mName_Locale, theBase_Customer.mName_Locale));
            values.Add(new FieldValue("tName_EN", original_Base_Customer.tName_EN, theBase_Customer.tName_EN));
            values.Add(new FieldValue("fName_EN", original_Base_Customer.fName_EN, theBase_Customer.fName_EN));
            values.Add(new FieldValue("lName_EN", original_Base_Customer.lName_EN, theBase_Customer.lName_EN));
            values.Add(new FieldValue("mName_EN", original_Base_Customer.mName_EN, theBase_Customer.mName_EN));
            values.Add(new FieldValue("BirthDate", original_Base_Customer.BirthDate, theBase_Customer.BirthDate));
            values.Add(new FieldValue("IdenIssuedDate", original_Base_Customer.IdenIssuedDate, theBase_Customer.IdenIssuedDate));
            values.Add(new FieldValue("IdenExpireDate", original_Base_Customer.IdenExpireDate, theBase_Customer.IdenExpireDate));
            values.Add(new FieldValue("Addr_Home", original_Base_Customer.Addr_Home, theBase_Customer.Addr_Home));
            values.Add(new FieldValue("Addr_Moo", original_Base_Customer.Addr_Moo, theBase_Customer.Addr_Moo));
            values.Add(new FieldValue("Addr_Trok", original_Base_Customer.Addr_Trok, theBase_Customer.Addr_Trok));
            values.Add(new FieldValue("Addr_SubDistrict", original_Base_Customer.Addr_SubDistrict, theBase_Customer.Addr_SubDistrict));
            values.Add(new FieldValue("Addr_District", original_Base_Customer.Addr_District, theBase_Customer.Addr_District));
            values.Add(new FieldValue("Addr_Province", original_Base_Customer.Addr_Province, theBase_Customer.Addr_Province));
            values.Add(new FieldValue("Address", original_Base_Customer.Address, theBase_Customer.Address));
            values.Add(new FieldValue("Sex", original_Base_Customer.Sex, theBase_Customer.Sex));
            values.Add(new FieldValue("Nationality", original_Base_Customer.Nationality, theBase_Customer.Nationality));
            values.Add(new FieldValue("Country_Code", original_Base_Customer.Country_Code, theBase_Customer.Country_Code));
            values.Add(new FieldValue("Country_Country_Name_Locale", original_Base_Customer.Country_Country_Name_Locale, theBase_Customer.Country_Country_Name_Locale, true));
            values.Add(new FieldValue("Email", original_Base_Customer.Email, theBase_Customer.Email));
            values.Add(new FieldValue("Phone_No", original_Base_Customer.Phone_No, theBase_Customer.Phone_No));
            values.Add(new FieldValue("GenBy_Code", original_Base_Customer.GenBy_Code, theBase_Customer.GenBy_Code));
            values.Add(new FieldValue("GenBy_GenBy_Name", original_Base_Customer.GenBy_GenBy_Name, theBase_Customer.GenBy_GenBy_Name, true));
            values.Add(new FieldValue("Refer_ID", original_Base_Customer.Refer_ID, theBase_Customer.Refer_ID));
            values.Add(new FieldValue("Item_Flag", original_Base_Customer.Item_Flag, theBase_Customer.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_Base_Customer.CreatedBy, theBase_Customer.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_Base_Customer.CreatedOn, theBase_Customer.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_Base_Customer.ModifiedBy, theBase_Customer.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_Base_Customer.ModifiedOn, theBase_Customer.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.Base_Customer theBase_Customer, VSM.Data.Objects.Base_Customer original_Base_Customer, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Base_Customer";
            args.View = dataView;
            args.Values = CreateFieldValues(theBase_Customer, original_Base_Customer);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Base_Customer", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theBase_Customer);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.Base_Customer theBase_Customer, VSM.Data.Objects.Base_Customer original_Base_Customer)
        {
            return ExecuteAction(theBase_Customer, original_Base_Customer, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.Base_Customer theBase_Customer)
        {
            return Update(theBase_Customer, SelectSingle(theBase_Customer.Customer_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.Base_Customer theBase_Customer)
        {
            return ExecuteAction(theBase_Customer, new Base_Customer(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.Base_Customer theBase_Customer)
        {
            return ExecuteAction(theBase_Customer, theBase_Customer, "Select", "Delete", DeleteView);
        }
    }
}

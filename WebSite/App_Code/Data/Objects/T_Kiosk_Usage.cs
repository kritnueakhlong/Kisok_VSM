using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class T_Kiosk_Usage
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskUsage_ID;
        
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
        private string _usageStatus_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _authen_User;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _authen_Password;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedOn;
        
        public T_Kiosk_Usage()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? KioskUsage_ID
        {
            get
            {
                return _kioskUsage_ID;
            }
            set
            {
                _kioskUsage_ID = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string UsageStatus_Code
        {
            get
            {
                return _usageStatus_Code;
            }
            set
            {
                _usageStatus_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        public static List<VSM.Data.Objects.T_Kiosk_Usage> Select(
                    System.Guid? kioskUsage_ID, 
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
                    System.Guid? kiosk_ID, 
                    string kiosk_Kiosk_Code, 
                    string kiosk_KioskType_KioskType_Name, 
                    string kiosk_Location_Location_Address, 
                    string kiosk_Location_KioskOwner_KioskOwner_Code, 
                    string usageStatus_Code, 
                    string authen_User, 
                    string authen_Password, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn)
        {
            return new T_Kiosk_UsageFactory().Select(kioskUsage_ID, idenDoc_Code, idenDoc_IdenDoc_Name, identity_ID, tName_Locale, fName_Locale, lName_Locale, mName_Locale, tName_EN, fName_EN, lName_EN, mName_EN, birthDate, idenIssuedDate, idenExpireDate, addr_Home, addr_Moo, addr_Trok, addr_SubDistrict, addr_District, addr_Province, address, sex, nationality, country_Code, country_Country_Name_Locale, email, phone_No, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, usageStatus_Code, authen_User, authen_Password, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.T_Kiosk_Usage> Select(VSM.Data.Objects.T_Kiosk_Usage qbe)
        {
            return new T_Kiosk_UsageFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.T_Kiosk_Usage> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new T_Kiosk_UsageFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Kiosk_Usage> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new T_Kiosk_UsageFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Kiosk_Usage> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new T_Kiosk_UsageFactory().Select(filter, sort, T_Kiosk_UsageFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Kiosk_Usage> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new T_Kiosk_UsageFactory().Select(filter, sort, T_Kiosk_UsageFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.T_Kiosk_Usage> Select(string filter, BusinessObjectParameters parameters)
        {
            return new T_Kiosk_UsageFactory().Select(filter, null, T_Kiosk_UsageFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.T_Kiosk_Usage> Select(string filter, params FieldValue[] parameters)
        {
            return new T_Kiosk_UsageFactory().Select(filter, null, T_Kiosk_UsageFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Kiosk_Usage SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new T_Kiosk_UsageFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.T_Kiosk_Usage SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new T_Kiosk_UsageFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.T_Kiosk_Usage SelectSingle(System.Guid? kioskUsage_ID)
        {
            return new T_Kiosk_UsageFactory().SelectSingle(kioskUsage_ID);
        }
        
        public int Insert()
        {
            return new T_Kiosk_UsageFactory().Insert(this);
        }
        
        public int Update()
        {
            return new T_Kiosk_UsageFactory().Update(this);
        }
        
        public int Delete()
        {
            return new T_Kiosk_UsageFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("KioskUsage_ID: {0}", this.KioskUsage_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class T_Kiosk_UsageFactory
    {
        
        public T_Kiosk_UsageFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("T_Kiosk_Usage");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("T_Kiosk_Usage");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("T_Kiosk_Usage");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("T_Kiosk_Usage");
            }
        }
        
        public static T_Kiosk_UsageFactory Create()
        {
            return new T_Kiosk_UsageFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    System.Guid? kioskUsage_ID, 
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
                    System.Guid? kiosk_ID, 
                    string kiosk_Kiosk_Code, 
                    string kiosk_KioskType_KioskType_Name, 
                    string kiosk_Location_Location_Address, 
                    string kiosk_Location_KioskOwner_KioskOwner_Code, 
                    string usageStatus_Code, 
                    string authen_User, 
                    string authen_Password, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (kioskUsage_ID.HasValue)
            	filter.Add(("KioskUsage_ID:=" + kioskUsage_ID.Value.ToString()));
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
            if (!(String.IsNullOrEmpty(usageStatus_Code)))
            	filter.Add(("UsageStatus_Code:*" + usageStatus_Code));
            if (!(String.IsNullOrEmpty(authen_User)))
            	filter.Add(("Authen_User:*" + authen_User));
            if (!(String.IsNullOrEmpty(authen_Password)))
            	filter.Add(("Authen_Password:*" + authen_Password));
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
        public List<VSM.Data.Objects.T_Kiosk_Usage> Select(
                    System.Guid? kioskUsage_ID, 
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
                    System.Guid? kiosk_ID, 
                    string kiosk_Kiosk_Code, 
                    string kiosk_KioskType_KioskType_Name, 
                    string kiosk_Location_Location_Address, 
                    string kiosk_Location_KioskOwner_KioskOwner_Code, 
                    string usageStatus_Code, 
                    string authen_User, 
                    string authen_Password, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(kioskUsage_ID, idenDoc_Code, idenDoc_IdenDoc_Name, identity_ID, tName_Locale, fName_Locale, lName_Locale, mName_Locale, tName_EN, fName_EN, lName_EN, mName_EN, birthDate, idenIssuedDate, idenExpireDate, addr_Home, addr_Moo, addr_Trok, addr_SubDistrict, addr_District, addr_Province, address, sex, nationality, country_Code, country_Country_Name_Locale, email, phone_No, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, usageStatus_Code, authen_User, authen_Password, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Kiosk_Usage", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Kiosk_Usage>();
        }
        
        public List<VSM.Data.Objects.T_Kiosk_Usage> Select(VSM.Data.Objects.T_Kiosk_Usage qbe)
        {
            return Select(qbe.KioskUsage_ID, qbe.IdenDoc_Code, qbe.IdenDoc_IdenDoc_Name, qbe.Identity_ID, qbe.tName_Locale, qbe.fName_Locale, qbe.lName_Locale, qbe.mName_Locale, qbe.tName_EN, qbe.fName_EN, qbe.lName_EN, qbe.mName_EN, qbe.BirthDate, qbe.IdenIssuedDate, qbe.IdenExpireDate, qbe.Addr_Home, qbe.Addr_Moo, qbe.Addr_Trok, qbe.Addr_SubDistrict, qbe.Addr_District, qbe.Addr_Province, qbe.Address, qbe.Sex, qbe.Nationality, qbe.Country_Code, qbe.Country_Country_Name_Locale, qbe.Email, qbe.Phone_No, qbe.Kiosk_ID, qbe.Kiosk_Kiosk_Code, qbe.Kiosk_KioskType_KioskType_Name, qbe.Kiosk_Location_Location_Address, qbe.Kiosk_Location_KioskOwner_KioskOwner_Code, qbe.UsageStatus_Code, qbe.Authen_User, qbe.Authen_Password, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? kioskUsage_ID, 
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
                    System.Guid? kiosk_ID, 
                    string kiosk_Kiosk_Code, 
                    string kiosk_KioskType_KioskType_Name, 
                    string kiosk_Location_Location_Address, 
                    string kiosk_Location_KioskOwner_KioskOwner_Code, 
                    string usageStatus_Code, 
                    string authen_User, 
                    string authen_Password, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(kioskUsage_ID, idenDoc_Code, idenDoc_IdenDoc_Name, identity_ID, tName_Locale, fName_Locale, lName_Locale, mName_Locale, tName_EN, fName_EN, lName_EN, mName_EN, birthDate, idenIssuedDate, idenExpireDate, addr_Home, addr_Moo, addr_Trok, addr_SubDistrict, addr_District, addr_Province, address, sex, nationality, country_Code, country_Country_Name_Locale, email, phone_No, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, usageStatus_Code, authen_User, authen_Password, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("T_Kiosk_Usage", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.T_Kiosk_Usage> Select(
                    System.Guid? kioskUsage_ID, 
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
                    System.Guid? kiosk_ID, 
                    string kiosk_Kiosk_Code, 
                    string kiosk_KioskType_KioskType_Name, 
                    string kiosk_Location_Location_Address, 
                    string kiosk_Location_KioskOwner_KioskOwner_Code, 
                    string usageStatus_Code, 
                    string authen_User, 
                    string authen_Password, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn)
        {
            return Select(kioskUsage_ID, idenDoc_Code, idenDoc_IdenDoc_Name, identity_ID, tName_Locale, fName_Locale, lName_Locale, mName_Locale, tName_EN, fName_EN, lName_EN, mName_EN, birthDate, idenIssuedDate, idenExpireDate, addr_Home, addr_Moo, addr_Trok, addr_SubDistrict, addr_District, addr_Province, address, sex, nationality, country_Code, country_Country_Name_Locale, email, phone_No, kiosk_ID, kiosk_Kiosk_Code, kiosk_KioskType_KioskType_Name, kiosk_Location_Location_Address, kiosk_Location_KioskOwner_KioskOwner_Code, usageStatus_Code, authen_User, authen_Password, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.T_Kiosk_Usage SelectSingle(System.Guid? kioskUsage_ID)
        {
            List<VSM.Data.Objects.T_Kiosk_Usage> list = Select(kioskUsage_ID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.T_Kiosk_Usage> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("T_Kiosk_Usage", dataView, request);
            return page.ToList<VSM.Data.Objects.T_Kiosk_Usage>();
        }
        
        public List<VSM.Data.Objects.T_Kiosk_Usage> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.T_Kiosk_Usage> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.T_Kiosk_Usage SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.T_Kiosk_Usage> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.T_Kiosk_Usage theT_Kiosk_Usage, VSM.Data.Objects.T_Kiosk_Usage original_T_Kiosk_Usage)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("KioskUsage_ID", original_T_Kiosk_Usage.KioskUsage_ID, theT_Kiosk_Usage.KioskUsage_ID));
            values.Add(new FieldValue("IdenDoc_Code", original_T_Kiosk_Usage.IdenDoc_Code, theT_Kiosk_Usage.IdenDoc_Code));
            values.Add(new FieldValue("IdenDoc_IdenDoc_Name", original_T_Kiosk_Usage.IdenDoc_IdenDoc_Name, theT_Kiosk_Usage.IdenDoc_IdenDoc_Name, true));
            values.Add(new FieldValue("Identity_ID", original_T_Kiosk_Usage.Identity_ID, theT_Kiosk_Usage.Identity_ID));
            values.Add(new FieldValue("tName_Locale", original_T_Kiosk_Usage.tName_Locale, theT_Kiosk_Usage.tName_Locale));
            values.Add(new FieldValue("fName_Locale", original_T_Kiosk_Usage.fName_Locale, theT_Kiosk_Usage.fName_Locale));
            values.Add(new FieldValue("lName_Locale", original_T_Kiosk_Usage.lName_Locale, theT_Kiosk_Usage.lName_Locale));
            values.Add(new FieldValue("mName_Locale", original_T_Kiosk_Usage.mName_Locale, theT_Kiosk_Usage.mName_Locale));
            values.Add(new FieldValue("tName_EN", original_T_Kiosk_Usage.tName_EN, theT_Kiosk_Usage.tName_EN));
            values.Add(new FieldValue("fName_EN", original_T_Kiosk_Usage.fName_EN, theT_Kiosk_Usage.fName_EN));
            values.Add(new FieldValue("lName_EN", original_T_Kiosk_Usage.lName_EN, theT_Kiosk_Usage.lName_EN));
            values.Add(new FieldValue("mName_EN", original_T_Kiosk_Usage.mName_EN, theT_Kiosk_Usage.mName_EN));
            values.Add(new FieldValue("BirthDate", original_T_Kiosk_Usage.BirthDate, theT_Kiosk_Usage.BirthDate));
            values.Add(new FieldValue("IdenIssuedDate", original_T_Kiosk_Usage.IdenIssuedDate, theT_Kiosk_Usage.IdenIssuedDate));
            values.Add(new FieldValue("IdenExpireDate", original_T_Kiosk_Usage.IdenExpireDate, theT_Kiosk_Usage.IdenExpireDate));
            values.Add(new FieldValue("Addr_Home", original_T_Kiosk_Usage.Addr_Home, theT_Kiosk_Usage.Addr_Home));
            values.Add(new FieldValue("Addr_Moo", original_T_Kiosk_Usage.Addr_Moo, theT_Kiosk_Usage.Addr_Moo));
            values.Add(new FieldValue("Addr_Trok", original_T_Kiosk_Usage.Addr_Trok, theT_Kiosk_Usage.Addr_Trok));
            values.Add(new FieldValue("Addr_SubDistrict", original_T_Kiosk_Usage.Addr_SubDistrict, theT_Kiosk_Usage.Addr_SubDistrict));
            values.Add(new FieldValue("Addr_District", original_T_Kiosk_Usage.Addr_District, theT_Kiosk_Usage.Addr_District));
            values.Add(new FieldValue("Addr_Province", original_T_Kiosk_Usage.Addr_Province, theT_Kiosk_Usage.Addr_Province));
            values.Add(new FieldValue("Address", original_T_Kiosk_Usage.Address, theT_Kiosk_Usage.Address));
            values.Add(new FieldValue("Sex", original_T_Kiosk_Usage.Sex, theT_Kiosk_Usage.Sex));
            values.Add(new FieldValue("Nationality", original_T_Kiosk_Usage.Nationality, theT_Kiosk_Usage.Nationality));
            values.Add(new FieldValue("Country_Code", original_T_Kiosk_Usage.Country_Code, theT_Kiosk_Usage.Country_Code));
            values.Add(new FieldValue("Country_Country_Name_Locale", original_T_Kiosk_Usage.Country_Country_Name_Locale, theT_Kiosk_Usage.Country_Country_Name_Locale, true));
            values.Add(new FieldValue("Email", original_T_Kiosk_Usage.Email, theT_Kiosk_Usage.Email));
            values.Add(new FieldValue("Phone_No", original_T_Kiosk_Usage.Phone_No, theT_Kiosk_Usage.Phone_No));
            values.Add(new FieldValue("Kiosk_ID", original_T_Kiosk_Usage.Kiosk_ID, theT_Kiosk_Usage.Kiosk_ID));
            values.Add(new FieldValue("Kiosk_Kiosk_Code", original_T_Kiosk_Usage.Kiosk_Kiosk_Code, theT_Kiosk_Usage.Kiosk_Kiosk_Code, true));
            values.Add(new FieldValue("Kiosk_KioskType_KioskType_Name", original_T_Kiosk_Usage.Kiosk_KioskType_KioskType_Name, theT_Kiosk_Usage.Kiosk_KioskType_KioskType_Name, true));
            values.Add(new FieldValue("Kiosk_Location_Location_Address", original_T_Kiosk_Usage.Kiosk_Location_Location_Address, theT_Kiosk_Usage.Kiosk_Location_Location_Address, true));
            values.Add(new FieldValue("Kiosk_Location_KioskOwner_KioskOwner_Code", original_T_Kiosk_Usage.Kiosk_Location_KioskOwner_KioskOwner_Code, theT_Kiosk_Usage.Kiosk_Location_KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("UsageStatus_Code", original_T_Kiosk_Usage.UsageStatus_Code, theT_Kiosk_Usage.UsageStatus_Code));
            values.Add(new FieldValue("Authen_User", original_T_Kiosk_Usage.Authen_User, theT_Kiosk_Usage.Authen_User));
            values.Add(new FieldValue("Authen_Password", original_T_Kiosk_Usage.Authen_Password, theT_Kiosk_Usage.Authen_Password));
            values.Add(new FieldValue("CreatedBy", original_T_Kiosk_Usage.CreatedBy, theT_Kiosk_Usage.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_T_Kiosk_Usage.CreatedOn, theT_Kiosk_Usage.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_T_Kiosk_Usage.ModifiedBy, theT_Kiosk_Usage.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_T_Kiosk_Usage.ModifiedOn, theT_Kiosk_Usage.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.T_Kiosk_Usage theT_Kiosk_Usage, VSM.Data.Objects.T_Kiosk_Usage original_T_Kiosk_Usage, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "T_Kiosk_Usage";
            args.View = dataView;
            args.Values = CreateFieldValues(theT_Kiosk_Usage, original_T_Kiosk_Usage);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("T_Kiosk_Usage", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theT_Kiosk_Usage);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.T_Kiosk_Usage theT_Kiosk_Usage, VSM.Data.Objects.T_Kiosk_Usage original_T_Kiosk_Usage)
        {
            return ExecuteAction(theT_Kiosk_Usage, original_T_Kiosk_Usage, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.T_Kiosk_Usage theT_Kiosk_Usage)
        {
            return Update(theT_Kiosk_Usage, SelectSingle(theT_Kiosk_Usage.KioskUsage_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.T_Kiosk_Usage theT_Kiosk_Usage)
        {
            return ExecuteAction(theT_Kiosk_Usage, new T_Kiosk_Usage(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.T_Kiosk_Usage theT_Kiosk_Usage)
        {
            return ExecuteAction(theT_Kiosk_Usage, theT_Kiosk_Usage, "Select", "Delete", DeleteView);
        }
    }
}

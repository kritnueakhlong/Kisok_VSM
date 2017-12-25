using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class VW_RPT_Log_Kiosk
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kiosk_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _location_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _usageStatus_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _idenDoc_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _identity_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _name_th;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _birthDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sex;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _log_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _phone_No;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _authen_User;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_Branch_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdOn;
        
        public VW_RPT_Log_Kiosk()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Kiosk_Code
        {
            get
            {
                return _kiosk_Code;
            }
            set
            {
                _kiosk_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Location_Address
        {
            get
            {
                return _location_Address;
            }
            set
            {
                _location_Address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string UsageStatus_Name
        {
            get
            {
                return _usageStatus_Name;
            }
            set
            {
                _usageStatus_Name = value;
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
        public DateTime? BirthDate
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Log_Address
        {
            get
            {
                return _log_Address;
            }
            set
            {
                _log_Address = value;
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
        
        public static List<VSM.Data.Objects.VW_RPT_Log_Kiosk> Select(string kiosk_Code, string location_Address, string usageStatus_Name, string idenDoc_Code, string identity_ID, string name_th, DateTime? birthDate, string sex, string log_Address, string phone_No, string authen_User, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, DateTime? createdOn)
        {
            return new VW_RPT_Log_KioskFactory().Select(kiosk_Code, location_Address, usageStatus_Name, idenDoc_Code, identity_ID, name_th, birthDate, sex, log_Address, phone_No, authen_User, kioskOwner_ID, kioskOwner_Branch_ID, createdOn);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Log_Kiosk> Select(VSM.Data.Objects.VW_RPT_Log_Kiosk qbe)
        {
            return new VW_RPT_Log_KioskFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Log_Kiosk> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new VW_RPT_Log_KioskFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Log_Kiosk> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new VW_RPT_Log_KioskFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Log_Kiosk> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new VW_RPT_Log_KioskFactory().Select(filter, sort, VW_RPT_Log_KioskFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Log_Kiosk> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new VW_RPT_Log_KioskFactory().Select(filter, sort, VW_RPT_Log_KioskFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Log_Kiosk> Select(string filter, BusinessObjectParameters parameters)
        {
            return new VW_RPT_Log_KioskFactory().Select(filter, null, VW_RPT_Log_KioskFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_RPT_Log_Kiosk> Select(string filter, params FieldValue[] parameters)
        {
            return new VW_RPT_Log_KioskFactory().Select(filter, null, VW_RPT_Log_KioskFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.VW_RPT_Log_Kiosk SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new VW_RPT_Log_KioskFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.VW_RPT_Log_Kiosk SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new VW_RPT_Log_KioskFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public override string ToString()
        {
            return String.Format("");
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class VW_RPT_Log_KioskFactory
    {
        
        public VW_RPT_Log_KioskFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("VW_RPT_Log_Kiosk");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("VW_RPT_Log_Kiosk");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("VW_RPT_Log_Kiosk");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("VW_RPT_Log_Kiosk");
            }
        }
        
        public static VW_RPT_Log_KioskFactory Create()
        {
            return new VW_RPT_Log_KioskFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    string kiosk_Code, 
                    string location_Address, 
                    string usageStatus_Name, 
                    string idenDoc_Code, 
                    string identity_ID, 
                    string name_th, 
                    DateTime? birthDate, 
                    string sex, 
                    string log_Address, 
                    string phone_No, 
                    string authen_User, 
                    System.Guid? kioskOwner_ID, 
                    System.Guid? kioskOwner_Branch_ID, 
                    DateTime? createdOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (!(String.IsNullOrEmpty(kiosk_Code)))
            	filter.Add(("Kiosk_Code:*" + kiosk_Code));
            if (!(String.IsNullOrEmpty(location_Address)))
            	filter.Add(("Location_Address:*" + location_Address));
            if (!(String.IsNullOrEmpty(usageStatus_Name)))
            	filter.Add(("UsageStatus_Name:*" + usageStatus_Name));
            if (!(String.IsNullOrEmpty(idenDoc_Code)))
            	filter.Add(("IdenDoc_Code:*" + idenDoc_Code));
            if (!(String.IsNullOrEmpty(identity_ID)))
            	filter.Add(("Identity_ID:*" + identity_ID));
            if (!(String.IsNullOrEmpty(name_th)))
            	filter.Add(("Name_th:*" + name_th));
            if (birthDate.HasValue)
            	filter.Add(("BirthDate:=" + birthDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(sex)))
            	filter.Add(("Sex:*" + sex));
            if (!(String.IsNullOrEmpty(log_Address)))
            	filter.Add(("Log_Address:*" + log_Address));
            if (!(String.IsNullOrEmpty(phone_No)))
            	filter.Add(("Phone_No:*" + phone_No));
            if (!(String.IsNullOrEmpty(authen_User)))
            	filter.Add(("Authen_User:*" + authen_User));
            if (kioskOwner_ID.HasValue)
            	filter.Add(("KioskOwner_ID:=" + kioskOwner_ID.Value.ToString()));
            if (kioskOwner_Branch_ID.HasValue)
            	filter.Add(("KioskOwner_Branch_ID:=" + kioskOwner_Branch_ID.Value.ToString()));
            if (createdOn.HasValue)
            	filter.Add(("CreatedOn:=" + createdOn.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<VSM.Data.Objects.VW_RPT_Log_Kiosk> Select(
                    string kiosk_Code, 
                    string location_Address, 
                    string usageStatus_Name, 
                    string idenDoc_Code, 
                    string identity_ID, 
                    string name_th, 
                    DateTime? birthDate, 
                    string sex, 
                    string log_Address, 
                    string phone_No, 
                    string authen_User, 
                    System.Guid? kioskOwner_ID, 
                    System.Guid? kioskOwner_Branch_ID, 
                    DateTime? createdOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(kiosk_Code, location_Address, usageStatus_Name, idenDoc_Code, identity_ID, name_th, birthDate, sex, log_Address, phone_No, authen_User, kioskOwner_ID, kioskOwner_Branch_ID, createdOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VW_RPT_Log_Kiosk", dataView, request);
            return page.ToList<VSM.Data.Objects.VW_RPT_Log_Kiosk>();
        }
        
        public List<VSM.Data.Objects.VW_RPT_Log_Kiosk> Select(VSM.Data.Objects.VW_RPT_Log_Kiosk qbe)
        {
            return Select(qbe.Kiosk_Code, qbe.Location_Address, qbe.UsageStatus_Name, qbe.IdenDoc_Code, qbe.Identity_ID, qbe.Name_th, qbe.BirthDate, qbe.Sex, qbe.Log_Address, qbe.Phone_No, qbe.Authen_User, qbe.KioskOwner_ID, qbe.KioskOwner_Branch_ID, qbe.CreatedOn);
        }
        
        public int SelectCount(
                    string kiosk_Code, 
                    string location_Address, 
                    string usageStatus_Name, 
                    string idenDoc_Code, 
                    string identity_ID, 
                    string name_th, 
                    DateTime? birthDate, 
                    string sex, 
                    string log_Address, 
                    string phone_No, 
                    string authen_User, 
                    System.Guid? kioskOwner_ID, 
                    System.Guid? kioskOwner_Branch_ID, 
                    DateTime? createdOn, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(kiosk_Code, location_Address, usageStatus_Name, idenDoc_Code, identity_ID, name_th, birthDate, sex, log_Address, phone_No, authen_User, kioskOwner_ID, kioskOwner_Branch_ID, createdOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VW_RPT_Log_Kiosk", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.VW_RPT_Log_Kiosk> Select(string kiosk_Code, string location_Address, string usageStatus_Name, string idenDoc_Code, string identity_ID, string name_th, DateTime? birthDate, string sex, string log_Address, string phone_No, string authen_User, System.Guid? kioskOwner_ID, System.Guid? kioskOwner_Branch_ID, DateTime? createdOn)
        {
            return Select(kiosk_Code, location_Address, usageStatus_Name, idenDoc_Code, identity_ID, name_th, birthDate, sex, log_Address, phone_No, authen_User, kioskOwner_ID, kioskOwner_Branch_ID, createdOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<VSM.Data.Objects.VW_RPT_Log_Kiosk> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("VW_RPT_Log_Kiosk", dataView, request);
            return page.ToList<VSM.Data.Objects.VW_RPT_Log_Kiosk>();
        }
        
        public List<VSM.Data.Objects.VW_RPT_Log_Kiosk> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.VW_RPT_Log_Kiosk> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.VW_RPT_Log_Kiosk SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.VW_RPT_Log_Kiosk> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
    }
}

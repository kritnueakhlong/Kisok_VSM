using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class M_KioskOwner_Radius_Connection
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _connection_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_KioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _radiusServer_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _radiusServer_Interface_CreatedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _radiusServer_Interface_Interface_Interface_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _radiusServer_Interface_RadiusServer_RadiusServer_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _interface_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _connection_IP_URL;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _connection_Database;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _connection_Username;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _connection_Password;
        
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
        
        public M_KioskOwner_Radius_Connection()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public System.Guid? Connection_ID
        {
            get
            {
                return _connection_ID;
            }
            set
            {
                _connection_ID = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string KioskOwner_KioskOwner_Code
        {
            get
            {
                return _kioskOwner_KioskOwner_Code;
            }
            set
            {
                _kioskOwner_KioskOwner_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        public string RadiusServer_Interface_CreatedBy
        {
            get
            {
                return _radiusServer_Interface_CreatedBy;
            }
            set
            {
                _radiusServer_Interface_CreatedBy = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RadiusServer_Interface_Interface_Interface_Name
        {
            get
            {
                return _radiusServer_Interface_Interface_Interface_Name;
            }
            set
            {
                _radiusServer_Interface_Interface_Interface_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RadiusServer_Interface_RadiusServer_RadiusServer_Name
        {
            get
            {
                return _radiusServer_Interface_RadiusServer_RadiusServer_Name;
            }
            set
            {
                _radiusServer_Interface_RadiusServer_RadiusServer_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Interface_Code
        {
            get
            {
                return _interface_Code;
            }
            set
            {
                _interface_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Connection_IP_URL
        {
            get
            {
                return _connection_IP_URL;
            }
            set
            {
                _connection_IP_URL = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Connection_Database
        {
            get
            {
                return _connection_Database;
            }
            set
            {
                _connection_Database = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Connection_Username
        {
            get
            {
                return _connection_Username;
            }
            set
            {
                _connection_Username = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Connection_Password
        {
            get
            {
                return _connection_Password;
            }
            set
            {
                _connection_Password = value;
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
        
        public static List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> Select(
                    System.Guid? connection_ID, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    string radiusServer_Code, 
                    string radiusServer_Interface_CreatedBy, 
                    string radiusServer_Interface_Interface_Interface_Name, 
                    string radiusServer_Interface_RadiusServer_RadiusServer_Name, 
                    string interface_Code, 
                    string connection_IP_URL, 
                    string connection_Database, 
                    string connection_Username, 
                    string connection_Password, 
                    bool? item_Flag, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn)
        {
            return new M_KioskOwner_Radius_ConnectionFactory().Select(connection_ID, kioskOwner_ID, kioskOwner_KioskOwner_Code, radiusServer_Code, radiusServer_Interface_CreatedBy, radiusServer_Interface_Interface_Interface_Name, radiusServer_Interface_RadiusServer_RadiusServer_Name, interface_Code, connection_IP_URL, connection_Database, connection_Username, connection_Password, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn);
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> Select(VSM.Data.Objects.M_KioskOwner_Radius_Connection qbe)
        {
            return new M_KioskOwner_Radius_ConnectionFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new M_KioskOwner_Radius_ConnectionFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new M_KioskOwner_Radius_ConnectionFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new M_KioskOwner_Radius_ConnectionFactory().Select(filter, sort, M_KioskOwner_Radius_ConnectionFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new M_KioskOwner_Radius_ConnectionFactory().Select(filter, sort, M_KioskOwner_Radius_ConnectionFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> Select(string filter, BusinessObjectParameters parameters)
        {
            return new M_KioskOwner_Radius_ConnectionFactory().Select(filter, null, M_KioskOwner_Radius_ConnectionFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> Select(string filter, params FieldValue[] parameters)
        {
            return new M_KioskOwner_Radius_ConnectionFactory().Select(filter, null, M_KioskOwner_Radius_ConnectionFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_KioskOwner_Radius_Connection SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new M_KioskOwner_Radius_ConnectionFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.M_KioskOwner_Radius_Connection SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new M_KioskOwner_Radius_ConnectionFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.M_KioskOwner_Radius_Connection SelectSingle(System.Guid? connection_ID)
        {
            return new M_KioskOwner_Radius_ConnectionFactory().SelectSingle(connection_ID);
        }
        
        public int Insert()
        {
            return new M_KioskOwner_Radius_ConnectionFactory().Insert(this);
        }
        
        public int Update()
        {
            return new M_KioskOwner_Radius_ConnectionFactory().Update(this);
        }
        
        public int Delete()
        {
            return new M_KioskOwner_Radius_ConnectionFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Connection_ID: {0}", this.Connection_ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class M_KioskOwner_Radius_ConnectionFactory
    {
        
        public M_KioskOwner_Radius_ConnectionFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("M_KioskOwner_Radius_Connection");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("M_KioskOwner_Radius_Connection");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("M_KioskOwner_Radius_Connection");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("M_KioskOwner_Radius_Connection");
            }
        }
        
        public static M_KioskOwner_Radius_ConnectionFactory Create()
        {
            return new M_KioskOwner_Radius_ConnectionFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    System.Guid? connection_ID, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    string radiusServer_Code, 
                    string radiusServer_Interface_CreatedBy, 
                    string radiusServer_Interface_Interface_Interface_Name, 
                    string radiusServer_Interface_RadiusServer_RadiusServer_Name, 
                    string interface_Code, 
                    string connection_IP_URL, 
                    string connection_Database, 
                    string connection_Username, 
                    string connection_Password, 
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
            if (connection_ID.HasValue)
            	filter.Add(("Connection_ID:=" + connection_ID.Value.ToString()));
            if (kioskOwner_ID.HasValue)
            	filter.Add(("KioskOwner_ID:=" + kioskOwner_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_KioskOwner_Code)))
            	filter.Add(("KioskOwner_KioskOwner_Code:*" + kioskOwner_KioskOwner_Code));
            if (!(String.IsNullOrEmpty(radiusServer_Code)))
            	filter.Add(("RadiusServer_Code:*" + radiusServer_Code));
            if (!(String.IsNullOrEmpty(radiusServer_Interface_CreatedBy)))
            	filter.Add(("RadiusServer_Interface_CreatedBy:*" + radiusServer_Interface_CreatedBy));
            if (!(String.IsNullOrEmpty(radiusServer_Interface_Interface_Interface_Name)))
            	filter.Add(("RadiusServer_Interface_Interface_Interface_Name:*" + radiusServer_Interface_Interface_Interface_Name));
            if (!(String.IsNullOrEmpty(radiusServer_Interface_RadiusServer_RadiusServer_Name)))
            	filter.Add(("RadiusServer_Interface_RadiusServer_RadiusServer_Name:*" + radiusServer_Interface_RadiusServer_RadiusServer_Name));
            if (!(String.IsNullOrEmpty(interface_Code)))
            	filter.Add(("Interface_Code:*" + interface_Code));
            if (!(String.IsNullOrEmpty(connection_IP_URL)))
            	filter.Add(("Connection_IP_URL:*" + connection_IP_URL));
            if (!(String.IsNullOrEmpty(connection_Database)))
            	filter.Add(("Connection_Database:*" + connection_Database));
            if (!(String.IsNullOrEmpty(connection_Username)))
            	filter.Add(("Connection_Username:*" + connection_Username));
            if (!(String.IsNullOrEmpty(connection_Password)))
            	filter.Add(("Connection_Password:*" + connection_Password));
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
        public List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> Select(
                    System.Guid? connection_ID, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    string radiusServer_Code, 
                    string radiusServer_Interface_CreatedBy, 
                    string radiusServer_Interface_Interface_Interface_Name, 
                    string radiusServer_Interface_RadiusServer_RadiusServer_Name, 
                    string interface_Code, 
                    string connection_IP_URL, 
                    string connection_Database, 
                    string connection_Username, 
                    string connection_Password, 
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
            PageRequest request = CreateRequest(connection_ID, kioskOwner_ID, kioskOwner_KioskOwner_Code, radiusServer_Code, radiusServer_Interface_CreatedBy, radiusServer_Interface_Interface_Interface_Name, radiusServer_Interface_RadiusServer_RadiusServer_Name, interface_Code, connection_IP_URL, connection_Database, connection_Username, connection_Password, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_KioskOwner_Radius_Connection", dataView, request);
            return page.ToList<VSM.Data.Objects.M_KioskOwner_Radius_Connection>();
        }
        
        public List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> Select(VSM.Data.Objects.M_KioskOwner_Radius_Connection qbe)
        {
            return Select(qbe.Connection_ID, qbe.KioskOwner_ID, qbe.KioskOwner_KioskOwner_Code, qbe.RadiusServer_Code, qbe.RadiusServer_Interface_CreatedBy, qbe.RadiusServer_Interface_Interface_Interface_Name, qbe.RadiusServer_Interface_RadiusServer_RadiusServer_Name, qbe.Interface_Code, qbe.Connection_IP_URL, qbe.Connection_Database, qbe.Connection_Username, qbe.Connection_Password, qbe.Item_Flag, qbe.CreatedBy, qbe.CreatedOn, qbe.ModifiedBy, qbe.ModifiedOn);
        }
        
        public int SelectCount(
                    System.Guid? connection_ID, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    string radiusServer_Code, 
                    string radiusServer_Interface_CreatedBy, 
                    string radiusServer_Interface_Interface_Interface_Name, 
                    string radiusServer_Interface_RadiusServer_RadiusServer_Name, 
                    string interface_Code, 
                    string connection_IP_URL, 
                    string connection_Database, 
                    string connection_Username, 
                    string connection_Password, 
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
            PageRequest request = CreateRequest(connection_ID, kioskOwner_ID, kioskOwner_KioskOwner_Code, radiusServer_Code, radiusServer_Interface_CreatedBy, radiusServer_Interface_Interface_Interface_Name, radiusServer_Interface_RadiusServer_RadiusServer_Name, interface_Code, connection_IP_URL, connection_Database, connection_Username, connection_Password, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("M_KioskOwner_Radius_Connection", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> Select(
                    System.Guid? connection_ID, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_KioskOwner_Code, 
                    string radiusServer_Code, 
                    string radiusServer_Interface_CreatedBy, 
                    string radiusServer_Interface_Interface_Interface_Name, 
                    string radiusServer_Interface_RadiusServer_RadiusServer_Name, 
                    string interface_Code, 
                    string connection_IP_URL, 
                    string connection_Database, 
                    string connection_Username, 
                    string connection_Password, 
                    bool? item_Flag, 
                    string createdBy, 
                    DateTime? createdOn, 
                    string modifiedBy, 
                    DateTime? modifiedOn)
        {
            return Select(connection_ID, kioskOwner_ID, kioskOwner_KioskOwner_Code, radiusServer_Code, radiusServer_Interface_CreatedBy, radiusServer_Interface_Interface_Interface_Name, radiusServer_Interface_RadiusServer_RadiusServer_Name, interface_Code, connection_IP_URL, connection_Database, connection_Username, connection_Password, item_Flag, createdBy, createdOn, modifiedBy, modifiedOn, null, Int32.MaxValue, 0, SelectView);
        }
        
        public VSM.Data.Objects.M_KioskOwner_Radius_Connection SelectSingle(System.Guid? connection_ID)
        {
            List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> list = Select(connection_ID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("M_KioskOwner_Radius_Connection", dataView, request);
            return page.ToList<VSM.Data.Objects.M_KioskOwner_Radius_Connection>();
        }
        
        public List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.M_KioskOwner_Radius_Connection SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.M_KioskOwner_Radius_Connection> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(VSM.Data.Objects.M_KioskOwner_Radius_Connection theM_KioskOwner_Radius_Connection, VSM.Data.Objects.M_KioskOwner_Radius_Connection original_M_KioskOwner_Radius_Connection)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Connection_ID", original_M_KioskOwner_Radius_Connection.Connection_ID, theM_KioskOwner_Radius_Connection.Connection_ID));
            values.Add(new FieldValue("KioskOwner_ID", original_M_KioskOwner_Radius_Connection.KioskOwner_ID, theM_KioskOwner_Radius_Connection.KioskOwner_ID));
            values.Add(new FieldValue("KioskOwner_KioskOwner_Code", original_M_KioskOwner_Radius_Connection.KioskOwner_KioskOwner_Code, theM_KioskOwner_Radius_Connection.KioskOwner_KioskOwner_Code, true));
            values.Add(new FieldValue("RadiusServer_Code", original_M_KioskOwner_Radius_Connection.RadiusServer_Code, theM_KioskOwner_Radius_Connection.RadiusServer_Code));
            values.Add(new FieldValue("RadiusServer_Interface_CreatedBy", original_M_KioskOwner_Radius_Connection.RadiusServer_Interface_CreatedBy, theM_KioskOwner_Radius_Connection.RadiusServer_Interface_CreatedBy, true));
            values.Add(new FieldValue("RadiusServer_Interface_Interface_Interface_Name", original_M_KioskOwner_Radius_Connection.RadiusServer_Interface_Interface_Interface_Name, theM_KioskOwner_Radius_Connection.RadiusServer_Interface_Interface_Interface_Name, true));
            values.Add(new FieldValue("RadiusServer_Interface_RadiusServer_RadiusServer_Name", original_M_KioskOwner_Radius_Connection.RadiusServer_Interface_RadiusServer_RadiusServer_Name, theM_KioskOwner_Radius_Connection.RadiusServer_Interface_RadiusServer_RadiusServer_Name, true));
            values.Add(new FieldValue("Interface_Code", original_M_KioskOwner_Radius_Connection.Interface_Code, theM_KioskOwner_Radius_Connection.Interface_Code));
            values.Add(new FieldValue("Connection_IP_URL", original_M_KioskOwner_Radius_Connection.Connection_IP_URL, theM_KioskOwner_Radius_Connection.Connection_IP_URL));
            values.Add(new FieldValue("Connection_Database", original_M_KioskOwner_Radius_Connection.Connection_Database, theM_KioskOwner_Radius_Connection.Connection_Database));
            values.Add(new FieldValue("Connection_Username", original_M_KioskOwner_Radius_Connection.Connection_Username, theM_KioskOwner_Radius_Connection.Connection_Username));
            values.Add(new FieldValue("Connection_Password", original_M_KioskOwner_Radius_Connection.Connection_Password, theM_KioskOwner_Radius_Connection.Connection_Password));
            values.Add(new FieldValue("Item_Flag", original_M_KioskOwner_Radius_Connection.Item_Flag, theM_KioskOwner_Radius_Connection.Item_Flag));
            values.Add(new FieldValue("CreatedBy", original_M_KioskOwner_Radius_Connection.CreatedBy, theM_KioskOwner_Radius_Connection.CreatedBy));
            values.Add(new FieldValue("CreatedOn", original_M_KioskOwner_Radius_Connection.CreatedOn, theM_KioskOwner_Radius_Connection.CreatedOn));
            values.Add(new FieldValue("ModifiedBy", original_M_KioskOwner_Radius_Connection.ModifiedBy, theM_KioskOwner_Radius_Connection.ModifiedBy));
            values.Add(new FieldValue("ModifiedOn", original_M_KioskOwner_Radius_Connection.ModifiedOn, theM_KioskOwner_Radius_Connection.ModifiedOn));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(VSM.Data.Objects.M_KioskOwner_Radius_Connection theM_KioskOwner_Radius_Connection, VSM.Data.Objects.M_KioskOwner_Radius_Connection original_M_KioskOwner_Radius_Connection, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "M_KioskOwner_Radius_Connection";
            args.View = dataView;
            args.Values = CreateFieldValues(theM_KioskOwner_Radius_Connection, original_M_KioskOwner_Radius_Connection);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("M_KioskOwner_Radius_Connection", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theM_KioskOwner_Radius_Connection);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(VSM.Data.Objects.M_KioskOwner_Radius_Connection theM_KioskOwner_Radius_Connection, VSM.Data.Objects.M_KioskOwner_Radius_Connection original_M_KioskOwner_Radius_Connection)
        {
            return ExecuteAction(theM_KioskOwner_Radius_Connection, original_M_KioskOwner_Radius_Connection, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(VSM.Data.Objects.M_KioskOwner_Radius_Connection theM_KioskOwner_Radius_Connection)
        {
            return Update(theM_KioskOwner_Radius_Connection, SelectSingle(theM_KioskOwner_Radius_Connection.Connection_ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(VSM.Data.Objects.M_KioskOwner_Radius_Connection theM_KioskOwner_Radius_Connection)
        {
            return ExecuteAction(theM_KioskOwner_Radius_Connection, new M_KioskOwner_Radius_Connection(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(VSM.Data.Objects.M_KioskOwner_Radius_Connection theM_KioskOwner_Radius_Connection)
        {
            return ExecuteAction(theM_KioskOwner_Radius_Connection, theM_KioskOwner_Radius_Connection, "Select", "Delete", DeleteView);
        }
    }
}

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class VW_Advertise
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _advertise_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _advertise_Date;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advertise_Desc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _effect_Type;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _effective_Date;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _end_Date;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kioskOwner_ID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _kioskOwner_Address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _kioskOwner_LAT;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _kioskOwner_LONG;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _kiosk_ID;
        
        public VW_Advertise()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public System.Guid? Advertise_ID
        {
            get
            {
                return _advertise_ID;
            }
            set
            {
                _advertise_ID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? Advertise_Date
        {
            get
            {
                return _advertise_Date;
            }
            set
            {
                _advertise_Date = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Advertise_Desc
        {
            get
            {
                return _advertise_Desc;
            }
            set
            {
                _advertise_Desc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Effect_Type
        {
            get
            {
                return _effect_Type;
            }
            set
            {
                _effect_Type = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? Effective_Date
        {
            get
            {
                return _effective_Date;
            }
            set
            {
                _effective_Date = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? End_Date
        {
            get
            {
                return _end_Date;
            }
            set
            {
                _end_Date = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        public string KioskOwner_Code
        {
            get
            {
                return _kioskOwner_Code;
            }
            set
            {
                _kioskOwner_Code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string KioskOwner_Name
        {
            get
            {
                return _kioskOwner_Name;
            }
            set
            {
                _kioskOwner_Name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string KioskOwner_Address
        {
            get
            {
                return _kioskOwner_Address;
            }
            set
            {
                _kioskOwner_Address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? KioskOwner_LAT
        {
            get
            {
                return _kioskOwner_LAT;
            }
            set
            {
                _kioskOwner_LAT = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? KioskOwner_LONG
        {
            get
            {
                return _kioskOwner_LONG;
            }
            set
            {
                _kioskOwner_LONG = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        public static List<VSM.Data.Objects.VW_Advertise> Select(System.Guid? advertise_ID, DateTime? advertise_Date, string advertise_Desc, string effect_Type, DateTime? effective_Date, DateTime? end_Date, System.Guid? kioskOwner_ID, string kioskOwner_Code, string kioskOwner_Name, string kioskOwner_Address, decimal? kioskOwner_LAT, decimal? kioskOwner_LONG, System.Guid? kiosk_ID)
        {
            return new VW_AdvertiseFactory().Select(advertise_ID, advertise_Date, advertise_Desc, effect_Type, effective_Date, end_Date, kioskOwner_ID, kioskOwner_Code, kioskOwner_Name, kioskOwner_Address, kioskOwner_LAT, kioskOwner_LONG, kiosk_ID);
        }
        
        public static List<VSM.Data.Objects.VW_Advertise> Select(VSM.Data.Objects.VW_Advertise qbe)
        {
            return new VW_AdvertiseFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.VW_Advertise> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new VW_AdvertiseFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_Advertise> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new VW_AdvertiseFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.VW_Advertise> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new VW_AdvertiseFactory().Select(filter, sort, VW_AdvertiseFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_Advertise> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new VW_AdvertiseFactory().Select(filter, sort, VW_AdvertiseFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.VW_Advertise> Select(string filter, BusinessObjectParameters parameters)
        {
            return new VW_AdvertiseFactory().Select(filter, null, VW_AdvertiseFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_Advertise> Select(string filter, params FieldValue[] parameters)
        {
            return new VW_AdvertiseFactory().Select(filter, null, VW_AdvertiseFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.VW_Advertise SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new VW_AdvertiseFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.VW_Advertise SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new VW_AdvertiseFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public override string ToString()
        {
            return String.Format("");
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class VW_AdvertiseFactory
    {
        
        public VW_AdvertiseFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("VW_Advertise");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("VW_Advertise");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("VW_Advertise");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("VW_Advertise");
            }
        }
        
        public static VW_AdvertiseFactory Create()
        {
            return new VW_AdvertiseFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    System.Guid? advertise_ID, 
                    DateTime? advertise_Date, 
                    string advertise_Desc, 
                    string effect_Type, 
                    DateTime? effective_Date, 
                    DateTime? end_Date, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_Code, 
                    string kioskOwner_Name, 
                    string kioskOwner_Address, 
                    decimal? kioskOwner_LAT, 
                    decimal? kioskOwner_LONG, 
                    System.Guid? kiosk_ID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (advertise_ID.HasValue)
            	filter.Add(("Advertise_ID:=" + advertise_ID.Value.ToString()));
            if (advertise_Date.HasValue)
            	filter.Add(("Advertise_Date:=" + advertise_Date.Value.ToString()));
            if (!(String.IsNullOrEmpty(advertise_Desc)))
            	filter.Add(("Advertise_Desc:*" + advertise_Desc));
            if (!(String.IsNullOrEmpty(effect_Type)))
            	filter.Add(("Effect_Type:*" + effect_Type));
            if (effective_Date.HasValue)
            	filter.Add(("Effective_Date:=" + effective_Date.Value.ToString()));
            if (end_Date.HasValue)
            	filter.Add(("End_Date:=" + end_Date.Value.ToString()));
            if (kioskOwner_ID.HasValue)
            	filter.Add(("KioskOwner_ID:=" + kioskOwner_ID.Value.ToString()));
            if (!(String.IsNullOrEmpty(kioskOwner_Code)))
            	filter.Add(("KioskOwner_Code:*" + kioskOwner_Code));
            if (!(String.IsNullOrEmpty(kioskOwner_Name)))
            	filter.Add(("KioskOwner_Name:*" + kioskOwner_Name));
            if (!(String.IsNullOrEmpty(kioskOwner_Address)))
            	filter.Add(("KioskOwner_Address:*" + kioskOwner_Address));
            if (kioskOwner_LAT.HasValue)
            	filter.Add(("KioskOwner_LAT:=" + kioskOwner_LAT.Value.ToString()));
            if (kioskOwner_LONG.HasValue)
            	filter.Add(("KioskOwner_LONG:=" + kioskOwner_LONG.Value.ToString()));
            if (kiosk_ID.HasValue)
            	filter.Add(("Kiosk_ID:=" + kiosk_ID.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<VSM.Data.Objects.VW_Advertise> Select(
                    System.Guid? advertise_ID, 
                    DateTime? advertise_Date, 
                    string advertise_Desc, 
                    string effect_Type, 
                    DateTime? effective_Date, 
                    DateTime? end_Date, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_Code, 
                    string kioskOwner_Name, 
                    string kioskOwner_Address, 
                    decimal? kioskOwner_LAT, 
                    decimal? kioskOwner_LONG, 
                    System.Guid? kiosk_ID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(advertise_ID, advertise_Date, advertise_Desc, effect_Type, effective_Date, end_Date, kioskOwner_ID, kioskOwner_Code, kioskOwner_Name, kioskOwner_Address, kioskOwner_LAT, kioskOwner_LONG, kiosk_ID, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VW_Advertise", dataView, request);
            return page.ToList<VSM.Data.Objects.VW_Advertise>();
        }
        
        public List<VSM.Data.Objects.VW_Advertise> Select(VSM.Data.Objects.VW_Advertise qbe)
        {
            return Select(qbe.Advertise_ID, qbe.Advertise_Date, qbe.Advertise_Desc, qbe.Effect_Type, qbe.Effective_Date, qbe.End_Date, qbe.KioskOwner_ID, qbe.KioskOwner_Code, qbe.KioskOwner_Name, qbe.KioskOwner_Address, qbe.KioskOwner_LAT, qbe.KioskOwner_LONG, qbe.Kiosk_ID);
        }
        
        public int SelectCount(
                    System.Guid? advertise_ID, 
                    DateTime? advertise_Date, 
                    string advertise_Desc, 
                    string effect_Type, 
                    DateTime? effective_Date, 
                    DateTime? end_Date, 
                    System.Guid? kioskOwner_ID, 
                    string kioskOwner_Code, 
                    string kioskOwner_Name, 
                    string kioskOwner_Address, 
                    decimal? kioskOwner_LAT, 
                    decimal? kioskOwner_LONG, 
                    System.Guid? kiosk_ID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(advertise_ID, advertise_Date, advertise_Desc, effect_Type, effective_Date, end_Date, kioskOwner_ID, kioskOwner_Code, kioskOwner_Name, kioskOwner_Address, kioskOwner_LAT, kioskOwner_LONG, kiosk_ID, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VW_Advertise", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.VW_Advertise> Select(System.Guid? advertise_ID, DateTime? advertise_Date, string advertise_Desc, string effect_Type, DateTime? effective_Date, DateTime? end_Date, System.Guid? kioskOwner_ID, string kioskOwner_Code, string kioskOwner_Name, string kioskOwner_Address, decimal? kioskOwner_LAT, decimal? kioskOwner_LONG, System.Guid? kiosk_ID)
        {
            return Select(advertise_ID, advertise_Date, advertise_Desc, effect_Type, effective_Date, end_Date, kioskOwner_ID, kioskOwner_Code, kioskOwner_Name, kioskOwner_Address, kioskOwner_LAT, kioskOwner_LONG, kiosk_ID, null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<VSM.Data.Objects.VW_Advertise> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("VW_Advertise", dataView, request);
            return page.ToList<VSM.Data.Objects.VW_Advertise>();
        }
        
        public List<VSM.Data.Objects.VW_Advertise> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.VW_Advertise> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.VW_Advertise SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.VW_Advertise> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
    }
}

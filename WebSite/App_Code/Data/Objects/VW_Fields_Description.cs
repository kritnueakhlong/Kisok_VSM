using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace VSM.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class VW_Fields_Description
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _object_schema;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _object_name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _column_name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _data_type;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private object _column_label;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _major_id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _minor_id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _major_minor;
        
        public VW_Fields_Description()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string object_schema
        {
            get
            {
                return _object_schema;
            }
            set
            {
                _object_schema = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string object_name
        {
            get
            {
                return _object_name;
            }
            set
            {
                _object_name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string column_name
        {
            get
            {
                return _column_name;
            }
            set
            {
                _column_name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string data_type
        {
            get
            {
                return _data_type;
            }
            set
            {
                _data_type = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public object column_label
        {
            get
            {
                return _column_label;
            }
            set
            {
                _column_label = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? major_id
        {
            get
            {
                return _major_id;
            }
            set
            {
                _major_id = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? minor_id
        {
            get
            {
                return _minor_id;
            }
            set
            {
                _minor_id = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? major_minor
        {
            get
            {
                return _major_minor;
            }
            set
            {
                _major_minor = value;
            }
        }
        
        public static List<VSM.Data.Objects.VW_Fields_Description> Select(string object_schema, string object_name, string column_name, string data_type, int? major_id, int? minor_id, int? major_minor)
        {
            return new VW_Fields_DescriptionFactory().Select(object_schema, object_name, column_name, data_type, major_id, minor_id, major_minor);
        }
        
        public static List<VSM.Data.Objects.VW_Fields_Description> Select(VSM.Data.Objects.VW_Fields_Description qbe)
        {
            return new VW_Fields_DescriptionFactory().Select(qbe);
        }
        
        public static List<VSM.Data.Objects.VW_Fields_Description> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new VW_Fields_DescriptionFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_Fields_Description> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new VW_Fields_DescriptionFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.VW_Fields_Description> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new VW_Fields_DescriptionFactory().Select(filter, sort, VW_Fields_DescriptionFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_Fields_Description> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new VW_Fields_DescriptionFactory().Select(filter, sort, VW_Fields_DescriptionFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<VSM.Data.Objects.VW_Fields_Description> Select(string filter, BusinessObjectParameters parameters)
        {
            return new VW_Fields_DescriptionFactory().Select(filter, null, VW_Fields_DescriptionFactory.SelectView, parameters);
        }
        
        public static List<VSM.Data.Objects.VW_Fields_Description> Select(string filter, params FieldValue[] parameters)
        {
            return new VW_Fields_DescriptionFactory().Select(filter, null, VW_Fields_DescriptionFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static VSM.Data.Objects.VW_Fields_Description SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new VW_Fields_DescriptionFactory().SelectSingle(filter, parameters);
        }
        
        public static VSM.Data.Objects.VW_Fields_Description SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new VW_Fields_DescriptionFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public override string ToString()
        {
            return String.Format("");
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class VW_Fields_DescriptionFactory
    {
        
        public VW_Fields_DescriptionFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("VW_Fields_Description");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("VW_Fields_Description");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("VW_Fields_Description");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("VW_Fields_Description");
            }
        }
        
        public static VW_Fields_DescriptionFactory Create()
        {
            return new VW_Fields_DescriptionFactory();
        }
        
        protected virtual PageRequest CreateRequest(string object_schema, string object_name, string column_name, string data_type, int? major_id, int? minor_id, int? major_minor, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (!(String.IsNullOrEmpty(object_schema)))
            	filter.Add(("object_schema:*" + object_schema));
            if (!(String.IsNullOrEmpty(object_name)))
            	filter.Add(("object_name:*" + object_name));
            if (!(String.IsNullOrEmpty(column_name)))
            	filter.Add(("column_name:*" + column_name));
            if (!(String.IsNullOrEmpty(data_type)))
            	filter.Add(("data_type:*" + data_type));
            if (major_id.HasValue)
            	filter.Add(("major_id:=" + major_id.Value.ToString()));
            if (minor_id.HasValue)
            	filter.Add(("minor_id:=" + minor_id.Value.ToString()));
            if (major_minor.HasValue)
            	filter.Add(("major_minor:=" + major_minor.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<VSM.Data.Objects.VW_Fields_Description> Select(string object_schema, string object_name, string column_name, string data_type, int? major_id, int? minor_id, int? major_minor, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(object_schema, object_name, column_name, data_type, major_id, minor_id, major_minor, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VW_Fields_Description", dataView, request);
            return page.ToList<VSM.Data.Objects.VW_Fields_Description>();
        }
        
        public List<VSM.Data.Objects.VW_Fields_Description> Select(VSM.Data.Objects.VW_Fields_Description qbe)
        {
            return Select(qbe.object_schema, qbe.object_name, qbe.column_name, qbe.data_type, qbe.major_id, qbe.minor_id, qbe.major_minor);
        }
        
        public int SelectCount(string object_schema, string object_name, string column_name, string data_type, int? major_id, int? minor_id, int? major_minor, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(object_schema, object_name, column_name, data_type, major_id, minor_id, major_minor, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VW_Fields_Description", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<VSM.Data.Objects.VW_Fields_Description> Select(string object_schema, string object_name, string column_name, string data_type, int? major_id, int? minor_id, int? major_minor)
        {
            return Select(object_schema, object_name, column_name, data_type, major_id, minor_id, major_minor, null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<VSM.Data.Objects.VW_Fields_Description> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("VW_Fields_Description", dataView, request);
            return page.ToList<VSM.Data.Objects.VW_Fields_Description>();
        }
        
        public List<VSM.Data.Objects.VW_Fields_Description> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<VSM.Data.Objects.VW_Fields_Description> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public VSM.Data.Objects.VW_Fields_Description SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<VSM.Data.Objects.VW_Fields_Description> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
    }
}

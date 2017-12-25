using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using VSM.Data;

namespace VSM.Rules
{
	public partial class M_Radius_ServerBusinessRules : VSM.Rules.SharedBusinessRules
    {
        
        [RowBuilder("M_Radius_Server", RowKind.Existing)]
        public void BuildExistingRow()
        {
            PopulateManyToManyField("Interfaces", "RadiusServer_Code", "M_Radius_Server_Interface", "RadiusServer_Code", "Interface_Code");
        }
        
        [ControllerAction("M_Radius_Server", "Insert", ActionPhase.Before)]
        [ControllerAction("M_Radius_Server", "Update", ActionPhase.Before)]
        public void BeforeInsertOrUpdate()
        {
            FieldValue valueOfInterfaces = SelectFieldValueObject("Interfaces");
            if (valueOfInterfaces != null)
            	valueOfInterfaces.Modified = false;
        }
        
        [ControllerAction("M_Radius_Server", "Insert", ActionPhase.After)]
        [ControllerAction("M_Radius_Server", "Update", ActionPhase.After)]
        public void AfterInsertOrUpdate()
        {
            UpdateManyToManyField("Interfaces", "RadiusServer_Code", "M_Radius_Server_Interface", "RadiusServer_Code", "Interface_Code");
        }
        
        [ControllerAction("M_Radius_Server", "Delete", ActionPhase.Before)]
        public void BeforeDelete()
        {
            ClearManyToManyField("Interfaces", "RadiusServer_Code", "M_Radius_Server_Interface", "RadiusServer_Code", "Interface_Code");
        }
    }
}

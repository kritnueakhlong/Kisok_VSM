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
	public partial class M_Kiosk_OwnerBusinessRules : VSM.Rules.SharedBusinessRules
    {
        
        [RowBuilder("M_Kiosk_Owner", RowKind.Existing)]
        public void BuildExistingRow()
        {
            PopulateManyToManyField("Configs", "KioskOwner_ID", "M_KioskOwner_Config", "", "Config_ID");
        }
        
        [ControllerAction("M_Kiosk_Owner", "Insert", ActionPhase.Before)]
        [ControllerAction("M_Kiosk_Owner", "Update", ActionPhase.Before)]
        public void BeforeInsertOrUpdate()
        {
            FieldValue valueOfConfigs = SelectFieldValueObject("Configs");
            if (valueOfConfigs != null)
            	valueOfConfigs.Modified = false;
        }
        
        [ControllerAction("M_Kiosk_Owner", "Insert", ActionPhase.After)]
        [ControllerAction("M_Kiosk_Owner", "Update", ActionPhase.After)]
        public void AfterInsertOrUpdate()
        {
            UpdateManyToManyField("Configs", "KioskOwner_ID", "M_KioskOwner_Config", "", "Config_ID");
        }
        
        [ControllerAction("M_Kiosk_Owner", "Delete", ActionPhase.Before)]
        public void BeforeDelete()
        {
            ClearManyToManyField("Configs", "KioskOwner_ID", "M_KioskOwner_Config", "", "Config_ID");
        }
    }
}

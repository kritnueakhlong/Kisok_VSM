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
	public partial class M_Kiosk_Owner_BranchBusinessRules : VSM.Rules.SharedBusinessRules
    {
        
        [RowBuilder("M_Kiosk_Owner_Branch", RowKind.Existing)]
        public void BuildExistingRow()
        {
            PopulateManyToManyField("Configs", "KioskOwner_Branch_ID", "M_KioskOwner_Config", "KioskOwner_Branch_ID", "Config_ID");
            PopulateManyToManyField("ConfigValue", "KioskOwner_Branch_ID", "M_KioskOwner_Config", "KioskOwner_Branch_ID", "Config_ID");
        }
        
        [ControllerAction("M_Kiosk_Owner_Branch", "Insert", ActionPhase.Before)]
        [ControllerAction("M_Kiosk_Owner_Branch", "Update", ActionPhase.Before)]
        public void BeforeInsertOrUpdate()
        {
            FieldValue valueOfConfigs = SelectFieldValueObject("Configs");
            if (valueOfConfigs != null)
            	valueOfConfigs.Modified = false;
            FieldValue valueOfConfigValue = SelectFieldValueObject("ConfigValue");
            if (valueOfConfigValue != null)
            	valueOfConfigValue.Modified = false;
        }
        
        [ControllerAction("M_Kiosk_Owner_Branch", "Insert", ActionPhase.After)]
        [ControllerAction("M_Kiosk_Owner_Branch", "Update", ActionPhase.After)]
        public void AfterInsertOrUpdate()
        {
            UpdateManyToManyField("Configs", "KioskOwner_Branch_ID", "M_KioskOwner_Config", "KioskOwner_Branch_ID", "Config_ID");
            UpdateManyToManyField("ConfigValue", "KioskOwner_Branch_ID", "M_KioskOwner_Config", "KioskOwner_Branch_ID", "Config_ID");
        }
        
        [ControllerAction("M_Kiosk_Owner_Branch", "Delete", ActionPhase.Before)]
        public void BeforeDelete()
        {
            ClearManyToManyField("Configs", "KioskOwner_Branch_ID", "M_KioskOwner_Config", "KioskOwner_Branch_ID", "Config_ID");
            ClearManyToManyField("ConfigValue", "KioskOwner_Branch_ID", "M_KioskOwner_Config", "KioskOwner_Branch_ID", "Config_ID");
        }
    }
}

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
	public partial class Con_Condition_GroupBusinessRules : VSM.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Con_Condition_Group", RowKind.Existing)]
        public void BuildExistingRow()
        {
            PopulateManyToManyField("Columns", "ConGroup_ID", "Con_Condition_Group_Column", "ConGroup_ID", "TableColumn_ID");
        }
        
        [ControllerAction("Con_Condition_Group", "Insert", ActionPhase.Before)]
        [ControllerAction("Con_Condition_Group", "Update", ActionPhase.Before)]
        public void BeforeInsertOrUpdate()
        {
            FieldValue valueOfColumns = SelectFieldValueObject("Columns");
            if (valueOfColumns != null)
            	valueOfColumns.Modified = false;
        }
        
        [ControllerAction("Con_Condition_Group", "Insert", ActionPhase.After)]
        [ControllerAction("Con_Condition_Group", "Update", ActionPhase.After)]
        public void AfterInsertOrUpdate()
        {
            UpdateManyToManyField("Columns", "ConGroup_ID", "Con_Condition_Group_Column", "ConGroup_ID", "TableColumn_ID");
        }
        
        [ControllerAction("Con_Condition_Group", "Delete", ActionPhase.Before)]
        public void BeforeDelete()
        {
            ClearManyToManyField("Columns", "ConGroup_ID", "Con_Condition_Group_Column", "ConGroup_ID", "TableColumn_ID");
        }
    }
}

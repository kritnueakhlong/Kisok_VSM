﻿using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using VSM.Data;

namespace VSM.Web
{
	[TargetControlType(typeof(HtmlGenericControl))]
    [ToolboxItem(false)]
    public class MembershipManagerExtender : AquariumExtenderBase
    {
        
        public MembershipManagerExtender() : 
                base("Web.MembershipManager")
        {
        }
        
        protected override void ConfigureDescriptor(ScriptBehaviorDescriptor descriptor)
        {
        }
        
        protected override void ConfigureScripts(List<ScriptReference> scripts)
        {
            if (EnableCombinedScript)
            	return;
            scripts.Add(CreateScriptReference("~/Scripts/Web.MembershipResources.js"));
            scripts.Add(CreateScriptReference("~/Scripts/Web.MembershipManager.js"));
        }
    }
}

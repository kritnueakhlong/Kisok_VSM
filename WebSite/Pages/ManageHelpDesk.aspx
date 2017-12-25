<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="ManageHelpDesk.aspx.cs" Inherits="Pages_ManageHelpDesk"  Title="^Page_Manage_HelpDesk^Manage Help Desk^Page_Manage_HelpDesk^" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">^Page_Manage_HelpDesk^Manage Help Desk^Page_Manage_HelpDesk^</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div data-activator="Tab|^Page_HelpDesk_view1^Manage Help Desk^Page_HelpDesk_view1^">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="HelpDesk" view="grid1" ShowInSummary="True" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows help desk management.</div>
    </div>
  </div>
</asp:Content>
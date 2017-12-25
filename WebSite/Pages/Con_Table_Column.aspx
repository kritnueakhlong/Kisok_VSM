<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="Con_Table_Column.aspx.cs" Inherits="Pages_Con_Table_Column"  Title="Con Table Column" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Con Table Column</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="Tab|Con Table Column">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Con_Table_Column" view="grid1" ShowInSummary="True" SelectionMode="Multiple" />
    </div>
    <div data-activator="Tab|Con Condition Group Column">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Con_Condition_Group_Column" view="grid1" FilterSource="view1Extender" FilterFields="TableColumn_ID" SelectionMode="Multiple" AutoHide="Self" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows con table column management.</div>
    </div>
  </div>
</asp:Content>
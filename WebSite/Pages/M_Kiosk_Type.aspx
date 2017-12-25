<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="M_Kiosk_Type.aspx.cs" Inherits="Pages_M_Kiosk_Type"  Title="M Kiosk Type" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">M Kiosk Type</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="M_Kiosk_Type" view="grid1" ShowInSummary="True" />
  </div>
  <div data-flow="row" style="padding-top:8px">
    <div data-activator="Tab|M Kiosk">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="M_Kiosk" view="grid1" FilterSource="view1Extender" FilterFields="KioskType_Code" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows m kiosk type management.</div>
    </div>
  </div>
</asp:Content>
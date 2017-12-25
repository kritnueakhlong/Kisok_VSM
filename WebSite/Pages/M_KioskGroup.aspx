<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="M_KioskGroup.aspx.cs" Inherits="Pages_M_KioskGroup"  Title="M Kiosk Group" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">M Kiosk Group</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="M_KioskGroup" view="grid1" ShowInSummary="True" />
  </div>
  <div data-flow="row" style="padding-top:8px">
    <div data-activator="Tab|M Kiosk Group Kiosk#">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="M_KioskGroup_KioskID" view="grid1" FilterSource="view1Extender" FilterFields="KioskGroup_ID" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|T Advertise Kiosk Group">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="T_Advertise_KioskGroup" view="grid1" FilterSource="view1Extender" FilterFields="KioskGroup_ID" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|T Contents Kiosk Group">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="T_Contents_KioskGroup" view="grid1" FilterSource="view1Extender" FilterFields="KioskGroup_ID" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows m kiosk group management.</div>
    </div>
  </div>
</asp:Content>
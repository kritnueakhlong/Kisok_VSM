<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="M_KioskOwner_Location.aspx.cs" Inherits="Pages_M_KioskOwner_Location"  Title="M Kiosk Owner Location" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">M Kiosk Owner Location</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="Tab|M Kiosk Owner Location">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="M_KioskOwner_Location" view="grid1" ShowInSummary="True" SelectionMode="Multiple" />
    </div>
    <div data-activator="Tab|M Kiosk">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="M_Kiosk" view="grid1" FilterSource="view1Extender" FilterFields="Location_ID" SelectionMode="Multiple" AutoHide="Self" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows m kiosk owner location management.</div>
    </div>
  </div>
</asp:Content>
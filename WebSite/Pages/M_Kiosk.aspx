<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="M_Kiosk.aspx.cs" Inherits="Pages_M_Kiosk"  Title="M Kiosk" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">M Kiosk</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="M_Kiosk" view="grid1" ShowInSummary="True" />
  </div>
  <div data-flow="row" style="padding-top:8px">
    <div data-activator="Tab|M Kiosk Material">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="M_Kiosk_Material" view="grid1" FilterSource="view1Extender" FilterFields="Kiosk_ID" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|M Kiosk Group Kiosk#">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="M_KioskGroup_KioskID" view="grid1" FilterSource="view1Extender" FilterFields="Kiosk_ID" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|M SSID Kiosk">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="M_SSID_Kiosk" view="grid1" FilterSource="view1Extender" FilterFields="Kiosk_ID" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|T Advertise Kiosk">
      <div id="view5" runat="server"></div>
      <aquarium:DataViewExtender id="view5Extender" runat="server" TargetControlID="view5" Controller="T_Advertise_Kiosk" view="grid1" FilterSource="view1Extender" FilterFields="Kiosk_ID" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|T Contents Kiosk">
      <div id="view6" runat="server"></div>
      <aquarium:DataViewExtender id="view6Extender" runat="server" TargetControlID="view6" Controller="T_Contents_Kiosk" view="grid1" FilterSource="view1Extender" FilterFields="Kiosk_ID" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|T Kiosk Signal">
      <div id="view7" runat="server"></div>
      <aquarium:DataViewExtender id="view7Extender" runat="server" TargetControlID="view7" Controller="T_Kiosk_Signal" view="grid1" FilterSource="view1Extender" FilterFields="Kiosk_ID" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|T Kiosk Usage">
      <div id="view8" runat="server"></div>
      <aquarium:DataViewExtender id="view8Extender" runat="server" TargetControlID="view8" Controller="T_Kiosk_Usage" view="grid1" FilterSource="view1Extender" FilterFields="Kiosk_ID" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows m kiosk management.</div>
    </div>
  </div>
</asp:Content>
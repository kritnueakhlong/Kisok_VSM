<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="M_Kiosk_Owner.aspx.cs" Inherits="Pages_M_Kiosk_Owner"  Title="M Kiosk Owner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">M Kiosk Owner</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="M_Kiosk_Owner" view="grid1" ShowInSummary="True" />
  </div>
  <div data-flow="row" style="padding-top:8px">
    <div data-activator="Tab|M Kiosk Owner Branch">
      <div id="view10" runat="server"></div>
      <aquarium:DataViewExtender id="view10Extender" runat="server" TargetControlID="view10" Controller="M_Kiosk_Owner_Branch" view="grid1" ShowInSummary="True" FilterSource="view1Extender" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|M Kiosk">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="M_Kiosk" view="grid1" FilterSource="view1Extender" FilterFields="KioskOwner_ID" PageSize="5" AutoHide="Self" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|M Kiosk Owner Location">
      <div id="view9" runat="server"></div>
      <aquarium:DataViewExtender id="view9Extender" runat="server" TargetControlID="view9" Controller="M_KioskOwner_Location" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="KioskOwner_ID" />
    </div>
    <div data-activator="Tab|M Kiosk Owner Radius Connection">
      <div id="view8" runat="server"></div>
      <aquarium:DataViewExtender id="view8Extender" runat="server" TargetControlID="view8" Controller="M_KioskOwner_Radius_Connection" view="grid1" FilterSource="view1Extender" FilterFields="KioskOwner_ID" SelectionMode="Multiple" AutoHide="Self" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|T Kiosk Owner MA">
      <div id="view7" runat="server"></div>
      <aquarium:DataViewExtender id="view7Extender" runat="server" TargetControlID="view7" Controller="T_KioskOwner_MA" view="" FilterSource="view1Extender" PageSize="5" AutoHide="Self" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|M Ssid">
      <div id="view5" runat="server"></div>
      <aquarium:DataViewExtender id="view5Extender" runat="server" TargetControlID="view5" Controller="M_SSID" view="grid1" FilterSource="view1Extender" FilterFields="KioskOwner_ID" PageSize="5" AutoHide="Self" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|T Advertise">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="T_Advertise" view="grid1" FilterSource="view1Extender" FilterFields="KioskOwner_ID" PageSize="5" AutoHide="Self" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|T Contents">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="T_Contents" view="grid1" FilterSource="view1Extender" FilterFields="KioskOwner_ID" PageSize="5" AutoHide="Self" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|M Kiosk Owner Config">
      <div id="view6" runat="server"></div>
      <aquarium:DataViewExtender id="view6Extender" runat="server" TargetControlID="view6" Controller="M_KioskOwner_Config" view="grid1" FilterSource="view1Extender" FilterFields="KioskOwner_ID" PageSize="5" AutoHide="Self" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows m kiosk owner management.</div>
    </div>
  </div>
</asp:Content>
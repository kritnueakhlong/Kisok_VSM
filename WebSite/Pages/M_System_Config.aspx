<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="M_System_Config.aspx.cs" Inherits="Pages_M_System_Config"  Title="^Page_M_System_Config^ตั้งค่า^Page_M_System_Config^" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">^Page_M_System_Config^ตั้งค่า^Page_M_System_Config^</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="M_System_Config" view="grid1" ShowInSummary="True" />
  </div>
  <div data-flow="row" style="padding-top:8px">
    <div data-activator="Tab|M Kiosk Owner Config">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="M_KioskOwner_Config" view="grid1" FilterSource="view1Extender" FilterFields="Config_ID" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows m system config management.</div>
    </div>
  </div>
</asp:Content>
<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="RPT_Kiosk_Usage.aspx.cs" Inherits="Pages_RPT_Kiosk_Usage"  Title="^Page_KioskUsage_Report^รายงานการใช้งาน kiosk ตามจุดต่างๆ^Page_KioskUsage_Report^" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">^Page_KioskUsage_Report^รายงานการใช้งาน kiosk ตามจุดต่างๆ^Page_KioskUsage_Report^</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="VW_RPT_Kiosk_Usage" view="" />
  </div>
  <div data-flow="row">
    <div data-activator="Tab|^Page_KioskUsage_Detail_Report^รายงานรายละเอียดการใช้งาน kiosk ตามจุดต่าง^Page_KioskUsage_Detail_Report^">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="VW_RPT_Kiosk_Usage_Detail" view="grid1" FilterSource="view1Extender" FilterFields="Kiosk_ID" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
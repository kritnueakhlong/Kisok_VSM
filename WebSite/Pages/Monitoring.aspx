<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="Monitoring.aspx.cs" Inherits="Pages_Monitoring"  Title="^Page_Kiosk_Monitoring^ตรวจสอบสถานะตู้ Kiosk^Page_Kiosk_Monitoring^" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">^Page_Kiosk_Monitoring^ตรวจสอบสถานะตู้ Kiosk^Page_Kiosk_Monitoring^</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="VW_Kiosk_Monitoring" view="" RefreshInterval="30" />
  </div>
</asp:Content>
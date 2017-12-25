<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="RPT_Log_Kiosk.aspx.cs" Inherits="Pages_RPT_Log_Kiosk"  Title="^Page_LogKiosk_Report^รายงานประวัติการใช้งานตู้ Kiosk^Page_LogKiosk_Report^" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">^Page_LogKiosk_Report^รายงานประวัติการใช้งานตู้ Kiosk^Page_LogKiosk_Report^</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="VW_RPT_Log_Kiosk" view="" />
  </div>
</asp:Content>
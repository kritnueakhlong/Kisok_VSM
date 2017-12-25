<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="RPT_Kiosk_Error.aspx.cs" Inherits="Pages_RPT_Kiosk_Error"  Title="^Page_KioskError_Report^รายงานปัญหาการใช้งาน^Page_KioskError_Report^" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">^Page_KioskError_Report^รายงานปัญหาการใช้งาน^Page_KioskError_Report^</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="VW_RPT_Kiosk_Error" view="" />
  </div>
</asp:Content>
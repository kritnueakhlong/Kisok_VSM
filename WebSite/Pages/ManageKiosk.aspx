<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="ManageKiosk.aspx.cs" Inherits="Pages_ManageKiosk"  Title="^Page_ManageKiosk^จัดการตู้ Kiosk^Page_ManageKiosk^" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">^Page_ManageKiosk^จัดการตู้ Kiosk^Page_ManageKiosk^</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="M_Kiosk" view="grid1" ShowInSummary="True" />
  </div>
</asp:Content>
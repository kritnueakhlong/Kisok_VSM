<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="Pages_test"  Title="test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">test</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div class="DataViewHeader">VW_RPT_Kiosk _Usage _Detail</div>
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="VW_RPT_Kiosk_Usage_Detail" view="grid1" FilterFields="Kiosk_ID" PageSize="5" ShowModalForms="True" />
  </div>
</asp:Content>
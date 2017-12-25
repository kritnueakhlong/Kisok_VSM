<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="RPT_OldCust.aspx.cs" Inherits="Pages_RPT_OldCust"  Title="^Page_OldCust_Report^รายงานการขอใช้งานลูกค้าเก่า^Page_OldCust_Report^" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">^Page_OldCust_Report^รายงานการขอใช้งานลูกค้าเก่า^Page_OldCust_Report^</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="VW_RPT_OldCustomer" view="" />
  </div>
  <div data-flow="row" style="padding-top:8px">
    <div data-activator="Tab|^Page_Old_Cust_Detail_Report^รายงานรายละเอียดการใช้งานของลูกค้าเก่า^Page_Old_Cust_Detail_Report^">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="VW_RPT_OldCustomer_Detail" view="grid1" FilterSource="view1Extender" FilterFields="Identity_ID" PageSize="5" AutoHide="Container" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
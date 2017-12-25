<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="RPT_Regis.aspx.cs" Inherits="Pages_RPT_Regis"  Title="^Page_Register_Report^รายงานการลงทะเบียนใหม่^Page_Register_Report^" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">^Page_Register_Report^รายงานการลงทะเบียนใหม่^Page_Register_Report^</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="VW_RPT_Register" view="" ShowInSummary="True" ShowModalForms="True" />
  </div>
</asp:Content>
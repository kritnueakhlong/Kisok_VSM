<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="VW_RPT_Kiosk_Usage_Detail.aspx.cs" Inherits="Pages_VW_RPT_Kiosk_Usage_Detail"  Title="VW RPT Kiosk Usage Detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">VW RPT Kiosk Usage Detail</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="Tab|VW RPT Kiosk Usage Detail">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="VW_RPT_Kiosk_Usage_Detail" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows vw rpt kiosk usage detail management.</div>
    </div>
  </div>
</asp:Content>
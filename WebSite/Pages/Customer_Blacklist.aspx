<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="Customer_Blacklist.aspx.cs" Inherits="Pages_Customer_Blacklist"  Title="^Page_Customer_Blacklist^รายการห้ามผู้ใช้งาน^Page_Customer_Blacklist^" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">^Page_Customer_Blacklist^รายการห้ามผู้ใช้งาน^Page_Customer_Blacklist^</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="T_Customer_Blacklist" view="grid1" ShowInSummary="True" ShowModalForms="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows t customer blacklist management.</div>
    </div>
  </div>
</asp:Content>
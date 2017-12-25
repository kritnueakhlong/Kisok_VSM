<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="Pages_User"  Title="^Page_User^จัดการผู้ใช้^Page_User^" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">^Page_User^จัดการผู้ใช้^Page_User^</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div data-activator="Tab|^Page_User_view1^User^Page_User_view1^">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Employee" view="grid1" ShowInSummary="True" />
    </div>
    <div data-activator="Tab|^Page_User_view2^User Roles^Page_User_view2^">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Employee_Roles" view="grid1" FilterSource="view1Extender" FilterFields="emp_id" AutoHide="Self" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows employee management.</div>
    </div>
  </div>
</asp:Content>
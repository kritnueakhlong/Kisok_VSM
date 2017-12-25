<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="EditUser.aspx.cs" Inherits="Pages_EditUser"  Title="^Page_EditUser^แก้ไขข้อมูล^Page_EditUser^" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">^Page_EditUser^แก้ไขข้อมูล^Page_EditUser^</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="EmployeeEdit" view="" />
  </div>
</asp:Content>
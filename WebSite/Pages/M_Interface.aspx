<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="M_Interface.aspx.cs" Inherits="Pages_M_Interface"  Title="M Interface" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">M Interface</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div data-activator="Tab|M Interface">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="M_Interface" view="grid1" ShowInSummary="True" SelectionMode="Multiple" />
    </div>
    <div data-activator="Tab|M Radius Server Interface">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="M_Radius_Server_Interface" view="grid1" FilterSource="view1Extender" FilterFields="Interface_Code" SelectionMode="Multiple" AutoHide="Self" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows m interface management.</div>
    </div>
  </div>
</asp:Content>
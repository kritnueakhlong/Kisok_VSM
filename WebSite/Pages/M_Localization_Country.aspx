﻿<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="M_Localization_Country.aspx.cs" Inherits="Pages_M_Localization_Country"  Title="M Localization Country" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">M Localization Country</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div data-activator="Tab|M Localization Country">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="M_Localization_Country" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows m localization country management.</div>
    </div>
  </div>
</asp:Content>
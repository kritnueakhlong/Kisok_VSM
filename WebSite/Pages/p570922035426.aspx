﻿<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="p570922035426.aspx.cs" Inherits="Pages_p570922035426"  Title="New Pages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">New Pages</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="false" StartFromCurrentNode="true" />
  <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" CssClass="TreeView" ImageSet="Simple" />
</asp:Content>
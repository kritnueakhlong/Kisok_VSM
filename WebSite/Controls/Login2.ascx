﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login2.ascx.cs" Inherits="Controls_Login" %>
<%@ Register Src="Welcome.ascx" TagName="Welcome" TagPrefix="uc1" %>
<div class="SettingsPanel">
    <asp:Login ID="Login1" runat="server" TitleText="" Style="border-collapse: separate;" OnLoggedIn="Login1_LoggedIn" >
    </asp:Login>
</div>
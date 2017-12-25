<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="Controls_Login"  %>
                  
<%@ Register Src="Welcome.ascx" TagName="Welcome" TagPrefix="uc1" %>
<div class="SettingsPanel">
    <asp:Login ID="Login1" runat="server" TitleText="" Style="border-collapse: separate;" OnLoggedIn="Login1_LoggedIn">
    </asp:Login>
    <%--<div style="width: 300px; margin: 20px -8px;">
        <uc1:Welcome ID="Welcome1" runat="server" />
    </div>--%>
</div>
                
              
<!-- custom login page for mobile devices -->
<script>
    (function () {
        if ($.mobile) {
            var resources = Web.MembershipResources.Messages;
            function performLogin() {
                var userName = $('#login-user-name'),
                    password = $('#login-password');
                if (!userName.val())
                    $appfactory.alert(resources.BlankUserName, function () {
                        userName.focus();
                    });
                else if (!password.val())
                    $appfactory.alert(resources.BlankPassword, function () {
                        password.focus();
                    });
                else
                    Sys.Services.AuthenticationService.login(userName.val(), password.val(), false, null, null,
                        function (validCredentials) {
                            if (!validCredentials) {
                                $appfactory.alert(resources.InvalidUserNameAndPassword, function () {
                                    userName.focus();
                                });
                            }
                            else {
                                var returnUrl = window.location.href.match(/\?ReturnUrl=(.+)$/);
                                window.location.replace(returnUrl && decodeURIComponent(returnUrl[1]) || '/');
                            }
                        })
            }
            // remove any other "app" pages 
            $('div.SettingsPanel div[data-app-role="page"]').remove();
            // register event handlers
            $(document)
                .on('vclick', '#login-button', performLogin)
                .on('keydown', '#login-user-name,#login-password', event, function () {
                    if (event.which == 13)
                        performLogin();
                });
            return false;
        };

    })();
</script>
<div id="app-login" data-app-role="page" data-theme="a" data-app-login="custom">
    <div data-role="content">
        <div class="ui-body ui-body-a ui-corner-all">
            <p>Login to this website:</p>
            <p>
                <input id="login-user-name" type="text" placeholder="User Name" />
                <input id="login-password" type="password" placeholder="Password" />
                <a id="login-button" href="#" class="ui-btn ui-btn-b ui-corner-all ui-shadow ui-btn-icon-left ui-icon-lock">Login</a>
            </p>
        </div>
    </div>
</div>

            
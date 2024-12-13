<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Connect_to_sqlserver_using_sqlclient_provider.aspx.cs" Inherits="ADOdotnet_With_ASPdotnet.Connect_to_sqlserver_using_sqlclient_provider" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="position: relative">
    <form id="form1" runat="server">
        <div>
            <center style="position: relative">
                <asp:Button ID="btn_connect" runat="server" Text="Connection" OnClick="btn_connect_Click" />
                <br />
                <asp:Label ID="lbl_message" runat="server"></asp:Label>
            </center>
        </div>
    </form>
</body>
</html>

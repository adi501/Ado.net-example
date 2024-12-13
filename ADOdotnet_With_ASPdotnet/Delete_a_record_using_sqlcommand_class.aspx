<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete_a_record_using_sqlcommand_class.aspx.cs" Inherits="ADOdotnet_With_ASPdotnet.Delete_a_record_using_sqlcommand_class" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
            <asp:Button ID="btn_delete" runat="server" Text="Delete" OnClick="btn_delete_Click" /><br />
                <asp:Label ID="lbl_msg" runat="server" ></asp:Label>
            </center>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete_a_record_by_using_the_non_parameterized_query.aspx.cs" Inherits="ADOdotnet_With_ASPdotnet.Delete_a_record_by_using_the_non_parameterized_query" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <table>
                    <tr>
                        <td>Emp ID:</td>
                        <td><asp:TextBox ID="txt_emp_id" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:Button ID="btn_delete" runat="server" Text="Delete" OnClick="btn_delete_Click" /></td>
                    </tr>
                </table>
                <asp:Label ID="lbl_msg" runat="server"></asp:Label>
            </center>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SMS.aspx.cs" Inherits="SMS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        From Email Address:<asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
        <div id="rt" runat="server"></div>
            Country Code:<asp:TextBox ID="txtCntCode" runat="server"></asp:TextBox>
        <div id="Div1" runat="server"></div>

        SendSMS Number:<asp:TextBox ID="txtTo" runat="server"></asp:TextBox>
        <div id="Div2" runat="server"></div>

        SendSMS Message:<asp:TextBox ID="txtMessage" runat="server"></asp:TextBox>
    <asp:Button ID="btn" runat="server" Text="Send Text" onclick="btn_Click" /><br />
    <div id="Div3" runat="server"></div>

    </div>
    </form>
</body>
</html>

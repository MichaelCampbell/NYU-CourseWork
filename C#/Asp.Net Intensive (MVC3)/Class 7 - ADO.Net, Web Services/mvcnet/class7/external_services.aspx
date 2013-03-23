<%@ Page Language="C#" AutoEventWireup="true" CodeFile="external_services.aspx.cs" Inherits="class7_external_services" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Get Zip Info:<asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
    <asp:Button ID="btn" runat="server" Text="get zip info" onclick="btn_Click" /><br />
    <div id="rt" runat="server"></div>
    </div>
    </form>
</body>
</html>

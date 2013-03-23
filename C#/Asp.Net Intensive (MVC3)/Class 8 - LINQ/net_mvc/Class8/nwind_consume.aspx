<%@ Page Language="C#" AutoEventWireup="true" CodeFile="nwind_consume.aspx.cs" Inherits="Class8_nwind_consume" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Working with Web Services</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Customer ID:"></asp:Label>
        <asp:TextBox ID="txtID" runat="server" Width="210px"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Company Name:"></asp:Label>
        <asp:TextBox ID="txtCompanyName" runat="server" Width="184px"></asp:TextBox><br />
        <asp:Button ID="btnInsert" runat="server" Text="insert" OnClick="btnInsert_Click" /><br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>

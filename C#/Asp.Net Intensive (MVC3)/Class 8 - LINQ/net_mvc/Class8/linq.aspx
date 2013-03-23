<%@ Page Language="C#" AutoEventWireup="true" CodeFile="linq.aspx.cs" Inherits="Class8_LINQ" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Update" />
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Insert" />
    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Delete" />
    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="SP" />
    </div>
    </form>
</body>
</html>

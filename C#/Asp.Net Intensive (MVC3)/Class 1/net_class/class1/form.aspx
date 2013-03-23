<%@ Page Language="C#" AutoEventWireup="true" CodeFile="form.aspx.cs" Inherits="class1_form" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    First Name:<input type="text" name="txtFirst" id="txtFirst" size="10" maxlength="10" title="Please type your first name here." value="George" readonly /><br />
    Password:<input type="password" name="txtPassword" id="txtPassword" size="10" maxlength="10" title="Please type your password here." /><br />
    <%--Comment--%>:
    </div>
    </form>
</body>
</html>

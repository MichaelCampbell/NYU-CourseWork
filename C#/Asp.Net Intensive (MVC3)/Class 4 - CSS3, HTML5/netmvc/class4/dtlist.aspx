<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/class4/dtlist.aspx.cs" Inherits="class4_dtlist" %>
<head>
    <title>Data Driven Datalists</title>
    <style>
        body
        {
            font-family:Verdana;
            font-size:smaller;
        }
        input
        {
            font-family: "Helvetica Neue" , Helvetica, Arial, sans-serif;
            border: 1px solid #ccc;
            font-size: 12px;
            width: 300px;
            min-height: 18px;
            display: block;
            margin-bottom: 15px;
            margin-top: 5px;
            outline: none;
            -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            -o-border-radius: 5px;
            -ms-border-radius: 5px;
            border-radius: 5px;
        }
        
        label
        {
            font-weight:bold;
        }
    </style>
</head>
<body>
    <form id="Form1" runat="server">
    <fieldset>
        <legend>DB Driven Datalist</legend>
        <label>Customers:</label>
        <input id=title type=text list=mylist />
        <div id="dl" runat="server" />
        <input type="submit" value="submit" /><br />
        <div id="err" runat="server" />
    </fieldset>
    </form>
</body>
</html>
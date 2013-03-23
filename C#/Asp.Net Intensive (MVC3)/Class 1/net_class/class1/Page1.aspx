<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="class1_Page1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <h1>Testing testing....</h1>
            <p>Some Text here</p>
            <h2>Testing testing....</h2>
            <p>Some Text here</p>
            <h3>Testing testing....</h3>
            <p>Some Text here</p>
            <h4>Testing testing....</h4>
            <p>Some Text here</p>
            <h5>Testing testing....</h5>
            <p>Some Text here</p>
            <h6>Testing testing....</h6>
        </div>
        <div id="lists">
            <h2>HTML Lists</h2>
            <b>Highest Paid Movie Stars</b>
            <ol>
            <li>Tom Hanks</li>
            <li>Will Smith</li>
                <ul>
                    <li>Independence Day</li>
                    <li>I Robot</li>
                    <li>I am Legend</li>
                </ul>
            <li>Cameron Diaz</li>
            </ol>
        </div>
        <div id="links">
            <h3>Simple Links</h3>
            <a href="http://www.dell.com">Dell</a><br />
            <a href="http://www.bestbuy.com">BestBuy</a><br />
            <a href="http://www.ebay.com" tabindex="2">eBay</a><br />
            <a href="http://www.msn.com" tabindex="1">MSN</a><br />
            
            <h3>Absolute Path Links</h3>
            <a href="http://localhost:49429/net_class/class1/Default3.aspx">Default3</a><br />
            <a href="http://localhost:49429/net_class/link/Default.aspx">Default</a><br />
            <a href="http://localhost:49429/net_class/link/Default2.aspx">Default2</a><br />
            
            <h3>Relative Path Links</h3>
            <a href="Default3.aspx">Default3</a><br />
            <a href="../link/Default.aspx">Default</a><br />
            <a href="../link/Default2.aspx">Default2</a><br />

            <h3>Querystring Links</h3>
            <a href="http://finance.yahoo.com/q?s=aapl">Apple's Closing Price</a><br />
            <a href="http://finance.yahoo.com/q?s=gm+f">US Car Manufacturers</a><br />
            <a href="http://finance.yahoo.com/q?s=c+jpm+bac">Banks</a><br />
        </div>

        <div id="tables">
        <table border="1" width="400" align="center" cellpadding="0" cellspacing="0" bgcolor="aqua">
        <caption>My first simple table</caption>
        <tr>
            <td>Row 1 Cell 1</td>
            <td>Row 1 Cell 2</td>
            <td>Row 1 Cell 3</td>
        </tr>
        <tr>
            <td>Row 2 Cell 1</td>
            <td>Row 2 Cell 2</td>
            <td>Row 2 Cell 3</td>
        </tr>
        <tr>
            <td>Row 3 Cell 1</td>
            <td>Row 3 Cell 2</td>
            <td>Row 3 Cell 3</td>
        </tr>        
        
        
        </table>
        </div>
    </div>
    </form>
</body>
</html>

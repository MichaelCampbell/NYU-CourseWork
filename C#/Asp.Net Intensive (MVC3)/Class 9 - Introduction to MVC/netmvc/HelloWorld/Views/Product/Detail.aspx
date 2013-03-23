<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<HelloWorld.Models.Product>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Detail</title>
</head>
<body>
    <div>
        <fieldset id = "Product">
            <legend>Product Details</legend>
            <%=Html.LabelFor(m=>m.Id) %> : <%=Model.Id %>
                <br />
            Name : <%=Html.TextBoxFor(m=>m.Name)%><br />
            Price : <%=Model.Price%><br />
        </fieldset>
    <%=Html.ActionLink("Back", "Index") %>
    </div>
</body>
</html>

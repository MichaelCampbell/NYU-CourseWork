<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Detail</title>
</head>
<body>
    <div>
        <fieldset id = "Car">
            <legend>Car Details</legend>
            Make: <%=Model.Make %> <br />
            Model: <%=Model.Model %> <br />
            Year: <%=Model.Year %> <br />
            Price: <%=Model.Price %> <br />
        </fieldset>
        <%=Html.ActionLink("Back", "Index") %>
    </div>
</body>
</html>

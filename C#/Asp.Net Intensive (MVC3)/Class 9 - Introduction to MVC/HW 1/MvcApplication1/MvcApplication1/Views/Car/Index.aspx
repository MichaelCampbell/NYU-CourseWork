<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<List<MvcApplication1.Models.Car>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<body>
    <div>
        <ul id="Make">
            <%foreach (var i in Model)
              {%>

                <li>
                <%=Html.ActionLink(i.Make, "Detail", new { make = i.Make })%>
                    <a href="Car/Details/<%=i.Make %>">
<%--                    <%=i.Make%>--%>
                    </a>
                </li>
            <%} %>
        </ul>
    </div>
</body>
</html>

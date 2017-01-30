<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Test_MVC.Models.Movie>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Create</title>
</head>
<body>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Id) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Id) %>
                <%: Html.ValidationMessageFor(model => model.Id) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Title) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Title) %>
                <%: Html.ValidationMessageFor(model => model.Title) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ReleaseYear) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.ReleaseYear) %>
                <%: Html.ValidationMessageFor(model => model.ReleaseYear) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Runtime) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Runtime) %>
                <%: Html.ValidationMessageFor(model => model.Runtime) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</body>
</html>


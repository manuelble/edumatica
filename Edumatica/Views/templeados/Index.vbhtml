@ModelType IEnumerable(Of Edumatica.templeados)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.direccion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.telefono)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tdepartamento.descripcion)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.direccion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.telefono)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.tdepartamento.descripcion)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id })
        </td>
    </tr>
Next

</table>

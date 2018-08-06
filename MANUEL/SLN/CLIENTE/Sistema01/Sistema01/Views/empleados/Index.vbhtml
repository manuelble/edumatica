@ModelType IEnumerable(Of Sistema01.empleados)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    <button id="Create" onclick="popupEmployeeCreate()" class="btn btn-primary btn-large fa fa-trash">Nuevo registro</button>
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Direccion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Telefono)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.departamentos.Descripcion)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Nombre)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Direccion)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Telefono)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.departamentos.Descripcion)
            </td>
            <td>
                <button id="edit" onclick="popupDepartmentsEdit(@item.idempleados)" class="btn btn-primary btn-sm" style="color:darkblue;font-weight:bold"><i class="fa fa-pencil-square-o" aria-hidden="true"></i> Modificar </button>
                <button id="details" onclick="popupDepartmentsDetails(@item.idempleados)" class="btn btn-success btn-sm" style="color:lawngreen;font-weight:bold"><i class="fa fa-info" aria-hidden="true"></i> Detalle </button>
                <button id="delete" onclick="popupDepartmentsDelete(@item.idempleados)" class="btn btn-danger btn-sm" style="color:darkred;font-weight:bold"><i class="fa fa-trash-o" aria-hidden="true"></i> Eliminar </button>
            </td>
        </tr>
    Next

</table>

<script src="~/Scripts/modals.js"></script>
<link href="~/Content/bootstrap.min.css" rel="stylesheet" />
<link href="~/Content/bootstrap.css" rel="stylesheet" />
<link href="~/Content/font-awesome.css" rel="stylesheet" />
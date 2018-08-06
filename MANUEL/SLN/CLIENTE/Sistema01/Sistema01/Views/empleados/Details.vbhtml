@ModelType Sistema01.empleados
@Code
    ViewData("Title") = "Details"
End Code

<div>
    <h4>Empleados</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Direccion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Direccion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Telefono)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Telefono)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.departamentos.Descripcion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.departamentos.Descripcion)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Regresar", "Index")
</p>

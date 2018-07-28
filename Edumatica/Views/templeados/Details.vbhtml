@ModelType Edumatica.templeados
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>templeados</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.direccion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.direccion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.telefono)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.telefono)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tdepartamento.descripcion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tdepartamento.descripcion)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>

@ModelType Edumatica.templeados
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>

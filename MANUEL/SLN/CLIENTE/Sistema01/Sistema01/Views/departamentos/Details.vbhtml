@ModelType Sistema01.departamentos
@Code
    ViewData("Title") = "Details"
End Code


<div>
    <h4>Departamentos</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Descripcion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Descripcion)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Regresar", "Index")
</p>

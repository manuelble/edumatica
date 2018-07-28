@ModelType Edumatica.tdepartamento
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>tdepartamento</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.descripcion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.descripcion)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>

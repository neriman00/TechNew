@model $rootnamespace$.Models.Product

@{
    ViewBag.Title = "Details";
}

<h2 class="mb-5">Details</h2>

<div>
    <h4>Product</h4>
    <hr />
    <dl class="row">
        <dt class="col-4">
            @Html.DisplayNameFor(model => model.Category.Name)
        </dt>

        <dd class="col-8">
            @Html.DisplayFor(model => model.Category.Name)
        </dd>

        <dt class="col-4">
            @Html.DisplayNameFor(model => model.Name)
        </dt>

        <dd class="col-8">
            @Html.DisplayFor(model => model.Name)
        </dd>

        <dt class="col-4">
            @Html.DisplayNameFor(model => model.Amount)
        </dt>

        <dd class="col-8">
            @Html.DisplayFor(model => model.Amount)
        </dd>

        <dt class="col-4">
            @Html.DisplayNameFor(model => model.Price)
        </dt>

        <dd class="col-8">
            @Html.DisplayFor(model => model.Price)
        </dd>

    </dl>
</div>
<p>
    <a href="@Url.Action("Edit",new { Model.Id })" class="btn btn-warning"><span class="fa fa-pencil"></span> Edit</a> @Html.ActionLink("Back to List", "Index", null, new { @class = "btn btn-secondary" })
</p>

@model $rootnamespace$.Models.Product

@{
    ViewBag.Title = "Edit";
}

<h2 class="mb-5">Edit</h2>

@using (Html.BeginForm())
{
    @Html.AntiForgeryToken()
    
    <div class="form-horizontal">
        <h4>Product</h4>
        <hr />
        @Html.ValidationSummary(true, "", new { @class = "text-danger" })
        @Html.HiddenFor(model => model.Id)

        <div class="form-group row">
            @Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "col-form-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } })
                @Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" })
            </div>
        </div>

        <div class="form-group row">
            @Html.LabelFor(model => model.Amount, htmlAttributes: new { @class = "col-form-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(model => model.Amount, new { htmlAttributes = new { @class = "form-control" } })
                @Html.ValidationMessageFor(model => model.Amount, "", new { @class = "text-danger" })
            </div>
        </div>

        <div class="form-group row">
            @Html.LabelFor(model => model.Price, htmlAttributes: new { @class = "col-form-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(model => model.Price, new { htmlAttributes = new { @class = "form-control" } })
                @Html.ValidationMessageFor(model => model.Price, "", new { @class = "text-danger" })
            </div>
        </div>

        <div class="form-group row">
            @Html.LabelFor(model => model.CategoryId, "CategoryId", htmlAttributes: new { @class = "col-form-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("CategoryId", null, htmlAttributes: new { @class = "form-control" })
                @Html.ValidationMessageFor(model => model.CategoryId, "", new { @class = "text-danger" })
            </div>
        </div>

        <div class="form-group row">
            <div class="offset-md-2 col-md-10">
                <button type="submit" class="btn btn-warning"><span class="fa fa-save"></span> Save</button> @Html.ActionLink("Back to List", "Index", null, new { @class = "btn btn-secondary" })
            </div>
        </div>
    </div>
}

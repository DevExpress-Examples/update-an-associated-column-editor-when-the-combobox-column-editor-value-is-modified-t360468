<script type="text/javascript">
    function OnSelectedIndexChanged(s, e) {
        $.ajax({
            url: '@Url.Action("HiddenColumnCallbackActionMethod")',
            type: "POST",
            dataType: "text",
            data: { categoryID: s.GetValue() },
            success: function (data) {
                GridView.GetEditor('ProductName').SetValue(data);
            },
            error: function (xhr, textStatus, errorThrown) {
                alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
            }
        });

    }
</script>

@Html.Action("GridViewPartial", New With {.hiddenColumnScenario = True})
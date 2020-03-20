$(function () {
    $("#designatorTable").dataTable({
        ajax: {
            type: "GET",
            contentType: "application/json",
            url: "/api/Designator",
            dataSrc: function (result) {
                return result;
            }
        },
        columns: [
            { title: "DesignatorId", data: "designatorId" },
            { title: "Nomenclature", data: "nomenclature" },
            {
                title: "", data: "designatorId", render: function (data) {
                    return '<a href="/Designator/' + data + '" class="btn btn-primary">View</a>';
                }
            }
        ]
    });
});
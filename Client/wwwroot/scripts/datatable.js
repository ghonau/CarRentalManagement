function AddDataTable(table) {
    $(document).ready(function () {
        $(table).DataTable();
    })
}

function DisposeDataTable(table) {
    $(document).ready(function () {
        $(table).DataTable().destroy();
        element = document.querySelector(table + "_wrapper");
        element.parentNode.removeChild(element); 
    })
}
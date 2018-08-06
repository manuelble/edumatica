function popupEmployeeEdit(employeeid) {

    $.ajax({
        type: 'get',
        url: '/empleados/Edit/',
        data: {
            'id': employeeid
        },
        success: function (response) {
            //$("#contenedor").html(response);
            $("#show-modal").modal({ show: true, keyboard: false })
            $("#inner-show-modal").html(response);

        },
        error: function () {
            alert("error");
        }
    });

    //$("#contenedor").html("<span style='color:green;'>Texto de Alonso</span>");

};

function popupEmployeeDetails(employeeid) {

    $.ajax({
        type: 'get',
        url: '/empleados/Details/',
        data: {
            'id': employeeid
        },
        success: function (response) {
            //$("#contenedor").html(response);
            $("#show-modal").modal({ show: true, keyboard: false })
            $("#inner-show-modal").html(response);

        },
        error: function () {
            alert("error");
        }
    });

    //$("#contenedor").html("<span style='color:green;'>Texto de Alonso</span>");

};

function popupEmployeeDelete(employeeid) {

    $.ajax({
        type: 'get',
        url: '/empleados/Delete/',
        data: {
            'id': employeeid
        },
        success: function (response) {
            //$("#contenedor").html(response);
            $("#show-modal").modal({ show: true, keyboard: false })
            $("#inner-show-modal").html(response);

        },
        error: function () {
            alert("error");
        }
    });

    //$("#contenedor").html("<span style='color:green;'>Texto de Alonso</span>");

};

function popupEmployeeCreate() {

    $.ajax({
        type: 'get',
        url: '/empleados/Create/',
        data: {
        },
        success: function (response) {
            //$("#contenedor").html(response);
            $("#show-modal").modal({ show: true, keyboard: false })
            $("#inner-show-modal").html(response);

        },
        error: function () {
            alert("error");
        }
    });

    //$("#contenedor").html("<span style='color:green;'>Texto de Alonso</span>");

};



function popupDepartmentsEdit(departmentid) {

    $.ajax({
        type: 'get',
        url: '/departamentos/Edit/',
        data: {
            'id': departmentid
        },
        success: function (response) {
            //$("#contenedor").html(response);
            $("#show-modal").modal({ show: true, keyboard: false })
            $("#inner-show-modal").html(response);

        },
        error: function () {
            alert("error");
        }
    });

    //$("#contenedor").html("<span style='color:green;'>Texto de Alonso</span>");

};

function popupDepartmentsDetails(departmentid) {

    $.ajax({
        type: 'get',
        url: '/departamentos/Details/',
        data: {
            'id': departmentid
        },
        success: function (response) {
            //$("#contenedor").html(response);
            $("#show-modal").modal({ show: true, keyboard: false })
            $("#inner-show-modal").html(response);

        },
        error: function () {
            alert("error");
        }
    });

    //$("#contenedor").html("<span style='color:green;'>Texto de Alonso</span>");

};

function popupDepartmentsDelete(departmentid) {

    $.ajax({
        type: 'get',
        url: '/departamentos/Delete/',
        data: {
            'id': departmentid
        },
        success: function (response) {
            //$("#contenedor").html(response);
            $("#show-modal").modal({ show: true, keyboard: false })
            $("#inner-show-modal").html(response);

        },
        error: function () {
            alert("error");
        }
    });

    //$("#contenedor").html("<span style='color:green;'>Texto de Alonso</span>");

};

function popupDepartmentsCreate() {

    $.ajax({
        type: 'get',
        url: '/departamentos/Create',
        data: {
        },
        success: function (response) {
            //$("#contenedor").html(response);
            $("#show-modal").modal({ show: true, keyboard: false })
            $("#inner-show-modal").html(response);

        },
        error: function () {
            alert("error");
        }
    });

    //$("#contenedor").html("<span style='color:green;'>Texto de Alonso</span>");

};

//442 447 86 61 Alejandro Ramirez

function GetEmployees() {
    //alert($("#department_id").val())
    $.ajax({
        type: 'get',
        dataType: "json",
        url: '/Service/Index',
        data: {
            'department_id': $("#department_id").val()
        },
        success: function (response) {
            //$("#contenedor").html(response);
            //$("#show-modal").modal({ show: true, keyboard: false })
            //$("#inner-show-modal").html(response);
            //var json = $.parseJSON(response);
            //alert(response);

            var tabla = "";
            tabla = "<table class='table'><tr><th>Nombre</th><th>Domicilio</th><th>Telefono</th></tr>";
            $.each(response, function (index, value) {
                tabla = tabla.concat("<tr>");
                tabla = tabla.concat("<td>" + value.nombre + "</td>");
                tabla = tabla.concat("<td>" + value.direccion + "</td>");
                tabla = tabla.concat("<td>" + value.telefono + "</td>");
                tabla = tabla.concat("</tr>");

            })

            tabla = tabla.concat("</table>");
            //alert(tabla);
            $("#show-modal").modal({ show: true, keyboard: false })
            $("#inner-show-modal").html(tabla);

        },
        error: function () {
            alert("error");
        }
    });

    //$("#contenedor").html("<span style='color:green;'>Texto de Alonso</span>");

};



window.onload = function () {

    var dataPoints = [];

    var chart = new CanvasJS.Chart("chartContainer", {
        animationEnabled: true,
        theme: "light2",
        title: {
            text: "Reporte de Ventas Diarias"
        },
        axisY: {
            title: "Unidades",
            titleFontSize: 24
        },
        data: [{
            type: "column",
            yValueFormatString: "#,### Units",
            dataPoints: dataPoints
        }]
    });

    /* function addData(data) {
         for (var i = 0; i < data.length; i++) {
             dataPoints.push({
                 x: new Date(data[i].date),
                 y: data[i].units
             });
         }
         chart.render();
     }*/



    $.ajax({
        type: 'GET',
        url: 'http://localhost:50221/Service/DataG',
        dataType: "json",
        success: function (response) {
            //alert(response)
            $.each(response, function (idx, value) {
                dataPoints.push({
                    x: new Date(value.date),
                    y: value.units
                });
            });
            chart.render();
        },
        error: function () {
            alert("error");
        }
    });





    //$.getJSON("https://canvasjs.com/data/gallery/javascript/daily-sales-data.json", addData);
    //$.getJSON("http://localhost:50221/Service/DataG", addData);


}
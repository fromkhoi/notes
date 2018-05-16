$(function(){
    $("#id").DataTable({
      "ajax": '@Url.Action("acction","controller")',
      "columns": [
                      {"data": "scheduleId"},
                       {"data":"scheduleName"}
      ]
    });
  })
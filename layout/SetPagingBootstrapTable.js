// set paging
$('#idtable').bootstrapTable('getOptions').pageNumber
table.fnPageChange(parseInt("pageNumberVal"));
table.page("số-trang").draw('page') // set số trang. draw('true') draw('false')

// "displayStart": số-trang,
// "deferLoading": true // trì hoãn đến lần vẽ thứ 2
// "paging": true
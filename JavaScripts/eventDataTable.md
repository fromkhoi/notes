$('#id-of-table').on('draw.dt', function() {
    // do action here
});

$('#example')
        .on( 'order.dt',  function () { console.log('Order' ); } )
        .on( 'search.dt', function () {console.log('Search' ); } )
        .on( 'page.dt',   function () { console.log('Page' ); } )
        .dataTable();

$('#example').on( 'length.dt', function ( e, settings, len ) {
    console.log( 'New page length: '+len );
} );
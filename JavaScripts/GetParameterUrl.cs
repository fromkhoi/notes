public static getQueryString(paramUrl: any) {
    var key = paramUrl, res = {}, itm = null;
    // get the query string without the ?
    var qs = location.search.substring(1);
    // make a regex pattern to grab key/value
    var pattern = /([^&=]+)=([^&]*)/g;
    // loop the items in the query string, either
    // find a match to the argument, or build an object
    // with key/value pairs
    while (itm = pattern.exec(qs)) {
    if (key !== false && decodeURIComponent(itm[1]) === key)
    return decodeURIComponent(itm[2]);
    else if (key === false)
    res[decodeURIComponent(itm[1])] = decodeURIComponent(itm[2]);
    }
    
        return key === false ? res : null;
}

// Use
var url = new URL(window.location.href);
var backVal = url.searchParams.get("back");


// *React
    //Declare befor constructor
    private isBack : any;
    
    // bind handler
    this.isBack = Utils.getQueryString("back");

    // use
    if(this.isBack == "True"){
            sortName = localStorage.getItem("sort-name");
            temp = localStorage.getItem("sort-order");
            sortOrder = temp as SortOrder;
    }
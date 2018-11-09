import { ajax } from "jquery";
class Utils {
  /**
   * Checking if a string is empty, blank, null,  undefined
   * @param str
   */
  public static isNullOrEmpty(str: string): boolean {
    return (!str || 0 === str.length) || (!str || /^\s*$/.test(str));
  }

  public static uuid(): string {
    /*jshint bitwise:false */
    let i: number;
    let random: number;
    let uuid: string = '';

    for (i = 0; i < 32; i++) {
      random = Math.random() * 16 | 0;
      if (i === 8 || i === 12 || i === 16 || i === 20) {
        uuid += '-';
      }
      uuid += (i === 12 ? 4 : (i === 16 ? (random & 3 | 8) : random))
        .toString(16);
    }

    return uuid;
  }

  public static getTraslateValue(reference: any, key: string): string {
    if (reference == null || !reference.state.loadSuccess) {
      return "Loading...";
    }

    return reference.getValue(key);
  }

  public static uploadFile(url: string, files: any[], callbackSuccess?: Function, callbackError?: Function): void {
    var formData = new FormData();
    for (var i = 0; i < files.length; i++) {
      var file = files[i];
      formData.append("FileUpload", file);
    }

    ajax({
      url: url,
      type: 'POST',
      data: formData,
      cache: false,
      dataType: 'json',
      processData: false, // Don't process the files
      contentType: false, // Set content type to false as jQuery will tell the server its a query string request
      success: function (data, textStatus, jqXHR) {
        if (callbackSuccess != null) {
          callbackSuccess(data, textStatus, jqXHR);
        }
      },
      error: function (jqXHR, textStatus, errorThrown) {
        if (callbackError != null) {
          callbackError(jqXHR, textStatus, errorThrown);
        }
      }
    });
  }

  public static checkValidation(controls: any[]): boolean {
    let isValid: boolean = true;
    for (let i = 0; i < controls.length; i++) {
      let control = controls[i];
      if (control != null) {
        if (control.triggerChange() == "error") {
          isValid = false;
        }
      }
    }

    return isValid;
  }

  public static stringFormat(strValue: string, value: any[]): string {
    let result = strValue;
    for (var i = 0; i < value.length; i++) {
      var reg = new RegExp("\\{" + i + "\\}", "gm");
      result = result.replace(reg, value[i]);
    }

    return result;
  }

  public static getQueryString(param: any) {
    let res = {}, itm = null;
    var qs = location.search.substring(1);
    var pattern = /([^&=]+)=([^&]*)/g;

    while (itm = pattern.exec(qs)) {
      if (param !== false && decodeURIComponent(itm[1]) === param)
        return decodeURIComponent(itm[2]);
      else if (param === false)
        res[decodeURIComponent(itm[1])] = decodeURIComponent(itm[2]);
    }

    return param === false ? res : null;
  }

}

function loadSelectTable(columnTextCheck: string, event: any) {
    document.onselectstart = function () { return false; };

    let classListSelect;
    let trList = document.getElementsByClassName('tr-table');
    if (event.target.parentNode.classList.contains('tr-table')) {
        classListSelect = event.target.parentNode.classList;
    }
    else {
        classListSelect = event.target.parentNode.parentNode.classList;
    }

    switch (true) {
        case event.ctrlKey:
            ctrlKeySelect(trList, classListSelect);

            break;
        case event.shiftKey:
              var indexOld = null;
              var indexNew = 0;
              for (var i = 0, length = trList.length; i < trList.length; i++) {
                  if (trList[i].classList.contains('old')) {
                      indexOld = i;
                  }

                  var columnText = trList[i].childNodes[1].textContent;
                  if (columnText == columnTextCheck) {
                      indexNew = i;
                  }

                  trList[i].classList.remove('selected');
              }

              if (!indexOld){
                  leftMouseSelect(trList, classListSelect);

                  break;
              }

              var indexes = [indexOld, indexNew];
              shiftKeySelect(indexes, trList);

              break;
        default:
            leftMouseSelect(trList, classListSelect);

            break;
    }
}

// #region private function in loadSelectTable.

function ctrlKeySelect(trList: any, classListSelect: any) {
    for (var i = 0, length = trList.length; i < trList.length; i++) {
        trList[i].classList.remove('old');
    }

    if (classListSelect.contains('selected')) {
        classListSelect.remove('selected');
    }
    else {
        classListSelect.add('selected');
        classListSelect.add('old');
    }
}

function shiftKeySelect(indexes: any, trList: any) {
    indexes.sort(function (a, b) {
        return a - b;
    });

    for (var indexselect = indexes[0]; indexselect <= indexes[1]; indexselect++) {
        trList[indexselect].classList.add('selected');
    }
}

function leftMouseSelect(trList: any, classListSelect: any) {
    //if (classListSelect.contains('selected')) {

    //}

    //for (var i = 0, length = trList.length; i < trList.length; i++) {
    //    if (trList[i].classList.contains('selected')) { 
    //        shiftBefore += 1;
    //    }

    //    trList[i].classList.remove('selected');
    //    trList[i].classList.remove('old');
    //}

    //classListSelect.add('selected');
    //classListSelect.add('old');


    let shiftBefore = 0;
    for (var i = 0, length = trList.length; i < trList.length; i++) {
        if (trList[i].classList.contains('selected')) {
            shiftBefore += 1;
        }
    }

    //if (shiftBefore != 1) {
    //    for (var i = 0, length = trList.length; i < trList.length; i++) {
    //        trList[i].classList.remove('selected');
    //        trList[i].classList.remove('old');
    //    }

    //    classListSelect.add('selected');
    //    classListSelect.add('old');
    //}
    //else {
    //    if (classListSelect.contains('selected')) {
    //        classListSelect.remove('selected');
    //    }
    //    else {
    //        for (var i = 0, length = trList.length; i < trList.length; i++) {
    //            trList[i].classList.remove('selected');
    //            trList[i].classList.remove('old');
    //        }

    //        classListSelect.add('selected');
    //        classListSelect.add('old');
    //    }
    //}

    if (classListSelect.contains('selected') && shiftBefore == 1) {
        classListSelect.remove('selected');
        classListSelect.remove('old');
    } else {
        for (var i = 0, length = trList.length; i < trList.length; i++) {
            trList[i].classList.remove('selected');
            trList[i].classList.remove('old');
        }

        classListSelect.add('selected');
        classListSelect.add('old');
    }
}
// #endregion

export { Utils, loadSelectTable };
#Moc
@{
    int idTempRadioNetwork = 0;
    var idRadioNetwork = "";
    foreach (var networkItem in Model.NetworkItems)
    {
        idTempRadioNetwork += 1;
        idRadioNetwork = "radio-network-" + idTempRadioNetwork;
        <label class="control-inline fancy-radio custom-color-green">
        <input id="@idRadioNetwork" type="radio" onchange="changeRadioNetwork(this);" value="@networkItem.Value" name="networkitem">
        <span><i></i>@networkItem.Text</span>
        </label>
    }
}

-----

<div class="form-group">
                      <label class="control-inline fancy-radio custom-color-green">
                        <input id="sheet-type-sheetfed" type="radio" onchange="changeSheetType(this);" value="@((int)SheetType.Sheetfed)" name="ftpksheettype">
                        <span><i></i>枚葉</span>
                      </label>
                      <label class="control-inline fancy-radio custom-color-green">
                        <input id="sheet-type-roll" type="radio" value="@((int)SheetType.Roll)" onchange="changeSheetType(this);" name="ftpksheettype">
                        <span><i></i>ロール</span>
                      </label>
                    </div>

#Script
<script type="text/javascript">
  $(function () {
	    changeRadioNetwork();
	changeNetworkType();
   	  setUpRadio();
  });

  function setUpRadio() {
    let sheetType = $('#sheet-type-id').val();
    if (sheetType == '@((int)SheetType.Sheetfed)') {
      $('#sheet-type-sheetfed').prop('checked', true);
    } else {
      $('#sheet-type-roll').prop('checked', true);
    }

    let ftpConnectionType = $('#ftp-connection-mode-id').val();
    if (ftpConnectionType == '@((int)FtpConnectionMode.Active)') {
      $('#connection-mode-active').prop('checked', true);
    } else {
      $('#connection-mode-passive').prop('checked', true);
    }

    $('#radio-network-1').prop('checked', true);
  }

// thay đổi radio khi chọn

  function changeNetworkType(e) {
    let networkTpye = parseInt(typeof e == "undefined" ? 0 : e);

    if (networkTpye == '@((int)NetWorkType.NetworkPath)') {
      $('#network-content').removeClass('hide');
      $('#ftp-content').addClass('hide');
    } else {
      $('#network-content').addClass('hide');
      $('#ftp-content').removeClass('hide');
    }
  }


  function changeRadioNetwork(e) {
    let checked = $(e).is(':checked');
    if (checked) {
      let value = $(e).val();
      changeNetworkType(value);
    }
  }
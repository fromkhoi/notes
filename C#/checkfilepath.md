Directory.CreateDirectory(directoryUpload);

# Scroll to top when change page size
sizePerPageListChange(sizePerPage) {
$("html, body").animate({ scrollTop: 0 }, "slow");
}

# input download
<div className="text-right">
    <button type="button" className="btn btn-flat btn-success" disabled={this.state.uploadingFile} onClick={this.browseFileToUpload.bind(this)} ><i className={this.state.uploadingFile ? `fa fa-refresh fa-spin` : `fa fa-clipboard`} style={{ marginRight: "10px" }}></i> 変換結果のプレビュー</button>
    <input type="file" id="fileToUpload" style={{ display: "none" }} onChange={this.fileChange.bind(this)} />
</div>

fileChange(event: any) {
        event.preventDefault();
        const { target } = event;
        const self = this;
        const fileData = target.files ? target.files[0] : event.dataTransfer ? event.dataTransfer.files[0] : null;
        let fileUpload = new FormData();
        fileUpload.append("File", fileData);
        fileUpload.append("conversionId", this.state.idConversion);
        this.setState({
            uploadingFile: true
        }, () => {
            this.downloadPreviewFile(fileUpload);
        })
        self.resetFormElement($('#fileToUpload'));
    }

    browseFileToUpload() {
        document.getElementById("fileToUpload").click();
    }

    resetFormElement(e) {
        e.wrap('<form>').closest('form').get(0).reset();
        e.unwrap();
    }

    private downloadPreviewFile(file: FormData) {
        const info: JQueryAjaxSettings = {
            type: 'POST',
            async: true,
            data: file,
            processData: false,
            contentType: false,
            url: /*this.getPathNameUrl() + */ "/api/GM006/UploadFile",
        };
        post(info).done(responseApi => {
            if (responseApi.status === constants.API_SUCCESS) {
                if (responseApi.response) {
                    window.location.href = /*this.getPathNameUrl() + */  `/api/GM006/DownloadFile?fileName=${response}`;
                }
            } else if (responseApi.status === constants.API_ERROR) {
            }
        })
    }
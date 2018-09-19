$("[id*=input-workflow]").each(function (index, e) {
    typeHeadFlowmaps(e);
    });

// tìm những id có bắt đầu là input-workflow



$newItem.find('.sections-nas').each(function (index, e) {
    $(e).css({ display: "block" })
})


$('input:radio[name=TypeRecovery]').change(function() {});

// Lấy tất cả các thẻ div không chứa class .title, 
$('div:not(.title)');

// Lấy thẻ span đầu tiên trong tất cả các span chứa class content
$('span.content:first');

//// example
<div class="article" articleId="456">
 <div class="title">...</div>
 <span class="content">...</span>
</div>

//Tìm các thẻ span trong đoạn html có dạng
$('.article span.content')
//Với khoảng trắng ở giữa “.article” và “span.content”, selector này có thể hiểu là: “tìm tất cả các thẻ span có class là content, và nó phải được chứa trong một html node có class là .article“. Khoảng trắng giữa các từ trong selector được điểu là quan hệ node cha-con, đọc từ trái qua phải là node cha tới node con.


//Đôi khi chỉ ta cần tìm chính xác chỉ 1 node nào đó trong rất nhiều node giống nhau, ta cần cung cấp thêm nhiều thông tin bổ sung để phân biệt cụ thể. jQuery hỗ trợ sâu nhất tới mức select trên các thuộc tính. Bổ sung cú pháp ” [<tên attirbute> = <giá trị>] “ vào selector. Ví dụ, để tìm “bài viết” có id là “456″ như ví dụ trên, ta viết $(“div.article[articleId=456]“) . với <giá trị> kiểu chuỗi, nên cẩn thận đặt trong cặp dấu nháy/nháy kép – [articleId='post456'].
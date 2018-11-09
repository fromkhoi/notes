# để biết chính xác một cái gì đó được thực hiện trong bao lâu
console.time('Timer1');
var items = [];
for(var i = 0; i < 100000; i++){
   items.push({index: i});
}
console.timeEnd('Timer1');
# đếm xem code được đọc bao nhiêu lần
console.count()
# xem dữ liệu của một object 
console.table()
# 2. Make logs easy to read, easy to find
Khi mà bạn muốn log ra nhiều thứ hơn, trên console có rất nhiều dòng log. Một điều mà bạn có thể làm để cấu trúc log dễ nhìn hơn là phân loại các log, sử dụng một số thứ cơ bản đã nhắc đến ngay đầu bài viết như: console.log, console.debug, console.warn, console.info ... Sau đó, bạn có thể lọc chúng theo từng loại. Nhưng đôi khi điều này không thực sự là những gì bạn muốn khi bạn cần debug javascript. Giờ đây bạn có thể sáng tạo và tạo ra kiểu riêng cho log của mình. Sử dụng CSS và tạo các bảng điều khiển có cấu trúc riêng khi debug:

console.todo = function(msg) {
  console.log(‘ % c % s % s % s‘, ‘color: yellow; background - color: black;’, ‘–‘, msg, ‘–‘);
}
console.important = function(msg) {
  console.log(‘ % c % s % s % s’, ‘color: brown; font - weight: bold; text - decoration: underline;’,     ‘–‘, msg, ‘–‘);
}
console.todo(“This is something that’ s need to be fixed”);
console.important(‘This is an important message’);
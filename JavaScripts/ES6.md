#FOR
## FOR-IN
let arr = [1, 2, 3, 4, 5, 6],
    i;
for (i in arr) {
    console.log(arr[i])
}
// output: 1 2 3 4 5 6
// nhược điểm là có thể đọc luôn các cái thuộc tính trong mảng đó (ví dụ như length), những phiên bản cũ của IE mới làm điều này. nói chung thì người ta không khuyên dùng cái for-in này.

## FOR-EACH
let arr = [1, 2, 3, 4, 5, 6]

arr.forEach((value, index)=> {
    console.log(value)
});
// output: 1 2 3 4 5 6
// forEach loop sẽ sử dụng callback function để in value và index ra, nhưng vì dùng callback nên forEach có một nhược điểm là không thể dùng break để thoát khỏi loop được vì break chỉ dùng trong loop thôi, nên khi gọi break trong callback thì sẽ bị syntax error ngay.

## FOR-OF
let arr = [1, 2, 3, 4, 5, 6]

for (let value of arr) {
    console.log(value)
}
// output: 1 2 3 4 5 6
// ĐM đéo nói nhiều. Xài cái này thôi. 2 cái trên kệ con mẹ nó :)
// for-of loop cú pháp sẽ tương tự như for-in nhưng for-in sẽ đọc các key của array và for-of sẽ đọc các value của array đó. Chúng ta có thể dùng continue, break, trong for-of tương tự với for.
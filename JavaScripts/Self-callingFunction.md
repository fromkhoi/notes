# Cũng được gọi là Self-Invoked Anonymous Function hay Immediately Invoked Function Expression (IIFE). Nó là một hàm thực hiện tự động khi bạn tạo nó

(function(){
    // code mà bạn muốn chạy tự động
})();


## Ví dụ:
(function(a,b){
    var result = a+b;
    return result;
})(10,20)

# bonus
## Lấy một số ngẫu nhiên từ một dải số cho trước
var x = Math.floor(Math.random() * (max - min + 1)) + min;

## Tạo một bộ ngẫu nhiên các ký tự chữ và số
function generateRandomAlphaNum(len) {
    var rdmString = "";
    for( ; rdmString.length < len; rdmString  += Math.random().toString(36).substr(2));
    return  rdmString.substr(0, len);
}
generateRandomAlphaNum(9)
// => "3rjzsgpmq"

# Đừng sử dụng delete để xóa một thành phần khỏi mảng
## Hãy sử dụng splice thay vì delete để xóa một item khỏi mảng. Sử dụng delete sẽ thay thế item bằng undefined/empty thay vì xóa nó khỏi mảng. Thay vì dùng:

var items = [12, 548 ,'a' , 2 , 5478 , 'foo' , 8852, , 'Doe' ,2154 , 119 ]; 
items.length; // return 11 
delete items[3]; // return true 
items.length; // return 11 
/* items <=> [12, 548, "a", empty, 5478, "foo", 8852, empty, "Doe", 2154, 119]   */

## Hãy dùng:

var items = [12, 548 ,'a' , 2 , 5478 , 'foo' , 8852, , 'Doe' ,2154 , 119 ]; 
items.length; // return 11 
items.splice(3,1) ; 
items.length; // return 10 
/* items <=> [12, 548, "a", 5478, "foo", 8852, empty, "Doe", 2154, 119]   */

# Cắt bớt mảng sử dụng length
var myArray = [12 , 222 , 1000 , 124 , 98 , 10 ];  
myArray.length = 4; // myArray <=> [12 , 222 , 1000 , 124].

# Sử dụng AND/OR cho biểu thức điều kiện
var foo = 10;  
foo == 10 && doSomething(); // nếu foo == 10 thực hiện hàm Something(); 
foo == 5 || doSomething(); // nếu (foo != 5) thì doSomething();

function doSomething(arg1){ 
    arg1 = arg1 || 10; // arg1 sẽ nhận giá trị 10 nếu nó chưa được khai gán trước đó.
}

# Làm tròn số
var num = 2.443242342;
num = num.toFixed(4);  // num nhận giá trị mới: "2.4432"

# Serialization và deserialization (với dữ liệu dạng JSON)
var person = {name :'Saad', age : 26, department : {ID : 15, name : "R&D"} }; 
var stringFromPerson = JSON.stringify(person); 
/* stringFromPerson tương đương "{"name":"Saad","age":26,"department":{"ID":15,"name":"R&D"}}"   */ 
var personFromString = JSON.parse(stringFromPerson);  
/* personFromString bây giờ tương đương person  */

# Sử dụng switch-case với dải số
function getCategory(age) {  
    var category = "";  
    switch (true) {  
        case isNaN(age):  
            category = "Sai gía trị rồi :)";  
            break;  
        case (age >= 50):  
            category = "Lớn tuổi";  
            break;  
        case (age <= 20):  
            category = "Thiếu niên";  
            break;  
        default:  
            category = "Bất tử!";  
            break;  
    };  
    return category;  
}  
getCategory(5);  // "Thiếu niên"

# Hàm escaper HTML
function escapeHTML(text) {  
    var replacements= {"<": "&lt;", ">": "&gt;","&": "&amp;", '"': "&quot;"};                      
    return text.replace(/[<>&"]/g, function(character) {  
        return replacements[character];  
    }); 
}
Hàm này có thể dùng trong trường hợp người dùng thêm code html vào trang web:

escapeHTML('<div class="abc"></div>')
Kết quả trả về sẽ là:
"&lt;div class=&quot;abc&quot;&gt;&lt;/div&gt;"
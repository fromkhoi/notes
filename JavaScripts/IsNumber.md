# Xác định một tham số truyền vào là một số
function isNumber(n){
    return !isNaN(parseFloat(n)) && isFinite(n);
}
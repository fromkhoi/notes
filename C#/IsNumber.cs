//Hàm kiểm tra chuỗi có phải là số hay không

public bool IsNumber(string pText)
{
Regex regex = new Regex(@”^(0|[1-9][0-9]*)$”);
return regex.IsMatch(pText);
}

//Sử  dụng hàm

if (IsNumber(tên chuỗi cần kiểm tra) == true)
{

// chuỗi là số

}
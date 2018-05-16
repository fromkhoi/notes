// NumericFormatString
    int value = 12345;
    Console.WriteLine(value.ToString("D"));
    // Displays 12345
    Console.WriteLine(value.ToString("D8"));
    // Displays 00012345

// Nối chuỗi
let url = `${Utils.getUrl("/api/SystemLogs/Download")}?id=${id}`
fileName = $"{DateTime.Now.ToString("yyyyMMddhhmmss")}.zip"
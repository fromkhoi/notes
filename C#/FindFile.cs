// Tìm tất cả các file ở thư mục hiện tại và các file ở thư mục con.
Directory.GetFiles("folderPath", "*.xml", SearchOption.AllDirectoriesc);

// Chỉ lấy các file ở thư mục hiện tại
Directory.GetFiles("folderPath", "*.xml", SearchOption.TopDirectory);
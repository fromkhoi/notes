// Download File

using (MemoryStream memoryStream = new MemoryStream())
{
		byte[] bufferTemp = new Byte[1024 * 4];
		using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
		{
				int bytesRead;
				while ((bytesRead = fileStream.Read(bufferTemp, 0, 1024 * 4)) > 0)
				{
						memoryStream.Write(bufferTemp, 0, bytesRead);
				}

				fileStream.Flush();
		}

		return memoryStream.ToArray(); // ~ byte[]
}

----------------------
	
	return this.File(bytes, contentType, fileName); // contentType = application/pdf, application/csv, image/jpeg, application/pdf;



    // Download Folder Zip

    public static byte[] CompressToZip(string directoryFolder, string sameFileName ="")
        {
            var files = Directory.GetFiles(directoryFolder, "*.*", SearchOption.AllDirectories);
            var items = new Dictionary<string, string>();
            var folderName = Path.GetFileName(directoryFolder);

            foreach (var item in files)
            {
                if(!string.IsNullOrEmpty(sameFileName) && item.IndexOf(sameFileName) < 0)
                {
                    continue;
                }

                var name = Path.Combine(folderName, item.Replace(directoryFolder + "\\", ""));
                items.Add(name, item);
            }

            using (var memoryStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    foreach (var item in items)
                    {
                        var demoFile = archive.CreateEntry(item.Key, CompressionLevel.Optimal);

                        using (var entryStream = demoFile.Open())
                        {
                            byte[] bufferTemp = new Byte[1024 * 4];
                            using (var fileStream = new FileStream(item.Value, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                            {
                                int bytesRead;
                                while ((bytesRead = fileStream.Read(bufferTemp, 0, 1024 * 4)) > 0)
                                {
                                    entryStream.Write(bufferTemp, 0, bytesRead);
                                }

                                entryStream.Flush();

                            }
                        }
                    }
                }

                return memoryStream.ToArray();
            }
        }

------------------------------------------------------------------------------------
	byte[] bytes = Util.Common.CompressToZip(directoryJobIdFolder, jobId);
return this.File(bytes, "application/zip", $"{jobId}.zip"); 




//////// to byte[]

//cách 1
var fileBytes = System.IO.File.ReadAllBytes(filePath);

//cách 2
FileInfo fileInfo = new FileInfo(filePath);
string fileName = fileInfo.Name;
byte[] bytes = new byte[64];
bytes = this.DownloadByFilePath(entity.AssetFilePath);

return this.File(bytes, "application/x-msdownload", fileName);



private byte[] DownloadByFilePath(string filePath)
{
			using (MemoryStream memoryStream = new MemoryStream())
      {
      			byte[] bufferTemp = new byte[1024 * 4];
            using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                    int bytesRead;
                    while ((bytesRead = fileStream.Read(bufferTemp, 0, 1024 * 4)) > 0)
                    {
                        memoryStream.Write(bufferTemp, 0, bytesRead);
                    }

                    fileStream.Flush();
            }

            return memoryStream.ToArray();
            }
			}
}

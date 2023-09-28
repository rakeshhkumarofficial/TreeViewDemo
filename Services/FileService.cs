using TreeViewDemo.Services.Interfaces;

namespace TreeViewDemo.Services
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _env;

        public FileService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public void SaveFile(string fileName , string fileContent , int value)
        {
            string webRootPath = _env.WebRootPath;
            if (value == 1)
            {
                webRootPath += "/files/YMLFiles";
            }
            if (value == 2)
            {
                webRootPath += "/files/XMLFiles";
            }
            if (value == 3)
            {
                webRootPath += "/files/JsonPathFiles";
            }
            if (value == 4)
            {
                webRootPath += "/files/XMLPathFiles";
            }

            if (!Directory.Exists(webRootPath))
            {
                Directory.CreateDirectory(webRootPath);
            }
            string filePath = Path.Combine(webRootPath, fileName);
            File.WriteAllText(filePath, fileContent);
        }
    }
}

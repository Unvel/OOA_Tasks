using System;
using System.IO;

namespace Proxy
{
    public class File : IFile
    {
        private string _path;
        private File _file;

        public File(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path), "Отсутствует путь к файлу");
            }
            _path = path;
            _file = new File(_path);
        }

        public double GetSize()
        {
            var file = new FileInfo(_path);
            return file.Length;
        }

        public string GetPath()
        {
            return _path;
        }

        public byte[] Show()
        {
            return System.IO.File.ReadAllBytes(_path);
        }
    }
}

﻿using System;
using System.IO;

namespace Proxy
{
    public class File : IFile
    {
        private string _path;
        private StreamReader _streamReader;
        private File _file;

        public File(string path)
        {
            if (!Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }
            _path = path;
            _streamReader = new StreamReader(_path);
        }

        private static bool Exists(string path)
        {
            throw new NotImplementedException();
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

        public void Dispose()
        {
            _streamReader.Dispose();
        }
    }
}
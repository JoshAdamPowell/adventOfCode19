using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    public class FileReader
    {
        private readonly string _path;

        public FileReader(string path)
        {
            this._path = path;
        }

        public List<string> GetList()
        {
            return File.ReadAllLines(_path).ToList();
        }
    }
}

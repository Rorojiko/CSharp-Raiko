using System.Collections.Generic;

namespace _053501_Raiko_Lab10FileServiceLib
{
    interface IFileService<T> where T:class
    {
        IEnumerable<T> ReadFile(string fileName);
        void SaveData(IEnumerable<T> data, string fileName);
    }
}
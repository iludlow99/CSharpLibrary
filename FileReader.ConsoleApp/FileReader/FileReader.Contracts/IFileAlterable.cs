using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader.Contracts
{
    public interface IFileAlterable
    {
        string CreateFile(string path);
        void DeleteFile(string path);
        string ReadFile(string path);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CarInfo.Interfaces
{
    public interface IFile
    {
        string GetLocalFilePath(string fileName);
    }
}

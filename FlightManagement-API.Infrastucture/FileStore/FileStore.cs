using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Common.Interfaces.Files;


namespace FlightManagement_API.Infrastructure.FileStore
{
    public class FileStore(IFileWrapper fileWrapper, IDirectoryWrapper directoryWrapper) : IFileStore
    {
        public string SafeWriteFile(byte[] content, string sourceFileName, string path)
        {
            directoryWrapper.CreateDirectory(path);
            var outputFile = Path.Combine(path, sourceFileName);
            fileWrapper.WriteAllBytes(outputFile, content);

            return outputFile;
        }

    }

}
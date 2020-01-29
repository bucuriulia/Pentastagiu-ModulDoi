using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Saptamana2.DataStream
{
    public class StreamOperations
    {
        public void WriteToFile()
        {
            NumberStreamReader streamReader = new NumberStreamReader();

            var correctNumberStream = new NumberStreamWriter(new FileStream(FilePathConstants.CorrectNumbersFilePath, FileMode.OpenOrCreate));
            var incorrectNumberStream = new NumberStreamWriter(new FileStream(FilePathConstants.IncorrectNumbersFilePath, FileMode.OpenOrCreate));

            correctNumberStream.WriteNumber(streamReader.CorrectNumbers);
            incorrectNumberStream.WriteNumber(streamReader.IncorrectNumbers);
        }
    }
}

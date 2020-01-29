using System;
using System.Collections.Generic;
using System.IO;

namespace Modul2_Saptamana2.DataStream
{
    public class NumberStreamReader : IDisposable
    {
        private readonly StreamReader streamReader;
        public List<string> CorrectNumbers { get; set; } = new List<string>();
        public List<string> IncorrectNumbers { get; set; } = new List<string>();
        public NumberStreamReader()
        {
            var stream = new FileStream(FilePathConstants.InputFilePath, FileMode.Open);
            if (stream.Length == 0) return;
            streamReader = new StreamReader(stream);
            ReadAllNumbers();
        }

        private void ReadAllNumbers()
        {
            while (!streamReader.EndOfStream)
            {
                var tempResult = streamReader.ReadLine();
                try
                {
                    var number = int.Parse(tempResult);
                    CorrectNumbers.Add(tempResult);
                }
                catch (Exception)
                {
                    IncorrectNumbers.Add(tempResult);
                }
            }
        }

        public void Dispose()
        {
            streamReader.Dispose();
        }
    }
}

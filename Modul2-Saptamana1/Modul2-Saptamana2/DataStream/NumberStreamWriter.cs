using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Saptamana2.DataStream
{
    class NumberStreamWriter : IDisposable
    {
        private readonly StreamWriter streamWriter;
        public bool IsReady { get; set; }
        public NumberStreamWriter(Stream stream)
        {
            if (stream == null) return;
            IsReady = true;
            streamWriter = new StreamWriter(stream);
        }


        public void WriteNumber(List<string> numbers)
        {
            foreach (var number in numbers)
            {

                streamWriter.WriteLine(number);
            }

            streamWriter.WriteLine();
            streamWriter.Flush();
        }

        public void Dispose()
        {
            streamWriter.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

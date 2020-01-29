using Modul2_Saptamana2.DataStream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Saptamana2
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumberStreamReader numberStreamReader = new NumberStreamReader();
            StreamOperations streamOperations = new StreamOperations();
            streamOperations.WriteToFile();
        }
    }
}

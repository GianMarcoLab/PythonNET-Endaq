using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace TestProject
{
    public class PythonInterop
    {
        public static void Initialize()
        {
            string pythonDll = @"C:\Users\ghost\AppData\Local\Programs\Python\Python38\python38.dll";
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", pythonDll);
            PythonEngine.Initialize();
        }

        public static void RunPythonCode(string pycode)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");

                dynamic np = Py.Import("numpy");
                Console.WriteLine(np.cos(np.pi * 2));


                // edDAQ.ide
                // Console.WriteLine(endaq.ide.get_doc("https://info.endaq.com/hubfs/data/surgical-instrument.ide"));

                // edDAQ.calc
                var doc = endaq.ide.get_doc("https://info.endaq.com/hubfs/data/Motorcycle-Car-Crash.ide");
                var accel = endaq.ide.to_pandas(doc.channels[8], "seconds");
                Console.WriteLine(accel);

                /*
                accel = accel - accel.median();
                var freqs = endaq.calc.utils.logfreqs(accel, 1, 12);
                var srs = endaq.calc.shock.shock_spectrum(accel, freqs, 0.5, 12.0, 0.05, "srs");
                
                Console.WriteLine(freqs, srs);
                */

                PythonEngine.RunSimpleString(pycode);
            }
        }
    }
}

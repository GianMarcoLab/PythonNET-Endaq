using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace TestProject.Endap_Calc.Integrate
{
    internal class Integrate
    {
        public static void Initialize()
        {
            string pythonDll = @"C:\Users\ghost\AppData\Local\Programs\Python\Python38\python38.dll";
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", pythonDll);
            PythonEngine.Initialize();
        }

        // Get the filter type and cutoff frequency array.
        public static dynamic _integrate(dynamic df, string zero = "start")
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.integrate._integrate(df, zero);
                Console.WriteLine(result);
                return result;
            }
        }

        // Iterate over conditioned integrals of the given original data.
        public static dynamic iter_integrals(
            dynamic df, 
            string zero = "start", 
            double highpass_cutoff = 0,
            double tukey_percent = 0.0)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.integrate.iter_integrals(df, zero, highpass_cutoff, tukey_percent);
                Console.WriteLine(result);
                return result;
            }
        }

        // Calculate `n` integrations of the given data.
        public static dynamic integrals(
            dynamic df,
            int n = 1,
            string zero = "start",
            double highpass_cutoff = 0,
            double tukey_percent = 0.0)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.integrate.integrals(df, n, zero, highpass_cutoff, tukey_percent);
                Console.WriteLine(result);
                return result;
            }
        }
    }
}

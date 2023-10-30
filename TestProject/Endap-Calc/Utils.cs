using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Endap_Calc.Utils
{
    internal class Utils
    {
        public static void Initialize()
        {
            string pythonDll = @"C:\Users\ghost\AppData\Local\Programs\Python\Python38\python38.dll";
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", pythonDll);
            PythonEngine.Initialize();
        }

        // Calculate the average spacing between individual samples
        public static dynamic sample_spacing(
            dynamic data = null,
            string convert = "to_seconds")
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.Utils.sample_spacing(
                    data, convert
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Calculate a sequence of log-spaced frequencies for a given dataframe.
        public static dynamic logfreqs(
            dynamic df = null,
            dynamic init_freq = null,
            double bins_per_octave = 12.0)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.Utils.logfreqs(
                    df, init_freq, bins_per_octave
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Scale data into units of decibels.
        public static dynamic to_dB(
            dynamic data,
            dynamic reference,
            bool squared = false)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.Utils.to_dB(
                    data, reference, squared
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Resample a dataframe to a desired sample rate (in Hz)
        public static dynamic resample(
            dynamic df,
            dynamic sample_rate)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.Utils.resample(
                    df, sample_rate
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Compute parameters needed to define index locations and slice width for rolling computations
        public static dynamic _rolling_slice_definitions(
            dynamic df = null,
            int num_slices = 100,
            dynamic indexes = null,
            dynamic index_values = null,
            dynamic slice_width = null)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.Utils._rolling_slice_definitions(
                    df,
                    num_slices,
                    indexes,
                    index_values,
                    slice_width
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Using the `Pint library <https://github.com/hgrecco/pint/blob/master/pint/default_en.txt>`_ apply a unit conversion to a provided unit-unaware dataframe.
        public static dynamic convert_units(
            string units_in,
            string units_out,
            dynamic df)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.Utils.convert_units(
                    units_in,
                    units_out,
                    df
                );
                Console.WriteLine(result);
                return result;
            }
        }
    }
}
using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace TestProject.Endap_Calc.Filters
{
    internal class Filters
    {
        public static void Initialize()
        {
            string pythonDll = @"C:\Users\ghost\AppData\Local\Programs\Python\Python38\python38.dll";
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", pythonDll);
            PythonEngine.Initialize();
        }


        // Get the filter type and cutoff frequency array.
        public static dynamic _get_filter_frequencies_type(dynamic low_cutoff, dynamic high_cutoff)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.filters._get_filter_frequencies_type(low_cutoff, high_cutoff);
                Console.WriteLine(result);
                return result;
            }
        }

        // Remove the rolling mean of an input time series dataframe.
        public static dynamic rolling_mean(dynamic df, float duration)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.filters.rolling_mean(df, duration);
                Console.WriteLine(result);
                return result;
            }
        }


        // Apply a lowpass and/or a highpass Butterworth filter to an array.
        public static dynamic butterworth(
            dynamic df, 
            double low_cutoff = 1.0,
            dynamic high_cutoff = null, 
            int half_order = 0,
            double tukey_percent = 0.0)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.filters.butterworth(df, low_cutoff, high_cutoff, half_order, tukey_percent);
                Console.WriteLine(result);
                return result;
            }
        }



        // Apply a lowpass and/or a highpass Bessel filter to an array.
        public static dynamic bessel(
            dynamic df,
            double low_cutoff = 1.0,
            dynamic high_cutoff = null,
            int half_order = 3,
            double tukey_percent = 0.0,
            string norm = "mag")
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.filters.bessel(df, low_cutoff, high_cutoff, half_order, tukey_percent, norm);
                Console.WriteLine(result);
                return result;
            }
        }

        //  Apply a lowpass and/or a highpass Chebyshev type I filter to an array.
        public static dynamic cheby1(
            dynamic df,
            double low_cutoff = 1.0,
            dynamic high_cutoff = null,
            int half_order = 3,
            double tukey_percent = 0.0,
            double rp = 3.0)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.filters.cheby1(df, low_cutoff, high_cutoff, half_order, tukey_percent, rp);
                Console.WriteLine(result);
                return result;
            }
        }


        //  Apply a lowpass and/or a highpass Chebyshev type II filter to an array.
        public static dynamic cheby2(
            dynamic df,
            double low_cutoff = 1.0,
            dynamic high_cutoff = null,
            int half_order = 3,
            double tukey_percent = 0.0,
            double rs = 30.0)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.filters.cheby2(df, low_cutoff, high_cutoff, half_order, tukey_percent, rs);
                Console.WriteLine(result);
                return result;
            }
        }


        //  Apply a lowpass and/or a highpass Elliptic filter to an array.
        public static dynamic ellip(
            dynamic df,
            double low_cutoff = 1.0,
            dynamic high_cutoff = null,
            int half_order = 3,
            double tukey_percent = 0.0,
            double rp = 3.0,
            double rs = 30.0)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.filters.ellip(df, low_cutoff, high_cutoff, half_order, tukey_percent, rp, rs);
                Console.WriteLine(result);
                return result;
            }
        }


        //  Generate time series noise for a given range of frequencies with random phase using ifft.
        public static dynamic _fftnoise(dynamic f)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.filters._fftnoise(f);
                Console.WriteLine(result);
                return result;
            }
        }

        //  Generate a time series with noise in a defined frequency range.
        public static dynamic band_limited_noise(
            double min_freq = 0.0,
            dynamic max_freq = null,
            double duration = 1.0,
            double sample_rate = 1000.0,
            string norm = "peak")
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.filters.band_limited_noise(min_freq, max_freq, duration, sample_rate, norm);
                Console.WriteLine(result);
                return result;
            }
        }
    }
}

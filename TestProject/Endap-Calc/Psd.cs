using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Endap_Calc.Psd
{
    internal class Psd
    {
        public static void Initialize()
        {
            string pythonDll = @"C:\Users\ghost\AppData\Local\Programs\Python\Python38\python38.dll";
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", pythonDll);
            PythonEngine.Initialize();
        }

        // Compute histograms over a specified axis.
        public static dynamic _np_histogram_nd(
            dynamic array,
            double bins = 10,
            dynamic weights = null,
            double axis = 1.0,
            dynamic kwargs = null)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.psd._np_histogram_nd(array, bins, weights, axis, kwargs);
                Console.WriteLine(result);
                return result;
            }
        }

        // Perform `scipy.signal.welch` with a specified frequency spacing.
        public static dynamic welch(
            dynamic df,
            double bin_width = 1.0,
            string scaling = "",
            dynamic kwargs = null)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.psd.welch(df, bin_width, scaling, kwargs);
                Console.WriteLine(result);
                return result;
            }
        }

        // Get the filter type and cutoff frequency array.
        public static dynamic differentiate(
            dynamic df,
            double n = 1.0)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.psd.differentiate(df, n);
                Console.WriteLine(result);
                return result;
            }
        }

        // Calculate a periodogram over non-uniformly spaced frequency bins.
        public static dynamic to_jagged(
            dynamic df,
            dynamic freq_splits,
            string agg = "mean")
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.psd.to_jagged(df, freq_splits, agg);
                Console.WriteLine(result);
                return result;
            }
        }

        // Calculate a periodogram over log-spaced frequency bins.
        public static dynamic to_octave(
            dynamic df,
            double fstart = 1.0,
            double octave_bins = 12.0,
            dynamic kwargs = null)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.psd.to_octave(df, fstart, octave_bins, kwargs);
                Console.WriteLine(result);
                return result;
            }
        }

        // Calculate a "good" linearly-spaced bin width, from a PSD of which an octave-spaced PSD can be accurately calculated.
        public static dynamic _aligned_bin_width(
            double fstart = 1.0,
            double octave_bins = 12.0)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.psd._aligned_bin_width(fstart, octave_bins);
                Console.WriteLine(result);
                return result;
            }
        }

        // Calculate Vibration Criterion (VC) curves from an acceleration periodogram.
        public static dynamic vc_curves(
            dynamic accel_psd = null,
            double fstart = 1.0,
            double octave_bins = 12.0)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.psd.vc_curves(accel_psd, fstart, octave_bins);
                Console.WriteLine(result);
                return result;
            }
        }

        // Compute PSDs for defined slices of a time series data set using :py:func:`~endaq.calc.psd.welch()`
        public static dynamic rolling_psd(
            dynamic df,
            double bin_width = 1.0,
            dynamic octave_bins = null,
            double fstart = 1.0,
            string scaling = null,
            string agg = "mean",
            dynamic freq_splits = null,
            int num_slices = 100,
            dynamic indexes = null,
            dynamic index_values = null,
            dynamic slice_width = null,
            bool add_resultant = true,
            bool disable_warnings = true,
            dynamic kwargs = null)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.psd.rolling_psd(df, bin_width, octave_bins, fstart, scaling, agg, 
                    freq_splits, num_slices, indexes, index_values, slice_width, add_resultant, disable_warnings, kwargs);
                Console.WriteLine(result);
                return result;
            }
        }

        // Compute a spectrogram for a time series data set using :py:func:`scipy.signal.spectrogram()`
        public static dynamic spectrogram(
            dynamic df,
            int num_slices = 100,
            string scaling = null,
            double bin_width = 1.0,
            dynamic octave_bins = null,
            double fstart = 1.0,
            string agg = "mean",
            dynamic freq_splits = null,
            bool add_resultant = true,
            bool disable_warnings = true,
            dynamic kwargs = null)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.psd.spectrogram(df, num_slices, scaling, bin_width, octave_bins, fstart, agg,
                    freq_splits, add_resultant, disable_warnings, kwargs);
                Console.WriteLine(result);
                return result;
            }
        }
    }
}

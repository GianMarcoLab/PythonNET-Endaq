using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Endap_Calc.Stats
{
    internal class Stats
    {
        public static void Initialize()
        {
            string pythonDll = @"C:\Users\ghost\AppData\Local\Programs\Python\Python38\python38.dll";
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", pythonDll);
            PythonEngine.Initialize();
        }

        // Compute the following shock and vibration metrics for a given time series dataframe
        public static dynamic shock_vibe_metrics(
            dynamic df,
            double tukey_percent = 0.1,
            dynamic highpass_cutoff = null,
            string accel_units = "gravity",
            string disp_units = "in",
            List<int?> freq_splits = null,
            string detrend = "median",
            string zero = "start",
            bool include_integration = true,
            bool include_pseudo_velocity = false,
            double damp = 0.05,
            double init_freq = 1.0,
            double bins_per_octave = 12,
            bool include_resultant = false,
            bool display_plots = false)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.stats.shock_vibe_metrics(
                    df,
                    tukey_percent,
                    highpass_cutoff,
                    accel_units,
                    disp_units,
                    freq_splits,
                    detrend,
                    zero,
                    include_integration,
                    include_pseudo_velocity,
                    damp,
                    init_freq,
                    bins_per_octave,
                    include_resultant,
                    display_plots
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Find the peak events of a given time series using the maximum across all input columns
        public static dynamic find_peaks(
            dynamic df,
            double time_distance = 1.0,
            bool add_resultant = false,
            dynamic threshold = null,
            string threshold_reference = "peak",
            double threshold_multiplier = 0.1,
            bool use_abs = true,
            bool display_plots = false)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.stats.find_peaks(
                    df,
                    time_distance,
                    add_resultant,
                    threshold,
                    threshold_reference,
                    threshold_multiplier,
                    use_abs,
                    display_plots
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Quantify a series of time slices of a given time series
        public static dynamic rolling_metrics(
            dynamic df,
            double indexes = 1.0,
            bool index_values = false,
            dynamic num_slices = null,
            string slice_width = "peak",
            dynamic kwargs = null)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.stats.rolling_metrics(
                    df,
                    indexes,
                    index_values,
                    num_slices,
                    slice_width,
                    kwargs
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Compute the L2 norm (a.k.a. the Euclidean Norm).
        public static dynamic L2_norm(
            dynamic array,
            dynamic axis = null,
            bool keepdims = false)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.stats.L2_norm(
                    array, axis, keepdims
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Compute the maximum of the absolute value of an array.
        public static dynamic max_abs(
            dynamic array,
            dynamic axis = null,
            bool keepdims = false)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.stats.max_abs(
                    array, axis, keepdims
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Calculate the root-mean-square (RMS) along a given axis.
        public static dynamic rms(
            dynamic array,
            dynamic axis = null,
            bool keepdims = false)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.stats.rms(
                    array, axis, keepdims
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Calculate a rolling root-mean-square (RMS) over a pandas `DataFrame`.
        public static dynamic rolling_rms(
            dynamic df,
            int window_len,
            dynamic args,
            dynamic kwargs)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.stats.rolling_rms(
                    df, window_len, args, kwargs
                );
                Console.WriteLine(result);
                return result;
            }
        }
    }
}

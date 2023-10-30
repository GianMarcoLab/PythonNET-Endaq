using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Endap_Calc.Shock
{
    internal class Shock
    {
        public static void Initialize()
        {
            string pythonDll = @"C:\Users\ghost\AppData\Local\Programs\Python\Python38\python38.dll";
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", pythonDll);
            PythonEngine.Initialize();
        }

        // Calculate the absolute acceleration for a SDOF system.
        public static dynamic absolute_acceleration(
            dynamic accel, 
            double omega, 
            double damp = 0.0)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.shock.absolute_acceleration(
                    accel, omega, damp
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Calculate the relative velocity for a SDOF system.
        public static dynamic relative_velocity(
            dynamic accel,
            double omega,
            double damp = 0.0)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.shock.relative_velocity(
                    accel, omega, damp
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Calculate the relative displacement for a SDOF system.
        public static dynamic relative_displacement(
            dynamic accel,
            double omega,
            double damp = 0.0)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.shock.relative_displacement(
                    accel, omega, damp
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Calculate the pseudo-velocity for a SDOF system.
        public static dynamic pseudo_velocity(
            dynamic accel,
            double omega,
            double damp = 0.0)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.shock.pseudo_velocity(
                    accel, omega, damp
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Calculate the relative displacement expressed as equivalent static acceleration for a SDOF system.
        public static dynamic relative_displacement_static(
            dynamic accel,
            double omega,
            double damp = 0.0)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.shock.relative_displacement_static(
                    accel, omega, damp
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Calculate the shock spectrum of an acceleration signal. Note this defaults to first find peak events, then compute the spectrum on those peaks to speed up processing time.
        public static dynamic shock_spectrum(
            dynamic accel,
            dynamic freqs = null,
            double init_freq = 0.5,
            double bins_per_octave = 12.0,
            double damp = 0.05,
            string mode = "srs",
            double max_time = 2.0,
            double peak_threshold = 0.1,
            bool two_sided = false,
            bool aggregate_axes = false)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.shock.shock_spectrum(
                    accel, freqs, init_freq, bins_per_octave, damp, mode, max_time, peak_threshold, two_sided, aggregate_axes
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Compute Shock Response Spectrums for defined slices of a time series data set using :py:func:`~endaq.calc.shock.shock_spectrum()`
        public static dynamic rolling_shock_spectrum(
            dynamic df,
            double damp = 0.05,
            string mode = "srs",
            bool add_resultant = true,
            dynamic freqs = null,
            double init_freq = 0.5,
            double bins_per_octave = 12.0,
            int num_slices = 100,
            dynamic indexes = null,
            dynamic index_values = null,
            dynamic slice_width = null,
            bool disable_warnings = false)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.shock.rolling_shock_spectrum(
                    df, damp, mode, add_resultant, freqs, init_freq, bins_per_octave, num_slices, indexes, index_values, slice_width, disable_warnings
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Compute Shock Response Spectrums for defined slices of a time series data set using :py:func:`~endaq.calc.shock.shock_spectrum()`
        public static dynamic enveloping_half_sine(
            dynamic pvss,
            double damp = 0.05)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.shock.enveloping_half_sine(
                    pvss, damp
                );
                Console.WriteLine(result);
                return result;
            }
        }
    }
}
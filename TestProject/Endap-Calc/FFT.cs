using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Endap_Calc.FFT
{
    internal class FFT
    {
        public static void Initialize()
        {
            string pythonDll = @"C:\Users\ghost\AppData\Local\Programs\Python\Python38\python38.dll";
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", pythonDll);
            PythonEngine.Initialize();
        }

        // Calculate the FFT using :py:func:`scipy.signal.welch` with a specified frequency spacing.  The data returned is in the sameunits as the data input.
        public static dynamic aggregate_fft(
            dynamic df,
            dynamic kwargs)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.fft.aggregate_fft(
                    df, kwargs
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Compute FFTs for defined slices of a time series data set using :py:func:`~endaq.calc.fft.aggregate_fft()`
        public static dynamic rolling_fft(
            dynamic df,
            double bin_width = 1.0,
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
                dynamic result = endaq.calc.fft.rolling_fft(
                    df,
                    bin_width,
                    num_slices,
                    indexes,
                    index_values,
                    slice_width,
                    add_resultant,
                    disable_warnings,
                    kwargs
                );
                Console.WriteLine(result);
                return result;
            }
        }


        // the FFT of the data in ``df``, using SciPy's FFT method from :py:func:`scipy.fft.fft`.  If the in ``df`` is all real, then the output will be symmetrical between positive and negative frequencies, and it is instead recommended that you use the :py:func:`endaq.calc.fft.fft` method.
        public static dynamic fft(
            dynamic df = null,
            dynamic output = null,
            dynamic nfft = null,
            dynamic norm = null,
            bool optimize = true)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.fft.fft(
                    df,
                    output,
                    nfft,
                    norm,
                    optimize
                );
                Console.WriteLine(result);
                return result;
            }
        }


        // Perform the real valued FFT of the data in ``df``, using SciPy's RFFT method from :py:func:`scipy.fft.rfft`.
        public static dynamic rfft(
            dynamic df = null,
            dynamic output = null,
            dynamic nfft = null,
            dynamic norm = null,
            bool optimize = true)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.fft.rfft(
                    df,
                    output,
                    nfft,
                    norm,
                    optimize
                );
                Console.WriteLine(result);
                return result;
            }
        }

        // Calculate the DCT of the data in ``df``, using SciPy's DCT method from :py:func:`scipy.fft.dct`.
        public static dynamic dct(
            dynamic df,
            dynamic nfft = null,
            dynamic norm = null,
            dynamic kwargs = null)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.fft.dct(
                    df, nfft, norm, kwargs
                );
                Console.WriteLine(result);
                return result;
            }
        }


        // Calculate the DST of the data in ``df``, using SciPy's DST method from :py:func:`scipy.fft.dst`.
        public static dynamic dst(
            dynamic df,
            dynamic nfft = null,
            dynamic norm = null,
            dynamic kwargs = null)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.fft.aggregate_fft(
                    df, nfft, norm, kwargs
                );
                Console.WriteLine(result);
                return result;
            }
        }
    }
}
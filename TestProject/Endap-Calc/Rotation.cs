using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Endap_Calc.Rotation
{
    internal class Rotation
    {
        public static void Initialize()
        {
            string pythonDll = @"C:\Users\ghost\AppData\Local\Programs\Python\Python38\python38.dll";
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", pythonDll);
            PythonEngine.Initialize();
        }

        // Compute histograms over a specified axis.
        public static dynamic _validate_euler_mode(string mod)
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.rotation._validate_euler_mode(mod);
                Console.WriteLine(result);
                return result;
            }
        }

        // Convert quaternion data in the dataframe ``df`` to euler angles.  This can be done with either intrinsic or extrinsic rotations, determined automatically based on ``mode``
        public static dynamic quaternion_to_euler(dynamic df, string mod = "x-y-z")
        {
            Initialize();
            using (Py.GIL())
            {
                dynamic endaq = Py.Import("endaq");
                dynamic result = endaq.calc.rotation.quaternion_to_euler(df, mod);
                Console.WriteLine(result);
                return result;
            }
        }
    }
}

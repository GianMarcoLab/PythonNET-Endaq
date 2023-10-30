// See https://aka.ms/new-console-template for more information
using TestProject;
using TestProject.Endap_Calc.Filters;

Console.WriteLine(Filters._get_filter_frequencies_type(null, null));

void Main()
{
    PythonInterop.RunPythonCode(
@"import clr
print(""Hello we are here to make enDAQ working onto C#!"")
clr.AddReference(""System"");
import plotly.express as px
import pandas as pd
import endaq
endaq.plot.utilities.set_theme('endaq_light')

#Get Acceleration Data
doc = endaq.ide.get_doc('https://info.endaq.com/hubfs/data/Motorcycle-Car-Crash.ide')
accel = endaq.ide.to_pandas(doc.channels[8], time_mode='seconds')[1137.4:1137.8]
accel = accel - accel.median()

#Calculate SRS
freqs = endaq.calc.utils.logfreqs(accel, init_freq=1, bins_per_octave=12)
srs = endaq.calc.shock.shock_spectrum(accel, freqs=freqs, damp=0.05, mode='srs')
print(freqs, srs)cc 
");
}

Main();
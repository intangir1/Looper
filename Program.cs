using System;
using System.Diagnostics;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Looper
{
	class Program
	{
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		static void Main(string[] args)
		{
			Console.WriteLine("Please, enter a number:");
			string input = Console.ReadLine();

			if(Int32.TryParse(input, out int loops)){								// If the input was legitimate
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				for (int i = 0; i < loops; i++) ;
				stopwatch.Stop();
				TimeSpan timespan = stopwatch.Elapsed;

				string seconds_elapsed = timespan.ToString(@"s\.f");				// Formating the time output
				string log_message = "Input:" + input + " - Time: " +
					seconds_elapsed + " ms";
				log.Debug(log_message);												// In the folder "logs" in the folder of this program (gets created if absent)

				Console.ReadLine();													// So the console doesn't instantly close
			}

			
			
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGIS.Desktop {
	static class Program {
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Configurations.formLogger = new FormLogger();
			Configurations.formLogger.Show();
			Logger.log("Started at " + DateTime.Now.ToString() + " on " + Configurations.appName + " " + Configurations.appVersion);
			Logger.log("Press Esc to hide.");
			Logger.log("===============Logger Start===============");

			Application.Run(new FormMain());
			Configurations.formLogger.Show();
			Logger.log("===============Logger End=================");
			Logger.doDelay(1);
		}
	}
}

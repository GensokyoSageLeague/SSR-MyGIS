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
			if (Configurations.showLoggerInit)
				Configurations.formLogger.Show();
			Configurations.formSplashWrapper = new Plugins.SplashScreen.SplashMain();
			Configurations.formSplashWrapper.Activate();
			Logger.log("Started at " + DateTime.Now.ToString() + " on " + Configurations.appName + " " + Configurations.appVersion);
			Logger.log("Press Esc to hide.");
			Logger.log("===============Logger Start===============");

			Application.Run(new FormMain());
			if (Configurations.showLoggerInit)
				Configurations.formLogger.Show();
			Logger.log("===============Logger End=================");
			if (Configurations.showLoggerInit)
				Logger.doDelay(1);
		}
	}
}

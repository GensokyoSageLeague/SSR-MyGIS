using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGIS.Desktop {
	static class Configurations {
		// Configurations
		public static bool usingClassicHough { get; set; } = false;
		private static bool _unlimitedZoom = false;
		public static bool unlimitedZoom {
			get {
				return _unlimitedZoom;
			}
			set {
				_unlimitedZoom = value;
				formMain.map1.ZoomOutFartherThanMaxExtent = value;
			}
		}
		private static bool _showTool = true;
		public static bool showTool {
			get {
				return _showTool;
			}
			set {
				_showTool = value;
				formMain.spatialDockManager2.Panel2Collapsed = !value;
				formMain.toolsToolStripMenuItem.Checked = value;
				formMain.basicOperationsToolStripMenuItem.Checked = value;
			}
		}

		// Global Variables
		public static FormMain formMain { get; set; }
		public static FormLogger formLogger { get; set; }
		public static Plugins.SplashScreen.SplashMain formSplashWrapper { get; set; }

		// AppInfo
		public static string appName = ((AssemblyTitleAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyTitleAttribute))).Title;
		//public static string appNameProduct = ((AssemblyProductAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyProductAttribute))).Product;
		public static string appNameProduct = Application.ProductName;
		public static string appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		public static string appBuildTime = System.IO.File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location).ToString();

		// Constants
#if DEBUG
		public const bool showLoggerInit = true;
#else
		public const bool showLoggerInit = false;
#endif
	}
}

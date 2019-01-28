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
		public static bool usingClassicHough { get; set; }

		// Global Variables
		public static FormMain formMain { get; set; }
		public static FormLogger formLogger { get; set; }

		// AppInfo
		public static string appName = ((AssemblyTitleAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyTitleAttribute))).Title;
		//public static string appNameProduct = ((AssemblyProductAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyProductAttribute))).Product;
		public static string appNameProduct = Application.ProductName;
		public static string appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		public static string appBuildTime = System.IO.File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location).ToString();
	}
}

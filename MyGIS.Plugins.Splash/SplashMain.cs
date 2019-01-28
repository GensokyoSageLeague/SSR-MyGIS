using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotSpatial.Extensions;
using DotSpatial.Extensions.SplashScreens;
using System.Threading;
using System.Windows.Forms;

namespace MyGIS.Plugins.SplashScreen {
	public class SplashMain : ISplashScreenManager {
		FormSplash thisForm;

		public void Activate() {
			thisForm = new FormSplash();
			thisForm.Show();
		}

		public void Deactivate() {
			thisForm.Close();
		}

		public void ProcessCommand(Enum cmd, object arg) {
			if ((SplashScreenCommand)cmd == SplashScreenCommand.SetDisplayText) {
				if (arg is string) {
					thisForm.label.Text = (string)arg;
				}
			}
		}
	}
}

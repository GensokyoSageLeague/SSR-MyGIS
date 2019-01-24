using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGIS {
	public partial class FormLogger : Form {
		public FormLogger() {
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
		}

		public void log(string s) {
			logBox.AppendText(s + "\r\n");
		}

		private void logBox_KeyDown(object sender, KeyEventArgs e) {
			if ((e.KeyCode == Keys.F4) && (e.Alt == true)) {
				e.Handled = true;
			}
			if (e.KeyCode == Keys.Escape) {
				this.Visible = false;
			}
		}

		private void FormLogger_FormClosing(object sender, FormClosingEventArgs e) {
			Logger.log("===============Logger End=================");
			Logger.doDelay(1);

		}
	}

	public static class Logger {
		public static void log(string s) {
			if (Configurations.formLogger != null) {
				Configurations.formLogger.log(s);
			}
		}

		public static bool doDelay(int delayTime) {
			DateTime now = DateTime.Now;
			int s;
			do {
				TimeSpan spand = DateTime.Now - now;
				s = spand.Seconds;
				Application.DoEvents();
			} while (s < delayTime);
			return true;
		}
	}
}

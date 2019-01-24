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

		public void log (string s) {
			logBox.AppendText(s + "\r\n");
		}

		private void logBox_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Escape) {
				this.Visible = false;
			}
		}
	}

	public static class Logger {
		public static void log(string s) {
			if (Configurations.formLogger != null) {
				Configurations.formLogger.log(s);
			}
		}
	}
}

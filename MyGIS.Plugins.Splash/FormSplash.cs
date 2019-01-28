using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGIS.Plugins.SplashScreen {
	public partial class FormSplash : Form {
		public FormSplash() {
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
		}
	}
}

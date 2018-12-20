using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleShapeRecognition {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("Proudly Made by\r\n\t10170320 李云烽\r\n\t10170325 李健纯\r\n\t10170347 姜子威\r\n\t10170348 姚迪昭", "About Project");
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Application.Exit();
		}
	}
}

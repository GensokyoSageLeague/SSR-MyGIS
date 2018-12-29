namespace MyGIS {
	partial class FormTestDotSpatial {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestDotSpatial));
			this.appManager1 = new DotSpatial.Controls.AppManager();
			this.SuspendLayout();
			// 
			// appManager1
			// 
			this.appManager1.Directories = ((System.Collections.Generic.List<string>)(resources.GetObject("appManager1.Directories")));
			this.appManager1.DockManager = null;
			this.appManager1.HeaderControl = null;
			this.appManager1.Legend = null;
			this.appManager1.Map = null;
			this.appManager1.ProgressHandler = null;
			this.appManager1.ShowExtensionsDialogMode = DotSpatial.Controls.ShowExtensionsDialogMode.Default;
			// 
			// FormTestDotSpatial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 448);
			this.Name = "FormTestDotSpatial";
			this.Text = "FormTestDotSpatial";
			this.ResumeLayout(false);

		}

		#endregion

		private DotSpatial.Controls.AppManager appManager1;
	}
}
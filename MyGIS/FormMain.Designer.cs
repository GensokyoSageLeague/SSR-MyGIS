namespace MyGIS {
	partial class FormMain {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.procToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.map1 = new DotSpatial.Controls.Map();
			this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dotSpatialTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.procToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.debugToolStripMenuItem});
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openShapefileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
			// 
			// openShapefileToolStripMenuItem
			// 
			this.openShapefileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shapefileToolStripMenuItem,
            this.gridToolStripMenuItem});
			this.openShapefileToolStripMenuItem.Name = "openShapefileToolStripMenuItem";
			resources.ApplyResources(this.openShapefileToolStripMenuItem, "openShapefileToolStripMenuItem");
			// 
			// shapefileToolStripMenuItem
			// 
			this.shapefileToolStripMenuItem.Name = "shapefileToolStripMenuItem";
			resources.ApplyResources(this.shapefileToolStripMenuItem, "shapefileToolStripMenuItem");
			// 
			// gridToolStripMenuItem
			// 
			this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
			resources.ApplyResources(this.gridToolStripMenuItem, "gridToolStripMenuItem");
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
			// 
			// procToolStripMenuItem
			// 
			this.procToolStripMenuItem.Name = "procToolStripMenuItem";
			resources.ApplyResources(this.procToolStripMenuItem, "procToolStripMenuItem");
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
			resources.ApplyResources(this.toolStrip1, "toolStrip1");
			this.toolStrip1.Name = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
			this.toolStripButton1.Name = "toolStripButton1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			resources.ApplyResources(this.statusStrip1, "statusStrip1");
			this.statusStrip1.Name = "statusStrip1";
			// 
			// splitContainer1
			// 
			resources.ApplyResources(this.splitContainer1, "splitContainer1");
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.listView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.map1);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			resources.ApplyResources(this.listView1, "listView1");
			this.listView1.Name = "listView1";
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			resources.ApplyResources(this.columnHeader1, "columnHeader1");
			// 
			// map1
			// 
			this.map1.AllowDrop = true;
			this.map1.BackColor = System.Drawing.Color.White;
			this.map1.CollectAfterDraw = false;
			this.map1.CollisionDetection = false;
			this.map1.ExtendBuffer = false;
			this.map1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
			this.map1.IsBusy = false;
			this.map1.IsZoomedToMaxExtent = false;
			this.map1.Legend = null;
			resources.ApplyResources(this.map1, "map1");
			this.map1.Name = "map1";
			this.map1.ProgressHandler = null;
			this.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
			this.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
			this.map1.RedrawLayersWhileResizing = false;
			this.map1.SelectionEnabled = true;
			this.map1.ZoomOutFartherThanMaxExtent = false;
			// 
			// debugToolStripMenuItem
			// 
			this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dotSpatialTestToolStripMenuItem});
			this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
			resources.ApplyResources(this.debugToolStripMenuItem, "debugToolStripMenuItem");
			// 
			// dotSpatialTestToolStripMenuItem
			// 
			this.dotSpatialTestToolStripMenuItem.Name = "dotSpatialTestToolStripMenuItem";
			resources.ApplyResources(this.dotSpatialTestToolStripMenuItem, "dotSpatialTestToolStripMenuItem");
			this.dotSpatialTestToolStripMenuItem.Click += new System.EventHandler(this.dotSpatialTestToolStripMenuItem_Click);
			// 
			// FormMain
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem procToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openShapefileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shapefileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private DotSpatial.Controls.Map map1;
		private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dotSpatialTestToolStripMenuItem;
	}
}


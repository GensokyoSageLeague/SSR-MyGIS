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
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.legend1 = new DotSpatial.Controls.Legend();
			this.map1 = new DotSpatial.Controls.Map();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.openShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reverseSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.layersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mapRenderingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.procToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.basicOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.landformIdentificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.crescentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toggleDebugLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dotSpatialTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sSRTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sSREnumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
			this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.debuggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.ContentPanel
			// 
			resources.ApplyResources(this.toolStripContainer.ContentPanel, "toolStripContainer.ContentPanel");
			this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer);
			resources.ApplyResources(this.toolStripContainer, "toolStripContainer");
			this.toolStripContainer.Name = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
			// 
			// splitContainer
			// 
			resources.ApplyResources(this.splitContainer, "splitContainer");
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.legend1);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.map1);
			// 
			// legend1
			// 
			this.legend1.BackColor = System.Drawing.Color.White;
			this.legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 200, 368);
			resources.ApplyResources(this.legend1, "legend1");
			this.legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
			this.legend1.HorizontalScrollEnabled = true;
			this.legend1.Indentation = 30;
			this.legend1.IsInitialized = false;
			this.legend1.Name = "legend1";
			this.legend1.ProgressHandler = null;
			this.legend1.ResetOnResize = false;
			this.legend1.SelectionFontColor = System.Drawing.Color.Black;
			this.legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
			this.legend1.VerticalScrollEnabled = true;
			// 
			// map1
			// 
			this.map1.AllowDrop = true;
			this.map1.BackColor = System.Drawing.Color.White;
			this.map1.CollectAfterDraw = false;
			this.map1.CollisionDetection = false;
			resources.ApplyResources(this.map1, "map1");
			this.map1.ExtendBuffer = false;
			this.map1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
			this.map1.IsBusy = false;
			this.map1.IsZoomedToMaxExtent = false;
			this.map1.Legend = this.legend1;
			this.map1.Name = "map1";
			this.map1.ProgressHandler = null;
			this.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
			this.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
			this.map1.RedrawLayersWhileResizing = false;
			this.map1.SelectionEnabled = true;
			this.map1.ZoomOutFartherThanMaxExtent = false;
			// 
			// menuStrip
			// 
			resources.ApplyResources(this.menuStrip, "menuStrip");
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.procToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.debugToolStripMenuItem});
			this.menuStrip.Name = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.openShapefileToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.propertiesToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
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
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			resources.ApplyResources(this.exportToolStripMenuItem, "exportToolStripMenuItem");
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			// 
			// propertiesToolStripMenuItem
			// 
			this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
			resources.ApplyResources(this.propertiesToolStripMenuItem, "propertiesToolStripMenuItem");
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
            this.selectAllToolStripMenuItem,
            this.selectNoneToolStripMenuItem,
            this.reverseSelectionToolStripMenuItem,
            this.toolStripSeparator2,
            this.optionsToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			resources.ApplyResources(this.selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
			// 
			// selectNoneToolStripMenuItem
			// 
			this.selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
			resources.ApplyResources(this.selectNoneToolStripMenuItem, "selectNoneToolStripMenuItem");
			// 
			// reverseSelectionToolStripMenuItem
			// 
			this.reverseSelectionToolStripMenuItem.Name = "reverseSelectionToolStripMenuItem";
			resources.ApplyResources(this.reverseSelectionToolStripMenuItem, "reverseSelectionToolStripMenuItem");
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layersToolStripMenuItem,
            this.mapRenderingToolStripMenuItem,
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
			// 
			// layersToolStripMenuItem
			// 
			this.layersToolStripMenuItem.Checked = true;
			this.layersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.layersToolStripMenuItem.Name = "layersToolStripMenuItem";
			resources.ApplyResources(this.layersToolStripMenuItem, "layersToolStripMenuItem");
			// 
			// mapRenderingToolStripMenuItem
			// 
			this.mapRenderingToolStripMenuItem.Checked = true;
			this.mapRenderingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mapRenderingToolStripMenuItem.Name = "mapRenderingToolStripMenuItem";
			resources.ApplyResources(this.mapRenderingToolStripMenuItem, "mapRenderingToolStripMenuItem");
			// 
			// toolBarToolStripMenuItem
			// 
			this.toolBarToolStripMenuItem.Checked = true;
			this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
			resources.ApplyResources(this.toolBarToolStripMenuItem, "toolBarToolStripMenuItem");
			// 
			// statusBarToolStripMenuItem
			// 
			this.statusBarToolStripMenuItem.Checked = true;
			this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
			resources.ApplyResources(this.statusBarToolStripMenuItem, "statusBarToolStripMenuItem");
			// 
			// procToolStripMenuItem
			// 
			this.procToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicOperationsToolStripMenuItem,
            this.landformIdentificationToolStripMenuItem});
			this.procToolStripMenuItem.Name = "procToolStripMenuItem";
			resources.ApplyResources(this.procToolStripMenuItem, "procToolStripMenuItem");
			// 
			// basicOperationsToolStripMenuItem
			// 
			this.basicOperationsToolStripMenuItem.Name = "basicOperationsToolStripMenuItem";
			resources.ApplyResources(this.basicOperationsToolStripMenuItem, "basicOperationsToolStripMenuItem");
			// 
			// landformIdentificationToolStripMenuItem
			// 
			this.landformIdentificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.crescentToolStripMenuItem});
			this.landformIdentificationToolStripMenuItem.Name = "landformIdentificationToolStripMenuItem";
			resources.ApplyResources(this.landformIdentificationToolStripMenuItem, "landformIdentificationToolStripMenuItem");
			// 
			// lineToolStripMenuItem
			// 
			this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
			resources.ApplyResources(this.lineToolStripMenuItem, "lineToolStripMenuItem");
			// 
			// circleToolStripMenuItem
			// 
			this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
			resources.ApplyResources(this.circleToolStripMenuItem, "circleToolStripMenuItem");
			// 
			// crescentToolStripMenuItem
			// 
			this.crescentToolStripMenuItem.Name = "crescentToolStripMenuItem";
			resources.ApplyResources(this.crescentToolStripMenuItem, "crescentToolStripMenuItem");
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.onlineHelpToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator5,
            this.debuggingToolStripMenuItem,
            this.toggleDebugLogToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
			// 
			// helpToolStripMenuItem1
			// 
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			resources.ApplyResources(this.helpToolStripMenuItem1, "helpToolStripMenuItem1");
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// toggleDebugLogToolStripMenuItem
			// 
			this.toggleDebugLogToolStripMenuItem.Name = "toggleDebugLogToolStripMenuItem";
			resources.ApplyResources(this.toggleDebugLogToolStripMenuItem, "toggleDebugLogToolStripMenuItem");
			this.toggleDebugLogToolStripMenuItem.Click += new System.EventHandler(this.toggleDebugLogToolStripMenuItem_Click);
			// 
			// debugToolStripMenuItem
			// 
			this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dotSpatialTestToolStripMenuItem,
            this.sSRTestToolStripMenuItem,
            this.sSREnumToolStripMenuItem});
			this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
			resources.ApplyResources(this.debugToolStripMenuItem, "debugToolStripMenuItem");
			// 
			// dotSpatialTestToolStripMenuItem
			// 
			this.dotSpatialTestToolStripMenuItem.Name = "dotSpatialTestToolStripMenuItem";
			resources.ApplyResources(this.dotSpatialTestToolStripMenuItem, "dotSpatialTestToolStripMenuItem");
			this.dotSpatialTestToolStripMenuItem.Click += new System.EventHandler(this.dotSpatialTestToolStripMenuItem_Click);
			// 
			// sSRTestToolStripMenuItem
			// 
			this.sSRTestToolStripMenuItem.Name = "sSRTestToolStripMenuItem";
			resources.ApplyResources(this.sSRTestToolStripMenuItem, "sSRTestToolStripMenuItem");
			this.sSRTestToolStripMenuItem.Click += new System.EventHandler(this.sSRTestToolStripMenuItem_Click);
			// 
			// sSREnumToolStripMenuItem
			// 
			this.sSREnumToolStripMenuItem.Name = "sSREnumToolStripMenuItem";
			resources.ApplyResources(this.sSREnumToolStripMenuItem, "sSREnumToolStripMenuItem");
			this.sSREnumToolStripMenuItem.Click += new System.EventHandler(this.sSREnumToolStripMenuItem_Click);
			// 
			// toolStrip1
			// 
			resources.ApplyResources(this.toolStrip1, "toolStrip1");
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
			this.toolStrip1.Name = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
			resources.ApplyResources(this.statusStrip, "statusStrip");
			this.statusStrip.Name = "statusStrip";
			// 
			// statusBar
			// 
			this.statusBar.Name = "statusBar";
			resources.ApplyResources(this.statusBar, "statusBar");
			// 
			// onlineHelpToolStripMenuItem
			// 
			this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
			resources.ApplyResources(this.onlineHelpToolStripMenuItem, "onlineHelpToolStripMenuItem");
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
			// 
			// debuggingToolStripMenuItem
			// 
			resources.ApplyResources(this.debuggingToolStripMenuItem, "debuggingToolStripMenuItem");
			this.debuggingToolStripMenuItem.Name = "debuggingToolStripMenuItem";
			// 
			// FormMain
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.toolStripContainer);
			this.Controls.Add(this.statusStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "FormMain";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
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
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.SplitContainer splitContainer;
		private DotSpatial.Controls.Map map1;
		private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dotSpatialTestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sSRTestToolStripMenuItem;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.ToolStripStatusLabel statusBar;
		private DotSpatial.Controls.Legend legend1;
		private System.Windows.Forms.ToolStripMenuItem sSREnumToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectNoneToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reverseSelectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem basicOperationsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem landformIdentificationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem crescentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem layersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mapRenderingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem toggleDebugLogToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem debuggingToolStripMenuItem;
	}
}


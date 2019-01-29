namespace MyGIS.Desktop {
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
			this.spatialDockManager1 = new DotSpatial.Controls.SpatialDockManager();
			this.legend1 = new DotSpatial.Controls.Legend();
			this.spatialDockManager2 = new DotSpatial.Controls.SpatialDockManager();
			this.map1 = new DotSpatial.Controls.Map();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.layersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.mapRenderingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.zoomToExtentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.procToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.basicOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.landformIdentificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.crescentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kHeaderHelpItemKey = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.debuggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toggleDebugLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.appManager = new DotSpatial.Controls.AppManager();
			this.spatialHeaderControl = new DotSpatial.Controls.SpatialHeaderControl();
			this.spatialStatusStrip = new DotSpatial.Controls.SpatialStatusStrip();
			this.statusBar1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusBarBlocker1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.statusBarBlocker2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).BeginInit();
			this.spatialDockManager1.Panel1.SuspendLayout();
			this.spatialDockManager1.Panel2.SuspendLayout();
			this.spatialDockManager1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spatialDockManager2)).BeginInit();
			this.spatialDockManager2.Panel1.SuspendLayout();
			this.spatialDockManager2.Panel2.SuspendLayout();
			this.spatialDockManager2.SuspendLayout();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spatialHeaderControl)).BeginInit();
			this.spatialStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.ContentPanel
			// 
			resources.ApplyResources(this.toolStripContainer.ContentPanel, "toolStripContainer.ContentPanel");
			this.toolStripContainer.ContentPanel.Controls.Add(this.spatialDockManager1);
			resources.ApplyResources(this.toolStripContainer, "toolStripContainer");
			this.toolStripContainer.Name = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
			// 
			// spatialDockManager1
			// 
			resources.ApplyResources(this.spatialDockManager1, "spatialDockManager1");
			this.spatialDockManager1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.spatialDockManager1.Name = "spatialDockManager1";
			// 
			// spatialDockManager1.Panel1
			// 
			this.spatialDockManager1.Panel1.Controls.Add(this.legend1);
			// 
			// spatialDockManager1.Panel2
			// 
			this.spatialDockManager1.Panel2.Controls.Add(this.spatialDockManager2);
			this.spatialDockManager1.TabControl1 = null;
			this.spatialDockManager1.TabControl2 = null;
			// 
			// legend1
			// 
			this.legend1.BackColor = System.Drawing.Color.White;
			this.legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 200, 395);
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
			// spatialDockManager2
			// 
			resources.ApplyResources(this.spatialDockManager2, "spatialDockManager2");
			this.spatialDockManager2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.spatialDockManager2.Name = "spatialDockManager2";
			// 
			// spatialDockManager2.Panel1
			// 
			this.spatialDockManager2.Panel1.Controls.Add(this.map1);
			// 
			// spatialDockManager2.Panel2
			// 
			this.spatialDockManager2.Panel2.Controls.Add(this.tabControl1);
			this.spatialDockManager2.TabControl1 = this.tabControl1;
			this.spatialDockManager2.TabControl2 = this.tabControl1;
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
			// tabControl1
			// 
			resources.ApplyResources(this.tabControl1, "tabControl1");
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			// 
			// menuStrip
			// 
			resources.ApplyResources(this.menuStrip, "menuStrip");
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.procToolStripMenuItem,
            this.kHeaderHelpItemKey});
			this.menuStrip.Name = "menuStrip";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectNoneToolStripMenuItem,
            this.toolStripSeparator2,
            this.optionsToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
			// 
			// selectNoneToolStripMenuItem
			// 
			resources.ApplyResources(this.selectNoneToolStripMenuItem, "selectNoneToolStripMenuItem");
			this.selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
			this.selectNoneToolStripMenuItem.Click += new System.EventHandler(this.selectNoneToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
			// 
			// optionsToolStripMenuItem
			// 
			resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layersToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.toolBarToolStripMenuItem,
            this.toolStripSeparator6,
            this.mapRenderingToolStripMenuItem,
            this.toolStripSeparator7,
            this.zoomToExtentToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
			// 
			// layersToolStripMenuItem
			// 
			this.layersToolStripMenuItem.Checked = true;
			this.layersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.layersToolStripMenuItem.Name = "layersToolStripMenuItem";
			resources.ApplyResources(this.layersToolStripMenuItem, "layersToolStripMenuItem");
			this.layersToolStripMenuItem.Click += new System.EventHandler(this.layersToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.Checked = true;
			this.toolsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
			this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
			// 
			// toolBarToolStripMenuItem
			// 
			this.toolBarToolStripMenuItem.Checked = true;
			this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
			resources.ApplyResources(this.toolBarToolStripMenuItem, "toolBarToolStripMenuItem");
			this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.toolBarToolStripMenuItem_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
			// 
			// mapRenderingToolStripMenuItem
			// 
			this.mapRenderingToolStripMenuItem.Checked = true;
			this.mapRenderingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mapRenderingToolStripMenuItem.Name = "mapRenderingToolStripMenuItem";
			resources.ApplyResources(this.mapRenderingToolStripMenuItem, "mapRenderingToolStripMenuItem");
			this.mapRenderingToolStripMenuItem.Click += new System.EventHandler(this.mapRenderingToolStripMenuItem_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
			// 
			// zoomToExtentToolStripMenuItem
			// 
			resources.ApplyResources(this.zoomToExtentToolStripMenuItem, "zoomToExtentToolStripMenuItem");
			this.zoomToExtentToolStripMenuItem.Name = "zoomToExtentToolStripMenuItem";
			this.zoomToExtentToolStripMenuItem.Click += new System.EventHandler(this.zoomToExtentToolStripMenuItem_Click);
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
			this.basicOperationsToolStripMenuItem.Checked = true;
			this.basicOperationsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.basicOperationsToolStripMenuItem.Name = "basicOperationsToolStripMenuItem";
			resources.ApplyResources(this.basicOperationsToolStripMenuItem, "basicOperationsToolStripMenuItem");
			this.basicOperationsToolStripMenuItem.Click += new System.EventHandler(this.basicOperationsToolStripMenuItem_Click);
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
			// kHeaderHelpItemKey
			// 
			this.kHeaderHelpItemKey.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.onlineHelpToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator5,
            this.debuggingToolStripMenuItem,
            this.toggleDebugLogToolStripMenuItem});
			this.kHeaderHelpItemKey.Name = "kHeaderHelpItemKey";
			resources.ApplyResources(this.kHeaderHelpItemKey, "kHeaderHelpItemKey");
			// 
			// helpToolStripMenuItem1
			// 
			resources.ApplyResources(this.helpToolStripMenuItem1, "helpToolStripMenuItem1");
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			// 
			// onlineHelpToolStripMenuItem
			// 
			resources.ApplyResources(this.onlineHelpToolStripMenuItem, "onlineHelpToolStripMenuItem");
			this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
			this.onlineHelpToolStripMenuItem.Click += new System.EventHandler(this.onlineHelpToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
			// 
			// aboutToolStripMenuItem
			// 
			resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
			// toggleDebugLogToolStripMenuItem
			// 
			resources.ApplyResources(this.toggleDebugLogToolStripMenuItem, "toggleDebugLogToolStripMenuItem");
			this.toggleDebugLogToolStripMenuItem.Name = "toggleDebugLogToolStripMenuItem";
			this.toggleDebugLogToolStripMenuItem.Click += new System.EventHandler(this.toggleDebugLogToolStripMenuItem_Click);
			// 
			// appManager
			// 
			this.appManager.Directories = ((System.Collections.Generic.List<string>)(resources.GetObject("appManager.Directories")));
			this.appManager.DockManager = this.spatialDockManager2;
			this.appManager.HeaderControl = this.spatialHeaderControl;
			this.appManager.Legend = this.legend1;
			this.appManager.Map = this.map1;
			this.appManager.ProgressHandler = this.spatialStatusStrip;
			this.appManager.ShowExtensionsDialogMode = DotSpatial.Controls.ShowExtensionsDialogMode.Default;
			// 
			// spatialHeaderControl
			// 
			this.spatialHeaderControl.ApplicationManager = this.appManager;
			this.spatialHeaderControl.MenuStrip = this.menuStrip;
			this.spatialHeaderControl.ToolbarsContainer = this.toolStripContainer.TopToolStripPanel;
			// 
			// spatialStatusStrip
			// 
			this.spatialStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.spatialStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar1,
            this.statusBarBlocker1,
            this.progressBar,
            this.statusBarBlocker2});
			resources.ApplyResources(this.spatialStatusStrip, "spatialStatusStrip");
			this.spatialStatusStrip.Name = "spatialStatusStrip";
			this.spatialStatusStrip.ProgressBar = this.progressBar;
			this.spatialStatusStrip.ProgressLabel = this.statusBar1;
			// 
			// statusBar1
			// 
			this.statusBar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.statusBar1.Name = "statusBar1";
			resources.ApplyResources(this.statusBar1, "statusBar1");
			// 
			// statusBarBlocker1
			// 
			this.statusBarBlocker1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.statusBarBlocker1.Name = "statusBarBlocker1";
			resources.ApplyResources(this.statusBarBlocker1, "statusBarBlocker1");
			// 
			// progressBar
			// 
			this.progressBar.Name = "progressBar";
			resources.ApplyResources(this.progressBar, "progressBar");
			this.progressBar.Paint += new System.Windows.Forms.PaintEventHandler(this.progressBar_Paint);
			// 
			// statusBarBlocker2
			// 
			this.statusBarBlocker2.Name = "statusBarBlocker2";
			resources.ApplyResources(this.statusBarBlocker2, "statusBarBlocker2");
			this.statusBarBlocker2.Spring = true;
			// 
			// FormMain
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.spatialStatusStrip);
			this.Controls.Add(this.toolStripContainer);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "FormMain";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.spatialDockManager1.Panel1.ResumeLayout(false);
			this.spatialDockManager1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).EndInit();
			this.spatialDockManager1.ResumeLayout(false);
			this.spatialDockManager2.Panel1.ResumeLayout(false);
			this.spatialDockManager2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spatialDockManager2)).EndInit();
			this.spatialDockManager2.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spatialHeaderControl)).EndInit();
			this.spatialStatusStrip.ResumeLayout(false);
			this.spatialStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem procToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kHeaderHelpItemKey;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.ToolStripMenuItem selectNoneToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem landformIdentificationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem crescentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem layersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mapRenderingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem toggleDebugLogToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem debuggingToolStripMenuItem;
		private DotSpatial.Controls.AppManager appManager;
		private DotSpatial.Controls.SpatialStatusStrip spatialStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel statusBar1;
		private System.Windows.Forms.ToolStripStatusLabel statusBarBlocker2;
		private DotSpatial.Controls.SpatialDockManager spatialDockManager1;
		private DotSpatial.Controls.SpatialHeaderControl spatialHeaderControl;
		private System.Windows.Forms.ToolStripProgressBar progressBar;
		private System.Windows.Forms.ToolStripStatusLabel statusBarBlocker1;
		private DotSpatial.Controls.Legend legend1;
		private System.Windows.Forms.TabControl tabControl1;
		internal DotSpatial.Controls.Map map1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem zoomToExtentToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem basicOperationsToolStripMenuItem;
		internal DotSpatial.Controls.SpatialDockManager spatialDockManager2;
		internal System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
	}
}


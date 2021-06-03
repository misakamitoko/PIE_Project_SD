
namespace PIE_Project_SD
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.button_clear = new System.Windows.Forms.ToolStripButton();
            this.Button_chooseArea = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labMapName = new System.Windows.Forms.ToolStripStatusLabel();
            this.labLayerNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.labCoor = new System.Windows.Forms.ToolStripStatusLabel();
            this.labPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.labScreenXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip_FeatureLayer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteFeatureLayer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomtoFeatureLayer_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip_FeatureLayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.button_clear,
            this.Button_chooseArea});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1014, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(122, 28);
            this.toolStripButton1.Text = "添加地图数据";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // button_clear
            // 
            this.button_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_clear.Image = ((System.Drawing.Image)(resources.GetObject("button_clear.Image")));
            this.button_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(86, 28);
            this.button_clear.Text = "清除数据";
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Button_chooseArea
            // 
            this.Button_chooseArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Button_chooseArea.Image = ((System.Drawing.Image)(resources.GetObject("Button_chooseArea.Image")));
            this.Button_chooseArea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_chooseArea.Name = "Button_chooseArea";
            this.Button_chooseArea.Size = new System.Drawing.Size(86, 28);
            this.Button_chooseArea.Text = "选定范围";
            this.Button_chooseArea.Click += new System.EventHandler(this.Button_chooseArea_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1014, 464);
            this.splitContainer1.SplitterDistance = 296;
            this.splitContainer1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labMapName,
            this.labLayerNum,
            this.labCoor,
            this.labPosition,
            this.labScreenXY});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1014, 31);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labMapName
            // 
            this.labMapName.Enabled = false;
            this.labMapName.Name = "labMapName";
            this.labMapName.Size = new System.Drawing.Size(82, 24);
            this.labMapName.Text = "地图名称";
            // 
            // labLayerNum
            // 
            this.labLayerNum.Name = "labLayerNum";
            this.labLayerNum.Size = new System.Drawing.Size(82, 24);
            this.labLayerNum.Text = "图层数目";
            this.labLayerNum.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // labCoor
            // 
            this.labCoor.Name = "labCoor";
            this.labCoor.Size = new System.Drawing.Size(64, 24);
            this.labCoor.Text = "坐标系";
            this.labCoor.Click += new System.EventHandler(this.coordinateSystem_Click);
            // 
            // labPosition
            // 
            this.labPosition.Name = "labPosition";
            this.labPosition.Size = new System.Drawing.Size(82, 24);
            this.labPosition.Text = "地图坐标";
            // 
            // labScreenXY
            // 
            this.labScreenXY.Name = "labScreenXY";
            this.labScreenXY.Size = new System.Drawing.Size(82, 24);
            this.labScreenXY.Text = "屏幕坐标";
            // 
            // contextMenuStrip_FeatureLayer
            // 
            this.contextMenuStrip_FeatureLayer.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_FeatureLayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteFeatureLayer_MenuItem,
            this.ZoomtoFeatureLayer_MenuItem});
            this.contextMenuStrip_FeatureLayer.Name = "contextMenuStrip_FeatureLayer";
            this.contextMenuStrip_FeatureLayer.Size = new System.Drawing.Size(171, 64);
            // 
            // DeleteFeatureLayer_MenuItem
            // 
            this.DeleteFeatureLayer_MenuItem.Name = "DeleteFeatureLayer_MenuItem";
            this.DeleteFeatureLayer_MenuItem.Size = new System.Drawing.Size(170, 30);
            this.DeleteFeatureLayer_MenuItem.Text = "删除图层";
            // 
            // ZoomtoFeatureLayer_MenuItem
            // 
            this.ZoomtoFeatureLayer_MenuItem.Name = "ZoomtoFeatureLayer_MenuItem";
            this.ZoomtoFeatureLayer_MenuItem.Size = new System.Drawing.Size(170, 30);
            this.ZoomtoFeatureLayer_MenuItem.Text = "缩放至图层";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1014, 497);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "PIEDemo";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip_FeatureLayer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labMapName;
        private System.Windows.Forms.ToolStripStatusLabel labLayerNum;
        private System.Windows.Forms.ToolStripStatusLabel labCoor;
        private System.Windows.Forms.ToolStripStatusLabel labPosition;
        private System.Windows.Forms.ToolStripStatusLabel labScreenXY;
        private System.Windows.Forms.ToolStripButton button_clear;
        private System.Windows.Forms.ToolStripButton Button_chooseArea;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_FeatureLayer;
        private System.Windows.Forms.ToolStripMenuItem DeleteFeatureLayer_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomtoFeatureLayer_MenuItem;
    }
}


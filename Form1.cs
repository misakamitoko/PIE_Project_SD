using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIE.AxControls;
using PIE.Carto;
using PIE.Controls;
using PIE.CommonAlgo;
using PIE.Framework;
using System.Windows.Forms;
using PIE.SystemUI;
using PIEdll;
namespace PIE_Project_SD
{

    public partial class Form1 : Form
    {
        private MapControl myMapCtrl;
        private TOCControl myToolCtrl;
        public Form1()
        {
            InitializeComponent();
            // ADD ToCControl
            var myToolCtrl = new TOCControl();
            myToolCtrl.Dock = DockStyle.Fill;
            splitContainer1.Panel1.Controls.Add(myToolCtrl);

            // ADD MapControl
            myMapCtrl = new MapControl();
            myMapCtrl.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(myMapCtrl);
            //绑定
            myToolCtrl.SetBuddyControl(myMapCtrl);
            myMapCtrl.MouseMove += Mapctrl_Move;
            myToolCtrl.SetBuddyControl(myMapCtrl);
            labMapName.Text = $"地图名称:{myMapCtrl.FocusMap.Name}";
            labLayerNum.Text = $"图层数目:{myMapCtrl.FocusMap.LayerCount}";
            //labCoor.Text = $"坐标系:{myMapCtrl.FocusMap.SpatialReference.ExportToPrettyWkt()}";
           
            myToolCtrl.MouseClick += myToolCtrl_MouseClick;

        }
        private void myToolCtrl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PIETOCNodeType type = PIETOCNodeType.Null;
                IMap map = null;
                ILayer layer = null;
                Object unk = Type.Missing;
                Object data = Type.Missing;
                myToolCtrl.HitTest(e.X, e.Y, ref type, ref map, ref layer, ref unk, ref data);
                this.contextMenuStrip_FeatureLayer.Show(new System.Drawing.Point(e.X, e.Y));
                switch (type)
                {
                    case PIETOCNodeType.FeatureLayer:
                        IFeatureLayer featureLayer = layer as IFeatureLayer;
                        if (featureLayer == null) return;

                        //显示菜单
                        break;
                }
            }
        }
                private void Mapctrl_Move(object sender,MouseEventArgs e)
        {
            //显示鼠标所在位置
            labScreenXY.Text = $"屏幕坐标:{e.X},{e.Y}";
            var mapPnt = myMapCtrl.ToMapPoint(e.X, e.Y);
            labPosition.Text = $"地图坐标:{mapPnt.X},{mapPnt.Y}";
        }
            private void toolStripButton1_Click(object sender, EventArgs e)
            {
            var add = new PIE_Project_SD.Control();
            add.AddMap1(myMapCtrl);
            labMapName.Text = $"地图名称:{myMapCtrl.FocusMap.Name}";
            labLayerNum.Text = $"图层数目:{myMapCtrl.FocusMap.LayerCount}";
            labCoor.Text = $"坐标系:{myMapCtrl.FocusMap.SpatialReference.ExportToPrettyWkt()}";
        }
        private void TOCMenuItem_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return;

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item == null) return;

            ICommand command = item.Tag as ICommand;
            if (command == null) return;
            command.OnCreate(myMapCtrl); //必须加
            command.OnClick();

            ITool tool = command as ITool;
            if (tool != null)
            {
                myMapCtrl.CurrentTool = tool;
            }
        }


        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            

        }

        private void coordinateSystem_Click(object sender, EventArgs e)
        {
           
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            myMapCtrl.DeleteLayer(0);
            myMapCtrl.PartialRefresh(PIE.Carto.ViewDrawPhaseType.ViewAll);
        }

        private void Button_chooseArea_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }
    }
    }


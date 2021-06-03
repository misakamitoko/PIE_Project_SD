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
using System.Windows.Forms;
using PIE.CommonAlgo;
using PIE.Controls;
namespace PIE_Project_SD
{
    public class Control
    {
        public void AddMap1(MapControl myMapCtrl )
        {

            var ofd = new OpenFileDialog();
            //ofd.Filter = "ShapeFile|*.shp";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var file = ofd.FileName;
                var layer = PIE.Carto.LayerFactory.CreateDefaultLayer(file);
                if (layer == null)
                    return;
                myMapCtrl.AddLayer(layer, 0);

            }

        }
        
            }

        }


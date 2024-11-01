using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.Blob;
using Cognex.VisionPro.Display;


namespace Cognex_Test
{
    public partial class Form1 : Form
    {
        string imagePath;
        Bitmap bitmap;
        ICogImage cogImage;
        dynamic shape;


        public Form1()
        {
            InitializeComponent();
            init_listShape();
            cb_tool.Items.Add("Blob");
        }

        void LoadImage()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            
            imagePath = ofd.FileName;
            bitmap = new Bitmap(imagePath);
            cogImage = new CogImage8Grey(bitmap);

            cogDisplay_main.Image = cogImage;
            cogDisplay_main.AutoFit = true;
        }

        void init_listShape()
        {
            cb_toolShape.Items.Add("Rectangle Affine");
            cb_toolShape.Items.Add("Circle");
        }

        private void btn_loadImage_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void cb_tool_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cogRectangleAffine = new CogRectangleAffine();

            if (cb_tool.SelectedItem.ToString() == "Blob")
            {

                if(cb_toolShape.SelectedItem == null)
                {
                    shape = new CogRectangleAffine();
                }
                else if(cb_toolShape.SelectedItem.ToString() == "Rectangle Affine")
                {
                    shape = new CogRectangleAffine();
                }
               

                init_shape(shape);
                
                cogDisplay_main.InteractiveGraphics.Add(shape, "RectangleAffine", false);
            }
        }
        private void cb_toolShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_toolShape.SelectedItem == null)
            {
                shape = new CogRectangleAffine();
            }
            else if (cb_toolShape.SelectedItem.ToString() == "Rectangle Affine")
            {
                shape = new CogRectangleAffine();
                delete_shape();
                cogDisplay_main.InteractiveGraphics.Add(shape, "RectangleAffine", false);
            }
            else if(cb_toolShape.SelectedItem.ToString() == "Circle")
            {
                shape = new CogCircle();
                delete_shape();
                cogDisplay_main.InteractiveGraphics.Add(shape, "Circle", false);
            }

            init_shape(shape);
        }

        void init_shape(dynamic shape)
        {
            shape.Interactive = true;
            shape.Selected = true;
            shape.GraphicDOFEnableBase = CogGraphicDOFConstants.All;
            shape.MouseCursor = CogStandardCursorConstants.Default;
        }
        void delete_shape()
        {
            cogDisplay_main.InteractiveGraphics.Clear();
            //cogDisplay_main.InteractiveGraphics.Remove("RectangleAffine");
            //cogDisplay_main.InteractiveGraphics.Remove("Circle");
        }
        void blob_inspection()
        {
            CogBlobTool blobTool = new CogBlobTool();
            int pixel=0;
            
            blobTool.RunParams.SegmentationParams.Mode = CogBlobSegmentationModeConstants.HardFixedThreshold;
            blobTool.RunParams.SegmentationParams.Polarity = CogBlobSegmentationPolarityConstants.LightBlobs;
            blobTool.RunParams.SegmentationParams.HardFixedThreshold = (int)nup_threshold.Value;
            blobTool.InputImage = cogDisplay_main.Image;
            blobTool.Region = shape;

            blobTool.Run();

            CogBlobResults result = blobTool.Results;
            CogBlobResultCollection rc =  result.GetBlobs();
            for(int i=0; i<rc.Count; i++)
            {
                pixel += (int)rc[i].Area;
            }
            
            MessageBox.Show(pixel.ToString());
        }

        private void btn_inspect_Click(object sender, EventArgs e)
        {
            blob_inspection();
        }

        
    }
}

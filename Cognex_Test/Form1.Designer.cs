namespace Cognex_Test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cogDisplay_main = new Cognex.VisionPro.Display.CogDisplay();
            this.btn_loadImage = new System.Windows.Forms.Button();
            this.cb_tool = new System.Windows.Forms.ComboBox();
            this.btn_inspect = new System.Windows.Forms.Button();
            this.nup_threshold = new System.Windows.Forms.NumericUpDown();
            this.cb_toolShape = new System.Windows.Forms.ComboBox();
            this.lb_toolName = new System.Windows.Forms.Label();
            this.lb_shape = new System.Windows.Forms.Label();
            this.lb_threshold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_threshold)).BeginInit();
            this.SuspendLayout();
            // 
            // cogDisplay_main
            // 
            this.cogDisplay_main.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay_main.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay_main.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay_main.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay_main.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay_main.DoubleTapZoomCycleLength = 2;
            this.cogDisplay_main.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay_main.Location = new System.Drawing.Point(29, 34);
            this.cogDisplay_main.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay_main.MouseWheelSensitivity = 1D;
            this.cogDisplay_main.Name = "cogDisplay_main";
            this.cogDisplay_main.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay_main.OcxState")));
            this.cogDisplay_main.Size = new System.Drawing.Size(611, 522);
            this.cogDisplay_main.TabIndex = 1;
            // 
            // btn_loadImage
            // 
            this.btn_loadImage.Location = new System.Drawing.Point(659, 34);
            this.btn_loadImage.Name = "btn_loadImage";
            this.btn_loadImage.Size = new System.Drawing.Size(92, 23);
            this.btn_loadImage.TabIndex = 2;
            this.btn_loadImage.Text = "이미지 로드";
            this.btn_loadImage.UseVisualStyleBackColor = true;
            this.btn_loadImage.Click += new System.EventHandler(this.btn_loadImage_Click);
            // 
            // cb_tool
            // 
            this.cb_tool.FormattingEnabled = true;
            this.cb_tool.Location = new System.Drawing.Point(659, 199);
            this.cb_tool.Name = "cb_tool";
            this.cb_tool.Size = new System.Drawing.Size(121, 20);
            this.cb_tool.TabIndex = 3;
            this.cb_tool.SelectedIndexChanged += new System.EventHandler(this.cb_tool_SelectedIndexChanged);
            // 
            // btn_inspect
            // 
            this.btn_inspect.Location = new System.Drawing.Point(659, 510);
            this.btn_inspect.Name = "btn_inspect";
            this.btn_inspect.Size = new System.Drawing.Size(75, 23);
            this.btn_inspect.TabIndex = 4;
            this.btn_inspect.Text = "검사";
            this.btn_inspect.UseVisualStyleBackColor = true;
            this.btn_inspect.Click += new System.EventHandler(this.btn_inspect_Click);
            // 
            // nup_threshold
            // 
            this.nup_threshold.Location = new System.Drawing.Point(659, 379);
            this.nup_threshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nup_threshold.Name = "nup_threshold";
            this.nup_threshold.Size = new System.Drawing.Size(120, 21);
            this.nup_threshold.TabIndex = 5;
            // 
            // cb_toolShape
            // 
            this.cb_toolShape.FormattingEnabled = true;
            this.cb_toolShape.Location = new System.Drawing.Point(659, 244);
            this.cb_toolShape.Name = "cb_toolShape";
            this.cb_toolShape.Size = new System.Drawing.Size(121, 20);
            this.cb_toolShape.TabIndex = 6;
            this.cb_toolShape.SelectedIndexChanged += new System.EventHandler(this.cb_toolShape_SelectedIndexChanged);
            // 
            // lb_toolName
            // 
            this.lb_toolName.AutoSize = true;
            this.lb_toolName.Location = new System.Drawing.Point(659, 181);
            this.lb_toolName.Name = "lb_toolName";
            this.lb_toolName.Size = new System.Drawing.Size(30, 12);
            this.lb_toolName.TabIndex = 7;
            this.lb_toolName.Text = "Tool";
            // 
            // lb_shape
            // 
            this.lb_shape.AutoSize = true;
            this.lb_shape.Location = new System.Drawing.Point(659, 229);
            this.lb_shape.Name = "lb_shape";
            this.lb_shape.Size = new System.Drawing.Size(70, 12);
            this.lb_shape.TabIndex = 8;
            this.lb_shape.Text = "Tool Shape";
            // 
            // lb_threshold
            // 
            this.lb_threshold.AutoSize = true;
            this.lb_threshold.Location = new System.Drawing.Point(661, 361);
            this.lb_threshold.Name = "lb_threshold";
            this.lb_threshold.Size = new System.Drawing.Size(62, 12);
            this.lb_threshold.TabIndex = 9;
            this.lb_threshold.Text = "Threshold";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 569);
            this.Controls.Add(this.lb_threshold);
            this.Controls.Add(this.lb_shape);
            this.Controls.Add(this.lb_toolName);
            this.Controls.Add(this.cb_toolShape);
            this.Controls.Add(this.nup_threshold);
            this.Controls.Add(this.btn_inspect);
            this.Controls.Add(this.cb_tool);
            this.Controls.Add(this.btn_loadImage);
            this.Controls.Add(this.cogDisplay_main);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_threshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Cognex.VisionPro.Display.CogDisplay cogDisplay_main;
        private System.Windows.Forms.Button btn_loadImage;
        private System.Windows.Forms.ComboBox cb_tool;
        private System.Windows.Forms.Button btn_inspect;
        private System.Windows.Forms.NumericUpDown nup_threshold;
        private System.Windows.Forms.ComboBox cb_toolShape;
        private System.Windows.Forms.Label lb_toolName;
        private System.Windows.Forms.Label lb_shape;
        private System.Windows.Forms.Label lb_threshold;
    }
}


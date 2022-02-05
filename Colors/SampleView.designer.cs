namespace Colors
{
    partial class SampleView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fpnlSample = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSampleRgbPrompt = new System.Windows.Forms.Label();
            this.lblSampleRgb = new System.Windows.Forms.Label();
            this.lblSampleHexPrompt = new System.Windows.Forms.Label();
            this.lblSampleHex = new System.Windows.Forms.Label();
            this.lblSampleHsvPrompt = new System.Windows.Forms.Label();
            this.lblSampleHsv = new System.Windows.Forms.Label();
            this.lblSampleCmykPrompt = new System.Windows.Forms.Label();
            this.lblSampleCmyk = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fpnlSample.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnlSample
            // 
            this.fpnlSample.AutoScroll = true;
            this.fpnlSample.BackColor = System.Drawing.Color.Black;
            this.fpnlSample.Controls.Add(this.lblSampleRgbPrompt);
            this.fpnlSample.Controls.Add(this.lblSampleRgb);
            this.fpnlSample.Controls.Add(this.lblSampleHexPrompt);
            this.fpnlSample.Controls.Add(this.lblSampleHex);
            this.fpnlSample.Controls.Add(this.lblSampleHsvPrompt);
            this.fpnlSample.Controls.Add(this.lblSampleHsv);
            this.fpnlSample.Controls.Add(this.lblSampleCmykPrompt);
            this.fpnlSample.Controls.Add(this.lblSampleCmyk);
            this.fpnlSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlSample.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlSample.ForeColor = System.Drawing.Color.White;
            this.fpnlSample.Location = new System.Drawing.Point(0, 0);
            this.fpnlSample.Name = "fpnlSample";
            this.fpnlSample.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fpnlSample.Size = new System.Drawing.Size(310, 270);
            this.fpnlSample.TabIndex = 4;
            this.fpnlSample.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fpnlSample_MouseClick);
            // 
            // lblSampleRgbPrompt
            // 
            this.lblSampleRgbPrompt.AutoSize = true;
            this.lblSampleRgbPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblSampleRgbPrompt.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampleRgbPrompt.Location = new System.Drawing.Point(8, 5);
            this.lblSampleRgbPrompt.Name = "lblSampleRgbPrompt";
            this.lblSampleRgbPrompt.Size = new System.Drawing.Size(29, 13);
            this.lblSampleRgbPrompt.TabIndex = 0;
            this.lblSampleRgbPrompt.Text = "RGB";
            this.lblSampleRgbPrompt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblSampleIndicator_MouseClick);
            // 
            // lblSampleRgb
            // 
            this.lblSampleRgb.AutoSize = true;
            this.lblSampleRgb.BackColor = System.Drawing.Color.Transparent;
            this.lblSampleRgb.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSampleRgb.Location = new System.Drawing.Point(8, 18);
            this.lblSampleRgb.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
            this.lblSampleRgb.Name = "lblSampleRgb";
            this.lblSampleRgb.Size = new System.Drawing.Size(123, 30);
            this.lblSampleRgb.TabIndex = 1;
            this.lblSampleRgb.Text = "rgb(0, 0, 0)";
            this.lblSampleRgb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblSampleIndicator_MouseClick);
            // 
            // lblSampleHexPrompt
            // 
            this.lblSampleHexPrompt.AutoSize = true;
            this.lblSampleHexPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblSampleHexPrompt.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampleHexPrompt.Location = new System.Drawing.Point(8, 65);
            this.lblSampleHexPrompt.Name = "lblSampleHexPrompt";
            this.lblSampleHexPrompt.Size = new System.Drawing.Size(73, 13);
            this.lblSampleHexPrompt.TabIndex = 2;
            this.lblSampleHexPrompt.Text = "Hexadecimal";
            this.lblSampleHexPrompt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblSampleIndicator_MouseClick);
            // 
            // lblSampleHex
            // 
            this.lblSampleHex.AutoSize = true;
            this.lblSampleHex.BackColor = System.Drawing.Color.Transparent;
            this.lblSampleHex.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSampleHex.Location = new System.Drawing.Point(8, 78);
            this.lblSampleHex.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
            this.lblSampleHex.Name = "lblSampleHex";
            this.lblSampleHex.Size = new System.Drawing.Size(97, 30);
            this.lblSampleHex.TabIndex = 3;
            this.lblSampleHex.Text = "#000000";
            this.lblSampleHex.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblSampleIndicator_MouseClick);
            // 
            // lblSampleHsvPrompt
            // 
            this.lblSampleHsvPrompt.AutoSize = true;
            this.lblSampleHsvPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblSampleHsvPrompt.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampleHsvPrompt.Location = new System.Drawing.Point(8, 125);
            this.lblSampleHsvPrompt.Name = "lblSampleHsvPrompt";
            this.lblSampleHsvPrompt.Size = new System.Drawing.Size(28, 13);
            this.lblSampleHsvPrompt.TabIndex = 4;
            this.lblSampleHsvPrompt.Text = "HSV";
            this.lblSampleHsvPrompt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblSampleIndicator_MouseClick);
            // 
            // lblSampleHsv
            // 
            this.lblSampleHsv.AutoSize = true;
            this.lblSampleHsv.BackColor = System.Drawing.Color.Transparent;
            this.lblSampleHsv.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSampleHsv.Location = new System.Drawing.Point(8, 138);
            this.lblSampleHsv.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
            this.lblSampleHsv.Name = "lblSampleHsv";
            this.lblSampleHsv.Size = new System.Drawing.Size(122, 30);
            this.lblSampleHsv.TabIndex = 5;
            this.lblSampleHsv.Text = "hsv(0, 0, 0)";
            this.lblSampleHsv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblSampleIndicator_MouseClick);
            // 
            // lblSampleCmykPrompt
            // 
            this.lblSampleCmykPrompt.AutoSize = true;
            this.lblSampleCmykPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblSampleCmykPrompt.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampleCmykPrompt.Location = new System.Drawing.Point(8, 185);
            this.lblSampleCmykPrompt.Name = "lblSampleCmykPrompt";
            this.lblSampleCmykPrompt.Size = new System.Drawing.Size(37, 13);
            this.lblSampleCmykPrompt.TabIndex = 6;
            this.lblSampleCmykPrompt.Text = "CMYK";
            this.lblSampleCmykPrompt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblSampleIndicator_MouseClick);
            // 
            // lblSampleCmyk
            // 
            this.lblSampleCmyk.AutoSize = true;
            this.lblSampleCmyk.BackColor = System.Drawing.Color.Transparent;
            this.lblSampleCmyk.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSampleCmyk.Location = new System.Drawing.Point(137, 5);
            this.lblSampleCmyk.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
            this.lblSampleCmyk.Name = "lblSampleCmyk";
            this.lblSampleCmyk.Size = new System.Drawing.Size(145, 90);
            this.lblSampleCmyk.TabIndex = 7;
            this.lblSampleCmyk.Text = "cmyk(100%, 100%, 100%, 100%)";
            this.lblSampleCmyk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblSampleIndicator_MouseClick);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 0;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // SampleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpnlSample);
            this.MinimumSize = new System.Drawing.Size(310, 270);
            this.Name = "SampleView";
            this.Size = new System.Drawing.Size(310, 270);
            this.fpnlSample.ResumeLayout(false);
            this.fpnlSample.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlSample;
        private System.Windows.Forms.Label lblSampleRgbPrompt;
        private System.Windows.Forms.Label lblSampleRgb;
        private System.Windows.Forms.Label lblSampleHexPrompt;
        private System.Windows.Forms.Label lblSampleHex;
        private System.Windows.Forms.Label lblSampleHsvPrompt;
        private System.Windows.Forms.Label lblSampleHsv;
        private System.Windows.Forms.Label lblSampleCmykPrompt;
        private System.Windows.Forms.Label lblSampleCmyk;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

namespace Colors
{
    partial class ColorPaletteControl
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fpnlLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // fpnlLayout
            // 
            this.fpnlLayout.AutoScroll = true;
            this.fpnlLayout.BackColor = System.Drawing.SystemColors.Window;
            this.fpnlLayout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fpnlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlLayout.Location = new System.Drawing.Point(0, 0);
            this.fpnlLayout.Margin = new System.Windows.Forms.Padding(0);
            this.fpnlLayout.Name = "fpnlLayout";
            this.fpnlLayout.Padding = new System.Windows.Forms.Padding(3);
            this.fpnlLayout.Size = new System.Drawing.Size(207, 288);
            this.fpnlLayout.TabIndex = 3;
            // 
            // ColorPaletteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpnlLayout);
            this.Name = "ColorPaletteControl";
            this.Size = new System.Drawing.Size(207, 288);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.FlowLayoutPanel fpnlLayout;
    }
}

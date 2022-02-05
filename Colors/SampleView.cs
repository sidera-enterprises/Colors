using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    public partial class SampleView : UserControl
    {
        private Color _selected;
        public SampleView()
        {
            InitializeComponent();

            SelectedColor = Color.Black;
        }

        public Color SelectedColor
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;

                int red = _selected.R;
                int green = _selected.G;
                int blue = _selected.B;

                fpnlSample.BackColor = Color.FromArgb(red, green, blue);
                fpnlSample.ForeColor = Color.FromArgb(255 - red, 255 - green, 255 - blue);

                lblSampleRgb.Text = string.Format("rgb({0}, {1}, {2})", red, green, blue);
                lblSampleHex.Text = ColorConvert.RgbToHex(red, green, blue);
                lblSampleHsv.Text = string.Format("hsv({0})", string.Join(", ", ColorConvert.RgbToHsv(red, green, blue)));
                lblSampleCmyk.Text = string.Format("cmyk({0}%)", string.Join("%, ", ColorConvert.RgbToCmyk(red, green, blue)));

                StringBuilder rgb = new StringBuilder();
                StringBuilder hex = new StringBuilder();
                StringBuilder hsv = new StringBuilder();
                StringBuilder cmyk = new StringBuilder();
                StringBuilder title = new StringBuilder();
                
                rgb.AppendLine("RGB:");
                rgb.AppendLine(Rgb);
                
                hex.AppendLine("Hexadecimal:");
                hex.AppendLine(Hex);
                
                hsv.AppendLine("HSV:");
                hsv.AppendLine(Hsv);
                
                cmyk.AppendLine("CMYK:");
                cmyk.AppendLine(Cmyk);

                title.AppendLine(rgb.ToString());
                title.AppendLine(hex.ToString());
                title.AppendLine(hsv.ToString());
                title.AppendLine(cmyk.ToString());

                toolTip.SetToolTip(lblSampleRgbPrompt, rgb.ToString());
                toolTip.SetToolTip(lblSampleRgb, rgb.ToString());

                toolTip.SetToolTip(lblSampleHexPrompt, hex.ToString());
                toolTip.SetToolTip(lblSampleHex, hex.ToString());

                toolTip.SetToolTip(lblSampleHsvPrompt, hsv.ToString());
                toolTip.SetToolTip(lblSampleHsv, hsv.ToString());

                toolTip.SetToolTip(lblSampleCmykPrompt, cmyk.ToString());
                toolTip.SetToolTip(lblSampleCmyk, cmyk.ToString());

                toolTip.SetToolTip(fpnlSample, title.ToString());
            }
        }

        public string Rgb
        {
            get
            {
                return lblSampleRgb.Text;
            }
        }

        public string Hex
        {
            get
            {
                return lblSampleHex.Text;
            }
        }
        
        public string Hsv
        {
            get
            {
                return lblSampleHsv.Text;
            }
        }

        public string Cmyk
        {
            get
            {
                return lblSampleCmyk.Text;
            }
        }

        private void fpnlSample_MouseClick(object sender, MouseEventArgs e)
        {
            OnMouseClick(e);
        }

        private void lblSampleIndicator_MouseClick(object sender, MouseEventArgs e)
        {
            OnMouseClick(e);
        }
    }
}

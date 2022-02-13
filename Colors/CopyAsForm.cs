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
    public partial class CopyAsForm : Form
    {
        private Color _color;
        public CopyAsForm(Color color)
        {
            InitializeComponent();

            _color = color;
        }

        private void lvwOptions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && lvwOptions.SelectedItems.Count > 0)
                btnOK.PerformClick();
        }

        public string CopyText
        {
            get
            {
                switch (lvwOptions.SelectedIndices[0])
                {
                    case 0:
                        return string.Format("rgb({0}, {1}, {2})", _color.R, _color.G, _color.B);
                    case 1:
                        return ColorConvert.RgbToHex(_color.R, _color.G, _color.B);
                    default:
                        throw new Exception("No option selected.");
                }
            }
        }
    }
}

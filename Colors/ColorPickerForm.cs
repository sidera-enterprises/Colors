using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Colors
{
    public partial class ColorPickerForm : Form
    {
        private List<Keys> _keypresses;

        private bool _fullscreen;
        private SampleView _selectedSampleView;

        private bool _switch;
        private Color _default;

        public ColorPickerForm() : this(0, 0, 0) { }

        public ColorPickerForm(int red, int green, int blue) : this(red, green, blue, false) { }

        public ColorPickerForm(bool party) : this(0, 0, 0, party) { }

        public ColorPickerForm(int red, int green, int blue, bool party)
        {
            InitializeComponent();

            _keypresses = new List<Keys>();

            _fullscreen = false;
            _selectedSampleView = sampleView1;

            _switch = false;

            tbRed.Value = Math.Min(0, Math.Max(red, 255));
            tbGreen.Value = Math.Min(0, Math.Max(green, 255));
            tbBlue.Value = Math.Min(0, Math.Max(blue, 255));
            _default = ColorConvert.FromRgb(red, green, blue);

            sampleView1.SelectedColor = _default;
            sampleView2.SelectedColor = _default;

            if (party)
                tmrParty.Start();
        }

        private SampleView SelectedSampleView
        {
            get { return _selectedSampleView; }
        }

        private bool FullScreen
        {
            get { return _fullscreen; }
            set
            {
                _fullscreen = value;

                if (WindowState == FormWindowState.Maximized)
                    WindowState = FormWindowState.Normal;

                mnuToolbar.Visible
                    = tpnlColorTracks.Visible
                    = colorPalette.Visible
                    = mnuStatusBar.Visible = !_fullscreen;

                FormBorderStyle = _fullscreen ? FormBorderStyle.None : FormBorderStyle.Sizable;
                WindowState = _fullscreen ? FormWindowState.Maximized : FormWindowState.Normal;
            }
        }

        private void ColorPickerForm_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = false;

            if (_keypresses != null)
            {
                _keypresses.Add(e.KeyCode);

                var template = new Keys[]
                {
                    Keys.Up,
                    Keys.Up,
                    Keys.Down,
                    Keys.Down,
                    Keys.Left,
                    Keys.Right,
                    Keys.Left,
                    Keys.Right,
                    Keys.B,
                    Keys.A
                };

                string t = string.Join(",", template);
                string k = string.Join(",", _keypresses);

                if (!t.StartsWith(k))
                    _keypresses.Clear();

                if (k == t)
                {
                    _keypresses.Clear();
                    tmrParty.Start();
                }
            }
        }

        private void tmrParty_Tick(object sender, EventArgs e)
        {
            const int MIN = 0, MAX = 255;

            int r = tbRed.Value;
            int g = tbGreen.Value;
            int b = tbBlue.Value;

            if (r < MAX && g == MIN)
                tbRed.Value++;
            else if (g < MAX && b == MIN)
                tbGreen.Value++;
            else if (r > MIN && g == MAX)
                tbRed.Value--;
            else if (b < MAX && r == MIN)
                tbBlue.Value++;
            else if (g > MIN && b == MAX)
                tbGreen.Value--;
            else if (b > MIN && g == MIN)
                tbBlue.Value--;
            else
            {
                tbRed.Value = 0;
                tbGreen.Value = 0;
                tbBlue.Value = 0;
            }
            

            //if (tbBlue.Value < MAX)
            //    tbBlue.Value++;
            //else
            //{
            //    if (tbGreen.Value < MAX)
            //        tbGreen.Value++;
            //    else
            //    {
            //        if (tbRed.Value < MAX)
            //            tbRed.Value++;
            //        else
            //        {
            //            tmrAutoDec.Start();
            //            tmrAutoInc.Stop();
            //        }
            //    }
            //}
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                string clipboard = Clipboard.ContainsText() ? Clipboard.GetData(DataFormats.Text).ToString() : "";

                // Check if the clipboard text is a color name
                bool isName = ColorConvert.IsColorName(clipboard);
                bool isRgb = ColorConvert.IsRgb(clipboard);
                bool isHex = ColorConvert.IsHex(clipboard);

                bool canPaste = false;
                if (clipboard != null)
                {
                    canPaste = !string.IsNullOrWhiteSpace(clipboard) &&
                        (isName || isRgb || isHex);
                }

                mnuEdit_Paste.Enabled = canPaste;
                btnPaste.Enabled = mnuEdit_Paste.Enabled;
            }
            catch
            {
                mnuEdit_Paste.Enabled = false;
                btnPaste.Enabled = mnuEdit_Paste.Enabled;
            }
        }

        private void mnuFile_New_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
        }

        private void mnuFile_Open_Click(object sender, EventArgs e)
        {
            OpenSaveColorDialog d = new OpenSaveColorDialog(OpenSaveColorDialog.Mode.Open);
            DialogResult dr = d.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Color c = d.SelectedColor;

                _default = c;

                tbRed.Value = c.R;
                tbGreen.Value = c.G;
                tbBlue.Value = c.B;
            }
        }

        private void mnuFile_Save_Click(object sender, EventArgs e)
        {
            OpenSaveColorDialog d = new OpenSaveColorDialog(OpenSaveColorDialog.Mode.Save);
            DialogResult dr = d.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (d.ColorName.Contains(","))
                {
                    MessageBox.Show("Color names cannot contain a comma (',').",
                        "Format Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                Color c = SelectedSampleView.SelectedColor;
                string name = d.ColorName;
                string hex = ColorConvert.RgbToHex(c.R, c.G, c.B).ToLower();

                StringBuilder sb = new StringBuilder(File.Exists(AppIo.OutFile) ? (File.ReadAllText(AppIo.OutFile) ?? "") : "");
                sb.AppendLine(string.Format("{0},{1}", name, hex));

                File.WriteAllText(AppIo.OutFile, sb.ToString());
            }
        }

        private void mnuFile_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuEdit_Copy_Click(object sender, EventArgs e)
        {
            CopyAsForm f = new CopyAsForm(SelectedSampleView.SelectedColor);
            DialogResult dr = f.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Clipboard.SetText(f.CopyText);
            }
        }

        private void mnuEdit_Paste_Click(object sender, EventArgs e)
        {
            if (tmrParty.Enabled)
                tmrParty.Stop();

            string clipboard = Clipboard.ContainsText() ? Clipboard.GetData(DataFormats.Text).ToString() : "";

            // Check if the clipboard text is a color name
            bool isName = ColorConvert.IsColorName(clipboard);
            bool isRgb = ColorConvert.IsRgb(clipboard);
            bool isHex = ColorConvert.IsHex(clipboard);

            Color c = new Color();

            if (isName)
                c = Color.FromName(clipboard);
            else if (isRgb)
                c = ColorConvert.FromRgb(clipboard);
            else if (isHex)
                c = ColorConvert.FromHex(clipboard);

            tbRed.Value = c.R;
            tbGreen.Value = c.G;
            tbBlue.Value = c.B;
        }

        private void mnuView_Compare_CheckedChanged(object sender, EventArgs e)
        {
            spnlSplit.Panel2Collapsed = !mnuView_Compare.Checked;
            btnCompare.Checked = mnuView_Compare.Checked;
        }

        private void mnuView_Fullscreen_Click(object sender, EventArgs e)
        {
            FullScreen = mnuView_Fullscreen.Checked;
        }

        private void btnCompare_CheckedChanged(object sender, EventArgs e)
        {
            mnuView_Compare.Checked = btnCompare.Checked;
            return;
        }

        private void mnuView_Layout_Vertical_Click(object sender, EventArgs e)
        {
            spnlSplit.Orientation = Orientation.Vertical;
        }

        private void mnuView_Layout_Horizontal_Click(object sender, EventArgs e)
        {
            spnlSplit.Orientation = Orientation.Horizontal;
        }

        private void mnuColor_Reset_Click(object sender, EventArgs e)
        {
            if (tmrParty.Enabled)
                tmrParty.Stop();

            tbRed.Value = _default.R;
            tbGreen.Value = _default.G;
            tbBlue.Value = _default.B;
        }

        private void mnuColor_Random_Click(object sender, EventArgs e)
        {
            if (tmrParty.Enabled)
                tmrParty.Stop();

            Random r = new Random();

            tbRed.Value = r.Next(tbRed.Minimum, tbRed.Maximum);
            tbGreen.Value = r.Next(tbGreen.Minimum, tbGreen.Maximum);
            tbBlue.Value = r.Next(tbBlue.Minimum, tbBlue.Maximum);

            _default = ColorConvert.FromRgb(tbRed.Value, tbGreen.Value, tbBlue.Value);
        }

        private void mnuColor_Invert_Click(object sender, EventArgs e)
        {
            if (tmrParty.Enabled)
                tmrParty.Stop();

            tbRed.Value = tbRed.Maximum - tbRed.Value;
            tbGreen.Value = tbGreen.Maximum - tbGreen.Value;
            tbBlue.Value = tbBlue.Maximum - tbBlue.Value;
        }

        private void mnuHelp_Manual_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "https://sidera.dev/support/colors/";
            psi.UseShellExecute = true;

            Process.Start(psi);
        }

        private void mnuHelp_About_Click(object sender, EventArgs e)
        {
            AboutBox f = new AboutBox();
            f.ShowDialog();
        }

        private void ColorBar_ValueChanged(object sender, EventArgs e)
        {
            nudRed.Value = tbRed.Value;
            nudGreen.Value = tbGreen.Value;
            nudBlue.Value = tbBlue.Value;

            if (!_switch)
                SelectedSampleView.SelectedColor = Color.FromArgb(tbRed.Value, tbGreen.Value, tbBlue.Value);
        }

        private void ColorBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (tmrParty.Enabled)
                tmrParty.Stop();
        }

        private void ColorNud_Enter(object sender, EventArgs e)
        {
            NumericUpDown s = sender as NumericUpDown;
            s.Select(0, s.Text.Length);
        }

        private void ColorNud_ValueChanged(object sender, EventArgs e)
        {
            tbRed.Value = (int)nudRed.Value;
            tbGreen.Value = (int)nudGreen.Value;
            tbBlue.Value = (int)nudBlue.Value;

            if (!_switch)
                SelectedSampleView.SelectedColor = Color.FromArgb(tbRed.Value, tbGreen.Value, tbBlue.Value);
        }

        private void colorPalette_SelectedColorChanged(object sender, EventArgs e)
        {
            if (tmrParty.Enabled)
                tmrParty.Stop();

            tbRed.Value = colorPalette.SelectedColor.R;
            tbGreen.Value = colorPalette.SelectedColor.G;
            tbBlue.Value = colorPalette.SelectedColor.B;

            _default = colorPalette.SelectedColor;
        }

        private void sampleView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _switch = true;

                SelectedSampleView.Parent.BackColor = SystemColors.InactiveCaption;

                SampleView s = sender as SampleView;

                _selectedSampleView = s;

                tbRed.Value = _selectedSampleView.SelectedColor.R;
                tbGreen.Value = _selectedSampleView.SelectedColor.G;
                tbBlue.Value = _selectedSampleView.SelectedColor.B;

                SelectedSampleView.Parent.BackColor = SystemColors.ActiveCaption;

                _switch = false;

                return;
            }
        }
    }
}

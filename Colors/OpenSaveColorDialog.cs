using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    public partial class OpenSaveColorDialog : Form
    {
        private Mode _mode;
        private Color? _color;

        public OpenSaveColorDialog(Mode mode) : this(mode, null) { }
        public OpenSaveColorDialog(Mode mode, Color? color)
        {
            InitializeComponent();

            _mode = mode;
            _color = color;

            bool open = mode == Mode.Open;
            Text = open ? "Open Custom Color" : "Save Custom Color";
            lblPrompt.Text = open ? "Select a custom saved color:" : "Save your custom color:";
            txtName.ReadOnly = open;
            btnOK.Text = open ? "&Open" : "&Save";
            txtName.Select();

            UpdateButtonStates();

            string outfile = AppIo.OutFile;

            if (File.Exists(outfile))
            {
                string[] lines = File.ReadAllLines(outfile);
                bool fileEmpty = string.IsNullOrWhiteSpace(File.ReadAllText(outfile));
                bool proper = true;
                int columns = lines.Length == 0 ?
                    0 : lines[0].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length;
                foreach (string s in lines)
                {
                    bool lineEmpty = string.IsNullOrWhiteSpace(s);
                    bool colsMatch = s.Split(',').Length != columns;
                    if ((!fileEmpty && !lineEmpty) && !s.Contains(','))
                    {
                        proper = false;
                        ShowFileFormatError();

                        return;
                    }

                    columns = s.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length;
                }

                if (proper && !fileEmpty)
                {
                    string text = File.ReadAllText(outfile);

                    foreach (string line in text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] values = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                            string name = values[0], hex = values[1];

                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = name;
                            lvi.SubItems.Add(hex);

                            lvwColors.Items.Add(lvi);
                        }
                    }
                }
            }
        }

        public enum Mode { Open, Save }

        public Mode FileMode
        {
            get => _mode;
        }

        public string ColorName
        {
            get => txtName.Text;
            set => txtName.Text = value;
        }

        public Color SelectedColor
        {
            get => ColorConvert.FromHex(lvwColors.SelectedItems[0].SubItems[1].Text);
        }

        private void UpdateButtonStates()
        {
            bool selectone = lvwColors.SelectedItems.Count == 1;
            bool selectmulti = lvwColors.SelectedItems.Count > 0;
            bool namenonnull = !string.IsNullOrWhiteSpace(txtName.Text);

            txtName.Text = selectone ? lvwColors.SelectedItems[0].Text : "";
            btnDelete.Enabled = selectmulti;

            if (_mode == Mode.Open)
                btnOK.Enabled = selectmulti;
            else
                btnOK.Enabled = namenonnull;
        }

        private void ShowFileFormatError()
        {
            DialogResult dr = MessageBox.Show("The color file is not formatted correctly and therefore cannot be read. A new one must be generated, and all saved entries will be lost.\n\nProceed?",
                           "Format Error",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Error);

            if (dr == DialogResult.Yes)
            {
                File.Delete(AppIo.OutFile);
                File.Create(AppIo.OutFile);
            }
        }

        private void lvwColors_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && lvwColors.SelectedItems.Count == 1)
                btnOK.PerformClick();
        }

        private void lvwColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateButtonStates();
                pnlSample.BackColor = lvwColors.SelectedItems.Count == 1 ? SelectedColor : SystemColors.Control;
            }
            catch (FormatException)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendLine("The selected hexadecimal string does not represent a valid color.");
                msg.AppendLine();
                msg.Append("Do you want to delete the color entry '");
                msg.Append(lvwColors.SelectedItems[0].Text);
                msg.Append("'?");

                DialogResult dr = MessageBox.Show(msg.ToString(),
                    "Format Error",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error);

                if (dr == DialogResult.Yes)
                    btnDelete.PerformClick();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (FileMode == Mode.Save)
                btnOK.Enabled = !string.IsNullOrEmpty(txtName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lvwColors.SelectedItems[0];
            string msg = string.Format("Are you sure you want to delete '{0}'?", lvi.Text);
            string title = string.Format("Delete '{0}'?", lvi.Text);
            DialogResult dr = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int index = lvwColors.SelectedIndices[0];
                string text = File.ReadAllText(AppIo.OutFile);
                string[] lines = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i != lvwColors.SelectedIndices[0])
                        sb.AppendLine(lines[i]);
                }

                File.WriteAllText(AppIo.OutFile, sb.ToString());

                lvwColors.Items.Remove(lvi);
            }
        }
    }
}

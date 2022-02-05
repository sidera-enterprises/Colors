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
    public partial class ColorPaletteControl : UserControl
    {
        private Array _knowncolors;

        private Color _selectedColor;

        public ColorPaletteControl()
        {
            InitializeComponent();

            //// Gather all known colors first
            _knowncolors = Enum.GetValues(typeof(KnownColor));


            //// Create a default palette
            //List<Color> defPalette = new List<Color>();

            //// Create two key-value pairs to associate with one another
            //KeyValuePair<int, string>[] kvpNames = new KeyValuePair<int, string>[_knowncolors.Length];
            //KeyValuePair<int, string>[] kvpHexes = new KeyValuePair<int, string>[_knowncolors.Length];

            //int start = 27, end = _knowncolors.Length - 7;

            //for (int i = start; i < end; i++)
            //{
            //    KnownColor kc = (KnownColor)(_knowncolors.GetValue(i));
            //    Color c = Color.FromKnownColor(kc);

            //    kvpNames[i] = new KeyValuePair<int, string>(i, c.Name);
            //    kvpHexes[i] = new KeyValuePair<int, string>(i, ColorConvert.RgbToHex(c.R, c.G, c.B));

            //    defPalette.Add(c);
            //}

            //defPalette = SortByHex(defPalette.ToArray()).ToList();

            //for (int i = 0; i < defPalette.Count; i++)
            //{
            //    foreach (KeyValuePair<int, string> kvp in kvpHexes)
            //    {

            //    }
            //}

            // Create a new list to contain the sorted colors
            List<Color> colors = new List<Color>();
            List<string> names = new List<string>();

            //int start = 27, end = _knowncolors.Length - 7;
            //for (int i = start; i < end; i++)
            for (int i = 0; i < _knowncolors.Length; i++)
            {
                KnownColor kc = (KnownColor)(_knowncolors.GetValue(i));
                //Add(Color.FromKnownColor(kc), Color.FromKnownColor(kc).Name);

                if (!Color.FromKnownColor(kc).IsSystemColor && Color.FromKnownColor(kc).A == 255)
                {
                    colors.Add(Color.FromKnownColor(kc));
                    names.Add(Color.FromKnownColor(kc).Name);
                }
            }

            //foreach (Color c in SortByHex(colors.ToArray()))
            for (int i = 0; i < SortByHex(colors.ToArray()).Length; i++)
            {
                Color c = SortByHex(colors.ToArray())[i];
                string name = "";

                for (int j = 0; j < names.Count; j++)
                {
                    string s = names[j];

                    Color m = Color.FromName(s);

                    bool rMatch = c.R == m.R;
                    bool gMatch = c.G == m.G;
                    bool bMatch = c.B == m.B;

                    bool equal = rMatch && gMatch && bMatch;

                    if (equal)
                    {
                        name = s;
                        names.Remove(s);
                    }
                }

                //foreach (string s in names)
                //{
                //    bool redsMatch = c.R == Color.FromName(s).R;
                //    bool greensMatch = c.G == Color.FromName(s).G;
                //    bool bluesMatch = c.B == Color.FromName(s).B;

                //    if (redsMatch && greensMatch && bluesMatch)
                //    {
                //        name = s;
                //        names.Remove(s);
                //    }
                //    else name = s;
                //}

                Add(c, name);
            }
        }

        private Color[] SortByHex(Color[] colors)
        {
            List<Color> list = new List<Color>();
            List<string> hexvals = new List<string>();

            foreach (Color c in colors)
            {
                hexvals.Add(ColorConvert.RgbToHex(c.R, c.G, c.B));
            }

            hexvals.Sort();

            foreach (string s in hexvals)
                list.Add(ColorConvert.FromHex(s));

            return list.ToArray();
        }

        public Color SelectedColor
        {
            get
            {
                return _selectedColor;
            }
            set
            {
                Color c = _selectedColor = value;
                //textBox1.Text = c.IsNamedColor ? c.Name : ColorConvert.RgbToHex(c.R, c.G, c.B);
                //OnColorChanged();
                OnSelectedColorChanged(EventArgs.Empty);
            }
        }

        public void Add(Color color, string name)
        {
            foreach (Control c in fpnlLayout.Controls)
            {
                if (c.BackColor == color)
                    return;
            }

            Button b = new Button()
            {
                BackColor = color,
                FlatStyle = FlatStyle.Popup,
                Margin = new Padding(3, 3, 3, 3),
                Size = new Size(24, 24)
            };

            fpnlLayout.Controls.Add(b);
            toolTip.SetToolTip(b, name);

            b.Click += (o, i) =>
            {
                SelectedColor = b.BackColor;
            };
        }

        public delegate void SelectedColorChangedEventHandler(object sender, EventArgs e);
        public event SelectedColorChangedEventHandler SelectedColorChanged;
        protected virtual void OnSelectedColorChanged(EventArgs e)
        {
            if (SelectedColorChanged != null)
                SelectedColorChanged(this, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            if (rdbRed.Checked == true)
                ShowPicked("Red\n#" + Color.Red.GetHashCode().ToString(), Color.Red);
            else if (rdbGreen.Checked == true)
                ShowPicked("Green\n#" + Color.Green.GetHashCode().ToString(), Color.Green);
            else if (rdbBlue.Checked == true)
                ShowPicked("Blue\n#" + Color.Blue.GetHashCode().ToString(), Color.Blue);
            else if (rdbYellow.Checked == true)
                ShowPicked("Playing Despacito...", Color.Yellow);
        }

        private void ShowPicked(string message, Color color)
        {
            pbxCanvas.BackColor = color;
            MessageBox.Show(message);
        }
    }
}

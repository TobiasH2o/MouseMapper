using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMapper
{
    public partial class Settings : Form
    {

        public int thickness { get; set; }
        public int ocpacity { get; set; }
        public Settings()
        {
            FormClosing += new FormClosingEventHandler(Settings_FormClosing);
            thickness = 1;
            ocpacity = 50;
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void strengthBox_ValueChanged(object sender, EventArgs e)
        {
            ocpacity = (int)((NumericUpDown)sender).Value;
        }

        private void thickBox_ValueChanged(object sender, EventArgs e)
        {
            thickness = (int)((NumericUpDown)sender).Value;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;    // Do not close the form.
        }

    }
}

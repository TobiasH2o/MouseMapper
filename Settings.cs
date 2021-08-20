using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MouseMapper
{
    public partial class Settings : Form
    {

        public int thickness { get; set; }
        public int ocpacity { get; set; }
        public Action<object, PaintEventArgs, List<Point>> printMethod { get; set; }
        public Settings()
        {
            FormClosing += new FormClosingEventHandler(Settings_FormClosing);
            InitializeComponent();
            printMethod = line;
            thickness = (int)thickBox.Value;
            ocpacity = (int)strengthBox.Value;
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
            e.Cancel = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)comboBox1.SelectedItem)
            {
                case "line":
                    printMethod = line;
                    break;
                case "circle":
                    printMethod = circle;
                    break;
                case "curve":
                    printMethod = curve;
                    break;
            }
        }


        private void circle(object sender, PaintEventArgs e, List<Point> dataPoints)
        {
            Pen pen = new Pen(Color.FromArgb(ocpacity, 200, 10, 10));
            Brush brush = pen.Brush;
            pen.Width = thickness;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            for (int i = 0; i < dataPoints.Count; i++)
            {
                e.Graphics.FillEllipse(brush, new Rectangle(dataPoints[i].X - thickness,
                    dataPoints[i].Y - thickness,
                    thickness * 2,
                   thickness * 2));
            }
        }

        private void line(object sender, PaintEventArgs e, List<Point> dataPoints)
        {
            Pen pen = new Pen(Color.FromArgb(ocpacity, 200, 10, 10));
            pen.Width = thickness;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            if (dataPoints.Count > 1) e.Graphics.DrawLines(pen, dataPoints.ToArray());
        }

        private void curve(object sender, PaintEventArgs e, List<Point> dataPoints)
        {
            Pen pen = new Pen(Color.FromArgb(ocpacity, 200, 10, 10));
            pen.Width = thickness;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            if (dataPoints.Count > 1) e.Graphics.DrawCurve(pen, dataPoints.ToArray());
        }
    }
}

﻿using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MouseMapper
{
    public partial class Main : Form
    {
        Settings settingsWindow;
        private List<int[]> dataPoints = new List<int[]>();

        public Main()
        {
            settingsWindow = new Settings();
            InitializeComponent();
            draw.Paint += new PaintEventHandler(paintLines);


            if(isTask()) 

            Timer time = new Timer();
            time.Interval = 25;
            time.Tick += new EventHandler(addNewMouse);
            time.Enabled = true;
            time.Start();

        }

        private bool isTask()
        {
            return new TaskService().FindAllTasks(new System.Text.RegularExpressions.Regex("tfhMouseLogger")).Length > 0;
        }

        
        private void addNewMouse(object sender, EventArgs e)
        {
            addLine(Cursor.Position.X, Cursor.Position.Y);
            draw.Refresh();
        }

        public void addLine(int x, int y)
        {
            var s = Screen.FromControl(this).Bounds;
            int xP = (int)(x * ((double)draw.Size.Width / (double)s.Width));
            int yP = (int)(y * ((double)draw.Size.Height / (double)s.Height));
            dataPoints.Add(new int[] { xP, yP });
        }

        private void paintLines(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(settingsWindow.ocpacity, 200, 10, 10));
            pen.Width = settingsWindow.thickness;
            for(int i = 1; i < dataPoints.Count; i++)
            {
                e.Graphics.DrawLine(pen, dataPoints[i - 1][0], dataPoints[i - 1][1], dataPoints[i][0], dataPoints[i][1]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void updateLabel(Object sender, EventArgs e)
        {

        }

        private void openSettings_Click(object sender, EventArgs e)
        {
            settingsWindow.Show();
        }

        private void launchButton_Click(object sender, EventArgs e)
        {

        }
    }
}

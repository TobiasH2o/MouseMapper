
namespace MouseMapper
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.process1 = new System.Diagnostics.Process();
            this.draw = new System.Windows.Forms.PictureBox();
            this.openSettings = new System.Windows.Forms.Button();
            this.launchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.draw)).BeginInit();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // draw
            // 
            this.draw.BackColor = System.Drawing.SystemColors.ControlLight;
            this.draw.Location = new System.Drawing.Point(12, 53);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(776, 385);
            this.draw.TabIndex = 0;
            this.draw.TabStop = false;
            // 
            // openSettings
            // 
            this.openSettings.Location = new System.Drawing.Point(13, 6);
            this.openSettings.Name = "openSettings";
            this.openSettings.Size = new System.Drawing.Size(118, 41);
            this.openSettings.TabIndex = 1;
            this.openSettings.Text = "openSettings";
            this.openSettings.UseVisualStyleBackColor = true;
            this.openSettings.Click += new System.EventHandler(this.openSettings_Click);
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(741, 13);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(46, 34);
            this.launchButton.TabIndex = 2;
            this.launchButton.Text = "OFF";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enable Auto Launch:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.openSettings);
            this.Controls.Add(this.draw);
            this.HelpButton = true;
            this.Name = "Main";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.draw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.PictureBox draw;
        private System.Windows.Forms.Button openSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button launchButton;
    }
}


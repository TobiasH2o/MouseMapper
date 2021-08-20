
namespace MouseMapper
{
    partial class Settings
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
            this.strengthBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.thickBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.strengthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickBox)).BeginInit();
            this.SuspendLayout();
            // 
            // strengthBox
            // 
            this.strengthBox.Location = new System.Drawing.Point(209, 12);
            this.strengthBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.strengthBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.strengthBox.Name = "strengthBox";
            this.strengthBox.Size = new System.Drawing.Size(120, 22);
            this.strengthBox.TabIndex = 0;
            this.strengthBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.strengthBox.ValueChanged += new System.EventHandler(this.strengthBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Graph Strength";
            // 
            // thickBox
            // 
            this.thickBox.Location = new System.Drawing.Point(209, 41);
            this.thickBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thickBox.Name = "thickBox";
            this.thickBox.Size = new System.Drawing.Size(120, 22);
            this.thickBox.TabIndex = 2;
            this.thickBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thickBox.ValueChanged += new System.EventHandler(this.thickBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Line Thickness";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "curve",
            "line",
            "circle"});
            this.comboBox1.Location = new System.Drawing.Point(209, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Circle";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Paint Type";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(341, 628);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.thickBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.strengthBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.strengthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown strengthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown thickBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}
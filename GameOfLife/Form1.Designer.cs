using System;
using System.Drawing;

namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridCheckbox = new System.Windows.Forms.CheckBox();
            this.RunCheckbox = new System.Windows.Forms.CheckBox();
            this.SizeNud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DelayNud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.DensityNud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LastRenderTimeLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RenderTimeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PartitioningNud = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DensityNud)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartitioningNud)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCheckbox
            // 
            this.GridCheckbox.AutoSize = true;
            this.GridCheckbox.Location = new System.Drawing.Point(9, 111);
            this.GridCheckbox.Name = "GridCheckbox";
            this.GridCheckbox.Size = new System.Drawing.Size(48, 19);
            this.GridCheckbox.TabIndex = 1;
            this.GridCheckbox.Text = "Grid";
            this.GridCheckbox.UseVisualStyleBackColor = true;
            // 
            // RunCheckbox
            // 
            this.RunCheckbox.AutoSize = true;
            this.RunCheckbox.Location = new System.Drawing.Point(6, 13);
            this.RunCheckbox.Name = "RunCheckbox";
            this.RunCheckbox.Size = new System.Drawing.Size(47, 19);
            this.RunCheckbox.TabIndex = 2;
            this.RunCheckbox.Text = "Run";
            this.RunCheckbox.UseVisualStyleBackColor = true;
            this.RunCheckbox.CheckedChanged += new System.EventHandler(this.RunCheckbox_CheckedChanged);
            // 
            // SizeNud
            // 
            this.SizeNud.Location = new System.Drawing.Point(138, 33);
            this.SizeNud.Name = "SizeNud";
            this.SizeNud.Size = new System.Drawing.Size(48, 23);
            this.SizeNud.TabIndex = 3;
            this.SizeNud.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SizeNud.ValueChanged += new System.EventHandler(this.SizeNud_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Square size (px):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Delay (ms): ";
            // 
            // DelayNud
            // 
            this.DelayNud.Location = new System.Drawing.Point(138, 62);
            this.DelayNud.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.DelayNud.Name = "DelayNud";
            this.DelayNud.Size = new System.Drawing.Size(48, 23);
            this.DelayNud.TabIndex = 5;
            this.DelayNud.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DelayNud.ValueChanged += new System.EventHandler(this.DelayNud_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Density (%):";
            // 
            // DensityNud
            // 
            this.DensityNud.Location = new System.Drawing.Point(138, 91);
            this.DensityNud.Name = "DensityNud";
            this.DensityNud.Size = new System.Drawing.Size(48, 23);
            this.DensityNud.TabIndex = 7;
            this.DensityNud.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.DensityNud.ValueChanged += new System.EventHandler(this.DensityNud_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 9;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(9, 160);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PartitioningNud);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.LastRenderTimeLabel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.RenderTimeLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.RunCheckbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ResetButton);
            this.groupBox2.Controls.Add(this.SizeNud);
            this.groupBox2.Controls.Add(this.DelayNud);
            this.groupBox2.Controls.Add(this.GridCheckbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DensityNud);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 607);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "ms";
            // 
            // LastRenderTimeLabel
            // 
            this.LastRenderTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LastRenderTimeLabel.AutoSize = true;
            this.LastRenderTimeLabel.Location = new System.Drawing.Point(156, 560);
            this.LastRenderTimeLabel.Name = "LastRenderTimeLabel";
            this.LastRenderTimeLabel.Size = new System.Drawing.Size(13, 15);
            this.LastRenderTimeLabel.TabIndex = 20;
            this.LastRenderTimeLabel.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 560);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Last calculation time:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 586);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "ms";
            // 
            // RenderTimeLabel
            // 
            this.RenderTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RenderTimeLabel.AutoSize = true;
            this.RenderTimeLabel.Location = new System.Drawing.Point(156, 586);
            this.RenderTimeLabel.Name = "RenderTimeLabel";
            this.RenderTimeLabel.Size = new System.Drawing.Size(13, 15);
            this.RenderTimeLabel.TabIndex = 14;
            this.RenderTimeLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 586);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Average calculation time: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(319, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 607);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Data partitioning level:";
            // 
            // PartitioningNud
            // 
            this.PartitioningNud.Location = new System.Drawing.Point(138, 131);
            this.PartitioningNud.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PartitioningNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PartitioningNud.Name = "PartitioningNud";
            this.PartitioningNud.Size = new System.Drawing.Size(48, 23);
            this.PartitioningNud.TabIndex = 23;
            this.PartitioningNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 607);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SizeNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DensityNud)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartitioningNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox GridCheckbox;
        private System.Windows.Forms.CheckBox RunCheckbox;
        private System.Windows.Forms.NumericUpDown SizeNud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown DelayNud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DensityNud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label RenderTimeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LastRenderTimeLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown PartitioningNud;
        private System.Windows.Forms.Label label5;
    }
}


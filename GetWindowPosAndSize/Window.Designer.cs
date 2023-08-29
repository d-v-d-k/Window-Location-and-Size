
namespace GetWindowPosAndSize
{
    partial class Window
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudLocX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudLocY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudSizeH = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSizeW = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbChrome = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocY)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeW)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudLocX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudLocY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // nudLocX
            // 
            this.nudLocX.Location = new System.Drawing.Point(50, 19);
            this.nudLocX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudLocX.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudLocX.Name = "nudLocX";
            this.nudLocX.Size = new System.Drawing.Size(56, 20);
            this.nudLocX.TabIndex = 4;
            this.nudLocX.ValueChanged += new System.EventHandler(this.nudLocX_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // nudLocY
            // 
            this.nudLocY.Location = new System.Drawing.Point(159, 22);
            this.nudLocY.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudLocY.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudLocY.Name = "nudLocY";
            this.nudLocY.Size = new System.Drawing.Size(56, 20);
            this.nudLocY.TabIndex = 5;
            this.nudLocY.ValueChanged += new System.EventHandler(this.nudLocY_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudSizeH);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudSizeW);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 53);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // nudSizeH
            // 
            this.nudSizeH.Location = new System.Drawing.Point(159, 19);
            this.nudSizeH.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudSizeH.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudSizeH.Name = "nudSizeH";
            this.nudSizeH.Size = new System.Drawing.Size(56, 20);
            this.nudSizeH.TabIndex = 7;
            this.nudSizeH.ValueChanged += new System.EventHandler(this.nudSizeH_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height:";
            // 
            // nudSizeW
            // 
            this.nudSizeW.Location = new System.Drawing.Point(50, 19);
            this.nudSizeW.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudSizeW.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudSizeW.Name = "nudSizeW";
            this.nudSizeW.Size = new System.Drawing.Size(56, 20);
            this.nudSizeW.TabIndex = 6;
            this.nudSizeW.ValueChanged += new System.EventHandler(this.nudSizeW_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Width:";
            // 
            // tbChrome
            // 
            this.tbChrome.Location = new System.Drawing.Point(6, 19);
            this.tbChrome.Multiline = true;
            this.tbChrome.Name = "tbChrome";
            this.tbChrome.ReadOnly = true;
            this.tbChrome.Size = new System.Drawing.Size(216, 40);
            this.tbChrome.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbChrome);
            this.groupBox3.Location = new System.Drawing.Point(12, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 75);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chrome/Edge";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 216);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Window";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Window_Load);
            this.Move += new System.EventHandler(this.Window_Move);
            this.Resize += new System.EventHandler(this.Window_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocY)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeW)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudLocX;
        private System.Windows.Forms.NumericUpDown nudLocY;
        private System.Windows.Forms.NumericUpDown nudSizeW;
        private System.Windows.Forms.NumericUpDown nudSizeH;
        private System.Windows.Forms.TextBox tbChrome;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}


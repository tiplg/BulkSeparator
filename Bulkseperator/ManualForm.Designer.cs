namespace Bulkseperator
{
    partial class ManualForm
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
            this.pic1trackbar = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lic1trackbar = new System.Windows.Forms.TrackBar();
            this.lic2trackbar = new System.Windows.Forms.TrackBar();
            this.chkPresure = new System.Windows.Forms.CheckBox();
            this.chkLiquid = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lic1trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lic2trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkLiquid);
            this.groupBox1.Controls.Add(this.chkPresure);
            this.groupBox1.Controls.Add(this.lic2trackbar);
            this.groupBox1.Controls.Add(this.lic1trackbar);
            this.groupBox1.Controls.Add(this.pic1trackbar);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(188, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "       Enable";
            // 
            // pic1trackbar
            // 
            this.pic1trackbar.Location = new System.Drawing.Point(13, 53);
            this.pic1trackbar.Maximum = 100;
            this.pic1trackbar.Name = "pic1trackbar";
            this.pic1trackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.pic1trackbar.Size = new System.Drawing.Size(45, 256);
            this.pic1trackbar.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lic1trackbar
            // 
            this.lic1trackbar.Location = new System.Drawing.Point(73, 53);
            this.lic1trackbar.Maximum = 100;
            this.lic1trackbar.Name = "lic1trackbar";
            this.lic1trackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.lic1trackbar.Size = new System.Drawing.Size(45, 256);
            this.lic1trackbar.TabIndex = 1;
            // 
            // lic2trackbar
            // 
            this.lic2trackbar.Location = new System.Drawing.Point(133, 53);
            this.lic2trackbar.Maximum = 100;
            this.lic2trackbar.Name = "lic2trackbar";
            this.lic2trackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.lic2trackbar.Size = new System.Drawing.Size(45, 256);
            this.lic2trackbar.TabIndex = 2;
            // 
            // chkPresure
            // 
            this.chkPresure.AutoSize = true;
            this.chkPresure.Location = new System.Drawing.Point(6, 315);
            this.chkPresure.Name = "chkPresure";
            this.chkPresure.Size = new System.Drawing.Size(86, 17);
            this.chkPresure.TabIndex = 3;
            this.chkPresure.Text = "Force HPSD";
            this.chkPresure.UseVisualStyleBackColor = true;
            // 
            // chkLiquid
            // 
            this.chkLiquid.AutoSize = true;
            this.chkLiquid.Location = new System.Drawing.Point(98, 315);
            this.chkLiquid.Name = "chkLiquid";
            this.chkLiquid.Size = new System.Drawing.Size(85, 17);
            this.chkLiquid.TabIndex = 4;
            this.chkLiquid.Text = "Force HLSD";
            this.chkLiquid.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PIC 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "LIC 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "LIC 2";
            // 
            // ManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 364);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManualForm";
            this.Text = "Manual Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManualForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lic1trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lic2trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar pic1trackbar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkLiquid;
        private System.Windows.Forms.CheckBox chkPresure;
        private System.Windows.Forms.TrackBar lic2trackbar;
        private System.Windows.Forms.TrackBar lic1trackbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}